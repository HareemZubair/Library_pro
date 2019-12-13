using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace myweb
{
    public partial class frmadminlogin : System.Web.UI.Page
    {
        clslib obj = new clslib();
        string qry;

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void clear()
        {
            txtaid.Text = "";
            txtpas.Text = "";
            txtaid.Focus();
        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtaid.Text == "" || txtpas.Text == "")
            {
                Label1.Text = "ID and Password Required";
            }
            else
            {


                qry = "select * from tbladmin where aloginid='" + txtaid.Text + "' and apass = '" + txtpas.Text + "'";

                bool check = obj.SearchRecord(qry);

                if (check == false)
                {

                    Label1.Text = "Invalid login Id or Password";
                    clear();

                }
                else
                {

                    Session["aname"] = obj.FindField("tbladmin", "aloginid", txtaid.Text, "aname");
                    Session["aemail"] = obj.FindField("tbladmin", "aloginid", txtaid.Text, "aemail");
                    Session["acountry"] = obj.FindField("tbladmin", "aloginid", txtaid.Text, "acountry");
                    Response.Redirect("frmfeedback.aspx");

                }
            }
        }
    }
}