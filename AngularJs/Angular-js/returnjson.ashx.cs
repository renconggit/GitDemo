using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Angular_js
{
    /// <summary>
    /// returnjson 的摘要说明
    /// </summary>
    public class returnjson : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write(
                 "[{\"id\":1,\"name\":\"保时捷\",\"price\":50,\"color\":\"红色\",\"speed\":\"200km/h\"},{\"id\":2,\"name\":\"保时捷2\",\"price\":50,\"color\":\"红色\",\"speed\":\"200km/h\"},{\"id\":3,\"name\":\"保时捷3\",\"price\":50,\"color\":\"红色\",\"speed\":\"200km/h\"}]");
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}