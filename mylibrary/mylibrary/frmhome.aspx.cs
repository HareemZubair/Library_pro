using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace mylibrary
{
    public partial class frmhome : System.Web.UI.Page
    {
        clslib obj = new clslib();
        string q;

        protected void Page_Load(object sender, EventArgs e)
        {

            q = "select * from tblHome";
            obj.BindToDataList(q, DataList1);
        }

        protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}