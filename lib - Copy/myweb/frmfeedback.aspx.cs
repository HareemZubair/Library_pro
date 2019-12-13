using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace myweb
{
    public partial class frmfeedback : System.Web.UI.Page
    {
        clslib obj = new clslib();
        string qry;

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void clear()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox1.Focus();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "" || TextBox2.Text == "")
            {
                Label1.Text = "ID and Password Required";
            }
            else
            {


                qry = "select * from tblmember where mloginid='" + TextBox1.Text + "' and mpass = '" + TextBox2.Text + "'";

                bool check = obj.SearchRecord(qry);

                if (check == false)
                {

                    Label1.Text = "Invalid User ID or Password or not Registered";
                    clear();

                }
                else
                {

                    Session["mname"] = obj.FindField("tblmember", "mloginid", TextBox1.Text, "mname");
                    Session["memail"] = obj.FindField("tblmember", "mloginid", TextBox1.Text, "memail");
                    Session["mcountry"] = obj.FindField("tblmember", "mloginid", TextBox1.Text, "mcountry");
                    Response.Redirect("frmComments.aspx");

                }

            }
              
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmmemberlogin.aspx");
        }
    }
}