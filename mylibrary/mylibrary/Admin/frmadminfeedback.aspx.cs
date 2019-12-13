using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mylibrary.Admin
{
    public partial class frmadminfeedback : System.Web.UI.Page
    {
        clslib obj = new clslib();
        string qry;

        protected void Page_Load(object sender, EventArgs e)
        {
            qry = "select tblComments.cid,tblLogin.uname,tblComments.date,tblComments.comment,tblComments.status from tblComments join tblLogin on tblComments.uid=tblLogin.uid order by tblComments.cid desc";
            obj.BindToGridView(qry, GridView1);

            if (!IsPostBack)
            {
                obj.BindToDropDownlist(qry, DropDownList1, "cid", "cid");
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (DropDownList2.SelectedItem.Text != "Allow" && DropDownList2.SelectedItem.Text != "Block")
            {
                lblmessage.Text = " Select Status";

            }
            else
            {
                //lblMessage.Text = DropDownList2.SelectedItem.Text;
                try
                {

                    qry = "update tblComments set status = " + DropDownList2.SelectedValue + " where cid=" + DropDownList1.SelectedValue + "";


                    lblmessage.Text = obj.Manipulate(qry, "Status Updated");
                    Page_Load(sender, e);

                }
                catch (Exception ex)
                {
                    lblmessage.Text = "Error";

                }


            }
  
        }
    }
}