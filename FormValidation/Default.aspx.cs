using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormValidation
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(Page.IsValid)
            {
                Label8.Text = "form submitted successfully";
                Label8.ForeColor = System.Drawing.Color.Green;
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox4.Text = "";
                TextBox3.Text = "";
                DropDownList1.SelectedIndex = 0;
                CheckBoxList1.ClearSelection();
                TextBox5.Text = "";
            }
            else
            {
                Label8.Text = "Please fill all the fields";
                Label8.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
        }
    }
}