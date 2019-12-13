using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace mylibrary
{
    public partial class frmadmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

       
        protected bool CheckUser(string userid, string password, bool remem)
        {
            if (userid == "hareem" && password == "hcc")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

       

       
        protected void Login1_Authenticate1(object sender, AuthenticateEventArgs e)
        {
            bool chk = CheckUser(Login1.UserName, Login1.Password, Login1.RememberMeSet);

            if (chk == true)
            {
                FormsAuthentication.RedirectFromLoginPage(Login1.UserName, Login1.RememberMeSet);
            }
        }
    }
}