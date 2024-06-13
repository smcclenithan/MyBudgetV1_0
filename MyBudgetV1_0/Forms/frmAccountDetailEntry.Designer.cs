namespace MyBudgetV1_0.Forms
{
    partial class frmAccountDetailEntry
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lblAccountNumber;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccountDetailEntry));
            this.mtbPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.tbAccountName = new System.Windows.Forms.TextBox();
            this.lblAccountName = new System.Windows.Forms.Label();
            this.lblCityState = new System.Windows.Forms.Label();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.tbAddressLine2 = new System.Windows.Forms.TextBox();
            this.lblDash = new System.Windows.Forms.Label();
            this.tbPostalCode4 = new System.Windows.Forms.TextBox();
            this.tbPostalCode = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.lblAddressLine2 = new System.Windows.Forms.Label();
            this.cboStateCode = new System.Windows.Forms.ComboBox();
            this.tbAddressLine1 = new System.Windows.Forms.TextBox();
            this.grbAccountDetails = new System.Windows.Forms.GroupBox();
            this.cboAccountStatus = new System.Windows.Forms.ComboBox();
            this.lblAccountStatus = new System.Windows.Forms.Label();
            this.mtbAPR = new System.Windows.Forms.MaskedTextBox();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.lblModifiedDateValue = new System.Windows.Forms.Label();
            this.lblCreateDateValue = new System.Windows.Forms.Label();
            this.dtpLastPasswordUpdate = new System.Windows.Forms.DateTimePicker();
            this.lblComments = new System.Windows.Forms.Label();
            this.tbComments = new System.Windows.Forms.TextBox();
            this.cboAPRCalcFrequency = new System.Windows.Forms.ComboBox();
            this.lblAPRCalcFrequency = new System.Windows.Forms.Label();
            this.lblAPR = new System.Windows.Forms.Label();
            this.mtbCreditLimit = new System.Windows.Forms.MaskedTextBox();
            this.lblCreditLimit = new System.Windows.Forms.Label();
            this.dtpOpenedDate = new System.Windows.Forms.DateTimePicker();
            this.lblOpenedDate = new System.Windows.Forms.Label();
            this.lblModifiedDate = new System.Windows.Forms.Label();
            this.lblCreateDate = new System.Windows.Forms.Label();
            this.lblLastPasswordUpdate = new System.Windows.Forms.Label();
            this.tbWebsiteURL = new System.Windows.Forms.TextBox();
            this.lblWebsiteURL = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.mtbAnnualFee = new System.Windows.Forms.MaskedTextBox();
            this.lblAnnualFee = new System.Windows.Forms.Label();
            this.cboDefaultPayType = new System.Windows.Forms.ComboBox();
            this.lblDefaultPayType = new System.Windows.Forms.Label();
            this.tbStatementDay = new System.Windows.Forms.TextBox();
            this.lblStatementDay = new System.Windows.Forms.Label();
            this.tbDueDay = new System.Windows.Forms.TextBox();
            this.lblDueDay = new System.Windows.Forms.Label();
            this.lblMaturityExpDate = new System.Windows.Forms.Label();
            this.dtpMaturityExpDate = new System.Windows.Forms.DateTimePicker();
            this.cboAccountType = new System.Windows.Forms.ComboBox();
            this.lblAccountTypeCode = new System.Windows.Forms.Label();
            this.tbAccountNumber = new System.Windows.Forms.TextBox();
            this.lblAccountID = new System.Windows.Forms.Label();
            this.lblAddressLine1 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cboDefaultPayAccount = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            lblAccountNumber = new System.Windows.Forms.Label();
            this.grbAccountDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAccountNumber
            // 
            lblAccountNumber.AutoSize = true;
            lblAccountNumber.Location = new System.Drawing.Point(17, 232);
            lblAccountNumber.Name = "lblAccountNumber";
            lblAccountNumber.Size = new System.Drawing.Size(90, 13);
            lblAccountNumber.TabIndex = 0;
            lblAccountNumber.Text = "Account Number:";
            // 
            // mtbPhoneNumber
            // 
            this.mtbPhoneNumber.BackColor = System.Drawing.Color.White;
            this.mtbPhoneNumber.Location = new System.Drawing.Point(117, 189);
            this.mtbPhoneNumber.Mask = "(999) 000-0000";
            this.mtbPhoneNumber.Name = "mtbPhoneNumber";
            this.mtbPhoneNumber.Size = new System.Drawing.Size(84, 20);
            this.mtbPhoneNumber.TabIndex = 9;
            this.mtbPhoneNumber.TextChanged += new System.EventHandler(this.MaskedTextBox_TextChanged);
            this.mtbPhoneNumber.Enter += new System.EventHandler(this.formControl_Enter);
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(17, 192);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(81, 13);
            this.lblPhoneNumber.TabIndex = 0;
            this.lblPhoneNumber.Text = "Phone Number:";
            // 
            // tbAccountName
            // 
            this.tbAccountName.BackColor = System.Drawing.Color.White;
            this.tbAccountName.Location = new System.Drawing.Point(116, 54);
            this.tbAccountName.Name = "tbAccountName";
            this.tbAccountName.Size = new System.Drawing.Size(221, 20);
            this.tbAccountName.TabIndex = 2;
            this.tbAccountName.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.tbAccountName.Enter += new System.EventHandler(this.formControl_Enter);
            // 
            // lblAccountName
            // 
            this.lblAccountName.AutoSize = true;
            this.lblAccountName.Location = new System.Drawing.Point(17, 57);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(81, 13);
            this.lblAccountName.TabIndex = 0;
            this.lblAccountName.Text = "Account Name:";
            // 
            // lblCityState
            // 
            this.lblCityState.AutoSize = true;
            this.lblCityState.Location = new System.Drawing.Point(17, 135);
            this.lblCityState.Name = "lblCityState";
            this.lblCityState.Size = new System.Drawing.Size(58, 13);
            this.lblCityState.TabIndex = 0;
            this.lblCityState.Text = "City, State:";
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.Location = new System.Drawing.Point(17, 161);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.Size = new System.Drawing.Size(67, 13);
            this.lblPostalCode.TabIndex = 0;
            this.lblPostalCode.Text = "Postal Code:";
            // 
            // tbAddressLine2
            // 
            this.tbAddressLine2.BackColor = System.Drawing.Color.White;
            this.tbAddressLine2.Location = new System.Drawing.Point(117, 106);
            this.tbAddressLine2.Name = "tbAddressLine2";
            this.tbAddressLine2.Size = new System.Drawing.Size(221, 20);
            this.tbAddressLine2.TabIndex = 4;
            this.tbAddressLine2.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.tbAddressLine2.Enter += new System.EventHandler(this.formControl_Enter);
            // 
            // lblDash
            // 
            this.lblDash.AutoSize = true;
            this.lblDash.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDash.Location = new System.Drawing.Point(282, 161);
            this.lblDash.Name = "lblDash";
            this.lblDash.Size = new System.Drawing.Size(11, 13);
            this.lblDash.TabIndex = 0;
            this.lblDash.Text = "-";
            // 
            // tbPostalCode4
            // 
            this.tbPostalCode4.Location = new System.Drawing.Point(298, 158);
            this.tbPostalCode4.Name = "tbPostalCode4";
            this.tbPostalCode4.Size = new System.Drawing.Size(39, 20);
            this.tbPostalCode4.TabIndex = 8;
            this.tbPostalCode4.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.tbPostalCode4.Enter += new System.EventHandler(this.formControl_Enter);
            // 
            // tbPostalCode
            // 
            this.tbPostalCode.BackColor = System.Drawing.Color.White;
            this.tbPostalCode.Location = new System.Drawing.Point(222, 158);
            this.tbPostalCode.Name = "tbPostalCode";
            this.tbPostalCode.Size = new System.Drawing.Size(54, 20);
            this.tbPostalCode.TabIndex = 7;
            this.tbPostalCode.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.tbPostalCode.Enter += new System.EventHandler(this.formControl_Enter);
            // 
            // tbCity
            // 
            this.tbCity.BackColor = System.Drawing.Color.White;
            this.tbCity.Location = new System.Drawing.Point(117, 132);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(149, 20);
            this.tbCity.TabIndex = 5;
            this.tbCity.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.tbCity.Enter += new System.EventHandler(this.formControl_Enter);
            // 
            // lblAddressLine2
            // 
            this.lblAddressLine2.AutoSize = true;
            this.lblAddressLine2.Location = new System.Drawing.Point(17, 109);
            this.lblAddressLine2.Name = "lblAddressLine2";
            this.lblAddressLine2.Size = new System.Drawing.Size(80, 13);
            this.lblAddressLine2.TabIndex = 0;
            this.lblAddressLine2.Text = "Address Line 2:";
            // 
            // cboStateCode
            // 
            this.cboStateCode.Location = new System.Drawing.Point(277, 132);
            this.cboStateCode.Name = "cboStateCode";
            this.cboStateCode.Size = new System.Drawing.Size(60, 21);
            this.cboStateCode.TabIndex = 6;
            this.cboStateCode.SelectedValueChanged += new System.EventHandler(this.ComboBox_SelectedValueChanged);
            this.cboStateCode.Enter += new System.EventHandler(this.formControl_Enter);
            // 
            // tbAddressLine1
            // 
            this.tbAddressLine1.BackColor = System.Drawing.Color.White;
            this.tbAddressLine1.Location = new System.Drawing.Point(117, 80);
            this.tbAddressLine1.Name = "tbAddressLine1";
            this.tbAddressLine1.Size = new System.Drawing.Size(221, 20);
            this.tbAddressLine1.TabIndex = 3;
            this.tbAddressLine1.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.tbAddressLine1.Enter += new System.EventHandler(this.formControl_Enter);
            // 
            // grbAccountDetails
            // 
            this.grbAccountDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbAccountDetails.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.grbAccountDetails.Controls.Add(this.cboDefaultPayAccount);
            this.grbAccountDetails.Controls.Add(this.label1);
            this.grbAccountDetails.Controls.Add(this.cboAccountStatus);
            this.grbAccountDetails.Controls.Add(this.lblAccountStatus);
            this.grbAccountDetails.Controls.Add(this.mtbAPR);
            this.grbAccountDetails.Controls.Add(this.btnLaunch);
            this.grbAccountDetails.Controls.Add(this.lblModifiedDateValue);
            this.grbAccountDetails.Controls.Add(this.lblCreateDateValue);
            this.grbAccountDetails.Controls.Add(this.dtpLastPasswordUpdate);
            this.grbAccountDetails.Controls.Add(this.lblComments);
            this.grbAccountDetails.Controls.Add(this.tbComments);
            this.grbAccountDetails.Controls.Add(this.cboAPRCalcFrequency);
            this.grbAccountDetails.Controls.Add(this.lblAPRCalcFrequency);
            this.grbAccountDetails.Controls.Add(this.lblAPR);
            this.grbAccountDetails.Controls.Add(this.mtbCreditLimit);
            this.grbAccountDetails.Controls.Add(this.lblCreditLimit);
            this.grbAccountDetails.Controls.Add(this.dtpOpenedDate);
            this.grbAccountDetails.Controls.Add(this.lblOpenedDate);
            this.grbAccountDetails.Controls.Add(this.lblModifiedDate);
            this.grbAccountDetails.Controls.Add(this.lblCreateDate);
            this.grbAccountDetails.Controls.Add(this.lblLastPasswordUpdate);
            this.grbAccountDetails.Controls.Add(this.tbWebsiteURL);
            this.grbAccountDetails.Controls.Add(this.lblWebsiteURL);
            this.grbAccountDetails.Controls.Add(this.tbPassword);
            this.grbAccountDetails.Controls.Add(this.lblPassword);
            this.grbAccountDetails.Controls.Add(this.tbUserName);
            this.grbAccountDetails.Controls.Add(this.lblUserName);
            this.grbAccountDetails.Controls.Add(this.mtbAnnualFee);
            this.grbAccountDetails.Controls.Add(this.lblAnnualFee);
            this.grbAccountDetails.Controls.Add(this.cboDefaultPayType);
            this.grbAccountDetails.Controls.Add(this.lblDefaultPayType);
            this.grbAccountDetails.Controls.Add(this.tbStatementDay);
            this.grbAccountDetails.Controls.Add(this.lblStatementDay);
            this.grbAccountDetails.Controls.Add(this.tbDueDay);
            this.grbAccountDetails.Controls.Add(this.lblDueDay);
            this.grbAccountDetails.Controls.Add(this.lblMaturityExpDate);
            this.grbAccountDetails.Controls.Add(this.dtpMaturityExpDate);
            this.grbAccountDetails.Controls.Add(this.cboAccountType);
            this.grbAccountDetails.Controls.Add(this.lblAccountTypeCode);
            this.grbAccountDetails.Controls.Add(this.tbAccountNumber);
            this.grbAccountDetails.Controls.Add(this.lblAccountID);
            this.grbAccountDetails.Controls.Add(this.mtbPhoneNumber);
            this.grbAccountDetails.Controls.Add(this.lblPhoneNumber);
            this.grbAccountDetails.Controls.Add(lblAccountNumber);
            this.grbAccountDetails.Controls.Add(this.tbAccountName);
            this.grbAccountDetails.Controls.Add(this.lblAccountName);
            this.grbAccountDetails.Controls.Add(this.lblCityState);
            this.grbAccountDetails.Controls.Add(this.lblPostalCode);
            this.grbAccountDetails.Controls.Add(this.tbAddressLine2);
            this.grbAccountDetails.Controls.Add(this.lblDash);
            this.grbAccountDetails.Controls.Add(this.tbPostalCode4);
            this.grbAccountDetails.Controls.Add(this.tbPostalCode);
            this.grbAccountDetails.Controls.Add(this.tbCity);
            this.grbAccountDetails.Controls.Add(this.lblAddressLine2);
            this.grbAccountDetails.Controls.Add(this.cboStateCode);
            this.grbAccountDetails.Controls.Add(this.tbAddressLine1);
            this.grbAccountDetails.Controls.Add(this.lblAddressLine1);
            this.grbAccountDetails.Location = new System.Drawing.Point(13, 13);
            this.grbAccountDetails.Name = "grbAccountDetails";
            this.grbAccountDetails.Size = new System.Drawing.Size(478, 596);
            this.grbAccountDetails.TabIndex = 0;
            this.grbAccountDetails.TabStop = false;
            // 
            // cboAccountStatus
            // 
            this.cboAccountStatus.BackColor = System.Drawing.Color.White;
            this.cboAccountStatus.FormattingEnabled = true;
            this.cboAccountStatus.Location = new System.Drawing.Point(254, 26);
            this.cboAccountStatus.Name = "cboAccountStatus";
            this.cboAccountStatus.Size = new System.Drawing.Size(84, 21);
            this.cboAccountStatus.TabIndex = 1;
            this.cboAccountStatus.SelectedValueChanged += new System.EventHandler(this.ComboBox_SelectedValueChanged);
            this.cboAccountStatus.Enter += new System.EventHandler(this.formControl_Enter);
            // 
            // lblAccountStatus
            // 
            this.lblAccountStatus.AutoSize = true;
            this.lblAccountStatus.Location = new System.Drawing.Point(165, 29);
            this.lblAccountStatus.Name = "lblAccountStatus";
            this.lblAccountStatus.Size = new System.Drawing.Size(83, 13);
            this.lblAccountStatus.TabIndex = 0;
            this.lblAccountStatus.Text = "Account Status:";
            // 
            // mtbAPR
            // 
            this.mtbAPR.BackColor = System.Drawing.Color.White;
            this.mtbAPR.Location = new System.Drawing.Point(116, 388);
            this.mtbAPR.Name = "mtbAPR";
            this.mtbAPR.Size = new System.Drawing.Size(55, 20);
            this.mtbAPR.TabIndex = 18;
            this.mtbAPR.Text = "00.0000";
            this.mtbAPR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtbAPR.Enter += new System.EventHandler(this.formControl_Enter);
            // 
            // btnLaunch
            // 
            this.btnLaunch.Image = ((System.Drawing.Image)(resources.GetObject("btnLaunch.Image")));
            this.btnLaunch.Location = new System.Drawing.Point(421, 452);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(31, 23);
            this.btnLaunch.TabIndex = 22;
            this.btnLaunch.UseVisualStyleBackColor = true;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // lblModifiedDateValue
            // 
            this.lblModifiedDateValue.AutoSize = true;
            this.lblModifiedDateValue.Location = new System.Drawing.Point(367, 572);
            this.lblModifiedDateValue.Name = "lblModifiedDateValue";
            this.lblModifiedDateValue.Size = new System.Drawing.Size(73, 13);
            this.lblModifiedDateValue.TabIndex = 0;
            this.lblModifiedDateValue.Text = "XX/XX/XXXX";
            // 
            // lblCreateDateValue
            // 
            this.lblCreateDateValue.AutoSize = true;
            this.lblCreateDateValue.Location = new System.Drawing.Point(111, 572);
            this.lblCreateDateValue.Name = "lblCreateDateValue";
            this.lblCreateDateValue.Size = new System.Drawing.Size(73, 13);
            this.lblCreateDateValue.TabIndex = 0;
            this.lblCreateDateValue.Text = "XX/XX/XXXX";
            // 
            // dtpLastPasswordUpdate
            // 
            this.dtpLastPasswordUpdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpLastPasswordUpdate.Location = new System.Drawing.Point(349, 506);
            this.dtpLastPasswordUpdate.Name = "dtpLastPasswordUpdate";
            this.dtpLastPasswordUpdate.ShowCheckBox = true;
            this.dtpLastPasswordUpdate.Size = new System.Drawing.Size(103, 20);
            this.dtpLastPasswordUpdate.TabIndex = 25;
            this.dtpLastPasswordUpdate.Enter += new System.EventHandler(this.formControl_Enter);
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Location = new System.Drawing.Point(17, 417);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(59, 13);
            this.lblComments.TabIndex = 0;
            this.lblComments.Text = "Comments:";
            // 
            // tbComments
            // 
            this.tbComments.BackColor = System.Drawing.Color.White;
            this.tbComments.Location = new System.Drawing.Point(117, 414);
            this.tbComments.MaxLength = 100;
            this.tbComments.Multiline = true;
            this.tbComments.Name = "tbComments";
            this.tbComments.Size = new System.Drawing.Size(335, 34);
            this.tbComments.TabIndex = 20;
            this.tbComments.Enter += new System.EventHandler(this.formControl_Enter);
            // 
            // cboAPRCalcFrequency
            // 
            this.cboAPRCalcFrequency.BackColor = System.Drawing.Color.White;
            this.cboAPRCalcFrequency.FormattingEnabled = true;
            this.cboAPRCalcFrequency.Location = new System.Drawing.Point(341, 387);
            this.cboAPRCalcFrequency.Name = "cboAPRCalcFrequency";
            this.cboAPRCalcFrequency.Size = new System.Drawing.Size(72, 21);
            this.cboAPRCalcFrequency.TabIndex = 19;
            this.cboAPRCalcFrequency.SelectedValueChanged += new System.EventHandler(this.ComboBox_SelectedValueChanged);
            this.cboAPRCalcFrequency.Enter += new System.EventHandler(this.formControl_Enter);
            // 
            // lblAPRCalcFrequency
            // 
            this.lblAPRCalcFrequency.AutoSize = true;
            this.lblAPRCalcFrequency.Location = new System.Drawing.Point(226, 391);
            this.lblAPRCalcFrequency.Name = "lblAPRCalcFrequency";
            this.lblAPRCalcFrequency.Size = new System.Drawing.Size(109, 13);
            this.lblAPRCalcFrequency.TabIndex = 0;
            this.lblAPRCalcFrequency.Text = "APR Calc Frequency:";
            // 
            // lblAPR
            // 
            this.lblAPR.AutoSize = true;
            this.lblAPR.Location = new System.Drawing.Point(17, 391);
            this.lblAPR.Name = "lblAPR";
            this.lblAPR.Size = new System.Drawing.Size(32, 13);
            this.lblAPR.TabIndex = 0;
            this.lblAPR.Text = "APR:";
            // 
            // mtbCreditLimit
            // 
            this.mtbCreditLimit.BackColor = System.Drawing.Color.White;
            this.mtbCreditLimit.Location = new System.Drawing.Point(341, 362);
            this.mtbCreditLimit.Name = "mtbCreditLimit";
            this.mtbCreditLimit.Size = new System.Drawing.Size(72, 20);
            this.mtbCreditLimit.TabIndex = 17;
            this.mtbCreditLimit.Text = "0.00";
            this.mtbCreditLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtbCreditLimit.Enter += new System.EventHandler(this.formControl_Enter);
            // 
            // lblCreditLimit
            // 
            this.lblCreditLimit.AutoSize = true;
            this.lblCreditLimit.Location = new System.Drawing.Point(226, 365);
            this.lblCreditLimit.Name = "lblCreditLimit";
            this.lblCreditLimit.Size = new System.Drawing.Size(61, 13);
            this.lblCreditLimit.TabIndex = 0;
            this.lblCreditLimit.Text = "Credit Limit:";
            // 
            // dtpOpenedDate
            // 
            this.dtpOpenedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOpenedDate.Location = new System.Drawing.Point(116, 532);
            this.dtpOpenedDate.Name = "dtpOpenedDate";
            this.dtpOpenedDate.Size = new System.Drawing.Size(101, 20);
            this.dtpOpenedDate.TabIndex = 26;
            this.dtpOpenedDate.Enter += new System.EventHandler(this.formControl_Enter);
            // 
            // lblOpenedDate
            // 
            this.lblOpenedDate.AutoSize = true;
            this.lblOpenedDate.Location = new System.Drawing.Point(17, 534);
            this.lblOpenedDate.Name = "lblOpenedDate";
            this.lblOpenedDate.Size = new System.Drawing.Size(80, 13);
            this.lblOpenedDate.TabIndex = 0;
            this.lblOpenedDate.Text = "Opened Date:  ";
            // 
            // lblModifiedDate
            // 
            this.lblModifiedDate.AutoSize = true;
            this.lblModifiedDate.Location = new System.Drawing.Point(258, 572);
            this.lblModifiedDate.Name = "lblModifiedDate";
            this.lblModifiedDate.Size = new System.Drawing.Size(82, 13);
            this.lblModifiedDate.TabIndex = 0;
            this.lblModifiedDate.Text = "Modified Date:  ";
            // 
            // lblCreateDate
            // 
            this.lblCreateDate.AutoSize = true;
            this.lblCreateDate.Location = new System.Drawing.Point(17, 572);
            this.lblCreateDate.Name = "lblCreateDate";
            this.lblCreateDate.Size = new System.Drawing.Size(73, 13);
            this.lblCreateDate.TabIndex = 0;
            this.lblCreateDate.Text = "Create Date:  ";
            // 
            // lblLastPasswordUpdate
            // 
            this.lblLastPasswordUpdate.AutoSize = true;
            this.lblLastPasswordUpdate.Location = new System.Drawing.Point(225, 509);
            this.lblLastPasswordUpdate.Name = "lblLastPasswordUpdate";
            this.lblLastPasswordUpdate.Size = new System.Drawing.Size(123, 13);
            this.lblLastPasswordUpdate.TabIndex = 0;
            this.lblLastPasswordUpdate.Text = "Last Password Update:  ";
            // 
            // tbWebsiteURL
            // 
            this.tbWebsiteURL.BackColor = System.Drawing.Color.White;
            this.tbWebsiteURL.Location = new System.Drawing.Point(116, 454);
            this.tbWebsiteURL.Name = "tbWebsiteURL";
            this.tbWebsiteURL.Size = new System.Drawing.Size(300, 20);
            this.tbWebsiteURL.TabIndex = 21;
            this.tbWebsiteURL.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.tbWebsiteURL.Enter += new System.EventHandler(this.formControl_Enter);
            // 
            // lblWebsiteURL
            // 
            this.lblWebsiteURL.AutoSize = true;
            this.lblWebsiteURL.Location = new System.Drawing.Point(17, 457);
            this.lblWebsiteURL.Name = "lblWebsiteURL";
            this.lblWebsiteURL.Size = new System.Drawing.Size(74, 13);
            this.lblWebsiteURL.TabIndex = 0;
            this.lblWebsiteURL.Text = "Website URL:";
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.White;
            this.tbPassword.Location = new System.Drawing.Point(117, 506);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(100, 20);
            this.tbPassword.TabIndex = 24;
            this.tbPassword.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.tbPassword.Enter += new System.EventHandler(this.formControl_Enter);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(17, 509);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Password:";
            this.lblPassword.Click += new System.EventHandler(this.lblPassword_Click);
            // 
            // tbUserName
            // 
            this.tbUserName.BackColor = System.Drawing.Color.White;
            this.tbUserName.Location = new System.Drawing.Point(117, 480);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(175, 20);
            this.tbUserName.TabIndex = 23;
            this.tbUserName.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.tbUserName.Enter += new System.EventHandler(this.formControl_Enter);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(17, 483);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(63, 13);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "User Name:";
            this.lblUserName.Click += new System.EventHandler(this.lblUserName_Click);
            // 
            // mtbAnnualFee
            // 
            this.mtbAnnualFee.BackColor = System.Drawing.Color.White;
            this.mtbAnnualFee.Location = new System.Drawing.Point(116, 362);
            this.mtbAnnualFee.Name = "mtbAnnualFee";
            this.mtbAnnualFee.Size = new System.Drawing.Size(72, 20);
            this.mtbAnnualFee.TabIndex = 16;
            this.mtbAnnualFee.Text = "0.00";
            this.mtbAnnualFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtbAnnualFee.TextChanged += new System.EventHandler(this.MaskedTextBox_TextChanged);
            this.mtbAnnualFee.Enter += new System.EventHandler(this.formControl_Enter);
            // 
            // lblAnnualFee
            // 
            this.lblAnnualFee.AutoSize = true;
            this.lblAnnualFee.Location = new System.Drawing.Point(17, 365);
            this.lblAnnualFee.Name = "lblAnnualFee";
            this.lblAnnualFee.Size = new System.Drawing.Size(64, 13);
            this.lblAnnualFee.TabIndex = 0;
            this.lblAnnualFee.Text = "Annual Fee:";
            // 
            // cboDefaultPayType
            // 
            this.cboDefaultPayType.BackColor = System.Drawing.Color.White;
            this.cboDefaultPayType.FormattingEnabled = true;
            this.cboDefaultPayType.Location = new System.Drawing.Point(117, 282);
            this.cboDefaultPayType.Name = "cboDefaultPayType";
            this.cboDefaultPayType.Size = new System.Drawing.Size(124, 21);
            this.cboDefaultPayType.TabIndex = 15;
            this.cboDefaultPayType.SelectedValueChanged += new System.EventHandler(this.ComboBox_SelectedValueChanged);
            this.cboDefaultPayType.Enter += new System.EventHandler(this.formControl_Enter);
            // 
            // lblDefaultPayType
            // 
            this.lblDefaultPayType.AutoSize = true;
            this.lblDefaultPayType.Location = new System.Drawing.Point(17, 285);
            this.lblDefaultPayType.Name = "lblDefaultPayType";
            this.lblDefaultPayType.Size = new System.Drawing.Size(92, 13);
            this.lblDefaultPayType.TabIndex = 0;
            this.lblDefaultPayType.Text = "Default Pay Type:";
            // 
            // tbStatementDay
            // 
            this.tbStatementDay.BackColor = System.Drawing.Color.White;
            this.tbStatementDay.Location = new System.Drawing.Point(117, 336);
            this.tbStatementDay.Name = "tbStatementDay";
            this.tbStatementDay.Size = new System.Drawing.Size(38, 20);
            this.tbStatementDay.TabIndex = 13;
            this.tbStatementDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbStatementDay.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.tbStatementDay.Enter += new System.EventHandler(this.formControl_Enter);
            // 
            // lblStatementDay
            // 
            this.lblStatementDay.AutoSize = true;
            this.lblStatementDay.Location = new System.Drawing.Point(17, 339);
            this.lblStatementDay.Name = "lblStatementDay";
            this.lblStatementDay.Size = new System.Drawing.Size(80, 13);
            this.lblStatementDay.TabIndex = 0;
            this.lblStatementDay.Text = "Statement Day:";
            // 
            // tbDueDay
            // 
            this.tbDueDay.BackColor = System.Drawing.Color.White;
            this.tbDueDay.Location = new System.Drawing.Point(341, 336);
            this.tbDueDay.Name = "tbDueDay";
            this.tbDueDay.Size = new System.Drawing.Size(38, 20);
            this.tbDueDay.TabIndex = 14;
            this.tbDueDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbDueDay.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.tbDueDay.Enter += new System.EventHandler(this.formControl_Enter);
            // 
            // lblDueDay
            // 
            this.lblDueDay.AutoSize = true;
            this.lblDueDay.Location = new System.Drawing.Point(226, 339);
            this.lblDueDay.Name = "lblDueDay";
            this.lblDueDay.Size = new System.Drawing.Size(52, 13);
            this.lblDueDay.TabIndex = 0;
            this.lblDueDay.Text = "Due Day:";
            // 
            // lblMaturityExpDate
            // 
            this.lblMaturityExpDate.AutoSize = true;
            this.lblMaturityExpDate.Location = new System.Drawing.Point(225, 534);
            this.lblMaturityExpDate.Name = "lblMaturityExpDate";
            this.lblMaturityExpDate.Size = new System.Drawing.Size(73, 13);
            this.lblMaturityExpDate.TabIndex = 0;
            this.lblMaturityExpDate.Text = "Maturity Date:";
            // 
            // dtpMaturityExpDate
            // 
            this.dtpMaturityExpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMaturityExpDate.Location = new System.Drawing.Point(313, 532);
            this.dtpMaturityExpDate.Name = "dtpMaturityExpDate";
            this.dtpMaturityExpDate.ShowCheckBox = true;
            this.dtpMaturityExpDate.Size = new System.Drawing.Size(103, 20);
            this.dtpMaturityExpDate.TabIndex = 27;
            this.dtpMaturityExpDate.ValueChanged += new System.EventHandler(this.DateTimePicker_ValueChanged);
            this.dtpMaturityExpDate.Enter += new System.EventHandler(this.formControl_Enter);
            // 
            // cboAccountType
            // 
            this.cboAccountType.BackColor = System.Drawing.Color.White;
            this.cboAccountType.FormattingEnabled = true;
            this.cboAccountType.Location = new System.Drawing.Point(116, 255);
            this.cboAccountType.Name = "cboAccountType";
            this.cboAccountType.Size = new System.Drawing.Size(336, 21);
            this.cboAccountType.TabIndex = 11;
            this.cboAccountType.SelectedValueChanged += new System.EventHandler(this.cboAccountType_SelectedValueChanged);
            this.cboAccountType.Enter += new System.EventHandler(this.formControl_Enter);
            // 
            // lblAccountTypeCode
            // 
            this.lblAccountTypeCode.AutoSize = true;
            this.lblAccountTypeCode.Location = new System.Drawing.Point(17, 258);
            this.lblAccountTypeCode.Name = "lblAccountTypeCode";
            this.lblAccountTypeCode.Size = new System.Drawing.Size(77, 13);
            this.lblAccountTypeCode.TabIndex = 0;
            this.lblAccountTypeCode.Text = "Account Type:";
            // 
            // tbAccountNumber
            // 
            this.tbAccountNumber.BackColor = System.Drawing.Color.White;
            this.tbAccountNumber.Location = new System.Drawing.Point(117, 229);
            this.tbAccountNumber.Name = "tbAccountNumber";
            this.tbAccountNumber.Size = new System.Drawing.Size(161, 20);
            this.tbAccountNumber.TabIndex = 10;
            this.tbAccountNumber.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.tbAccountNumber.Enter += new System.EventHandler(this.formControl_Enter);
            // 
            // lblAccountID
            // 
            this.lblAccountID.AutoSize = true;
            this.lblAccountID.Location = new System.Drawing.Point(17, 29);
            this.lblAccountID.Name = "lblAccountID";
            this.lblAccountID.Size = new System.Drawing.Size(70, 13);
            this.lblAccountID.TabIndex = 0;
            this.lblAccountID.Text = "<AccountID>";
            // 
            // lblAddressLine1
            // 
            this.lblAddressLine1.AutoSize = true;
            this.lblAddressLine1.Location = new System.Drawing.Point(17, 83);
            this.lblAddressLine1.Name = "lblAddressLine1";
            this.lblAddressLine1.Size = new System.Drawing.Size(80, 13);
            this.lblAddressLine1.TabIndex = 0;
            this.lblAddressLine1.Text = "Address Line 1:";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEdit.Location = new System.Drawing.Point(49, 616);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(379, 616);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.Location = new System.Drawing.Point(214, 616);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Link_16x_32.bmp");
            // 
            // cboDefaultPayAccount
            // 
            this.cboDefaultPayAccount.BackColor = System.Drawing.Color.White;
            this.cboDefaultPayAccount.FormattingEnabled = true;
            this.cboDefaultPayAccount.Location = new System.Drawing.Point(117, 309);
            this.cboDefaultPayAccount.Name = "cboDefaultPayAccount";
            this.cboDefaultPayAccount.Size = new System.Drawing.Size(335, 21);
            this.cboDefaultPayAccount.TabIndex = 29;
            this.cboDefaultPayAccount.SelectedValueChanged += new System.EventHandler(this.ComboBox_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Default Pay Acct:";
            // 
            // frmAccountDetailEntry
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(503, 651);
            this.Controls.Add(this.grbAccountDetails);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnClose);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAccountDetailEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Account Detail:  ";
            this.Load += new System.EventHandler(this.AccountDetail_Load);
            this.grbAccountDetails.ResumeLayout(false);
            this.grbAccountDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtbPhoneNumber;
        public System.Windows.Forms.Label lblPhoneNumber;
        public System.Windows.Forms.TextBox tbAccountName;
        public System.Windows.Forms.Label lblAccountName;
        public System.Windows.Forms.Label lblCityState;
        public System.Windows.Forms.Label lblPostalCode;
        public System.Windows.Forms.TextBox tbAddressLine2;
        public System.Windows.Forms.Label lblDash;
        public System.Windows.Forms.TextBox tbPostalCode4;
        public System.Windows.Forms.TextBox tbPostalCode;
        public System.Windows.Forms.TextBox tbCity;
        public System.Windows.Forms.Label lblAddressLine2;
        public System.Windows.Forms.ComboBox cboStateCode;
        public System.Windows.Forms.TextBox tbAddressLine1;
        private System.Windows.Forms.GroupBox grbAccountDetails;
        public System.Windows.Forms.Label lblAddressLine1;
        private System.Windows.Forms.Label lblAccountID;
        public System.Windows.Forms.TextBox tbAccountNumber;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cboAccountType;
        private System.Windows.Forms.Label lblAccountTypeCode;
        private System.Windows.Forms.Label lblModifiedDate;
        private System.Windows.Forms.Label lblCreateDate;
        private System.Windows.Forms.Label lblLastPasswordUpdate;
        public System.Windows.Forms.TextBox tbWebsiteURL;
        public System.Windows.Forms.Label lblWebsiteURL;
        public System.Windows.Forms.TextBox tbPassword;
        public System.Windows.Forms.Label lblPassword;
        public System.Windows.Forms.TextBox tbUserName;
        public System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.MaskedTextBox mtbAnnualFee;
        private System.Windows.Forms.Label lblAnnualFee;
        private System.Windows.Forms.ComboBox cboDefaultPayType;
        private System.Windows.Forms.Label lblDefaultPayType;
        private System.Windows.Forms.TextBox tbStatementDay;
        private System.Windows.Forms.Label lblStatementDay;
        private System.Windows.Forms.TextBox tbDueDay;
        private System.Windows.Forms.Label lblDueDay;
        private System.Windows.Forms.Label lblMaturityExpDate;
        private System.Windows.Forms.DateTimePicker dtpMaturityExpDate;
        private System.Windows.Forms.DateTimePicker dtpOpenedDate;
        private System.Windows.Forms.Label lblOpenedDate;
        private System.Windows.Forms.Label lblComments;
        public System.Windows.Forms.TextBox tbComments;
        private System.Windows.Forms.ComboBox cboAPRCalcFrequency;
        private System.Windows.Forms.Label lblAPRCalcFrequency;
        private System.Windows.Forms.Label lblAPR;
        private System.Windows.Forms.MaskedTextBox mtbCreditLimit;
        private System.Windows.Forms.Label lblCreditLimit;
        private System.Windows.Forms.DateTimePicker dtpLastPasswordUpdate;
        private System.Windows.Forms.Label lblModifiedDateValue;
        private System.Windows.Forms.Label lblCreateDateValue;
        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.MaskedTextBox mtbAPR;
        private System.Windows.Forms.ComboBox cboAccountStatus;
        private System.Windows.Forms.Label lblAccountStatus;
        private System.Windows.Forms.ComboBox cboDefaultPayAccount;
        private System.Windows.Forms.Label label1;
    }
}