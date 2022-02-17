using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GlobalDemo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int appcode = Convert.ToInt32(Application["appcode"].ToString());
            appcode++;
            int sesscode = Convert.ToInt32(Session["sesscode"].ToString());
            sesscode++;
            Response.Write("Application code "+appcode);
            Response.Write("Session code " + sesscode);
        }
    }
}