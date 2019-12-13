using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace myweb
{
    public partial class frmmemberlogin : System.Web.UI.Page
    {
        clslib obj = new clslib();
        string qry;
        int id;

        protected void Page_Load(object sender, EventArgs e)
        {
            id = int.Parse(obj.NewID("tblmember", "mid"));
        }

        protected void txtmname_TextChanged(object sender, EventArgs e)
        {

        }
        public void ClearBoxes()
        {
            txtcnic.Text = "";
            txtcontact.Text = "";
            txtemail.Text = "";
            txtloginid.Text = "";
            txtmname.Text = "";
            txtpass.Text = "";
            txtrepass.Text = "";
            DropDownList1.Text = "";
            txtmname.Focus();
        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            if (txtmname.Text == "" || txtemail.Text == "" || txtcnic.Text == "" || txtcontact.Text == "" || DropDownList1.Text == "" || txtloginid.Text == "" || txtrepass.Text == "")
            {
                Label1.Text = "Fill all of the above information";
            }
            else
            {
                bool chk = obj.SearchRecord("tblmember", "mname", txtmname.Text);

                if (chk == false)
                {

                    qry = "select * from tblmember where mloginid='" + txtloginid.Text + "' or mpass = '" + txtpass.Text + "'";
                   
                    bool check = obj.SearchRecord(qry);

                    if (check == false)
                    {

                        qry = "insert into tblmember values(" + id + ",'" + txtmname.Text + "','" + txtemail.Text + "','" + txtcnic.Text + "','" + txtcontact.Text + "','" + DropDownList1.Text + "','" + txtloginid.Text+"','"+txtpass.Text + "')";


                        Label1.Text = obj.Manipulate(qry, "Added New Member");
                        ClearBoxes();
                    }
                    else
                    {
                        Label1.Text = "This ID or Password is already Exits";
                        txtmname.Text="";
                        txtmname.Focus();
                    }
                  
                }
                else
                {
                    Label1.Text = "This Person is already a Member";
                    txtmname.Text="";
                    txtmname.Focus();
                }

               
            }
            }

        protected void btnclear_Click(object sender, EventArgs e)
        {
            ClearBoxes();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmfeedback.aspx");
        }
        }
    }
