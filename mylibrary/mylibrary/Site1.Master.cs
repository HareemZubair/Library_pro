using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mylibrary
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

       

        protected void ImageButton10_Click(object sender, ImageClickEventArgs e)
        {
            string url = "http://www.google.com/search?query=" + txtSearch.Text;

            Response.Redirect(url);
        }
    }
}