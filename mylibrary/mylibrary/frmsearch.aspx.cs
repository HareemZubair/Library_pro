using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mylibrary
{
    public partial class frmsearch : System.Web.UI.Page
    {
        clslib obj = new clslib();
        string q;

        protected void Page_Load(object sender, EventArgs e)
        {
            q = "select * from tblCat";
            if (!IsPostBack)
            {
                obj.BindToDropDownlist(q,DropDownList1,"category","catid");
            }
            q = "select * from tblSubcat";
            if (!IsPostBack)
            {
                obj.BindToDropDownlist(q, DropDownList2, "subcategory", "subcatid");
            }
            q = "select * from tblBook";
            if (!IsPostBack)
            {
                obj.BindToDropDownlist(q, DropDownList3, "bname", "bid");
            }
            
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
       

        protected void ImageButton15_Click(object sender, ImageClickEventArgs e)
        {
            q = "select * from tblBook where bid='" + DropDownList3.SelectedValue.ToString() +"'";
            obj.BindToGridView(q, GridView1);
        }

        
    }
}