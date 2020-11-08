using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Alaa_Homework
{
    public partial class page2 : System.Web.UI.Page
    {
        string a;
        protected void Page_Load(object sender, EventArgs e)
        {
            a = Request.QueryString["name"];
            TextBox1.Text = a;


        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
         
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            CheckBox1.Checked = true;
                }
    }
}