using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mylibrary
{
    public partial class frmviewfeedback : System.Web.UI.Page
    {
        clslib obj = new clslib();
        string qry;
        protected void Page_Load(object sender, EventArgs e)
        {
            qry = "select tblLogin.uname,tblLogin.uemail,tblLogin.ucountry,tblComments.date,tblComments.comment from tblComments join tblLogin on tblComments.uid = tblLogin.uid where tblComments.status=1 order by tblComments.cid desc";

            obj.BindToDataList(qry, DataList1);
        }

        protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}