using System;
using System.Collections.Generic;
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
        int num = Convert.ToInt32(TextBox1.Text);

        if (num%5 == 0 && num % 11 == 0)
        {
            Label3.Visible = true;
            Label2.Visible = false;
        }
        else
        {
            Label3.Visible = false;
            Label2.Visible = true;
        }
    }
}