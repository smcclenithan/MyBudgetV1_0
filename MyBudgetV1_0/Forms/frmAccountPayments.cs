using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace MyBudgetV1_0.Forms
{
    public static class DateTimeMethods
    {
        public static DateTime StartOfMonth(this DateTime date)
        {
            return new DateTime(date.Year, date.Month, 1, 0, 0, 0);
        }

        public static DateTime EndOfMonth(this DateTime date)
        {
            return date.StartOfMonth().AddMonths(1).AddSeconds(-1);
        }
    }
    public partial class frmAccountPayments : Form
    {
        int accountBalanceID = 0;
        int accountPaymentID = 0;
        static DateTime CurrentDate = DateTime.Today;
        DateTime FilterRangeFrom = CurrentDate.StartOfMonth();
        DateTime FilterRangeTo = CurrentDate.EndOfMonth();
        DataTable dtPayments;
        
        public frmAccountPayments()
        {
            InitializeComponent();
        }

        private void Payments_Load(object sender, EventArgs e)
        {
            dgvPayments.DataSource = GetPaymentsList();

            //Cleanup and format datagridview
            dgvPayments.Columns[0].Visible = false;
            dgvPayments.Columns[1].Visible = false;
            dgvPayments.Columns[5].DefaultCellStyle.Format = "c2";
            dgvPayments.Columns[6].DefaultCellStyle.Format = "c2";
            dgvPayments.Columns[7].Visible = false;
            dgvPayments.Columns[8].DefaultCellStyle.Format = "c2";
            dgvPayments.Columns[11].Visible = false;
            dgvPayments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dtpFilterRangeFrom.Value = FilterRangeFrom;
            dtpFilterRangeTo.Value = FilterRangeTo;

            if (dgvPayments.RowCount > 0)
            {
                btnDelete.Enabled = true;
            }
            else
            {
                btnDelete.Enabled = false;
            }

            dgvPayments.DataSource = GetPaymentsList();
        }

        private DataTable GetPaymentsList()
        {
            dtPayments = new DataTable();
            string conString =
                ConfigurationManager.ConnectionStrings["MyBudgetV1_0.Properties.Settings.MyBudgetDBConnectionString"].ConnectionString;

            using (SqlConnection con = new SqlConnection(conString))
            {
                using (SqlCommand cmd = new SqlCommand(
                    "SELECT AB.AccountBalanceID, AB.AccountID, A.AccountName, AB.StatementDate, AB.DueDate, AB.Balance, AB.AmountDue, " +
                    "ISNULL(AP.AccountPaymentID, 0) AS AccountPaymentID, AP.AmountPaid, AP.DatePaid, AP.PaymentCleared, AP.PaymentComment, AP.ConfirmationNumber " +
                    "FROM AccountBalance AB " +
                    "LEFT JOIN AccountPayment AP ON AB.AccountBalanceID = AP.AccountBalanceID " +
                    "JOIN Account A ON AB.AccountID = A.AccountID " +
                    "WHERE A.LUAccountTypeID != 12" +
                    "AND AB.DueDate BETWEEN '" + dtpFilterRangeFrom.Value + "' AND '" + dtpFilterRangeTo.Value + "'" +
                    "ORDER BY AB.DueDate, AB.AmountDue", con))
                {
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    dtPayments.Load(dr);
                }
            }
            PopulateBankInformationSummary();
            return dtPayments;
        }

        private void btnPayNow_Click(object sender, EventArgs e)
        {
            int SelectedRowCount = dgvPayments.SelectedRows.Count;

            if (SelectedRowCount == 0)
            {
                MessageBox.Show("Select a record to pay.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                accountBalanceID = Convert.ToInt32(dgvPayments.CurrentRow.Cells[0].Value.ToString());
                accountPaymentID = Convert.ToInt32(dgvPayments.CurrentRow.Cells[7].Value.ToString());

                frmAccountPaymentEntry accountPaymentEntry = new frmAccountPaymentEntry(accountBalanceID, accountPaymentID);
                accountPaymentEntry.ShowDialog();

                // Refresh the data grid when returning. .
                dgvPayments.DataSource = GetPaymentsList();
            }
        }

        private void dgvPayments_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            accountBalanceID = Convert.ToInt32(dgvPayments.CurrentRow.Cells[0].Value);
            if (Convert.ToInt32(dgvPayments.CurrentRow.Cells[7].Value.ToString()) == 0) // string.Empty)
            {
                accountPaymentID = 0;
            }
            else
            {
                accountPaymentID = Convert.ToInt32(dgvPayments.CurrentRow.Cells[7].Value);
            }

            frmAccountPaymentEntry accountPaymentEntry = new frmAccountPaymentEntry(accountBalanceID, accountPaymentID);
            accountPaymentEntry.ShowDialog();

            // Refresh the data grid when returning.
            dgvPayments.DataSource = GetPaymentsList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int SelectedRowCount = dgvPayments.SelectedRows.Count;

            if (SelectedRowCount == 0)
            {
                MessageBox.Show("Select a row to Delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                accountPaymentID = Convert.ToInt32(dgvPayments.CurrentRow.Cells[7].Value.ToString());

                DialogResult res =
                    MessageBox.Show("Are you sure that you want to\ndelete account payment record for:\n" +
                    dgvPayments.CurrentRow.Cells[2].Value.ToString() + "?", "Confirm Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (res == DialogResult.Yes)
                {
                    // Delete the selected row from the database.
                    string conString = ConfigurationManager.ConnectionStrings["MyBudgetV1_0.Properties.Settings.MyBudgetDBConnectionString"].ConnectionString;

                    using (SqlConnection con = new SqlConnection(conString))
                    {
                        using (SqlCommand cmd = new SqlCommand("DELETE FROM AccountPayment WHERE AccountPaymentID = " + accountPaymentID, con))
                        {
                            con.Open();
                            SqlDataReader dr = cmd.ExecuteReader();
                        }
                    }
                }
                // Refresh the data grid when returning.
                dgvPayments.DataSource = GetPaymentsList();
            }
        }

        private void dgvPayments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0)
            {
                return;
            }

            int index = e.RowIndex;
            dgvPayments.Rows[index].Selected = true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PopulateBankInformationSummary();
            dgvPayments.DataSource = GetPaymentsList();
        }

        private void PopulateBankInformationSummary()
        {
            double CurrentBankBalance = 0;
            double PendingBills = 0;
            double UnpaidBills = 0;
            double OutstandingMonthlyIncome = 0;
            double CalculatedCurrentBalance = 0;
            double EstimatedBankBalanceEOM = 0;

            string conString =
                ConfigurationManager.ConnectionStrings["MyBudgetV1_0.Properties.Settings.MyBudgetDBConnectionString"].ConnectionString;

            using (SqlConnection con = new SqlConnection(conString))
            {
                using (SqlCommand cmd = new SqlCommand(
                    "SELECT ISNULL(SUM(AB.Balance), 0) AS CurrentBankBalance " +
                    "FROM Account A " +
                    "LEFT JOIN AccountBalance AB " +
                    "ON AB.AccountID = A.AccountID " +
                    "WHERE A.LUAccountTypeID = 12 " +
                    "GROUP BY A.AccountID, " +
                    "A.AccountName ", con))
                {
                    con.Open();
                    CurrentBankBalance = Convert.ToDouble(cmd.ExecuteScalar());
                }
                con.Close();
            }

            using (SqlConnection con = new SqlConnection(conString))
            {
                using (SqlCommand cmd = new SqlCommand(
                    "SELECT ISNULL(SUM(AP.AmountPaid), 0) AS PendingBills " +
                    "FROM AccountBalance AB JOIN Account A ON AB.AccountID = A.AccountID LEFT JOIN AccountPayment AP ON AP.AccountBalanceID = AB.AccountBalanceID " +
                    "WHERE A.LUAccountTypeID != 12 AND AP.AmountPaid != 0 AND(AP.PaymentCleared = 'N' OR AP.PaymentCleared IS NULL)", con))
                {
                    con.Open();
                    PendingBills = Convert.ToDouble(cmd.ExecuteScalar());
                }
                con.Close();
            }

            using (SqlConnection con = new SqlConnection(conString))
            {
                using (SqlCommand cmd = new SqlCommand(
                    "SELECT ISNULL(SUM(AB.AmountDue), 0) AS UnpaidBills " +
                    "FROM AccountBalance AB JOIN Account A ON AB.AccountID = A.AccountID LEFT JOIN AccountPayment AP ON AP.AccountBalanceID = AB.AccountBalanceID " +
                    "WHERE A.LUAccountTypeID != 12 AND ISNULL(AP.AmountPaid, 0) = 0 AND(AP.PaymentCleared = 'N' OR AP.PaymentCleared IS NULL) ", con))
                {
                    con.Open();
                    UnpaidBills = Convert.ToDouble(cmd.ExecuteScalar());
                }
                con.Close();
            }

            using (SqlConnection con = new SqlConnection(conString))
            {
                using (SqlCommand cmd = new SqlCommand(
                    "SELECT ISNULL(SUM(IncomeAmount), 0) AS IncomeTotal " +
                    "FROM Income " +
                    "WHERE IncomeDate BETWEEN '" + dtpFilterRangeFrom.Value + "' AND '" + dtpFilterRangeTo.Value + "' " +
                    "AND Cleared = 'N'", con)) 
                {
                    con.Open();
                    OutstandingMonthlyIncome = Convert.ToDouble(cmd.ExecuteScalar());
                }
                con.Close();
            }

            CalculatedCurrentBalance = (CurrentBankBalance - PendingBills);
            EstimatedBankBalanceEOM = (CurrentBankBalance + OutstandingMonthlyIncome) - (PendingBills + UnpaidBills);

            tbCurrentBankBalance.Text = CurrentBankBalance.ToString("C2");
            tbPendingBills.Text = PendingBills.ToString("C2");
            tbUnpaidBills.Text = UnpaidBills.ToString("C2");
            tbOutstandingMonthlyIncome.Text = OutstandingMonthlyIncome.ToString("C2");
            tbCalculatedCurrentBalance.Text = CalculatedCurrentBalance.ToString("C2");
            tbEstimatedBankBalanceEOM.Text = EstimatedBankBalanceEOM.ToString("C2");
        }

        private void btnClearSelected_Click(object sender, EventArgs e)
        {
            string accountPaymentIDList = "";

            int SelectedRowCount = dgvPayments.SelectedRows.Count;

            if (SelectedRowCount == 0)
            {
                MessageBox.Show("Select one or more rows to mark as Cleared.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                DialogResult res;

                if (SelectedRowCount == 1)
                {
                    accountPaymentID = Convert.ToInt32(dgvPayments.CurrentRow.Cells[7].Value.ToString());
                    accountPaymentIDList = "(" + accountPaymentID + ")";
                    res = MessageBox.Show("Are you sure that you want to\nmark this record as cleared?", "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                }
                else
                {
                    accountPaymentIDList = "(";

                    foreach (DataGridViewRow r in dgvPayments.SelectedRows)
                    {
                        accountPaymentIDList = accountPaymentIDList + Convert.ToInt32(r.Cells[7].Value) + ",";
                    }
                    accountPaymentIDList = accountPaymentIDList + "-1)";   // -1 is a dummy value to account fopr the final , above.

                    res = MessageBox.Show("Are you sure that you want to\nmark these " + SelectedRowCount.ToString() + " records as cleared?", "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                }

                if (res == DialogResult.Yes)
                {// Update the selected rows in the database. Set as Cleared.
                    string conString = ConfigurationManager.ConnectionStrings["MyBudgetV1_0.Properties.Settings.MyBudgetDBConnectionString"].ConnectionString;

                    using (SqlConnection con = new SqlConnection(conString))
                    {
                        using (SqlCommand cmd = new SqlCommand("UPDATE AccountPayment SET PaymentCleared = 'Y' WHERE AccountPaymentID IN " + accountPaymentIDList, con))
                        {
                            con.Open();
                            SqlDataReader dr = cmd.ExecuteReader();
                        }
                        con.Close();
                    }
                }
            }

            dgvPayments.DataSource = GetPaymentsList();
        }
    }
}
