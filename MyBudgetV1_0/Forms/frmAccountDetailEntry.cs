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
    public partial class frmAccountDetailEntry : Form
    {
        int AccountID = 0;
        private Boolean RecordChanged { get; set; }

        public frmAccountDetailEntry()
        {
            InitializeComponent();
            RecordChanged = false;
            EnableEdit();
        }
        public frmAccountDetailEntry(int _accountID)
        {
            InitializeComponent();
            AccountID = _accountID;
            RecordChanged = false;
        }
        private void AccountDetail_Load(object sender, EventArgs e)
        {
            if (AccountID == 0)
            {
                FillStatusCodeComboBox();
                cboAccountStatus.SelectedIndex = 2;
                FillStateCodeComboBox();
                FillAccountTypeComboBox();
                cboAccountType.SelectedIndex = 0;
                FillDefaultPayTypeComboBox();
                FillAPRCalFrequencyComboBox();
                FillDefaultPaymentAccountComboBox();

                EnableEdit();
                lblCreateDateValue.Text = DateTime.Now.ToString();
            }
            else
            {
                DataTable dtAccountDetails = new DataTable();

                FillStatusCodeComboBox();
                FillStateCodeComboBox();
                FillAccountTypeComboBox();
                FillDefaultPayTypeComboBox();
                FillAPRCalFrequencyComboBox();
                FillDefaultPaymentAccountComboBox();

                dtAccountDetails = GetAccountDetails(AccountID);

                PopulateAccountDetailForm(dtAccountDetails);
            }
        }

        private void PopulateAccountDetailForm(DataTable dtAccountDetails)
        {
            this.Text = "Account Details:  " + dtAccountDetails.Rows[0]["AccountName"].ToString();

            //Populate Form with account details.
            lblAccountID.Text = "Account ID:  " + AccountID.ToString();
            cboAccountStatus.SelectedValue = Convert.ToInt32(dtAccountDetails.Rows[0]["LUStatusCodeID"]);
            tbAccountName.Text = dtAccountDetails.Rows[0]["AccountName"].ToString();
            tbAddressLine1.Text = dtAccountDetails.Rows[0]["AddressLine1"].ToString();
            tbAddressLine2.Text = dtAccountDetails.Rows[0]["AddressLine2"].ToString();
            tbCity.Text = dtAccountDetails.Rows[0]["City"].ToString();
            cboStateCode.SelectedValue = dtAccountDetails.Rows[0]["StateCode"].ToString();
            tbPostalCode.Text = dtAccountDetails.Rows[0]["PostalCode"].ToString();
            tbPostalCode4.Text = dtAccountDetails.Rows[0]["PostalCode4"].ToString();
            mtbPhoneNumber.Text = dtAccountDetails.Rows[0]["PhoneNumber"].ToString();
            tbAccountNumber.Text = dtAccountDetails.Rows[0]["AccountNumber"].ToString();
            cboAccountType.SelectedValue = dtAccountDetails.Rows[0]["LUAccountTypeID"];
            tbStatementDay.Text = dtAccountDetails.Rows[0]["StatementDay"].ToString();
            tbDueDay.Text = dtAccountDetails.Rows[0]["DueDay"].ToString();
            cboDefaultPayType.SelectedValue = dtAccountDetails.Rows[0]["DefaultPayTypeCode"].ToString();
            cboDefaultPayAccount.SelectedValue = dtAccountDetails.Rows[0]["DefaultPaymentAccountID"].ToString();
            mtbAnnualFee.Text = dtAccountDetails.Rows[0]["AnnualFee"].ToString();
            mtbCreditLimit.Text = dtAccountDetails.Rows[0]["CreditLimit"].ToString();
            mtbAPR.Text = dtAccountDetails.Rows[0]["APR"].ToString();
            cboAPRCalcFrequency.SelectedValue = dtAccountDetails.Rows[0]["APRCalcFrequencyCode"].ToString();
            tbComments.Text = dtAccountDetails.Rows[0]["Comments"].ToString();
            tbWebsiteURL.Text = dtAccountDetails.Rows[0]["WebSiteURL"].ToString();
            tbUserName.Text = dtAccountDetails.Rows[0]["UserName"].ToString();
            tbPassword.Text = dtAccountDetails.Rows[0]["Password"].ToString();
            dtpLastPasswordUpdate.Value = Convert.ToDateTime(dtAccountDetails.Rows[0]["LastPasswordUpdate"]);
            dtpOpenedDate.Value = Convert.ToDateTime(dtAccountDetails.Rows[0]["OpenedDate"]);
            
            if (dtAccountDetails.Rows[0]["MaturityExpDate"].ToString() == string.Empty)
            {
                dtpMaturityExpDate.Checked = false; 
            }
            else
            {
                dtpMaturityExpDate.Checked = true;
                dtpMaturityExpDate.Value = Convert.ToDateTime(dtAccountDetails.Rows[0]["MaturityExpDate"]);
            }
               
            lblCreateDateValue.Text = dtAccountDetails.Rows[0]["CreateDate"].ToString();
            lblModifiedDateValue.Text = dtAccountDetails.Rows[0]["ModifyDate"].ToString();

            // Now Disable Data Entry fields until the Edit button is clicked.
            DisableEdit();
        }

        protected void FillStateCodeComboBox()
        {
            string conString = ConfigurationManager.ConnectionStrings["MyBudgetV1_0.Properties.Settings.MyBudgetDBConnectionString"].ConnectionString;

            using (SqlConnection con = new SqlConnection(conString))
            {
                try
                {
                    string query = "SELECT StateCode, StateName FROM LU_StateCode ORDER BY StateCode";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    con.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "StateCodes");
                    cboStateCode.DisplayMember = "StateCode";
                    cboStateCode.ValueMember = "StateCode";
                    cboStateCode.DataSource = ds.Tables["StateCodes"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error occured while loading StateCode drop down!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        protected void FillStatusCodeComboBox()
        {
            string conString = ConfigurationManager.ConnectionStrings["MyBudgetV1_0.Properties.Settings.MyBudgetDBConnectionString"].ConnectionString;

            using (SqlConnection con = new SqlConnection(conString))
            {
                try
                {
                    string query = "SELECT LUStatusCodeID, StatusType, StatusCode, StatusCodeDesc FROM LU_StatusCode WHERE StatusType = 'Account' ORDER BY StatusCodeDesc";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    con.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "AccountStatus");
                    cboAccountStatus.DisplayMember = "StatusCodeDesc";
                    cboAccountStatus.ValueMember = "LUStatusCodeID";
                    cboAccountStatus.DataSource = ds.Tables["AccountStatus"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error occured while loading AccountStatus drop down!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        protected void FillAccountTypeComboBox()
        {
            string conString = ConfigurationManager.ConnectionStrings["MyBudgetV1_0.Properties.Settings.MyBudgetDBConnectionString"].ConnectionString;

            using (SqlConnection con = new SqlConnection(conString))
            {
                try
                {
                    string query = "SELECT LUAccountTypeID, AccountTypeCode, AccountTypeDesc, AccountSubTypeCode, AccountSubTypeDesc, CONCAT(AccountTypeDesc, ' - ', AccountSubTypeDesc) AS FullAccountTypeDesc FROM LU_AccountType ORDER BY FullAccountTypeDesc";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    con.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "AccountTypes");
                    cboAccountType.DisplayMember = "FullAccountTypeDesc";
                    cboAccountType.ValueMember = "LUAccountTypeID";
                    cboAccountType.DataSource = ds.Tables["AccountTypes"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error occured while loading AccountTypes drop down!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }
        }
        protected void FillDefaultPayTypeComboBox()
        {
            string conString = ConfigurationManager.ConnectionStrings["MyBudgetV1_0.Properties.Settings.MyBudgetDBConnectionString"].ConnectionString;

            using (SqlConnection con = new SqlConnection(conString))
            {
                try
                {
                    string query = "SELECT PayTypeCode, PayTypeDesc FROM LU_PayType ORDER BY PayTypeCode";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    con.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "PayTypes");
                    cboDefaultPayType.DisplayMember = "PayTypeDesc";
                    cboDefaultPayType.ValueMember = "PayTypeCode";
                    cboDefaultPayType.DataSource = ds.Tables["PayTypes"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error occured while loading DefaultPayType drop down!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }
        }
        protected void FillDefaultPaymentAccountComboBox()
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
                    da.Fill(ds, "DefaultPayAccountList");
                    cboDefaultPayAccount.DisplayMember = "FullDesc";
                    cboDefaultPayAccount.ValueMember = "AccountID";
                    cboDefaultPayAccount.DataSource = ds.Tables["DefaultPayAccountList"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error occured while loading DefaultPaymentAccount drop down!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }
        }
        protected void FillAPRCalFrequencyComboBox()
        {
            string conString = ConfigurationManager.ConnectionStrings["MyBudgetV1_0.Properties.Settings.MyBudgetDBConnectionString"].ConnectionString;

            using (SqlConnection con = new SqlConnection(conString))
            {
                try
                {
                    string query = "SELECT APRCalcFrequencyCode, APRCalcFrequencyDesc FROM LU_APRCalcFrequency ORDER BY APRCalcFrequencyCode";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    con.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "APRCalcFrequency");
                    cboAPRCalcFrequency.DisplayMember = "APRCalcFrequencyDesc";
                    cboAPRCalcFrequency.ValueMember = "APRCalcFrequencyCode";
                    cboAPRCalcFrequency.DataSource = ds.Tables["APRCalcFrequency"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured while loading APRCalFrequency drop down! - " + ex);
                }
                finally
                {
                    con.Close();
                }
            }
        }
        private DataTable GetAccountDetails(int AccountID)
        {
            DataTable dtAccounts = new DataTable();
            string conString = ConfigurationManager.ConnectionStrings["MyBudgetV1_0.Properties.Settings.MyBudgetDBConnectionString"].ConnectionString;

            using (SqlConnection con = new SqlConnection(conString))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT AccountID, " +
                       "AccountNumber, AccountName, AddressLine1, AddressLine2, City, StateCode, PostalCode, PostalCode4, PhoneNumber, " +
                       "LUAccountTypeID, DueDay, StatementDay, DefaultPayTypeCode, AnnualFee, MaturityExpDate, WebSiteURL, UserName, Password, " +
                       "LastPasswordUpdate, CreateDate, ModifyDate, OpenedDate, CreditLimit, APRCalcFrequencyCode, Comments, APR, LUStatusCodeID, " +
                       "DefaultPaymentAccountID " +
                       "FROM Account WHERE AccountID = " + AccountID, con))
                    {
                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        dtAccounts.Load(reader);
                    }
                }                                               
                
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured while loading Account Details! - " + ex);
                }
                finally
                {
                    con.Close();
                }
            }

            return dtAccounts;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EnableEdit();

            lblModifiedDateValue.Text = DateTime.Now.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveAccountToDatabase();
        }

        private void SaveAccountToDatabase()
        {
            if (ValidateInput())
            {
                string conString = ConfigurationManager.ConnectionStrings["MyBudgetV1_0.Properties.Settings.MyBudgetDBConnectionString"].ConnectionString;
                
                SqlConnection con = new SqlConnection(conString);

                string query = "";

                if (AccountID == 0)
                {
                    try
                    {
                        query = "INSERT INTO dbo.Account (LUStatusCodeID, AccountNumber, AccountName, AddressLine1, AddressLine2, City, StateCode, PostalCode, PostalCode4, PhoneNumber, LUAccountTypeID, DueDay, StatementDay, DefaultPayTypeCode, AnnualFee, MaturityExpDate, WebSiteURL, UserName, Password, LastPasswordUpdate, CreateDate, ModifyDate, OpenedDate, CreditLimit, APRCalcFrequencyCode, Comments, APR, DefaultPaymentAccountID) " +
                            "VALUES (@AccountStatus, @AccountNumber, @AccountName, @AddressLine1, @AddressLine2, @City, @StateCode, @PostalCode, @PostalCode4, @PhoneNumber, @AccountTypeCode, @DueDay, @StatementDay, @DefaultPayTypeCode, @AnnualFee, @MaturityExpDate, @WebSiteURL, @UserName, @Password, @LastPasswordUpdate, @CreateDate, @ModifyDate, @OpenedDate, @CreditLimit, @APRCalcFrequencyCode, @Comments, @APR, @DefaultPaymentAccountID); " +
                            "SELECT MAX(AccountID) FROM dbo.Account;";

                        SqlCommand cmd = new SqlCommand(query, con);

                        cmd.Parameters.AddWithValue("@AccountStatus", cboAccountStatus.SelectedValue.ToString() == null ? "O" : (object)cboAccountStatus.SelectedValue.ToString()); // Default to Open
                        cmd.Parameters.AddWithValue("@AccountNumber", tbAccountNumber.Text);
                        cmd.Parameters.AddWithValue("@AccountName", tbAccountName.Text);
                        cmd.Parameters.AddWithValue("@AddressLine1", tbAddressLine1.Text);
                        cmd.Parameters.AddWithValue("@AddressLine2", tbAddressLine2.Text);
                        cmd.Parameters.AddWithValue("@City", tbCity.Text);
                        cmd.Parameters.AddWithValue("@StateCode", cboStateCode.SelectedValue.ToString() == null ? DBNull.Value : (object)cboStateCode.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@PostalCode", tbPostalCode.Text);
                        cmd.Parameters.AddWithValue("@PostalCode4", tbPostalCode4.Text);
                        cmd.Parameters.AddWithValue("@PhoneNumber", mtbPhoneNumber.Text);
                        cmd.Parameters.AddWithValue("@AccountTypeCode", cboAccountType.SelectedValue);
                        cmd.Parameters.AddWithValue("@DueDay", tbDueDay.Text == string.Empty ? 0 : Convert.ToInt32((object)tbDueDay.Text));
                        cmd.Parameters.AddWithValue("@StatementDay", tbStatementDay.Text == string.Empty ? 0 : Convert.ToInt32((object)tbStatementDay.Text));
                        cmd.Parameters.AddWithValue("@DefaultPayTypeCode", cboDefaultPayType.SelectedValue.ToString() == null ? DBNull.Value : (object)cboDefaultPayType.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@AnnualFee", mtbAnnualFee.Text == string.Empty ? 0 : Convert.ToDecimal((object)mtbAnnualFee.Text));
                        cmd.Parameters.AddWithValue("@MaturityExpDate", dtpMaturityExpDate.Text);
                        cmd.Parameters.AddWithValue("@WebSiteURL", tbWebsiteURL.Text);
                        cmd.Parameters.AddWithValue("@UserName", tbUserName.Text);
                        cmd.Parameters.AddWithValue("@Password", tbPassword.Text);
                        cmd.Parameters.AddWithValue("@LastPasswordUpdate", dtpLastPasswordUpdate.Text);
                        cmd.Parameters.AddWithValue("@CreateDate", DateTime.Now);
                        cmd.Parameters.AddWithValue("@ModifyDate", DateTime.Now);
                        cmd.Parameters.AddWithValue("@OpenedDate", dtpOpenedDate.Text);
                        cmd.Parameters.AddWithValue("@CreditLimit", mtbCreditLimit.Text == string.Empty ? 0 : Convert.ToDecimal((object)mtbCreditLimit.Text));
                        cmd.Parameters.AddWithValue("@APRCalcFrequencyCode", cboAPRCalcFrequency.SelectedValue.ToString() == null ? DBNull.Value : (object)cboAPRCalcFrequency.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@Comments", tbComments.Text);
                        cmd.Parameters.AddWithValue("@APR", mtbAPR.Text == string.Empty ? 0 : Convert.ToDecimal((object)mtbAPR.Text));
                        cmd.Parameters.AddWithValue("@DefaultPaymentAccountID", cboDefaultPayAccount.SelectedValue.ToString() == null ? DBNull.Value : (object)cboDefaultPayAccount.SelectedValue.ToString());

                        con.Open();
                        AccountID = (Int32)cmd.ExecuteScalar();

                        DataTable dtAccountDetails = new DataTable();

                        FillStatusCodeComboBox();
                        FillStateCodeComboBox();
                        FillAccountTypeComboBox();
                        FillDefaultPayTypeComboBox();
                        FillAPRCalFrequencyComboBox();
                        FillDefaultPaymentAccountComboBox();

                        dtAccountDetails = GetAccountDetails(AccountID);

                        PopulateAccountDetailForm(dtAccountDetails);

                        MessageBox.Show("New Account " + AccountID + " successfully created for " + tbAccountName.Text + "!");
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
                        query = "UPDATE dbo.Account SET " +
                            "LUStatusCodeID = @AccountStatus, " +
                            "AccountNumber = @AccountNumber, " +
                            "AccountName = @AccountName, " +
                            "AddressLine1 = @AddressLine1, " +
                            "AddressLine2 = @AddressLine2, " +
                            "City = @City, " +
                            "StateCode = @StateCode, " +
                            "PostalCode = @PostalCode, " +
                            "PostalCode4 = @PostalCode4, " +
                            "PhoneNumber = @PhoneNumber, " +
                            "LUAccountTypeID = @AccountTypeCode, " +
                            "DueDay = @DueDay, " +
                            "StatementDay = @StatementDay, " +
                            "DefaultPayTypeCode = @DefaultPayTypeCode, " +
                            "AnnualFee = @AnnualFee, " +
                            "MaturityExpDate = @MaturityExpDate, " +
                            "WebSiteURL = @WebSiteURL, " +
                            "UserName = @UserName, " +
                            "Password = @Password, " +
                            "LastPasswordUpdate = @LastPasswordUpdate, " +
                            "ModifyDate = @ModifyDate, " +
                            "OpenedDate = @OpenedDate, " +
                            "CreditLimit = @CreditLimit," +
                            "APRCalcFrequencyCode = @APRCalcFrequencyCode," +
                            "Comments = @Comments," +
                            "APR = @APR," +
                            "DefaultPaymentAccountID = @DefaultPaymentAccountID " +
                            "WHERE AccountID = @AccountID";

                        SqlCommand cmd = new SqlCommand(query, con);

                        //Pass values to Parameters
                        cmd.Parameters.AddWithValue("@AccountStatus", cboAccountStatus.SelectedValue.ToString() == null ? "O" : (object)cboAccountStatus.SelectedValue.ToString()); // Default to Open
                        cmd.Parameters.AddWithValue("@AccountNumber", tbAccountNumber.Text);
                        cmd.Parameters.AddWithValue("@AccountName", tbAccountName.Text);
                        cmd.Parameters.AddWithValue("@AddressLine1", tbAddressLine1.Text);
                        cmd.Parameters.AddWithValue("@AddressLine2", tbAddressLine2.Text);
                        cmd.Parameters.AddWithValue("@City", tbCity.Text);
                        cmd.Parameters.AddWithValue("@StateCode", cboStateCode.SelectedValue.ToString() == null ? DBNull.Value : (object)cboStateCode.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@PostalCode", tbPostalCode.Text);
                        cmd.Parameters.AddWithValue("@PostalCode4", tbPostalCode4.Text);
                        cmd.Parameters.AddWithValue("@PhoneNumber", mtbPhoneNumber.Text);
                        cmd.Parameters.AddWithValue("@AccountTypeCode", cboAccountType.SelectedValue);
                        cmd.Parameters.AddWithValue("@DueDay", tbDueDay.Text == string.Empty ? 0 : Convert.ToInt32((object)tbDueDay.Text));
                        cmd.Parameters.AddWithValue("@StatementDay", tbStatementDay.Text == string.Empty ? 0 : Convert.ToInt32((object)tbStatementDay.Text));
                        cmd.Parameters.AddWithValue("@DefaultPayTypeCode", cboDefaultPayType.SelectedValue.ToString() == string.Empty ? DBNull.Value : (object)cboDefaultPayType.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@AnnualFee", mtbAnnualFee.Text == string.Empty ? 0 : Convert.ToDouble((object)mtbAnnualFee.Text));
                        cmd.Parameters.AddWithValue("@MaturityExpDate", dtpMaturityExpDate.Text);
                        cmd.Parameters.AddWithValue("@WebSiteURL", tbWebsiteURL.Text);
                        cmd.Parameters.AddWithValue("@UserName", tbUserName.Text);
                        cmd.Parameters.AddWithValue("@Password", tbPassword.Text);
                        cmd.Parameters.AddWithValue("@LastPasswordUpdate", dtpLastPasswordUpdate.Text);
                        cmd.Parameters.AddWithValue("@ModifyDate", DateTime.Now);
                        cmd.Parameters.AddWithValue("@OpenedDate", dtpOpenedDate.Text);
                        cmd.Parameters.AddWithValue("@CreditLimit", mtbCreditLimit.Text == string.Empty ? 0 : Convert.ToDouble((object)mtbCreditLimit.Text));
                        cmd.Parameters.AddWithValue("@APRCalcFrequencyCode", cboAPRCalcFrequency.SelectedValue.ToString() == null ? DBNull.Value : (object)cboAPRCalcFrequency.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@Comments", tbComments.Text);
                        cmd.Parameters.AddWithValue("@APR", mtbAPR.Text == string.Empty ? 0 : Convert.ToDouble((object)mtbAPR.Text));
                        cmd.Parameters.AddWithValue("@DefaultPaymentAccountID", cboDefaultPayAccount.SelectedValue.ToString() == null ? DBNull.Value : (object)cboDefaultPayAccount.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@AccountID", AccountID);

                        con.Open();
                        cmd.ExecuteNonQuery();

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
                if (cboAccountStatus.SelectedValue.ToString() == string.Empty)
                {
                    cboAccountStatus.BackColor = Color.DarkOrange;
                }
                else
                {
                    cboAccountStatus.BackColor = Color.White;
                }

                if (tbAccountName.Text == string.Empty)
                {
                    tbAccountName.BackColor = Color.DarkOrange;
                }
                else
                {
                    tbAccountName.BackColor = Color.White;
                }

                if (tbAccountNumber.Text == string.Empty)
                {
                    tbAccountNumber.BackColor = Color.DarkOrange;
                }
                else
                {
                    tbAccountNumber.BackColor = Color.White;
                }

                if (cboAccountType.SelectedValue.ToString() == string.Empty)
                {
                    cboAccountType.BackColor = Color.DarkOrange;
                }
                else
                {
                    cboAccountType.BackColor = Color.White;
                }

                if (cboDefaultPayType.SelectedValue.ToString() == string.Empty)
                {
                    cboDefaultPayType.BackColor = Color.DarkOrange;
                }
                else
                {
                    cboDefaultPayType.BackColor = Color.White;
                }

                MessageBox.Show("Highlighted fields are required!");
            }
        }

        private bool ValidateInput()
        {
            if (cboAccountStatus.SelectedValue.ToString() == string.Empty || 
                tbAccountName.Text == string.Empty ||
                tbAccountNumber.Text == string.Empty ||
                cboAccountType.SelectedValue.ToString() == string.Empty ||
                cboDefaultPayType.SelectedValue.ToString() == string.Empty)
            {
                return false;
            }
            else
            {
                cboAccountStatus.BackColor = Color.White;
                tbAccountName.BackColor = Color.White;
                tbAccountNumber.BackColor = Color.White;
                cboAccountType.BackColor = Color.White;
                cboDefaultPayType.BackColor = Color.White;

                return true;
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
                    SaveAccountToDatabase();

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
            foreach (Control ctl in grbAccountDetails.Controls)
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
            foreach (Control ctl in grbAccountDetails.Controls)
            {;
                if (ctl.GetType().ToString() == "System.Windows.Forms.TextBox" ||
                    ctl.GetType().ToString() == "System.Windows.Forms.MaskedTextBox" ||
                    ctl.GetType().ToString() == "System.Windows.Forms.ComboBox" ||
                    ctl.GetType().ToString() == "System.Windows.Forms.DateTimePicker")
                {
                    ctl.Enabled = true;
                }
            }

            btnEdit.Enabled = false;
            btnSave.Enabled = true;
            btnClose.Text = "Cancel Edit";
            btnClose.Enabled = true;
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            RecordChanged = true;

            if (sender == dtpLastPasswordUpdate)
            {
                dtpLastPasswordUpdate.Value = DateTime.Now;
            }
        }

        private void MaskedTextBox_TextChanged(object sender, EventArgs e)
        {
            RecordChanged = true;
        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            RecordChanged = true;
        }
               
        private void ComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            RecordChanged = true;
        }
        private void cboAccountType_SelectedValueChanged(object sender, EventArgs e)
        {
            RecordChanged = true;
        }
        private void btnLaunch_Click(object sender, EventArgs e)
        {
            if (tbWebsiteURL.Text != "")
            {
                Clipboard.SetText(tbUserName.Text);
                Process.Start(tbWebsiteURL.Text);
            }
        }

        private void lblUserName_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbUserName.Text);
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbPassword.Text);
        }

        private void formControl_Enter(object sender, EventArgs e)
        {
            if (sender is TextBox)
            {
                (sender as TextBox).SelectAll();
            }
            else if (sender is MaskedTextBox)
            {
                (sender as MaskedTextBox).SelectAll();
            }
            else if (sender is ComboBox)
            {
                (sender as ComboBox).SelectAll();
            }
        }
    }
}