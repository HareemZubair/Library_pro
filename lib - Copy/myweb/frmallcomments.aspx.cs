using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace myweb
{
    public partial class frmallcomments : System.Web.UI.Page
    {
        clslib obj = new clslib();
        string qry;

        protected void Page_Load(object sender, EventArgs e)
        {
            qry = "select tblmember.mid,tblmember.memail,tblmember.mcountry,tblcomment.comment,tblcomment.date from tblcomment join tblmember on tblcomment.mid = tblmember.mid where tblcomment.status=1 order by tblcomment.comid desc";

            obj.BindToDataList(qry, DataList1);

        }

        protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}