namespace MyBudgetV1_0.Forms
{
    partial class frmAccountPaymentEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccountPaymentEntry));
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grbBalanceDetails = new System.Windows.Forms.GroupBox();
            this.grbAccountPayment = new System.Windows.Forms.GroupBox();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.tbWebsiteURL = new System.Windows.Forms.TextBox();
            this.lblWebsiteURL = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.chbPaymentCleared = new System.Windows.Forms.CheckBox();
            this.lblConfirmationNumber = new System.Windows.Forms.Label();
            this.tbConfirmationNumber = new System.Windows.Forms.TextBox();
            this.lblAmountPaid = new System.Windows.Forms.Label();
            this.mtbAmountPaid = new System.Windows.Forms.MaskedTextBox();
            this.lblPaymentComments = new System.Windows.Forms.Label();
            this.lblPaymentDate = new System.Windows.Forms.Label();
            this.dtpPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.tbPaymentComments = new System.Windows.Forms.TextBox();
            this.lblPaymentCleared = new System.Windows.Forms.Label();
            this.cboPaymentAccount = new System.Windows.Forms.ComboBox();
            this.lblPaymentAccount = new System.Windows.Forms.Label();
            this.lblAmountDue = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.lblStatementDate = new System.Windows.Forms.Label();
            this.lblAccountName = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblModifiedDateValue = new System.Windows.Forms.Label();
            this.lblCreateDateValue = new System.Windows.Forms.Label();
            this.lblModifiedDate = new System.Windows.Forms.Label();
            this.lblCreateDate = new System.Windows.Forms.Label();
            this.grbBalanceDetails.SuspendLayout();
            this.grbAccountPayment.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSave.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.Location = new System.Drawing.Point(217, 490);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(66, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEdit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEdit.Location = new System.Drawing.Point(18, 490);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(66, 23);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClose.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(410, 490);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(66, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grbBalanceDetails
            // 
            this.grbBalanceDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbBalanceDetails.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.grbBalanceDetails.Controls.Add(this.grbAccountPayment);
            this.grbBalanceDetails.Controls.Add(this.lblAmountDue);
            this.grbBalanceDetails.Controls.Add(this.lblBalance);
            this.grbBalanceDetails.Controls.Add(this.lblDueDate);
            this.grbBalanceDetails.Controls.Add(this.lblStatementDate);
            this.grbBalanceDetails.Controls.Add(this.lblAccountName);
            this.grbBalanceDetails.Controls.Add(this.lblInstructions);
            this.grbBalanceDetails.Controls.Add(this.lblModifiedDateValue);
            this.grbBalanceDetails.Controls.Add(this.lblCreateDateValue);
            this.grbBalanceDetails.Controls.Add(this.lblModifiedDate);
            this.grbBalanceDetails.Controls.Add(this.lblCreateDate);
            this.grbBalanceDetails.Location = new System.Drawing.Point(12, -2);
            this.grbBalanceDetails.Name = "grbBalanceDetails";
            this.grbBalanceDetails.Size = new System.Drawing.Size(474, 482);
            this.grbBalanceDetails.TabIndex = 4;
            this.grbBalanceDetails.TabStop = false;
            // 
            // grbAccountPayment
            // 
            this.grbAccountPayment.Controls.Add(this.btnLaunch);
            this.grbAccountPayment.Controls.Add(this.tbWebsiteURL);
            this.grbAccountPayment.Controls.Add(this.lblWebsiteURL);
            this.grbAccountPayment.Controls.Add(this.tbPassword);
            this.grbAccountPayment.Controls.Add(this.lblPassword);
            this.grbAccountPayment.Controls.Add(this.tbUserName);
            this.grbAccountPayment.Controls.Add(this.lblUserName);
            this.grbAccountPayment.Controls.Add(this.chbPaymentCleared);
            this.grbAccountPayment.Controls.Add(this.lblConfirmationNumber);
            this.grbAccountPayment.Controls.Add(this.tbConfirmationNumber);
            this.grbAccountPayment.Controls.Add(this.lblAmountPaid);
            this.grbAccountPayment.Controls.Add(this.mtbAmountPaid);
            this.grbAccountPayment.Controls.Add(this.lblPaymentComments);
            this.grbAccountPayment.Controls.Add(this.lblPaymentDate);
            this.grbAccountPayment.Controls.Add(this.dtpPaymentDate);
            this.grbAccountPayment.Controls.Add(this.tbPaymentComments);
            this.grbAccountPayment.Controls.Add(this.lblPaymentCleared);
            this.grbAccountPayment.Controls.Add(this.cboPaymentAccount);
            this.grbAccountPayment.Controls.Add(this.lblPaymentAccount);
            this.grbAccountPayment.Location = new System.Drawing.Point(6, 124);
            this.grbAccountPayment.Name = "grbAccountPayment";
            this.grbAccountPayment.Size = new System.Drawing.Size(454, 278);
            this.grbAccountPayment.TabIndex = 27;
            this.grbAccountPayment.TabStop = false;
            // 
            // btnLaunch
            // 
            this.btnLaunch.Image = ((System.Drawing.Image)(resources.GetObject("btnLaunch.Image")));
            this.btnLaunch.Location = new System.Drawing.Point(405, 14);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(31, 23);
            this.btnLaunch.TabIndex = 43;
            this.btnLaunch.UseVisualStyleBackColor = true;
            // 
            // tbWebsiteURL
            // 
            this.tbWebsiteURL.BackColor = System.Drawing.Color.White;
            this.tbWebsiteURL.Location = new System.Drawing.Point(100, 16);
            this.tbWebsiteURL.Name = "tbWebsiteURL";
            this.tbWebsiteURL.ReadOnly = true;
            this.tbWebsiteURL.Size = new System.Drawing.Size(300, 20);
            this.tbWebsiteURL.TabIndex = 42;
            // 
            // lblWebsiteURL
            // 
            this.lblWebsiteURL.AutoSize = true;
            this.lblWebsiteURL.Location = new System.Drawing.Point(1, 19);
            this.lblWebsiteURL.Name = "lblWebsiteURL";
            this.lblWebsiteURL.Size = new System.Drawing.Size(74, 13);
            this.lblWebsiteURL.TabIndex = 39;
            this.lblWebsiteURL.Text = "Website URL:";
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.White;
            this.tbPassword.Location = new System.Drawing.Point(101, 68);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.ReadOnly = true;
            this.tbPassword.Size = new System.Drawing.Size(100, 20);
            this.tbPassword.TabIndex = 45;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(2, 71);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 40;
            this.lblPassword.Text = "Password:";
            // 
            // tbUserName
            // 
            this.tbUserName.BackColor = System.Drawing.Color.White;
            this.tbUserName.Location = new System.Drawing.Point(101, 42);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.ReadOnly = true;
            this.tbUserName.Size = new System.Drawing.Size(175, 20);
            this.tbUserName.TabIndex = 44;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(2, 45);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(63, 13);
            this.lblUserName.TabIndex = 41;
            this.lblUserName.Text = "User Name:";
            // 
            // chbPaymentCleared
            // 
            this.chbPaymentCleared.AutoSize = true;
            this.chbPaymentCleared.Location = new System.Drawing.Point(355, 129);
            this.chbPaymentCleared.Name = "chbPaymentCleared";
            this.chbPaymentCleared.Size = new System.Drawing.Size(15, 14);
            this.chbPaymentCleared.TabIndex = 38;
            this.chbPaymentCleared.UseVisualStyleBackColor = true;
            this.chbPaymentCleared.CheckedChanged += new System.EventHandler(this.chbPaymentCleared_CheckedChanged);
            // 
            // lblConfirmationNumber
            // 
            this.lblConfirmationNumber.AutoSize = true;
            this.lblConfirmationNumber.Location = new System.Drawing.Point(1, 244);
            this.lblConfirmationNumber.Name = "lblConfirmationNumber";
            this.lblConfirmationNumber.Size = new System.Drawing.Size(108, 13);
            this.lblConfirmationNumber.TabIndex = 36;
            this.lblConfirmationNumber.Text = "Confirmation Number:";
            // 
            // tbConfirmationNumber
            // 
            this.tbConfirmationNumber.BackColor = System.Drawing.Color.White;
            this.tbConfirmationNumber.Location = new System.Drawing.Point(131, 241);
            this.tbConfirmationNumber.MaxLength = 50;
            this.tbConfirmationNumber.Multiline = true;
            this.tbConfirmationNumber.Name = "tbConfirmationNumber";
            this.tbConfirmationNumber.Size = new System.Drawing.Size(163, 25);
            this.tbConfirmationNumber.TabIndex = 37;
            this.tbConfirmationNumber.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // lblAmountPaid
            // 
            this.lblAmountPaid.AutoSize = true;
            this.lblAmountPaid.Location = new System.Drawing.Point(1, 129);
            this.lblAmountPaid.Name = "lblAmountPaid";
            this.lblAmountPaid.Size = new System.Drawing.Size(70, 13);
            this.lblAmountPaid.TabIndex = 31;
            this.lblAmountPaid.Text = "Amount Paid:";
            // 
            // mtbAmountPaid
            // 
            this.mtbAmountPaid.BackColor = System.Drawing.Color.White;
            this.mtbAmountPaid.Location = new System.Drawing.Point(131, 126);
            this.mtbAmountPaid.Name = "mtbAmountPaid";
            this.mtbAmountPaid.Size = new System.Drawing.Size(74, 20);
            this.mtbAmountPaid.TabIndex = 34;
            this.mtbAmountPaid.Text = "0.00";
            this.mtbAmountPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtbAmountPaid.TextChanged += new System.EventHandler(this.MaskedTextBox_TextChanged);
            // 
            // lblPaymentComments
            // 
            this.lblPaymentComments.AutoSize = true;
            this.lblPaymentComments.Location = new System.Drawing.Point(1, 199);
            this.lblPaymentComments.Name = "lblPaymentComments";
            this.lblPaymentComments.Size = new System.Drawing.Size(103, 13);
            this.lblPaymentComments.TabIndex = 30;
            this.lblPaymentComments.Text = "Payment Comments:";
            // 
            // lblPaymentDate
            // 
            this.lblPaymentDate.AutoSize = true;
            this.lblPaymentDate.Location = new System.Drawing.Point(1, 103);
            this.lblPaymentDate.Name = "lblPaymentDate";
            this.lblPaymentDate.Size = new System.Drawing.Size(77, 13);
            this.lblPaymentDate.TabIndex = 29;
            this.lblPaymentDate.Text = "Payment Date:";
            // 
            // dtpPaymentDate
            // 
            this.dtpPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPaymentDate.Location = new System.Drawing.Point(131, 100);
            this.dtpPaymentDate.Name = "dtpPaymentDate";
            this.dtpPaymentDate.Size = new System.Drawing.Size(101, 20);
            this.dtpPaymentDate.TabIndex = 33;
            this.dtpPaymentDate.ValueChanged += new System.EventHandler(this.DateTimePicker_ValueChanged);
            // 
            // tbPaymentComments
            // 
            this.tbPaymentComments.BackColor = System.Drawing.Color.White;
            this.tbPaymentComments.Location = new System.Drawing.Point(131, 196);
            this.tbPaymentComments.MaxLength = 100;
            this.tbPaymentComments.Multiline = true;
            this.tbPaymentComments.Name = "tbPaymentComments";
            this.tbPaymentComments.Size = new System.Drawing.Size(322, 34);
            this.tbPaymentComments.TabIndex = 35;
            this.tbPaymentComments.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // lblPaymentCleared
            // 
            this.lblPaymentCleared.AutoSize = true;
            this.lblPaymentCleared.Location = new System.Drawing.Point(259, 129);
            this.lblPaymentCleared.Name = "lblPaymentCleared";
            this.lblPaymentCleared.Size = new System.Drawing.Size(90, 13);
            this.lblPaymentCleared.TabIndex = 28;
            this.lblPaymentCleared.Text = "Payment Cleared:";
            // 
            // cboPaymentAccount
            // 
            this.cboPaymentAccount.BackColor = System.Drawing.Color.White;
            this.cboPaymentAccount.FormattingEnabled = true;
            this.cboPaymentAccount.Location = new System.Drawing.Point(131, 158);
            this.cboPaymentAccount.Name = "cboPaymentAccount";
            this.cboPaymentAccount.Size = new System.Drawing.Size(283, 21);
            this.cboPaymentAccount.TabIndex = 32;
            this.cboPaymentAccount.SelectedValueChanged += new System.EventHandler(this.ComboBox_SelectedValueChanged);
            // 
            // lblPaymentAccount
            // 
            this.lblPaymentAccount.AutoSize = true;
            this.lblPaymentAccount.Location = new System.Drawing.Point(1, 161);
            this.lblPaymentAccount.Name = "lblPaymentAccount";
            this.lblPaymentAccount.Size = new System.Drawing.Size(94, 13);
            this.lblPaymentAccount.TabIndex = 27;
            this.lblPaymentAccount.Text = "Payment Account:";
            // 
            // lblAmountDue
            // 
            this.lblAmountDue.AutoSize = true;
            this.lblAmountDue.Location = new System.Drawing.Point(226, 108);
            this.lblAmountDue.Name = "lblAmountDue";
            this.lblAmountDue.Size = new System.Drawing.Size(69, 13);
            this.lblAmountDue.TabIndex = 18;
            this.lblAmountDue.Text = "Amount Due:";
            this.lblAmountDue.Click += new System.EventHandler(this.lblAmountDue_Click);
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(31, 108);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(49, 13);
            this.lblBalance.TabIndex = 19;
            this.lblBalance.Text = "Balance:";
            this.lblBalance.Click += new System.EventHandler(this.lblBalance_Click);
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Location = new System.Drawing.Point(226, 82);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(56, 13);
            this.lblDueDate.TabIndex = 17;
            this.lblDueDate.Text = "Due Date:";
            // 
            // lblStatementDate
            // 
            this.lblStatementDate.AutoSize = true;
            this.lblStatementDate.Location = new System.Drawing.Point(28, 82);
            this.lblStatementDate.Name = "lblStatementDate";
            this.lblStatementDate.Size = new System.Drawing.Size(84, 13);
            this.lblStatementDate.TabIndex = 16;
            this.lblStatementDate.Text = "Statement Date:";
            // 
            // lblAccountName
            // 
            this.lblAccountName.AutoSize = true;
            this.lblAccountName.Location = new System.Drawing.Point(27, 56);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(84, 13);
            this.lblAccountName.TabIndex = 15;
            this.lblAccountName.Text = "Account Name :";
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(8, 26);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(181, 15);
            this.lblInstructions.TabIndex = 0;
            this.lblInstructions.Text = "Enter Payment Information.";
            // 
            // lblModifiedDateValue
            // 
            this.lblModifiedDateValue.AutoSize = true;
            this.lblModifiedDateValue.Location = new System.Drawing.Point(100, 422);
            this.lblModifiedDateValue.Name = "lblModifiedDateValue";
            this.lblModifiedDateValue.Size = new System.Drawing.Size(73, 13);
            this.lblModifiedDateValue.TabIndex = 0;
            this.lblModifiedDateValue.Text = "XX/XX/XXXX";
            // 
            // lblCreateDateValue
            // 
            this.lblCreateDateValue.AutoSize = true;
            this.lblCreateDateValue.Location = new System.Drawing.Point(100, 449);
            this.lblCreateDateValue.Name = "lblCreateDateValue";
            this.lblCreateDateValue.Size = new System.Drawing.Size(73, 13);
            this.lblCreateDateValue.TabIndex = 0;
            this.lblCreateDateValue.Text = "XX/XX/XXXX";
            // 
            // lblModifiedDate
            // 
            this.lblModifiedDate.AutoSize = true;
            this.lblModifiedDate.Location = new System.Drawing.Point(7, 422);
            this.lblModifiedDate.Name = "lblModifiedDate";
            this.lblModifiedDate.Size = new System.Drawing.Size(82, 13);
            this.lblModifiedDate.TabIndex = 0;
            this.lblModifiedDate.Text = "Modified Date:  ";
            // 
            // lblCreateDate
            // 
            this.lblCreateDate.AutoSize = true;
            this.lblCreateDate.Location = new System.Drawing.Point(7, 449);
            this.lblCreateDate.Name = "lblCreateDate";
            this.lblCreateDate.Size = new System.Drawing.Size(73, 13);
            this.lblCreateDate.TabIndex = 0;
            this.lblCreateDate.Text = "Create Date:  ";
            // 
            // frmAccountPaymentEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 519);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grbBalanceDetails);
            this.Name = "frmAccountPaymentEntry";
            this.Text = "Account Payment Detail";
            this.Load += new System.EventHandler(this.AccountPaymentEntry_Load);
            this.grbBalanceDetails.ResumeLayout(false);
            this.grbBalanceDetails.PerformLayout();
            this.grbAccountPayment.ResumeLayout(false);
            this.grbAccountPayment.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grbBalanceDetails;
        public System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblModifiedDateValue;
        private System.Windows.Forms.Label lblCreateDateValue;
        private System.Windows.Forms.Label lblModifiedDate;
        private System.Windows.Forms.Label lblCreateDate;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.Label lblStatementDate;
        private System.Windows.Forms.Label lblAccountName;
        private System.Windows.Forms.Label lblAmountDue;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.GroupBox grbAccountPayment;
        private System.Windows.Forms.Button btnLaunch;
        public System.Windows.Forms.TextBox tbWebsiteURL;
        public System.Windows.Forms.Label lblWebsiteURL;
        public System.Windows.Forms.TextBox tbPassword;
        public System.Windows.Forms.Label lblPassword;
        public System.Windows.Forms.TextBox tbUserName;
        public System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.CheckBox chbPaymentCleared;
        private System.Windows.Forms.Label lblConfirmationNumber;
        public System.Windows.Forms.TextBox tbConfirmationNumber;
        private System.Windows.Forms.Label lblAmountPaid;
        private System.Windows.Forms.MaskedTextBox mtbAmountPaid;
        private System.Windows.Forms.Label lblPaymentComments;
        private System.Windows.Forms.Label lblPaymentDate;
        private System.Windows.Forms.DateTimePicker dtpPaymentDate;
        public System.Windows.Forms.TextBox tbPaymentComments;
        private System.Windows.Forms.Label lblPaymentCleared;
        private System.Windows.Forms.ComboBox cboPaymentAccount;
        public System.Windows.Forms.Label lblPaymentAccount;
    }
}