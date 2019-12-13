using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mylibrary
{
    public partial class frmmember : System.Web.UI.Page
    {
        clslib obj = new clslib();
        string qry;
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            id = int.Parse(obj.NewID("tblLogin", "uid"));
        }

       
        protected void ClearBoxes2()
        {
            TextBox7.Text = "";
            TextBox8.Text = "";
            TextBox9.Text = "";
            TextBox10.Text = "";
            TextBox11.Text = "";
            TextBox12.Text = "";
            TextBox13.Text = "";
            TextBox7.Focus();

        }

        protected void ClearBoxes1()
        {
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox5.Focus();

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (TextBox7.Text == "" || TextBox8.Text == "" || TextBox9.Text == "" || TextBox10.Text == "" || TextBox11.Text == "" || TextBox12.Text == "" || TextBox13.Text == "")
            {
                lblMessage2.Text = "All field Required";
            }
            else
            {
                bool chk = obj.SearchRecord("tblLogin", "uname", TextBox7.Text);

                if (chk == false)
                {

                    qry = "select * from tbLogin where loginid='" + TextBox11.Text + "' or pass = '" + TextBox12.Text + "'";

                    bool check = obj.SearchRecord(qry);

                    if (check == false)
                    {

                        qry = "insert into tblLogin values(" + id + ",'" + TextBox7.Text + "','" + TextBox8.Text + "','" + TextBox9.Text + "','" + TextBox10.Text + "','" + TextBox11.Text + "','" + TextBox12.Text + "')";


                        lblMessage.Text = obj.Manipulate(qry, "New Registration");
                        ClearBoxes1();
                        ClearBoxes2();
                        Panel2.Visible = false;
                        Panel1.Visible = true;
                    }
                    else
                    {
                        lblMessage2.Text = "user id or Password Already exists";
                        TextBox7.Text = "";
                        TextBox7.Focus();
                    }

                }
                else
                {
                    lblMessage2.Text = "user name Already Exist";
                    TextBox7.Text = "";
                    TextBox7.Focus();
                }


            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Panel1.Visible = false;
            Panel2.Visible = true;
        }

       

       
        protected void Button2_Click(object sender, EventArgs e)
        {
            if (TextBox5.Text == "" || TextBox6.Text == "")
            {
                lblMessage.Text = "ID and Password Required";
            }
            else
            {


                qry = "select * from tblLogin where loginid='" + TextBox5.Text + "' and pass = '" + TextBox6.Text + "'";

                bool check = obj.SearchRecord(qry);

                if (check == false)
                {

                    lblMessage.Text = "Invalid User ID or Password";
                    ClearBoxes1();

                }
                else
                {
                    Session["uid"] = obj.FindField("tblLogin", "loginid", TextBox5.Text, "uid");
                    Session["uname"] = obj.FindField("tblLogin", "loginid", TextBox5.Text, "uname");
                    Session["uemail"] = obj.FindField("tblLogin", "loginid", TextBox5.Text, "uemail");
                    Session["ucountry"] = obj.FindField("tblLogin", "loginid", TextBox5.Text, "ucountry");
                    Response.Redirect("frmComments.aspx");

                }
            }
        }
    }
}