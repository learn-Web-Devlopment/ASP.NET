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

    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        Label1.Text = Calendar1.SelectedDate.ToLocalTime().ToString();
        Label2.Text = Calendar1.SelectedDate.ToShortDateString();
        Label3.Text = Calendar1.SelectedDate.ToLongDateString();
    }
}