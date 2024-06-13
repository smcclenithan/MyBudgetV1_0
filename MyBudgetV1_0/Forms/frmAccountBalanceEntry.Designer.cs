namespace MyBudgetV1_0.Forms
{
    partial class frmAccountBalanceEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccountBalanceEntry));
            this.grbBalanceDetails = new System.Windows.Forms.GroupBox();
            this.lblAmountDue = new System.Windows.Forms.Label();
            this.mtbAmountDue = new System.Windows.Forms.MaskedTextBox();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.tbWebsiteURL = new System.Windows.Forms.TextBox();
            this.lblWebsiteURL = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblComments = new System.Windows.Forms.Label();
            this.lblStatementDate = new System.Windows.Forms.Label();
            this.dtpStatementDate = new System.Windows.Forms.DateTimePicker();
            this.lblModifiedDateValue = new System.Windows.Forms.Label();
            this.lblCreateDateValue = new System.Windows.Forms.Label();
            this.tbComments = new System.Windows.Forms.TextBox();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.lblModifiedDate = new System.Windows.Forms.Label();
            this.lblCreateDate = new System.Windows.Forms.Label();
            this.mtbBalance = new System.Windows.Forms.MaskedTextBox();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.cboAccountName = new System.Windows.Forms.ComboBox();
            this.lblAccountName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grbBalanceDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbBalanceDetails
            // 
            this.grbBalanceDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbBalanceDetails.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.grbBalanceDetails.Controls.Add(this.lblAmountDue);
            this.grbBalanceDetails.Controls.Add(this.mtbAmountDue);
            this.grbBalanceDetails.Controls.Add(this.lblInstructions);
            this.grbBalanceDetails.Controls.Add(this.lblBalance);
            this.grbBalanceDetails.Controls.Add(this.btnLaunch);
            this.grbBalanceDetails.Controls.Add(this.tbWebsiteURL);
            this.grbBalanceDetails.Controls.Add(this.lblWebsiteURL);
            this.grbBalanceDetails.Controls.Add(this.tbPassword);
            this.grbBalanceDetails.Controls.Add(this.lblPassword);
            this.grbBalanceDetails.Controls.Add(this.tbUserName);
            this.grbBalanceDetails.Controls.Add(this.lblUserName);
            this.grbBalanceDetails.Controls.Add(this.lblComments);
            this.grbBalanceDetails.Controls.Add(this.lblStatementDate);
            this.grbBalanceDetails.Controls.Add(this.dtpStatementDate);
            this.grbBalanceDetails.Controls.Add(this.lblModifiedDateValue);
            this.grbBalanceDetails.Controls.Add(this.lblCreateDateValue);
            this.grbBalanceDetails.Controls.Add(this.tbComments);
            this.grbBalanceDetails.Controls.Add(this.dtpDueDate);
            this.grbBalanceDetails.Controls.Add(this.lblModifiedDate);
            this.grbBalanceDetails.Controls.Add(this.lblCreateDate);
            this.grbBalanceDetails.Controls.Add(this.mtbBalance);
            this.grbBalanceDetails.Controls.Add(this.lblDueDate);
            this.grbBalanceDetails.Controls.Add(this.cboAccountName);
            this.grbBalanceDetails.Controls.Add(this.lblAccountName);
            this.grbBalanceDetails.Location = new System.Drawing.Point(12, 12);
            this.grbBalanceDetails.Name = "grbBalanceDetails";
            this.grbBalanceDetails.Size = new System.Drawing.Size(469, 423);
            this.grbBalanceDetails.TabIndex = 0;
            this.grbBalanceDetails.TabStop = false;
            // 
            // lblAmountDue
            // 
            this.lblAmountDue.AutoSize = true;
            this.lblAmountDue.Location = new System.Drawing.Point(6, 162);
            this.lblAmountDue.Name = "lblAmountDue";
            this.lblAmountDue.Size = new System.Drawing.Size(69, 13);
            this.lblAmountDue.TabIndex = 0;
            this.lblAmountDue.Text = "Amount Due:";
            // 
            // mtbAmountDue
            // 
            this.mtbAmountDue.BackColor = System.Drawing.Color.White;
            this.mtbAmountDue.Location = new System.Drawing.Point(103, 159);
            this.mtbAmountDue.Name = "mtbAmountDue";
            this.mtbAmountDue.Size = new System.Drawing.Size(74, 20);
            this.mtbAmountDue.TabIndex = 5;
            this.mtbAmountDue.Text = "0.00";
            this.mtbAmountDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(8, 26);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(456, 15);
            this.lblInstructions.TabIndex = 0;
            this.lblInstructions.Text = "Select an account from the list and enter the new balance information.";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(5, 136);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(49, 13);
            this.lblBalance.TabIndex = 0;
            this.lblBalance.Text = "Balance:";
            // 
            // btnLaunch
            // 
            this.btnLaunch.Image = ((System.Drawing.Image)(resources.GetObject("btnLaunch.Image")));
            this.btnLaunch.Location = new System.Drawing.Point(407, 244);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(31, 23);
            this.btnLaunch.TabIndex = 8;
            this.btnLaunch.UseVisualStyleBackColor = true;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // tbWebsiteURL
            // 
            this.tbWebsiteURL.BackColor = System.Drawing.Color.White;
            this.tbWebsiteURL.Location = new System.Drawing.Point(102, 246);
            this.tbWebsiteURL.Name = "tbWebsiteURL";
            this.tbWebsiteURL.ReadOnly = true;
            this.tbWebsiteURL.Size = new System.Drawing.Size(300, 20);
            this.tbWebsiteURL.TabIndex = 7;
            // 
            // lblWebsiteURL
            // 
            this.lblWebsiteURL.AutoSize = true;
            this.lblWebsiteURL.Location = new System.Drawing.Point(3, 249);
            this.lblWebsiteURL.Name = "lblWebsiteURL";
            this.lblWebsiteURL.Size = new System.Drawing.Size(74, 13);
            this.lblWebsiteURL.TabIndex = 0;
            this.lblWebsiteURL.Text = "Website URL:";
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.White;
            this.tbPassword.Location = new System.Drawing.Point(103, 298);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.ReadOnly = true;
            this.tbPassword.Size = new System.Drawing.Size(100, 20);
            this.tbPassword.TabIndex = 10;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(4, 301);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Password:";
            // 
            // tbUserName
            // 
            this.tbUserName.BackColor = System.Drawing.Color.White;
            this.tbUserName.Location = new System.Drawing.Point(103, 272);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.ReadOnly = true;
            this.tbUserName.Size = new System.Drawing.Size(175, 20);
            this.tbUserName.TabIndex = 9;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(4, 275);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(63, 13);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "User Name:";
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Location = new System.Drawing.Point(6, 194);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(59, 13);
            this.lblComments.TabIndex = 0;
            this.lblComments.Text = "Comments:";
            // 
            // lblStatementDate
            // 
            this.lblStatementDate.AutoSize = true;
            this.lblStatementDate.Location = new System.Drawing.Point(4, 84);
            this.lblStatementDate.Name = "lblStatementDate";
            this.lblStatementDate.Size = new System.Drawing.Size(84, 13);
            this.lblStatementDate.TabIndex = 0;
            this.lblStatementDate.Text = "Statement Date:";
            // 
            // dtpStatementDate
            // 
            this.dtpStatementDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStatementDate.Location = new System.Drawing.Point(102, 81);
            this.dtpStatementDate.Name = "dtpStatementDate";
            this.dtpStatementDate.Size = new System.Drawing.Size(101, 20);
            this.dtpStatementDate.TabIndex = 2;
            // 
            // lblModifiedDateValue
            // 
            this.lblModifiedDateValue.AutoSize = true;
            this.lblModifiedDateValue.Location = new System.Drawing.Point(100, 359);
            this.lblModifiedDateValue.Name = "lblModifiedDateValue";
            this.lblModifiedDateValue.Size = new System.Drawing.Size(73, 13);
            this.lblModifiedDateValue.TabIndex = 0;
            this.lblModifiedDateValue.Text = "XX/XX/XXXX";
            // 
            // lblCreateDateValue
            // 
            this.lblCreateDateValue.AutoSize = true;
            this.lblCreateDateValue.Location = new System.Drawing.Point(100, 386);
            this.lblCreateDateValue.Name = "lblCreateDateValue";
            this.lblCreateDateValue.Size = new System.Drawing.Size(73, 13);
            this.lblCreateDateValue.TabIndex = 0;
            this.lblCreateDateValue.Text = "XX/XX/XXXX";
            // 
            // tbComments
            // 
            this.tbComments.BackColor = System.Drawing.Color.White;
            this.tbComments.Location = new System.Drawing.Point(102, 191);
            this.tbComments.MaxLength = 100;
            this.tbComments.Multiline = true;
            this.tbComments.Name = "tbComments";
            this.tbComments.Size = new System.Drawing.Size(335, 34);
            this.tbComments.TabIndex = 6;
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDueDate.Location = new System.Drawing.Point(102, 107);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(101, 20);
            this.dtpDueDate.TabIndex = 3;
            // 
            // lblModifiedDate
            // 
            this.lblModifiedDate.AutoSize = true;
            this.lblModifiedDate.Location = new System.Drawing.Point(7, 359);
            this.lblModifiedDate.Name = "lblModifiedDate";
            this.lblModifiedDate.Size = new System.Drawing.Size(82, 13);
            this.lblModifiedDate.TabIndex = 0;
            this.lblModifiedDate.Text = "Modified Date:  ";
            // 
            // lblCreateDate
            // 
            this.lblCreateDate.AutoSize = true;
            this.lblCreateDate.Location = new System.Drawing.Point(7, 386);
            this.lblCreateDate.Name = "lblCreateDate";
            this.lblCreateDate.Size = new System.Drawing.Size(73, 13);
            this.lblCreateDate.TabIndex = 0;
            this.lblCreateDate.Text = "Create Date:  ";
            // 
            // mtbBalance
            // 
            this.mtbBalance.BackColor = System.Drawing.Color.White;
            this.mtbBalance.Location = new System.Drawing.Point(102, 133);
            this.mtbBalance.Name = "mtbBalance";
            this.mtbBalance.Size = new System.Drawing.Size(74, 20);
            this.mtbBalance.TabIndex = 4;
            this.mtbBalance.Text = "0.00";
            this.mtbBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtbBalance.Leave += new System.EventHandler(this.mtbBalance_Leave);
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Location = new System.Drawing.Point(4, 109);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(56, 13);
            this.lblDueDate.TabIndex = 0;
            this.lblDueDate.Text = "Due Date:";
            // 
            // cboAccountName
            // 
            this.cboAccountName.BackColor = System.Drawing.Color.White;
            this.cboAccountName.FormattingEnabled = true;
            this.cboAccountName.Location = new System.Drawing.Point(102, 54);
            this.cboAccountName.Name = "cboAccountName";
            this.cboAccountName.Size = new System.Drawing.Size(283, 21);
            this.cboAccountName.TabIndex = 1;
            this.cboAccountName.SelectedIndexChanged += new System.EventHandler(this.cboAccountName_SelectedIndexChanged);
            // 
            // lblAccountName
            // 
            this.lblAccountName.AutoSize = true;
            this.lblAccountName.Location = new System.Drawing.Point(5, 57);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(81, 13);
            this.lblAccountName.TabIndex = 0;
            this.lblAccountName.Text = "Account Name:";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSave.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.Location = new System.Drawing.Point(205, 444);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEdit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEdit.Location = new System.Drawing.Point(48, 443);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClose.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(378, 443);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmAccountBalanceEntry
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(496, 477);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grbBalanceDetails);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAccountBalanceEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Account Balance Entry/Update";
            this.Load += new System.EventHandler(this.frmAccountBalanceEntry_Load);
            this.grbBalanceDetails.ResumeLayout(false);
            this.grbBalanceDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbBalanceDetails;
        private System.Windows.Forms.Label lblModifiedDateValue;
        private System.Windows.Forms.Label lblCreateDateValue;
        public System.Windows.Forms.TextBox tbComments;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Label lblModifiedDate;
        private System.Windows.Forms.Label lblCreateDate;
        private System.Windows.Forms.MaskedTextBox mtbBalance;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.ComboBox cboAccountName;
        public System.Windows.Forms.Label lblAccountName;
        private System.Windows.Forms.Label lblStatementDate;
        private System.Windows.Forms.DateTimePicker dtpStatementDate;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnLaunch;
        public System.Windows.Forms.TextBox tbWebsiteURL;
        public System.Windows.Forms.Label lblWebsiteURL;
        public System.Windows.Forms.TextBox tbPassword;
        public System.Windows.Forms.Label lblPassword;
        public System.Windows.Forms.TextBox tbUserName;
        public System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblBalance;
        public System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblAmountDue;
        private System.Windows.Forms.MaskedTextBox mtbAmountDue;
    }
}