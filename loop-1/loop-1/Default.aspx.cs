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
        
        int a = 1;
        while (a <= 10)
        {
            Label1.Text += a.ToString() + " ";
            a++;
        }

        int b = 2;
        while (b <= 10)
        {
            Label2.Text += b.ToString() + " ";
            b += 2;
        }

        int c = 3;
        while (c <= 12)
        {
            Label3.Text += c.ToString() + " ";
            c += 3;
        }

        
        for (int i=1;i<= 3;i++)
        {
            for (int j=1;j<= i;j++)
            {
                Label4.Text += j.ToString() + " ";
            }
            Label4.Text += "<br>";
        }

        int d = 1;
        for (int i = 1; i <= 3; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Label5.Text += d.ToString() + " ";
                d += 2;
            }
            Label5.Text += "<br>";
        }


        for (int i = 1; i <= 3; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Label6.Text += "* ";
            }
            Label6.Text += "<br>";
        }

        for (int i = 1; i <= 3; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Label7.Text += i.ToString()+" ";
            }
            Label7.Text += "<br>";
        }

        int num5_1 = Convert.ToInt32(TextBox1.Text);

        for (int i = 1; i <= num5_1; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Label8.Text += i.ToString() + " ";
            }
            Label8.Text += "<br>";
        }

    }
}