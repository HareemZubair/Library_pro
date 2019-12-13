using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;

namespace mylibrary.Admin
{
    public partial class frmadminnews : System.Web.UI.Page
    {
        protected void Bind_Grid()
        {
            string s = Server.MapPath("~/Admin/XMLFile1.xml");
            DataSet ds = new DataSet();
            ds.ReadXml(s);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Bind_Grid();
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "add")
            {
                string nam = Server.MapPath("~/Admin/XMLFile1.xml");
                DataSet ds = new DataSet();
                ds.ReadXml(nam);

                DataRow r = ds.Tables[0].NewRow();

                r[0] = ((TextBox)(GridView1.FooterRow.FindControl("TextBox2"))).Text;
                r[1] = ((TextBox)(GridView1.FooterRow.FindControl("TextBox4"))).Text;

                ds.Tables[0].Rows.Add(r);

                ds.WriteXml(nam);

                Bind_Grid();
            }
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string nam = Server.MapPath("~/Admin/XMLFile1.xml");
            DataSet ds = new DataSet();
            ds.ReadXml(nam);

            ds.Tables[0].Rows.RemoveAt(e.RowIndex);
            ds.WriteXml(nam);

            Bind_Grid();

        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            Bind_Grid();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string nam = Server.MapPath("~/Admin/XMLFile1.xml");
            DataSet ds = new DataSet();
            ds.ReadXml(nam);

            ds.Tables[0].Rows[e.RowIndex][0] = ((TextBox)(GridView1.Rows[e.RowIndex].FindControl("TextBox1"))).Text;
            ds.Tables[0].Rows[e.RowIndex][1] = ((TextBox)(GridView1.Rows[e.RowIndex].FindControl("TextBox3"))).Text;

            GridView1.EditIndex = -1;

            ds.WriteXml(nam);

            Bind_Grid();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            Bind_Grid();
        }
    }
}