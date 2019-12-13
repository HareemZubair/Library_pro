using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace myweb
{
    public partial class frmbooksearch : System.Web.UI.Page
    {
        clslib obj = new clslib();
        string q;

        protected void Page_Load(object sender, EventArgs e)
        {
            q = "select * from tblbooksearch";
            obj.BindToGridView(q, GridView1);
            if (!IsPostBack)
            {
                obj.BindToDropDownlist(q, DropDownList2, "bookname", "bookid");
            }
        }

        protected void ImageButton8_Click(object sender, ImageClickEventArgs e)
        {
            q = "select * from tblbooksearch where bookid='" + DropDownList2.SelectedValue + "'";
            obj.BindToGridView(q, GridView1);
        }
    }
}