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
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""|DataDirectory|\Database.mdf"";Integrated Security=True");

        con.Open();

        SqlCommand cmd = new SqlCommand("select * from users",con); 

        SqlDataReader dr = cmd.ExecuteReader();

        GridView1.DataSource = dr;
        GridView1.DataBind();
    }
}