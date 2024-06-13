using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBudgetV1_0.Forms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            frmAccounts accounts = new frmAccounts();
            accounts.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // TO DO
            // Check program, settingsw and display messages as needed.
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAccountBalances_Click(object sender, EventArgs e)
        {
            frmAccountBalances balances = new frmAccountBalances();
            balances.ShowDialog();
        }

        private void programSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProgramSettings programSettings = new frmProgramSettings();
            programSettings.ShowDialog();
        }

        private void btnPayBills_Click(object sender, EventArgs e)
        {
            frmAccountPayments payments = new frmAccountPayments();
            payments.ShowDialog();
        }
    }
}
