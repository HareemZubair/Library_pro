using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace myweb
{
    public partial class frmaboutlibrary : System.Web.UI.Page
    {
        clslib obj = new clslib();
        string q;

        protected void Page_Load(object sender, EventArgs e)
        {
            q = "select * from tblabout";
            obj.BindToDataList(q, DataList1);
        }

        protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}