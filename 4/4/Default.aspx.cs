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
        setState();
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        setState();
    }

    public void setState()
    {
        string country = DropDownList1.SelectedItem.ToString();
        if (country == "India")
        {
            DropDownList2.Items.Clear();
            DropDownList2.Items.Add("Gujarat");
            DropDownList2.Items.Add("Goa");
            DropDownList2.Items.Add("Karnataka");
            DropDownList2.Items.Add("Maharashtra");
            DropDownList2.Items.Add("Haryana");
        }
        else if (country == "China")
        {
            DropDownList2.Items.Clear();
            DropDownList2.Items.Add("Beijing");
            DropDownList2.Items.Add("Shanghai");
            DropDownList2.Items.Add("Hong Kong");
            DropDownList2.Items.Add("Hunan");
            DropDownList2.Items.Add("Fujian");
        }
        else if (country == "Nepal")
        {
            DropDownList2.Items.Clear();
            DropDownList2.Items.Add("Koshi");
            DropDownList2.Items.Add("Madhesh");
            DropDownList2.Items.Add("Lumbini");
            DropDownList2.Items.Add("Karnali");
            DropDownList2.Items.Add("Gandaki");
        }
        else if (country == "Japan")
        {
            DropDownList2.Items.Clear();
            DropDownList2.Items.Add("Nagasaki");
            DropDownList2.Items.Add("Hiroshima");
            DropDownList2.Items.Add("Gunma");
            DropDownList2.Items.Add("Fukui");
            DropDownList2.Items.Add("Aichi");
        }
    }
}