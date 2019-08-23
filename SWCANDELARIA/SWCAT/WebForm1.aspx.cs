using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SWCAT
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WSDB.WSControlHombresSoapClient WS = new WSDB.WSControlHombresSoapClient();
            DataSet ds = WS.Getdata();
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
        }




        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}