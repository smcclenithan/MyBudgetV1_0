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
    public partial class frmAccountPaymentEntry : Form
    {
        int AccountBalanceID = 0;
        int AccountPaymentID = 0;

        DataTable dtAccountPayment = new DataTable();
        private Boolean RecordChanged { get; set; }

        public frmAccountPaymentEntry()
        {
            InitializeComponent();
            RecordChanged = false;
            EnableEdit();
        }

        public frmAccountPaymentEntry(int _BRecordID, int _PRecordID)
        {
            InitializeComponent();
            AccountBalanceID = _BRecordID;
            AccountPaymentID = _PRecordID;
            RecordChanged = false;
            EnableEdit();
        }

        private void AccountPaymentEntry_Load(object sender, EventArgs e)
        {
            FillPaymentAccountListComboBox();

            cboPaymentAccount.SelectedIndex = 0; // set default payment account value.

            dtAccountPayment = GetAccountPaymentDetails(AccountBalanceID);

            PopulateAccountPaymentForm(dtAccountPayment);

            EnableEdit();
            lblCreateDateValue.Text = DateTime.Now.ToString();

            EnableEdit();
            lblModifiedDateValue.Text = DateTime.Now.ToString();

        }

        private DataTable GetAccountPaymentDetails(int _balanceID)
        {
            DataTable dtPayment = new DataTable();
            string conString = ConfigurationManager.ConnectionStrings["MyBudgetV1_0.Properties.Settings.MyBudgetDBConnectionString"].ConnectionString;

            using (SqlConnection con = new SqlConnection(conString))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT AB.AccountBalanceID, AB.AccountID, A.AccountName, A.WebSiteURL, A.UserName, A.Password, " +
                        "AB.StatementDate, AB.DueDate, AB.Balance, AB.AmountDue, " +
                        "AP.DatePaid, AP.AmountPaid, AP.PaymentCleared, AP.AccountPaymentID, AP.CreateDate, AP.ModifyDate, AP.PaymentAccountID, A2.AccountName, " +
                        "AP.PaymentComment, AP.ConfirmationNumber " +
                        "FROM AccountBalance AB " +
                        "JOIN Account A ON AB.AccountID = A.AccountID " +
                        "LEFT JOIN AccountPayment AP ON AB.AccountBalanceID = AP.AccountBalanceID " +
                        "LEFT JOIN Account A2 ON AP.PaymentAccountID = A2.AccountID " +
                        "WHERE AB.AccountBalanceID = " + _balanceID, con))
                    {
                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        dtPayment.Load(reader);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured while loading Account Payment! - " + ex);
                }
                finally
                {
                    con.Close();
                }
            }

            return dtPayment;
        }

        private void PopulateAccountPaymentForm(DataTable dtAccountPayment)
        {
            this.Text = "Account Payment:  " + dtAccountPayment.Rows[0]["AccountName"].ToString();

            //Populate Form with account balance/payment details.
            lblAccountName.Text = "Account Name:  " + dtAccountPayment.Rows[0]["AccountName"].ToString();
            lblStatementDate.Text = "Statement Date:  " + ((DateTime)dtAccountPayment.Rows[0]["StatementDate"]).ToString("MM/dd/yyyy");
            lblDueDate.Text = "Due Date:  " + ((DateTime)dtAccountPayment.Rows[0]["DueDate"]).ToString("MM/dd/yyyy");
            lblBalance.Text = "Balance:  " + dtAccountPayment.Rows[0]["Balance"].ToString();
            lblAmountDue.Text = "Amount Due:  " + dtAccountPayment.Rows[0]["AmountDue"].ToString();
            tbWebsiteURL.Text = dtAccountPayment.Rows[0]["WebSiteURL"].ToString();
            tbUserName.Text = dtAccountPayment.Rows[0]["UserName"].ToString();
            tbPassword.Text = dtAccountPayment.Rows[0]["Password"].ToString();
            tbPaymentComments.Text = dtAccountPayment.Rows[0]["PaymentComment"].ToString();
            tbConfirmationNumber.Text = dtAccountPayment.Rows[0]["ConfirmationNumber"].ToString();
            mtbAmountPaid.Text = dtAccountPayment.Rows[0]["AmountPaid"].ToString();

            if (dtAccountPayment.Rows[0]["DatePaid"].ToString() == String.Empty)
            {
                dtpPaymentDate.Value = DateTime.Now;
            }
            else
            {
                dtpPaymentDate.Value = Convert.ToDateTime(dtAccountPayment.Rows[0]["DatePaid"]);
            }
            if (dtAccountPayment.Rows[0]["PaymentCleared"].ToString() == "Y")
            {
                this.chbPaymentCleared.Checked = true;
            }
            else
            {
                this.chbPaymentCleared.Checked = false;
            }
            
            if (AccountPaymentID == 0) // Balance record exists without a currrent payment record.
            {
                cboPaymentAccount.SelectedIndex = 0; // set default payment account value.
                lblCreateDateValue.Text = DateTime.Now.ToString();
                lblModifiedDateValue.Text = "";
            }
            else // An existing payment is available.
            {
                cboPaymentAccount.SelectedValue = dtAccountPayment.Rows[0]["PaymentAccountID"];
                lblCreateDateValue.Text = dtAccountPayment.Rows[0]["CreateDate"].ToString();
                lblModifiedDateValue.Text = dtAccountPayment.Rows[0]["ModifyDate"].ToString();
            }

            // Now Disable Data Entry fields until the Edit button is clicked.
            DisableEdit();
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
                    cboPaymentAccount.DisplayMember = "FullDesc";
                    cboPaymentAccount.ValueMember = "AccountID";
                    cboPaymentAccount.DataSource = ds.Tables["PaymentAccountList"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error occured while loading Payment Account List drop down!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    SavePaymentToDatabase();

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

        private void btnSave_Click(object sender, EventArgs e)
        {
            SavePaymentToDatabase();
        }

        private void SavePaymentToDatabase()
        {
            if (ValidateInput())
            {
                string conString = ConfigurationManager.ConnectionStrings["MyBudgetV1_0.Properties.Settings.MyBudgetDBConnectionString"].ConnectionString;

                SqlConnection con = new SqlConnection(conString);

                string query = "";

                if (AccountPaymentID == 0)
                {
                    try
                    {
                        query = "INSERT INTO dbo.AccountPayment (AccountBalanceID, AmountPaid, DatePaid, PaymentCleared, PaymentComment, ConfirmationNumber, CreateDate, ModifyDate, PaymentAccountID) " +
                            "VALUES (@AccountBalanceID, @AmountPaid, @DatePaid, @PaymentCleared, @PaymentComment, @ConfirmationNumber, @CreateDate, @ModifyDate, @PaymentAccountID); " +
                            "SELECT MAX(AccountPaymentID) FROM dbo.AccountPayment;";

                        SqlCommand cmd = new SqlCommand(query, con);
                        
                        cmd.Parameters.AddWithValue("@AccountBalanceID", AccountBalanceID);
                        cmd.Parameters.AddWithValue("@AmountPaid", mtbAmountPaid.Text.ToString());
                        cmd.Parameters.AddWithValue("@DatePaid", dtpPaymentDate.Text);
                        cmd.Parameters.AddWithValue("@PaymentCleared", chbPaymentCleared.Checked ? "Y" : "N");
                        cmd.Parameters.AddWithValue("@PaymentComment", tbPaymentComments.Text);
                        cmd.Parameters.AddWithValue("@ConfirmationNumber", tbConfirmationNumber.Text);
                        cmd.Parameters.AddWithValue("@CreateDate", DateTime.Now);
                        cmd.Parameters.AddWithValue("@ModifyDate", DateTime.Now);
                        cmd.Parameters.AddWithValue("@PaymentAccountID", cboPaymentAccount.SelectedValue.ToString());

                        con.Open();
                        AccountPaymentID = (Int32)cmd.ExecuteScalar();

                        DataTable dtAccountPaymentDetails = new DataTable();

                        //FillPaymentAccountListComboBox();

                        //dtAccountPaymentDetails = GetAccountDetails(AccountPaymentID);

                        //PopulateBalanceDetailForm(dtAccountBalanceDetails);

                        MessageBox.Show("New Account Payment successfully created for " + lblAccountName.Text + "!");
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Error occured while saving new record! - " + ex.Message);
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
                        query = "UPDATE dbo.AccountPayment SET " +
                          "AmountPaid = @AmountPaid, " +
                          "DatePaid = @DatePaid, " +
                          "PaymentCleared = @PaymentCleared, " +
                          "PaymentComment = @PaymentComment, " +
                          "ConfirmationNumber = @ConfirmationNumber, " +
                          "ModifyDate = @ModifyDate, " +
                          "PaymentAccountID = @PaymentAccountID " +
                          "WHERE AccountPaymentID = @AccountPaymentID";

                        SqlCommand cmd = new SqlCommand(query, con);
                                              
                        //Pass values to Parameters
                        cmd.Parameters.AddWithValue("@AmountPaid", mtbAmountPaid.Text.ToString());
                        cmd.Parameters.AddWithValue("@DatePaid", dtpPaymentDate.Text);
                        cmd.Parameters.AddWithValue("@PaymentCleared", chbPaymentCleared.Checked ? "Y" : "N");
                        cmd.Parameters.AddWithValue("@PaymentComment", tbPaymentComments.Text);
                        cmd.Parameters.AddWithValue("@ConfirmationNumber", tbConfirmationNumber.Text);
                        cmd.Parameters.AddWithValue("@ModifyDate", DateTime.Now);
                        cmd.Parameters.AddWithValue("@PaymentAccountID", cboPaymentAccount.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@AccountPaymentID", AccountPaymentID);

                        con.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Account Payment successfully updated for:\n" + lblAccountName.Text);
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
                if (dtpPaymentDate.Text == string.Empty)
                {
                    dtpPaymentDate.BackColor = Color.DarkOrange;
                }
                else
                {
                    dtpPaymentDate.BackColor = Color.White;
                }

                if (mtbAmountPaid.Text == string.Empty)
                {
                    mtbAmountPaid.BackColor = Color.DarkOrange;
                }
                else
                {
                    mtbAmountPaid.BackColor = Color.White;
                }

                if (cboPaymentAccount.SelectedIndex > -1)
                {
                    cboPaymentAccount.BackColor = Color.DarkOrange;
                }
                else
                {
                    cboPaymentAccount.BackColor = Color.White;
                }

                MessageBox.Show("Highlighted fields are required!");
            }
        }
        private bool ValidateInput()
        {
            if (cboPaymentAccount.SelectedValue.ToString() == string.Empty ||
                mtbAmountPaid.Text == string.Empty ||
                dtpPaymentDate.Text.ToString() == string.Empty)
            {
                return false;
            }
            else
            {
            cboPaymentAccount.BackColor = Color.White;
            mtbAmountPaid.BackColor = Color.White;
            dtpPaymentDate.BackColor = Color.White;

                return true;
            }
        }
        private void btnLaunch_Click(object sender, EventArgs e)
        {
            if (tbWebsiteURL.Text != "")
            {
            Clipboard.SetText(tbUserName.Text);
            Process.Start(tbWebsiteURL.Text);
            }
        }

        private void DisableEdit()
        {
            string controlType;
            foreach (Control ctl in grbAccountPayment.Controls)
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
            foreach (Control ctl in grbAccountPayment.Controls)
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

            btnEdit.Enabled = false;
            btnSave.Enabled = true;
            btnClose.Text = "Cancel Edit";
            btnClose.Enabled = true;

            lblModifiedDateValue.Text= DateTime.Now.ToString();
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

        private void ComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            RecordChanged = true;
        }

        private void chbPaymentCleared_CheckedChanged(object sender, EventArgs e)
        {
            RecordChanged = true;
        }

        private void lblAmountDue_Click(object sender, EventArgs e)
        {
            mtbAmountPaid.Text = dtAccountPayment.Rows[0]["AmountDue"].ToString();
        }

        private void lblBalance_Click(object sender, EventArgs e)
        {
            mtbAmountPaid.Text = dtAccountPayment.Rows[0]["Balance"].ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EnableEdit();
        }
    }
    }
