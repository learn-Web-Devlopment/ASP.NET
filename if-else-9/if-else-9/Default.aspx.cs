using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int age = Convert.ToInt32(TextBox1.Text);
        if (age > 18)
        {
            Label2.Text = "Eligible to vote";
            Label2.ForeColor = Color.Green;
        }
        else
        {
            Label2.Text = "Not Eligible to vote";
            Label2.ForeColor = Color.Red;
        }
    }
}