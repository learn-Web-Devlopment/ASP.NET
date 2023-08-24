using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""|DataDirectory|\Database.mdf"";Integrated Security=True");
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from users where email='" + TextBox1.Text + "' and pass='" + TextBox2.Text + "'", con);

        SqlDataReader dr = cmd.ExecuteReader();

        if (dr.Read())
        {
            if (dr["email"].Equals(TextBox1.Text) && dr["pass"].Equals(TextBox2.Text))
            {
                Response.Redirect("Welcome.aspx");
            }
        }
    }
}