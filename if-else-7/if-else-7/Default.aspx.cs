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
        int sub1 = Convert.ToInt32(TextBox1.Text);
        int sub2 = Convert.ToInt32(TextBox2.Text);
        int sub3 = Convert.ToInt32(TextBox3.Text);
        int sub4 = Convert.ToInt32(TextBox4.Text);

        int totalMarks = sub1 + sub2 + sub3 + sub4;

        float pr = (float)totalMarks / 400 * 100;

        Label6.Visible = true;
        Label8.Visible = true;
        if (pr >= 90)
        {
            Label6.Text = pr.ToString() + "%";
            Label8.Text = "A";
        }
        else if (pr >= 80)
        {
            Label6.Text = pr.ToString() + "%";
            Label8.Text = "B";
        }
        else if (pr >= 70)
        {
            Label6.Text = pr.ToString() + "%";
            Label8.Text = "C";
        }
        else if (pr >= 60)
        {
            Label6.Text = pr.ToString() + "%";
            Label8.Text = "D";
        }
        else if (pr >= 40)
        {
            Label6.Text = pr.ToString() + "%";
            Label8.Text = "E";
        }
        else
        {
            Label6.Text = pr.ToString() + "%";
            Label8.Text = "F";
        }
    }
}