using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace H5Example.轮询
{
    public partial class LongPolling : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            while (true)
            {
                int random = new Random().Next(1, 100);

                if (random == 50)
                {
                    Response.Write("{\"message\":\"" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\"}");
                    Response.End();
                    break;
                }
                else
                {
                    Thread.Sleep(100);
                }
            }
        }
    }
}