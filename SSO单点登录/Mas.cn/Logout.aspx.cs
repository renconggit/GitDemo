﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mas.com
{
    public partial class Logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["username"] = null;
            Session["token"] = null;

            Response.Write(Request.QueryString["callback"] + "({\"result\":\"success\"})");
            Response.End();
        }
    }
}