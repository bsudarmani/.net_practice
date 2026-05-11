using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SessionCount
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["visitorcount"]==null)
            {
                Session["visitorcount"] = 1;
            }
            else
            {
                Session["visitorcount"] = (int)Session["visitorcount"] + 1;
            }
            Label1.Text = "You have visited this page" + Session["visitorcount"] + "times in this session";
        }
    }
}