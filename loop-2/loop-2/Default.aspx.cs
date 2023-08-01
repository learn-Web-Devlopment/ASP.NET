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
        fbs.Text = "";
        int fbs1 = 0;
        int fbs2 = 1;
        for (int i = 0; i <= 10; i++)
        {
            fbs.Text += fbs1 + " ";
            int temp = fbs1;
            fbs1 = fbs2;
            fbs2 = temp + fbs2;
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        loop5.Text = "";
        int n1 = Convert.ToInt32(TextBox1.Text);
        int tem1 = 1;
        for (int i = 1; i <= n1; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                loop5.Text += tem1 + " ";
                tem1++;
            }
            loop5.Text += "<br>";
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        loop53.Text = "";
        int n2 = Convert.ToInt32(TextBox2.Text);
        for (int i = 1; i <= n2; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                loop53.Text += "0  ";
            }
            loop53.Text += "<br>";
        }
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        int n3 = Convert.ToInt32(TextBox3.Text);
        int sum = 0;
        for (int i = 1; i <= n3; i++)
        {
            sum += i;
        }
        loop9.Text = sum.ToString();
    }
}