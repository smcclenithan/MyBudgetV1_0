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
using System.Diagnostics;

namespace MyBudgetV1_0.Forms
{
    public partial class frmAccountBalanceEntry : Form
    {
        int AccountBalanceID = 0;
        private Boolean RecordChanged { get; set; }

        public frmAccountBalanceEntry()
        {
            InitializeComponent();
            RecordChanged = false;
            EnableEdit();
        }

        public frmAccountBalanceEntry(int _recordID)
        {
            InitializeComponent();
            AccountBalanceID = _recordID;
            EnableEdit();
        }

        protected void FillAccountListComboBox()
        {
            string conString = ConfigurationManager.ConnectionStrings["MyBudgetV1_0.Properties.Settings.MyBudgetDBConnectionString"].ConnectionString;

            using (SqlConnection con = new SqlConnection(conString))
            {
                try
                {
                    string query = "SELECT AccountID, AccountName, AccountNumber, CONCAT(AccountName, ' - ', AccountNumber) AS FullDesc, WebsiteURL, UserName, Password, StatementDay, DueDay FROM Account ORDER BY AccountName, AccountNumber";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    con.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "AccountList");
                    cboAccountName.DisplayMember = "FullDesc";
                    cboAccountName.ValueMember = "AccountID";
                    cboAccountName.DataSource = ds.Tables["AccountList"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error occured while loading Account List drop down!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {

                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult res;

            if (RecordChanged == true)
            {
                res = MessageBox.Show("Record has been changed. Do you want to save before exiting?", "Save Changes?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3);

                if (res == DialogResult.No)
                {
                    RecordChanged = false;
                    this.Close();
                }
                else if (res == DialogResult.Yes)
                {
                    SaveBalanceToDatabase();

                    this.Close();
                }
                else
                {
                    //Do nothing and return to form.
                }
            }
            else
            {
                {
                    RecordChanged = false;
                    this.Close();
                }
            }
        }

        private void DisableEdit()
        {
            string controlType;
            foreach (Control ctl in grbBalanceDetails.Controls)
            {
                controlType = ctl.GetType().ToString();
                if (ctl.GetType().ToString() == "System.Windows.Forms.TextBox" ||
                    ctl.GetType().ToString() == "System.Windows.Forms.MaskedTextBox" ||
                    ctl.GetType().ToString() == "System.Windows.Forms.ComboBox" ||
                    ctl.GetType().ToString() == "System.Windows.Forms.DateTimePicker")
                {
                    ctl.Enabled = false;
                }
            }

            btnEdit.Enabled = true;
            btnSave.Enabled = false;
            btnClose.Text = "Close";
            btnClose.Enabled = true;
            RecordChanged = false;
        }
        private void EnableEdit()
        {
            foreach (Control ctl in grbBalanceDetails.Controls)
            {
                ;
                if (ctl.GetType().ToString() == "System.Windows.Forms.TextBox" ||
                    ctl.GetType().ToString() == "System.Windows.Forms.MaskedTextBox" ||
                    ctl.GetType().ToString() == "System.Windows.Forms.ComboBox" ||
                    ctl.GetType().ToString() == "System.Windows.Forms.DateTimePicker")
                {
                    ctl.Enabled = true;
                }
            }

            // Do not enalble these for editing. 
            tbWebsiteURL.Enabled = false;
            tbUserName.Enabled = false;
            tbPassword.Enabled = false;

            btnEdit.Enabled = false;
            btnSave.Enabled = true;
            btnClose.Text = "Cancel Edit";
            btnClose.Enabled = true;
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            RecordChanged = true;
        }

        private void MaskedTextBox_TextChanged(object sender, EventArgs e)
        {
            RecordChanged = true;
        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            RecordChanged = true;
        }

        private void ComboBox_TextChanged(object sender, EventArgs e)
        {
            RecordChanged = true;
        }

        private void frmAccountBalanceEntry_Load(object sender, EventArgs e)
        {
            if (AccountBalanceID == 0) // New record
            {
                FillAccountListComboBox();

                lblCreateDateValue.Text = DateTime.Now.ToString();
                lblModifiedDateValue.Text = String.Empty;

                EnableEdit();
            }
            else // Existing record
            {
                DataTable dtBalanceDetails = new DataTable();

                FillAccountListComboBox();

                dtBalanceDetails = GetBalanceDetails(AccountBalanceID);

                PopulateBalanceDetailForm(dtBalanceDetails);
            }
        }

        private DataTable GetBalanceDetails(int RecordID)
        {
            DataTable dtAccountBalance = new DataTable();
            string conString = ConfigurationManager.ConnectionStrings["MyBudgetV1_0.Properties.Settings.MyBudgetDBConnectionString"].ConnectionString;

            using (SqlConnection con = new SqlConnection(conString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT a.AccountID, a.AccountName, a.WebSiteURL, a.UserName, a.Password, b.StatementDate, b.DueDate, b.Balance, b.AmountDue, b.Comments, b.CreateDate, b.ModifyDate FROM Account a JOIN AccountBalance b ON a.AccountID = b.AccountID WHERE b.AccountBalanceID = " + RecordID, con))
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    dtAccountBalance.Load(reader);
                }
            }

            return dtAccountBalance;
        }

        private void PopulateBalanceDetailForm(DataTable dtBalanceDetails)
        {

            this.Text = "Account Balance Details:  "; //+ dtBalanceDetails.Rows[0]["AccountName"].ToString();

            //Populate Form with account balance details.
            cboAccountName.SelectedValue = dtBalanceDetails.Rows[0]["AccountID"].ToString();
            dtpStatementDate.Value = Convert.ToDateTime(dtBalanceDetails.Rows[0]["StatementDate"]);
            dtpDueDate.Value = Convert.ToDateTime(dtBalanceDetails.Rows[0]["DueDate"]);
            mtbBalance.Text = dtBalanceDetails.Rows[0]["Balance"].ToString();
            mtbAmountDue.Text = dtBalanceDetails.Rows[0]["AmountDue"].ToString();
            tbComments.Text = dtBalanceDetails.Rows[0]["Comments"].ToString();
            tbWebsiteURL.Text = dtBalanceDetails.Rows[0]["WebSiteURL"].ToString();
            tbUserName.Text = dtBalanceDetails.Rows[0]["UserName"].ToString();
            tbPassword.Text = dtBalanceDetails.Rows[0]["Password"].ToString();

            lblCreateDateValue.Text = dtBalanceDetails.Rows[0]["CreateDate"].ToString();
            lblModifiedDateValue.Text = dtBalanceDetails.Rows[0]["ModifyDate"].ToString();

            // Now Disable Data Entry fields until the Edit button is clicked.
            DisableEdit();
        }

        private DataTable GetAccountDetails(int AccountID)
        {
            DataTable dtAccounts = new DataTable();
            string conString = ConfigurationManager.ConnectionStrings["MyBudgetV1_0.Properties.Settings.MyBudgetDBConnectionString"].ConnectionString;

            using (SqlConnection con = new SqlConnection(conString))
            { 
                // TO DO * below
                using (SqlCommand cmd = new SqlCommand("SELECT AccountID, AccountNumber, AccountName, AddressLine1, AddressLine2, " +
                    "City, StateCode, PostalCode, PostalCode4, PhoneNumber, LUAccountTypeID, DueDay, StatementDay, DefaultPayTypeCode, " +
                    "AnnualFee, MaturityExpDate, WebSiteURL, UserName, Password, LastPasswordUpdate, CreateDate, ModifyDate, OpenedDate, " +
                    "CreditLimit, APRCalcFrequencyCode, Comments, APR, LUStatusCodeID " +
                    "FROM Account WHERE AccountID = " + AccountID, con))
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    dtAccounts.Load(reader);
                }
            }
            return dtAccounts;
        }

        private void cboAccountName_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Asssume either a new entry or change Account Name as an existing entry.
            int _accountID;
            DateTime endOfMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(1).AddDays(-1);

            _accountID = Convert.ToInt32(Convert.ToInt32(cboAccountName.SelectedValue));

            DataTable dtAccountDetails = new DataTable();

            dtAccountDetails = GetAccountDetails(_accountID);

            DateTime newStatementDate;
            newStatementDate = endOfMonth.AddDays(Convert.ToInt32(dtAccountDetails.Rows[0]["StatementDay"]));

            dtpStatementDate.Value = newStatementDate;

            DateTime newDueDate;
            newDueDate = endOfMonth.AddDays(Convert.ToInt32(dtAccountDetails.Rows[0]["DueDay"]));

            dtpDueDate.Value = newDueDate;

            tbWebsiteURL.Text = dtAccountDetails.Rows[0]["WebSiteURL"].ToString();
            tbUserName.Text = dtAccountDetails.Rows[0]["UserName"].ToString();
            tbPassword.Text = dtAccountDetails.Rows[0]["Password"].ToString();
             
        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {
            if (tbWebsiteURL.Text != "")
            {
                Clipboard.SetText(tbUserName.Text);
                Process.Start(tbWebsiteURL.Text);
            }
        }

        private void btnPromoBalances_Click(object sender, EventArgs e)
        {
            // TO DO
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveBalanceToDatabase();
        }

        private void SaveBalanceToDatabase()
        {
            if (ValidateInput())
            {
                string conString = ConfigurationManager.ConnectionStrings["MyBudgetV1_0.Properties.Settings.MyBudgetDBConnectionString"].ConnectionString;

                SqlConnection con = new SqlConnection(conString);

                string query = "";

                if (AccountBalanceID == 0)
                {
                    try
                    {
                        query = "INSERT INTO dbo.AccountBalance (AccountID, StatementDate, DueDate, Balance, AmountDue, Comments, CreateDate, ModifyDate) VALUES (@AccountID, @StatementDate, @DueDate, @Balance, @AmountDue, @Comments, @CreateDate, @ModifyDate); SELECT MAX(AccountBalanceID) FROM dbo.AccountBalance;";

                        SqlCommand cmd = new SqlCommand(query, con);

                        cmd.Parameters.AddWithValue("@AccountID", cboAccountName.SelectedValue.ToString()); 
                        cmd.Parameters.AddWithValue("@StatementDate", dtpStatementDate.Text);
                        cmd.Parameters.AddWithValue("@DueDate", dtpDueDate.Text);
                        cmd.Parameters.AddWithValue("@Balance", mtbBalance.Text == string.Empty ? 0 : Convert.ToDecimal((object)mtbBalance.Text));
                        cmd.Parameters.AddWithValue("@AmountDue", mtbAmountDue.Text == string.Empty ? 0 : Convert.ToDecimal((object)mtbAmountDue.Text));
                        cmd.Parameters.AddWithValue("@Comments", tbComments.Text);
                        cmd.Parameters.AddWithValue("@CreateDate", DateTime.Now);
                        cmd.Parameters.AddWithValue("@ModifyDate", String.Empty);

                        con.Open();
                        AccountBalanceID = (Int32)cmd.ExecuteScalar();

                        DataTable dtAccountBalanceDetails = new DataTable();

                        FillAccountListComboBox();                        

                        dtAccountBalanceDetails = GetAccountDetails(AccountBalanceID);
                        
                        //PopulateBalanceDetailForm(dtAccountBalanceDetails);

                        MessageBox.Show("New Account Balance successfully created!");
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Error occured while saving new record! - " + ex);
                    }
                    finally
                    {
                        RecordChanged = false;
                        DisableEdit();
                        con.Close();
                    }
                }
                else
                {
                    try
                    {
                        query = "UPDATE dbo.AccountBalance SET " +
                            "AccountID = @AccountID, " +
                            "StatementDate = @StatementDate, " +
                            "DueDate = @DueDate, " +
                            "Balance = @Balance, " +
                            "AmountDue = @AmountDue, " +
                            "Comments = @Comments, " +
                            "ModifyDate = @ModifyDate " +
                            "WHERE AccountBalanceID = @AccountBalanceID";

                        SqlCommand cmd = new SqlCommand(query, con);

                        //Pass values to Parameters
                        cmd.Parameters.AddWithValue("@AccountID", cboAccountName.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@StatementDate", dtpStatementDate.Text);
                        cmd.Parameters.AddWithValue("@DueDate", dtpDueDate.Text);
                        cmd.Parameters.AddWithValue("@Balance", mtbBalance.Text == string.Empty ? 0 : Convert.ToDecimal((object)mtbBalance.Text));
                        cmd.Parameters.AddWithValue("@AmountDue", mtbAmountDue.Text == string.Empty ? 0 : Convert.ToDecimal((object)mtbAmountDue.Text));
                        cmd.Parameters.AddWithValue("@Comments", tbComments.Text);
                        cmd.Parameters.AddWithValue("@ModifyDate", DateTime.Now);
                        cmd.Parameters.AddWithValue("@AccountBalanceID", AccountBalanceID);

                        con.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Account Balance successfully updated!");
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Error occured while updating existing record! - " + ex);
                    }
                    finally
                    {
                        RecordChanged = false;
                        DisableEdit();
                        con.Close();
                    }
                }
            }
            else
            {
                if (cboAccountName.SelectedValue.ToString() == string.Empty)
                {
                    cboAccountName.BackColor = Color.DarkOrange;
                }
                else
                {
                    cboAccountName.BackColor = Color.White;
                }

                if (dtpStatementDate.Text == string.Empty)
                {
                    dtpStatementDate.BackColor = Color.DarkOrange;
                }
                else
                {
                    dtpStatementDate.BackColor = Color.White;
                }

                if (dtpDueDate.Text == string.Empty)
                {
                    dtpDueDate.BackColor = Color.DarkOrange;
                }
                else
                {
                    dtpDueDate.BackColor = Color.White;
                }

                if (mtbBalance.Text == string.Empty)
                {
                    mtbBalance.BackColor = Color.DarkOrange;
                }
                else
                {
                    mtbBalance.BackColor = Color.White;
                }

                if (mtbAmountDue.Text == string.Empty)
                {
                    mtbAmountDue.BackColor = Color.DarkOrange;
                }
                else
                {
                    mtbAmountDue.BackColor = Color.White;
                }

                MessageBox.Show("Highlighted fields are required!");
            }
        }

        private bool ValidateInput()
        {
            if (cboAccountName.SelectedValue.ToString() == string.Empty ||
                mtbBalance.Text == string.Empty ||
                mtbAmountDue.Text == string.Empty ||
                dtpStatementDate.Text.ToString() == string.Empty ||
                dtpDueDate.Text.ToString() == string.Empty)
            {
                return false;
            }
            else
            {
                cboAccountName.BackColor = Color.White;
                dtpStatementDate.BackColor = Color.White;
                dtpDueDate.BackColor = Color.White;
                mtbBalance.BackColor = Color.White;
                mtbAmountDue.BackColor = Color.White;

                return true;
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EnableEdit();

            lblModifiedDateValue.Text = DateTime.Now.ToString();
        }

        private void mtbBalance_Leave(object sender, EventArgs e)
        {
            // Set payment due value to balance by default
            mtbAmountDue.Text = mtbBalance.Text;
        }

        private void btnPayNow_Click(object sender, EventArgs e)
        {
            // TO DO
        }
    }
}
