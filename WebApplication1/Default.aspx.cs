using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int year = int.Parse(TextBox1.Text);
            if(((year%4==0)&&(year%100!=0)) ||(year%400==0))
            {
                Label3.Text = "Leap";
            }
            else
            {
                Label3.Text = "Not leap";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(TextBox2.Text);
            int temp = 0;
            while(num>0)
            {
                int digit = num % 10;
                temp = temp * 10 + digit;
                num /= 10;
            }
            Label4.Text = "" + temp;
        }
    }
}