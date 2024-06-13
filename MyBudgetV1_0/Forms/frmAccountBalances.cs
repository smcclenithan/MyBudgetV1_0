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
    public partial class frmAccountBalances : Form
    {
        public frmAccountBalances()
        {
            InitializeComponent();
        }

        private void Balances_Load(object sender, EventArgs e)
        {
            dgvBalances.DataSource = GetBalancesList();

            //Cleanup and format datagridview
            dgvBalances.Columns[0].Visible = false;
            dgvBalances.Columns[1].Visible = false;
            dgvBalances.Columns[5].DefaultCellStyle.Format = "c2";
            dgvBalances.Columns[6].DefaultCellStyle.Format = "c2";
            dgvBalances.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dgvBalances.RowCount > 0)
            {
                btnDelete.Enabled = true;
            }
            else
            {
                btnDelete.Enabled = false;
            }
        }

        private DataTable GetBalancesList()
        {
            DataTable dtBalances = new DataTable();
            string conString = ConfigurationManager.ConnectionStrings["MyBudgetV1_0.Properties.Settings.MyBudgetDBConnectionString"].ConnectionString;

            using (SqlConnection con = new SqlConnection(conString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT AB.AccountBalanceID, AB.AccountID, A.AccountName, AB.StatementDate, " +
                    "AB.DueDate, AB.Balance, AB.AmountDue, AB.Comments, AB.CreateDate, AB.ModifyDate, A.LUAccountTypeID " +
                    "FROM AccountBalance AB JOIN Account A ON AB.AccountID = A.AccountID ORDER BY AB.DueDate, AB.AmountDue", con))
                {
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    dtBalances.Load(dr);
                }
            }

            return dtBalances;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmAccountBalanceEntry accountBalanceDetail = new frmAccountBalanceEntry();
            accountBalanceDetail.ShowDialog();

            // Refresh the data grid when returning.
            dgvBalances.DataSource = GetBalancesList();
        }

        private void dgvBalances_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int accountBalanceID = Convert.ToInt32(dgvBalances.CurrentRow.Cells[0].Value.ToString());
            frmAccountBalanceEntry accountBalanceEntry = new frmAccountBalanceEntry(accountBalanceID);
            accountBalanceEntry.ShowDialog();

            // Refresh the data grid when returning.
            dgvBalances.DataSource = GetBalancesList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int accountBalanceID = Convert.ToInt32(dgvBalances.CurrentRow.Cells[0].Value.ToString());

            if (accountBalanceID.ToString() == string.Empty)
            {
                MessageBox.Show("Select a row to Delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                DialogResult res = 
                    MessageBox.Show("Are you sure that you want to\ndelete account balance record for:\n" +
                    dgvBalances.CurrentRow.Cells[2].Value.ToString() + "?", "Confirm Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (res == DialogResult.Yes)
                {
                    // Delete the selected row from the database.
                    string conString = ConfigurationManager.ConnectionStrings["MyBudgetV1_0.Properties.Settings.MyBudgetDBConnectionString"].ConnectionString;

                    using (SqlConnection con = new SqlConnection(conString))
                    {
                        using (SqlCommand cmd = new SqlCommand("DELETE FROM AccountBalance WHERE AccountBalanceID = " + accountBalanceID, con))
                        {
                            con.Open();
                            SqlDataReader dr = cmd.ExecuteReader();
                        }
                    }
                }
                // Refresh the data grid when returning.
                dgvBalances.DataSource = GetBalancesList();
            }
        }

        private void dgvBalances_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0)
            {
                return;
            }

            int index = e.RowIndex;
            dgvBalances.Rows[index].Selected = true;
        }

        private void cbShowBankAccounts_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowBankAccounts.Checked)
            {
                //Filter to Open accounts only
                (dgvBalances.DataSource as DataTable).DefaultView.RowFilter = null;
            }
            else
            {
                // Exclude bank accounts.
                (dgvBalances.DataSource as DataTable).DefaultView.RowFilter = string.Format("[LUAccountTypeID] <> '{0}'", "12");              
            }
        }
    }
}
