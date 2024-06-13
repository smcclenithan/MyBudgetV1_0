namespace MyBudgetV1_0.Forms
{
    partial class frmAccountPayments
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPayNow = new System.Windows.Forms.Button();
            this.dgvPayments = new System.Windows.Forms.DataGridView();
            this.pnlBankEstimate = new System.Windows.Forms.Panel();
            this.lblSelectDateRange = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tbEstimatedBankBalanceEOM = new System.Windows.Forms.TextBox();
            this.tbCalculatedCurrentBalance = new System.Windows.Forms.TextBox();
            this.tbOutstandingMonthlyIncome = new System.Windows.Forms.TextBox();
            this.tbUnpaidBills = new System.Windows.Forms.TextBox();
            this.tbPendingBills = new System.Windows.Forms.TextBox();
            this.tbCurrentBankBalance = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblEstimatedBankBalanceEOM = new System.Windows.Forms.Label();
            this.lblCalculatedCurrentBalance = new System.Windows.Forms.Label();
            this.lblOutstandingMonthlyIncome = new System.Windows.Forms.Label();
            this.lblUnpaiBills = new System.Windows.Forms.Label();
            this.lblPendingBills = new System.Windows.Forms.Label();
            this.lblCurrentBankBalance = new System.Windows.Forms.Label();
            this.btnClearSelected = new System.Windows.Forms.Button();
            this.dtpFilterRangeFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpFilterRangeTo = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).BeginInit();
            this.pnlBankEstimate.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(713, 458);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.Location = new System.Drawing.Point(109, 458);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPayNow
            // 
            this.btnPayNow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPayNow.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPayNow.Location = new System.Drawing.Point(13, 458);
            this.btnPayNow.Name = "btnPayNow";
            this.btnPayNow.Size = new System.Drawing.Size(75, 23);
            this.btnPayNow.TabIndex = 1;
            this.btnPayNow.Text = "Pay Now";
            this.btnPayNow.UseVisualStyleBackColor = false;
            this.btnPayNow.Click += new System.EventHandler(this.btnPayNow_Click);
            // 
            // dgvPayments
            // 
            this.dgvPayments.AllowUserToAddRows = false;
            this.dgvPayments.AllowUserToDeleteRows = false;
            this.dgvPayments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayments.Location = new System.Drawing.Point(13, 47);
            this.dgvPayments.Name = "dgvPayments";
            this.dgvPayments.ReadOnly = true;
            this.dgvPayments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPayments.Size = new System.Drawing.Size(775, 400);
            this.dgvPayments.TabIndex = 0;
            this.dgvPayments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPayments_CellContentClick);
            this.dgvPayments.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPayments_CellDoubleClick);
            // 
            // pnlBankEstimate
            // 
            this.pnlBankEstimate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBankEstimate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlBankEstimate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBankEstimate.Controls.Add(this.btnRefresh);
            this.pnlBankEstimate.Controls.Add(this.tbEstimatedBankBalanceEOM);
            this.pnlBankEstimate.Controls.Add(this.tbCalculatedCurrentBalance);
            this.pnlBankEstimate.Controls.Add(this.tbOutstandingMonthlyIncome);
            this.pnlBankEstimate.Controls.Add(this.tbUnpaidBills);
            this.pnlBankEstimate.Controls.Add(this.tbPendingBills);
            this.pnlBankEstimate.Controls.Add(this.tbCurrentBankBalance);
            this.pnlBankEstimate.Controls.Add(this.lblTitle);
            this.pnlBankEstimate.Controls.Add(this.lblEstimatedBankBalanceEOM);
            this.pnlBankEstimate.Controls.Add(this.lblCalculatedCurrentBalance);
            this.pnlBankEstimate.Controls.Add(this.lblOutstandingMonthlyIncome);
            this.pnlBankEstimate.Controls.Add(this.lblUnpaiBills);
            this.pnlBankEstimate.Controls.Add(this.lblPendingBills);
            this.pnlBankEstimate.Controls.Add(this.lblCurrentBankBalance);
            this.pnlBankEstimate.Location = new System.Drawing.Point(794, 13);
            this.pnlBankEstimate.Name = "pnlBankEstimate";
            this.pnlBankEstimate.Size = new System.Drawing.Size(331, 434);
            this.pnlBankEstimate.TabIndex = 0;
            // 
            // lblSelectDateRange
            // 
            this.lblSelectDateRange.AutoSize = true;
            this.lblSelectDateRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectDateRange.Location = new System.Drawing.Point(12, 20);
            this.lblSelectDateRange.Name = "lblSelectDateRange";
            this.lblSelectDateRange.Size = new System.Drawing.Size(119, 13);
            this.lblSelectDateRange.TabIndex = 2;
            this.lblSelectDateRange.Text = "Select Date Range:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(241, 351);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "&Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // tbEstimatedBankBalanceEOM
            // 
            this.tbEstimatedBankBalanceEOM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEstimatedBankBalanceEOM.Location = new System.Drawing.Point(213, 313);
            this.tbEstimatedBankBalanceEOM.Name = "tbEstimatedBankBalanceEOM";
            this.tbEstimatedBankBalanceEOM.ReadOnly = true;
            this.tbEstimatedBankBalanceEOM.Size = new System.Drawing.Size(103, 20);
            this.tbEstimatedBankBalanceEOM.TabIndex = 0;
            this.tbEstimatedBankBalanceEOM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbCalculatedCurrentBalance
            // 
            this.tbCalculatedCurrentBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCalculatedCurrentBalance.Location = new System.Drawing.Point(213, 286);
            this.tbCalculatedCurrentBalance.Name = "tbCalculatedCurrentBalance";
            this.tbCalculatedCurrentBalance.ReadOnly = true;
            this.tbCalculatedCurrentBalance.Size = new System.Drawing.Size(103, 20);
            this.tbCalculatedCurrentBalance.TabIndex = 0;
            this.tbCalculatedCurrentBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbOutstandingMonthlyIncome
            // 
            this.tbOutstandingMonthlyIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOutstandingMonthlyIncome.Location = new System.Drawing.Point(213, 259);
            this.tbOutstandingMonthlyIncome.Name = "tbOutstandingMonthlyIncome";
            this.tbOutstandingMonthlyIncome.ReadOnly = true;
            this.tbOutstandingMonthlyIncome.Size = new System.Drawing.Size(103, 20);
            this.tbOutstandingMonthlyIncome.TabIndex = 0;
            this.tbOutstandingMonthlyIncome.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbUnpaidBills
            // 
            this.tbUnpaidBills.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUnpaidBills.Location = new System.Drawing.Point(213, 232);
            this.tbUnpaidBills.Name = "tbUnpaidBills";
            this.tbUnpaidBills.ReadOnly = true;
            this.tbUnpaidBills.Size = new System.Drawing.Size(103, 20);
            this.tbUnpaidBills.TabIndex = 0;
            this.tbUnpaidBills.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbPendingBills
            // 
            this.tbPendingBills.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPendingBills.Location = new System.Drawing.Point(213, 205);
            this.tbPendingBills.Name = "tbPendingBills";
            this.tbPendingBills.ReadOnly = true;
            this.tbPendingBills.Size = new System.Drawing.Size(103, 20);
            this.tbPendingBills.TabIndex = 0;
            this.tbPendingBills.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbCurrentBankBalance
            // 
            this.tbCurrentBankBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCurrentBankBalance.Location = new System.Drawing.Point(213, 178);
            this.tbCurrentBankBalance.Name = "tbCurrentBankBalance";
            this.tbCurrentBankBalance.ReadOnly = true;
            this.tbCurrentBankBalance.Size = new System.Drawing.Size(103, 20);
            this.tbCurrentBankBalance.TabIndex = 0;
            this.tbCurrentBankBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(28, 113);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(250, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Banking Information Summary";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblEstimatedBankBalanceEOM
            // 
            this.lblEstimatedBankBalanceEOM.AutoSize = true;
            this.lblEstimatedBankBalanceEOM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstimatedBankBalanceEOM.Location = new System.Drawing.Point(4, 316);
            this.lblEstimatedBankBalanceEOM.Name = "lblEstimatedBankBalanceEOM";
            this.lblEstimatedBankBalanceEOM.Size = new System.Drawing.Size(180, 13);
            this.lblEstimatedBankBalanceEOM.TabIndex = 0;
            this.lblEstimatedBankBalanceEOM.Text = "Estimated Bank Balance EOM:";
            // 
            // lblCalculatedCurrentBalance
            // 
            this.lblCalculatedCurrentBalance.AutoSize = true;
            this.lblCalculatedCurrentBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalculatedCurrentBalance.Location = new System.Drawing.Point(4, 289);
            this.lblCalculatedCurrentBalance.Name = "lblCalculatedCurrentBalance";
            this.lblCalculatedCurrentBalance.Size = new System.Drawing.Size(166, 13);
            this.lblCalculatedCurrentBalance.TabIndex = 0;
            this.lblCalculatedCurrentBalance.Text = "Calculated Current Balance:";
            // 
            // lblOutstandingMonthlyIncome
            // 
            this.lblOutstandingMonthlyIncome.AutoSize = true;
            this.lblOutstandingMonthlyIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutstandingMonthlyIncome.Location = new System.Drawing.Point(4, 262);
            this.lblOutstandingMonthlyIncome.Name = "lblOutstandingMonthlyIncome";
            this.lblOutstandingMonthlyIncome.Size = new System.Drawing.Size(172, 13);
            this.lblOutstandingMonthlyIncome.TabIndex = 0;
            this.lblOutstandingMonthlyIncome.Text = "Outstanding Monthly Income:";
            // 
            // lblUnpaiBills
            // 
            this.lblUnpaiBills.AutoSize = true;
            this.lblUnpaiBills.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnpaiBills.Location = new System.Drawing.Point(4, 235);
            this.lblUnpaiBills.Name = "lblUnpaiBills";
            this.lblUnpaiBills.Size = new System.Drawing.Size(82, 13);
            this.lblUnpaiBills.TabIndex = 0;
            this.lblUnpaiBills.Text = "Unpaid Bills::";
            // 
            // lblPendingBills
            // 
            this.lblPendingBills.AutoSize = true;
            this.lblPendingBills.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendingBills.Location = new System.Drawing.Point(4, 208);
            this.lblPendingBills.Name = "lblPendingBills";
            this.lblPendingBills.Size = new System.Drawing.Size(88, 13);
            this.lblPendingBills.TabIndex = 0;
            this.lblPendingBills.Text = "Pending Bills::";
            // 
            // lblCurrentBankBalance
            // 
            this.lblCurrentBankBalance.AutoSize = true;
            this.lblCurrentBankBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentBankBalance.Location = new System.Drawing.Point(4, 181);
            this.lblCurrentBankBalance.Name = "lblCurrentBankBalance";
            this.lblCurrentBankBalance.Size = new System.Drawing.Size(135, 13);
            this.lblCurrentBankBalance.TabIndex = 0;
            this.lblCurrentBankBalance.Text = "Current Bank Balance:";
            // 
            // btnClearSelected
            // 
            this.btnClearSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClearSelected.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClearSelected.Location = new System.Drawing.Point(434, 458);
            this.btnClearSelected.Name = "btnClearSelected";
            this.btnClearSelected.Size = new System.Drawing.Size(95, 23);
            this.btnClearSelected.TabIndex = 3;
            this.btnClearSelected.Text = "Clear Selected";
            this.btnClearSelected.UseVisualStyleBackColor = false;
            this.btnClearSelected.Click += new System.EventHandler(this.btnClearSelected_Click);
            // 
            // dtpFilterRangeFrom
            // 
            this.dtpFilterRangeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFilterRangeFrom.Location = new System.Drawing.Point(199, 16);
            this.dtpFilterRangeFrom.Name = "dtpFilterRangeFrom";
            this.dtpFilterRangeFrom.ShowCheckBox = true;
            this.dtpFilterRangeFrom.Size = new System.Drawing.Size(111, 20);
            this.dtpFilterRangeFrom.TabIndex = 5;
            // 
            // dtpFilterRangeTo
            // 
            this.dtpFilterRangeTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFilterRangeTo.Location = new System.Drawing.Point(366, 16);
            this.dtpFilterRangeTo.Name = "dtpFilterRangeTo";
            this.dtpFilterRangeTo.ShowCheckBox = true;
            this.dtpFilterRangeTo.Size = new System.Drawing.Size(111, 20);
            this.dtpFilterRangeTo.TabIndex = 6;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(325, 20);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(26, 13);
            this.lblTo.TabIndex = 7;
            this.lblTo.Text = "To:";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.Location = new System.Drawing.Point(146, 20);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(38, 13);
            this.lblFrom.TabIndex = 8;
            this.lblFrom.Text = "From:";
            // 
            // frmAccountPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 493);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.dtpFilterRangeTo);
            this.Controls.Add(this.dtpFilterRangeFrom);
            this.Controls.Add(this.lblSelectDateRange);
            this.Controls.Add(this.btnClearSelected);
            this.Controls.Add(this.pnlBankEstimate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnPayNow);
            this.Controls.Add(this.dgvPayments);
            this.Name = "frmAccountPayments";
            this.Text = "Account Payments";
            this.Load += new System.EventHandler(this.Payments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).EndInit();
            this.pnlBankEstimate.ResumeLayout(false);
            this.pnlBankEstimate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPayNow;
        private System.Windows.Forms.DataGridView dgvPayments;
        private System.Windows.Forms.Panel pnlBankEstimate;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox tbEstimatedBankBalanceEOM;
        private System.Windows.Forms.TextBox tbCalculatedCurrentBalance;
        private System.Windows.Forms.TextBox tbOutstandingMonthlyIncome;
        private System.Windows.Forms.TextBox tbUnpaidBills;
        private System.Windows.Forms.TextBox tbPendingBills;
        private System.Windows.Forms.TextBox tbCurrentBankBalance;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblEstimatedBankBalanceEOM;
        private System.Windows.Forms.Label lblCalculatedCurrentBalance;
        private System.Windows.Forms.Label lblOutstandingMonthlyIncome;
        private System.Windows.Forms.Label lblUnpaiBills;
        private System.Windows.Forms.Label lblPendingBills;
        private System.Windows.Forms.Label lblCurrentBankBalance;
        private System.Windows.Forms.Button btnClearSelected;
        private System.Windows.Forms.Label lblSelectDateRange;
        private System.Windows.Forms.DateTimePicker dtpFilterRangeFrom;
        private System.Windows.Forms.DateTimePicker dtpFilterRangeTo;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
    }
}