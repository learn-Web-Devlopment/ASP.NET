using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class registration : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""|DataDirectory|\Database.mdf"";Integrated Security=True");
        con.Open();

        SqlCommand cmd = new SqlCommand("insert into users (email,pass) values('"+TextBox1.Text+"','"+TextBox2.Text+"')",con); 

        int res = cmd.ExecuteNonQuery();
        if (res == 1)
        {
            Response.Redirect("Default.aspx");
        }
    }
}