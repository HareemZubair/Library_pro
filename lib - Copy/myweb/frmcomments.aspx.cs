using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace myweb
{
    public partial class frmcomments : System.Web.UI.Page
    {
        clslib obj = new clslib();
        string qry;
        int id;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["mname"] != null)
            {
                Label2.Text = Session["mname"].ToString();
                Label3.Text = Session["memail"].ToString();
                Label5.Text = Session["mcountry"].ToString();
                Label4.Text = DateTime.Now.ToShortDateString();
            }
            else
            {
                Response.Redirect("frmmemberlogin.aspx");
            }


            id = int.Parse(obj.NewID("tblcomment", "comid"));
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "")
            {
                Label6.Text = "Give your Feedback!";
            }
            else
            {
                try
                {
                    int i = int.Parse(Session["mid"].ToString());
                    qry = "insert into tblcomment values(" + id + ",'" + TextBox1.Text + "','" + Label4.Text + "'," + 0 + "," + i + ")";
                    obj.Manipulate(qry, "Thanks For your Feedback!");
                    TextBox1.Text = "";
                    TextBox1.Focus();
                }
                catch (Exception ex)
                {
                    TextBox1.Text = "Some thing is wrong!";
                    TextBox1.Text = "";
                    TextBox1.Focus();
                }
            }

        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmallcomments.aspx");
        }
    }
}
