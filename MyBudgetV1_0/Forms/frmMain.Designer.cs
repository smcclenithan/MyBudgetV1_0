namespace MyBudgetV1_0.Forms
{
    partial class frmMain
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
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.ftsmFile = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ftsmTools = new System.Windows.Forms.ToolStripMenuItem();
            this.tableMaintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ftsmHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnBudgeet = new System.Windows.Forms.Button();
            this.btnAccountBalances = new System.Windows.Forms.Button();
            this.btnPayBills = new System.Windows.Forms.Button();
            this.btnAccounts = new System.Windows.Forms.Button();
            this.msMain.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ftsmFile,
            this.ftsmTools,
            this.ftsmHelp});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(800, 24);
            this.msMain.TabIndex = 4;
            // 
            // ftsmFile
            // 
            this.ftsmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.ftsmFile.Name = "ftsmFile";
            this.ftsmFile.Size = new System.Drawing.Size(37, 20);
            this.ftsmFile.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // ftsmTools
            // 
            this.ftsmTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tableMaintenanceToolStripMenuItem,
            this.programSettingsToolStripMenuItem});
            this.ftsmTools.Name = "ftsmTools";
            this.ftsmTools.Size = new System.Drawing.Size(46, 20);
            this.ftsmTools.Text = "&Tools";
            // 
            // tableMaintenanceToolStripMenuItem
            // 
            this.tableMaintenanceToolStripMenuItem.Name = "tableMaintenanceToolStripMenuItem";
            this.tableMaintenanceToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.tableMaintenanceToolStripMenuItem.Text = "&Table Maintenance";
            // 
            // programSettingsToolStripMenuItem
            // 
            this.programSettingsToolStripMenuItem.Name = "programSettingsToolStripMenuItem";
            this.programSettingsToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.programSettingsToolStripMenuItem.Text = "Program Settings";
            this.programSettingsToolStripMenuItem.Click += new System.EventHandler(this.programSettingsToolStripMenuItem_Click);
            // 
            // ftsmHelp
            // 
            this.ftsmHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.ftsmHelp.Name = "ftsmHelp";
            this.ftsmHelp.Size = new System.Drawing.Size(44, 20);
            this.ftsmHelp.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.Controls.Add(this.btnReports);
            this.pnlMain.Controls.Add(this.btnBudgeet);
            this.pnlMain.Controls.Add(this.btnAccountBalances);
            this.pnlMain.Controls.Add(this.btnPayBills);
            this.pnlMain.Controls.Add(this.btnAccounts);
            this.pnlMain.Location = new System.Drawing.Point(12, 33);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(776, 411);
            this.pnlMain.TabIndex = 5;
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(595, 38);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(103, 119);
            this.btnReports.TabIndex = 4;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            // 
            // btnBudgeet
            // 
            this.btnBudgeet.Location = new System.Drawing.Point(466, 38);
            this.btnBudgeet.Name = "btnBudgeet";
            this.btnBudgeet.Size = new System.Drawing.Size(103, 119);
            this.btnBudgeet.TabIndex = 3;
            this.btnBudgeet.Text = "Budget";
            this.btnBudgeet.UseVisualStyleBackColor = true;
            // 
            // btnAccountBalances
            // 
            this.btnAccountBalances.Location = new System.Drawing.Point(208, 38);
            this.btnAccountBalances.Name = "btnAccountBalances";
            this.btnAccountBalances.Size = new System.Drawing.Size(103, 119);
            this.btnAccountBalances.TabIndex = 2;
            this.btnAccountBalances.Text = "Account Balances";
            this.btnAccountBalances.UseVisualStyleBackColor = true;
            this.btnAccountBalances.Click += new System.EventHandler(this.btnAccountBalances_Click);
            // 
            // btnPayBills
            // 
            this.btnPayBills.Location = new System.Drawing.Point(337, 38);
            this.btnPayBills.Name = "btnPayBills";
            this.btnPayBills.Size = new System.Drawing.Size(103, 119);
            this.btnPayBills.TabIndex = 1;
            this.btnPayBills.Text = "PayBills";
            this.btnPayBills.UseVisualStyleBackColor = true;
            this.btnPayBills.Click += new System.EventHandler(this.btnPayBills_Click);
            // 
            // btnAccounts
            // 
            this.btnAccounts.Location = new System.Drawing.Point(79, 38);
            this.btnAccounts.Name = "btnAccounts";
            this.btnAccounts.Size = new System.Drawing.Size(103, 119);
            this.btnAccounts.TabIndex = 0;
            this.btnAccounts.Text = "Accounts";
            this.btnAccounts.UseVisualStyleBackColor = true;
            this.btnAccounts.Click += new System.EventHandler(this.btnAccounts_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.msMain);
            this.Controls.Add(this.pnlMain);
            this.Name = "frmMain";
            this.Text = "My Budget";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem ftsmFile;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ftsmTools;
        private System.Windows.Forms.ToolStripMenuItem tableMaintenanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ftsmHelp;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnBudgeet;
        private System.Windows.Forms.Button btnAccountBalances;
        private System.Windows.Forms.Button btnPayBills;
        private System.Windows.Forms.Button btnAccounts;
        private System.Windows.Forms.ToolStripMenuItem programSettingsToolStripMenuItem;
    }
}

