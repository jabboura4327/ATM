using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace ATM
{
    public partial class FirstPage : System.Web.UI.Page
    {
        // set your username and password in Web.config
        private static string USERNAME
        {
            get
            {
                return ConfigurationManager.AppSettings["username"];
            }
        }

        private static string PASSWORD
        {
            get
            {
                return ConfigurationManager.AppSettings["password"];
            }
        }
        private static string MainMenu
        {
            get
            {
                return ConfigurationManager.AppSettings["MainMenu"];
            }
        }


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            clearMessages();
            string ui = txtUI.Text;
            string password = txtPassword.Text;
            if (ui == USERNAME && password == PASSWORD)
            {
                Response.Redirect(MainMenu);
            }
            else if (ui != USERNAME && password != PASSWORD)
            {
                lblUIMessage.Text = "User ID is invalid";
                lblPasswordMessage.Text = "Password is invalid";
            }
            else if (ui != USERNAME)
            {
                lblUIMessage.Text = "User ID is invalid";
            }
            else
            {
                lblPasswordMessage.Text = "Password is invalid";
            }
        }

        protected void clearMessages()
        {
            lblUIMessage.Text = "";
            lblPasswordMessage.Text = "";
        }
    }
}