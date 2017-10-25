using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace H5Example
{
    public partial class SSE : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.ContentType = "text/event-stream";
            Response.CacheControl = "no-cache";
            Response.Write("retry:1000\ndata:" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            Response.Flush();

        }
    }
}