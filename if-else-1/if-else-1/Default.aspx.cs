﻿using System;
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
        int num1 = Convert.ToInt32(TextBox1.Text);
        int num2 = Convert.ToInt32(TextBox2.Text);

        if (num1 > num2)
        {
            TextBox3.Text = "Num 1 is Big " + num1;
        }
        else
        {
            TextBox3.Text = "Num 2 is Big " + num2;
        }
    }
}