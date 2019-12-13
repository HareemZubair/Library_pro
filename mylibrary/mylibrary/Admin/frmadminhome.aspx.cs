using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace mylibrary.Admin
{
    public partial class frmadminhome : System.Web.UI.Page
    {
        clslib obj = new clslib();
        string qry;
        string name;
        int hid;

        protected void Page_Load(object sender, EventArgs e)
        {
            hid = int.Parse(obj.NewID("tblHome", "hid"));


            if (!IsPostBack)
            {
                qry = "select * from tblHome";
                obj.BindToDropDownlist(qry, DropDownList1, "hid", "hid");
            }
        }

        protected void ImageButton13_Click(object sender, ImageClickEventArgs e)
        {
            TextBox1.Text = obj.FindField("tblHome", "hid", DropDownList1.SelectedValue, "heading");
            TextBox2.Text = obj.FindField("tblHome", "hid", DropDownList1.SelectedValue, "detail");
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "" || TextBox2.Text == "" || FileUpload1.HasFile == false)
            {
                lblmessage.Text = "Fill all Options";
            }
            else
            {
                try
                {
                    name = Path.GetFileName(FileUpload1.FileName);
                    FileUpload1.SaveAs(Server.MapPath("~/images/" + name));

                    name = "/images/" + name;

                }
                catch (Exception ex)
                {
                    lblmessage.Text = "Pic Uploading Failed";
                }

                try
                {
                    qry = "insert into tblHome values(" + hid + ",'" + TextBox1.Text + "','" + TextBox2.Text + "','" + name + "')";

                    lblmessage.Text = obj.Manipulate(qry, "Addition");

                    ClearBoxes();

                }
                catch (Exception ex)
                {
                    lblmessage.Text = "Error Occured";
                    ClearBoxes();
                }
            }
        }
            protected void ClearBoxes()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox1.Focus();

        }

            protected void Button4_Click(object sender, EventArgs e)
            {
                ClearBoxes();
            }
        }
    }
