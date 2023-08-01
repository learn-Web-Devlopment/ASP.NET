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
        if (num > 0)
        {
            RadioButton1.Checked = true;
            RadioButton2.Checked = false;
            RadioButton3.Checked = false;
        }
        else if (num < 0)
        {
            RadioButton1.Checked = false;
            RadioButton2.Checked = true;
            RadioButton3.Checked = false;
        }
        else {
            RadioButton1.Checked = false;
            RadioButton2.Checked = false;
            RadioButton3.Checked = true;
        }
    }
}