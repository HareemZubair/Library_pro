using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mylibrary.Admin
{
    public partial class frmadminabout : System.Web.UI.Page
    {
        clslib obj = new clslib();
        string qry;
        int aid;

        protected void Page_Load(object sender, EventArgs e)
        {
            aid = int.Parse(obj.NewID("tblAbout", "aid"));


            if (!IsPostBack)
            {
                qry = "select * from tblAbout";
                obj.BindToDropDownlist(qry, DropDownList1, "aid", "aid");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "" || TextBox2.Text == "" || TextBox3.Text == "" || TextBox4.Text == "" || TextBox5.Text == "")
            {
                lblmessage.Text = "Plz fill all fields";
            }
            else
            {
                qry = "insert into tblAbout values(" + aid + ",'" + TextBox1.Text + "', '" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "')";

                lblmessage.Text = obj.Manipulate(qry, "Record Added");
                ClearBoxes();
            }
        }
        protected void ClearBoxes()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox1.Focus();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                qry = "update tblAbout set campus='" + TextBox1.Text + "', address = '" + TextBox2.Text + "',contact = '" + TextBox3.Text + "',email = '" + TextBox4.Text + "',year = '" + TextBox5.Text + "' where aid = " + DropDownList1.SelectedValue + "";

                lblmessage.Text = obj.Manipulate(qry, "Updation");

                ClearBoxes();

            }
            catch (Exception ex)
            {
                lblmessage.Text = "Error Occured";
                ClearBoxes();
            }


        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                qry = "delete from tblAbout where aid = " + DropDownList1.SelectedValue + "";

                lblmessage.Text = obj.Manipulate(qry, "Deletion");

                ClearBoxes();

            }
            catch (Exception ex)
            {
                lblmessage.Text = "Error Occured";
                ClearBoxes();
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            ClearBoxes();
        }

        protected void ImageButton13_Click(object sender, ImageClickEventArgs e)
        {
            TextBox1.Text = obj.FindField("tblAbout", "aid", DropDownList1.SelectedValue, "campus");
            TextBox2.Text = obj.FindField("tblAbout", "aid", DropDownList1.SelectedValue, "address");
            TextBox3.Text = obj.FindField("tblAbout", "aid", DropDownList1.SelectedValue, "contact");
            TextBox4.Text = obj.FindField("tblAbout", "aid", DropDownList1.SelectedValue, "email");
            TextBox5.Text = obj.FindField("tblAbout", "aid", DropDownList1.SelectedValue, "year");
        }
    }
}