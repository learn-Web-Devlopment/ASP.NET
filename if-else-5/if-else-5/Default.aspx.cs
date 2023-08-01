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
        if (num%2 == 0)
        {
            Label2.Visible = true;
            Label3.Visible = false;
        }
        else
        {
            Label2.Visible = false;
            Label3.Visible = true;
        }
    }
}