using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mylibrary
{
    public partial class frmComments : System.Web.UI.Page
    {
        clslib obj = new clslib();
        string qry;
        int id;

        protected void Page_Load(object sender, EventArgs e)
        {
             if (Session["uname"] != null)
            {
                lblusername.Text = Session["uname"].ToString();
                lblemail.Text = Session["uemail"].ToString();
                lblcountry.Text = Session["ucountry"].ToString();
                lbldate.Text = DateTime.Now.ToShortDateString();
            }
            else
            {
                Response.Redirect("frmmember.aspx");
            }


            id = int.Parse(obj.NewID("tblComments", "cid"));
        
        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "")
            {
                lblmessage.Text = "Enter your Comment";
            }
            else
            {
                try
                {

                    int i = int.Parse(Session["uid"].ToString());
                    qry = "insert into tblComments values(" + id + ",'" + lbldate.Text + "','" + TextBox1.Text + "'," + 0 + "," + i + ")";


                    lblmessage.Text = obj.Manipulate(qry, "Comment Added Successfully");
                    TextBox1.Text = "";
                    TextBox1.Focus();

                }
                catch (Exception ex)
                {
                    lblmessage.Text = "Error Occured";
                    TextBox1.Text = "";
                    TextBox1.Focus();
                }
            }
        }
    }
}