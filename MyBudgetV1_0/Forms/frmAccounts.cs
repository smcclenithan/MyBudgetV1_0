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
    public partial class frmAccounts : Form
    {
        //SqlConnection con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename =\"|DataDirectory|\\MyBudgetSQLDB.mdf\";Integrated Security=True");
        //string conString = ConfigurationManager.ConnectionStrings["MyBudgetV1_0.Properties.Settings.MyBudgetDBConnectionString"].ConnectionString;
        public frmAccounts()
        {
            InitializeComponent();
        }

        private void Accounts_Load(object sender, EventArgs e)
        {
            dgvAccounts.DataSource = GetAccountList();

            dgvAccounts.Columns[8].DefaultCellStyle.Format = "c2";
            dgvAccounts.Columns[9].DefaultCellStyle.Format = "c2";
            dgvAccounts.Columns[10].DefaultCellStyle.Format = "P2";
            dgvAccounts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private DataTable GetAccountList()
        {
            DataTable dtAccounts = new DataTable();
            string conString = ConfigurationManager.ConnectionStrings["MyBudgetV1_0.Properties.Settings.MyBudgetDBConnectionString"].ConnectionString;

            using (SqlConnection con = new SqlConnection(conString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT A.AccountID AS 'Account ID', A.AccountNumber AS 'Account #', A.AccountName AS 'Account Name', A.PhoneNumber AS 'Phone #', AT.AccountTypeDesc + ' - ' + AT.AccountSubTypeDesc as 'Account Type', A.DueDay AS 'Due Day', " +
                    "A.StatementDay AS'Statement Day', PTC.PayTypeDesc AS 'Default Pay Type', NULLIF(A.AnnualFee, 0) AS 'Annual Fee', A.CreditLimit AS 'Credit Limit', A.APR AS 'APR', SC.StatusCodeDesc AS 'Status Code' " +
                    "FROM Account A " +
                    "LEFT JOIN LU_AccountType AT ON A.LUAccountTypeID = AT.LUAccountTypeID " +
                    "LEFT JOIN LU_PayType PTC ON A.DefaultPayTypeCode = PTC.PayTypeCode " +
                    "LEFT JOIN LU_StatusCode SC ON A.LUStatusCodeID = SC.LUStatusCodeID " +
                    "ORDER BY A.AccountName, A.AccountNumber", con))
                {
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    dtAccounts.Load(dr);
                }
            }

            return dtAccounts;
        }
        private void dgvAccounts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int accountID = Convert.ToInt32(dgvAccounts.CurrentRow.Cells[0].Value.ToString());
            frmAccountDetailEntry accountDetail = new frmAccountDetailEntry(accountID);
            accountDetail.ShowDialog();

            // Refresh the data grid when returning.
            dgvAccounts.DataSource = GetAccountList();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmAccountDetailEntry accountDetail = new frmAccountDetailEntry();
            accountDetail.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvAccounts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {        
                if (e.RowIndex < 0)
                {
                    return;
                }

                int index = e.RowIndex;
                dgvAccounts.Rows[index].Selected = true;
        }

        private void cbShowClosedAccounts_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowClosedAccounts.Checked)
            {
                //Clear filter
                (dgvAccounts.DataSource as DataTable).DefaultView.RowFilter = null;
            }
            else
            {
                //Filter to Open accounts only
                (dgvAccounts.DataSource as DataTable).DefaultView.RowFilter = string.Format("[Status Code] = '{0}'", "Open");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int accountID = Convert.ToInt32(dgvAccounts.CurrentRow.Cells[0].Value.ToString());
            double accountBalance = 0; // TO DO: Get account balance from database

            if (accountID.ToString() == string.Empty)
            {
                MessageBox.Show("Select a row to Delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else if (accountBalance != 0)
            {
                MessageBox.Show("Account balance is not 0 and/or there is account history.\nYou must update the balance to 0 and then set\nthe Account Status to Closed in Account Details. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                DialogResult res =
                    MessageBox.Show("Are you sure that you want to\ndelete account record for:\n" +
                    dgvAccounts.CurrentRow.Cells[2].Value.ToString() + "?", "Confirm Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (res == DialogResult.Yes)
                {
                    // Delete the selected row from the database.
                    string conString = ConfigurationManager.ConnectionStrings["MyBudgetV1_0.Properties.Settings.MyBudgetDBConnectionString"].ConnectionString;

                    using (SqlConnection con = new SqlConnection(conString))
                    {
                        using (SqlCommand cmd = new SqlCommand("DELETE FROM Account WHERE AccountID = " + accountID, con))
                        {
                            con.Open();
                            SqlDataReader dr = cmd.ExecuteReader();
                        }
                    }
                }
                // Refresh the data grid when returning.
                dgvAccounts.DataSource = GetAccountList();
            }
        }
    }
}
