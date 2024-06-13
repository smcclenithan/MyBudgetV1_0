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
    public partial class frmProgramSettings : Form
    {
        DataTable dtProgramSettings = new DataTable();
        public frmProgramSettings()
        {
            InitializeComponent();
        }

        protected void FillPaymentAccountListComboBox()
        {
            string conString = ConfigurationManager.ConnectionStrings["MyBudgetV1_0.Properties.Settings.MyBudgetDBConnectionString"].ConnectionString;

            using (SqlConnection con = new SqlConnection(conString))
            {
                try
                {
                    string query = "SELECT AccountID, AccountNumber, AccountName, CONCAT(AccountName, ' - ', AccountNumber) AS FullDesc FROM PaymentAccounts_vw ORDER BY AccountName, AccountNumber";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    con.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "PaymentAccountList");
                    cboDefaultPayAccount.DisplayMember = "FullDesc";
                    cboDefaultPayAccount.ValueMember = "AccountID";
                    cboDefaultPayAccount.DataSource = ds.Tables["PaymentAccountList"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error occured while loading Payment Account List drop down!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void frmProgramSettings_Load(object sender, EventArgs e)
        {
            PopulateProgramSettings();
            FillPaymentAccountListComboBox();
        }

        private void PopulateProgramSettings()
        {            
            string conString = ConfigurationManager.ConnectionStrings["MyBudgetV1_0.Properties.Settings.MyBudgetDBConnectionString"].ConnectionString;

            using (SqlConnection con = new SqlConnection(conString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT Id, Setting, Value FROM ProgramSettings;", con))
                {
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    dtProgramSettings.Load(dr);
                }
            }

            PopulateSettingsObjects();
        }

        private void PopulateSettingsObjects()
        {
            if (dtProgramSettings.Rows[0]["Value"].ToString() == "Y")
            {
                rbTimeToUpdateAlertYes.Checked = true;
            }
            else
            {
                rbTimeToUpdateAlertNo.Checked = true;
            }

            if (dtProgramSettings.Rows[1]["Value"].ToString() == "Y")
            {
                rbPastDueAlertYes.Checked = true;
            }
            else
            {
                rbPastDueAlertNo.Checked = true;
            }

            tbBillpayReminder.Text = dtProgramSettings.Rows[7]["Value"].ToString();
            cboDefaultPayAccount.SelectedValue = dtProgramSettings.Rows[8]["Value"];
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            //TO DO
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
