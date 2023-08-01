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

    protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {
        Label1.Text = "Gender : " + RadioButton1.Text;
    }

    protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
    {
        Label1.Text = "Gender : " + RadioButton2.Text;
    }
}