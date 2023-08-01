using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    string userid = "admin@";
    int pass = 12345;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {

        if (TextBox1.Text != userid || pass != Convert.ToInt32(TextBox2.Text))
        {
            Label3.Text = "User and Pass not matck";
            Label3.ForeColor = Color.Red;
        }
        else
        {
            Label3.Text = " ";
        }
    }
}