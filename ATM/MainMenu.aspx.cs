using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace ATM
{
    public partial class MainMenu : System.Web.UI.Page
    {
        private static string FirstPage
        {
            get
            {
                return ConfigurationManager.AppSettings["FirstPage"];
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            updateBalance();
        }

        ATM atm = new ATM();

        protected void btnWithdraw_Click(object sender, EventArgs e)
        {
            clearMessages();
            try
            {
                if (Double.Parse(txtWithdrawAmount.Text) > atm.getBalance()) {
                    lblActionMessage.Text = "Current balance is too low to make a withdrawal of <b>$" + Double.Parse(txtWithdrawAmount.Text).ToString("n2") + "</b>";
                }
                else {
                    atm.withdraw(Double.Parse(txtWithdrawAmount.Text));
                    lblActionMessage.Text = "You made a withdrawal amount of <b>$" + Double.Parse(txtWithdrawAmount.Text).ToString("n2") + "</b>";
                }
            }
            catch
            {
                txtWithdrawAmount.Text = "";
                lblWithdrawMessage.Text = "Invalid entry";
                lblActionMessage.Text = "-";
            }
            updateBalance();
            clearInput();
        }

        protected void btnDeposit_Click(object sender, EventArgs e)
        {
            clearMessages();
            try
            {
                atm.deposit(Double.Parse(txtDepositAmount.Text));
                lblActionMessage.Text = "You made a deposit amount of <b>$" + Double.Parse(txtDepositAmount.Text).ToString("n2") + "</b>";
            }
            catch
            {
                txtDepositAmount.Text = "";
                lblDepositMessage.Text = "Invalid entry";
                lblActionMessage.Text = "-";
            }
            updateBalance();
            clearInput();
        }

        protected void btnQuit_Click(object sender, EventArgs e)
        {
            Response.Redirect(FirstPage);
        }

        public void updateBalance()
        {
            lblBalance.Text = "Balance: $" + atm.getBalance().ToString("n2");
        }

        public void clearMessages()
        {
            lblWithdrawMessage.Text = "";
            lblDepositMessage.Text = "";
        }

        public void clearInput()
        {
            txtDepositAmount.Text = "";
            txtWithdrawAmount.Text = "";
        }
    }
}