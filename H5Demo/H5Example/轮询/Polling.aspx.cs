using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace H5Example.轮询
{
    public partial class Polling : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Response.Write("{\"message\":\"" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\"}");
            Response.End();
        }
    }
}