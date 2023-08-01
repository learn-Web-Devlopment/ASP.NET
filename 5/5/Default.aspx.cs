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
        if (ListBox1.SelectedIndex != -1)
        {
            ListBox2.Items.Add(ListBox1.SelectedItem.ToString());
            ListBox1.Items.Remove(ListBox1.SelectedItem.ToString());
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        if (ListBox2.SelectedIndex != -1)
        {
            ListBox1.Items.Add(ListBox2.SelectedItem.ToString());
            ListBox2.Items.Remove(ListBox2.SelectedItem.ToString());
        }
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        int totalItem = ListBox1.Items.Count;

        ListBox2.Items.Clear();
        for (int i =0;i < totalItem;i++)
        {
            ListBox2.Items.Add(ListBox1.Items[i]);
        }
        ListBox1.Items.Clear();
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        int totalItem = ListBox2.Items.Count;

        ListBox1.Items.Clear();
        for (int i = 0; i < totalItem; i++)
        {
            ListBox1.Items.Add(ListBox2.Items[i]);
        }
        ListBox2.Items.Clear();
    }
}