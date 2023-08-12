using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""|DataDirectory|\Database.mdf"";Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("insert into registration (name,email,msg) values ('"+TextBox1.Text+"','"+TextBox2.Text+"','"+TextBox3.Text+"')",con);
        cmd.ExecuteNonQuery();
        Label1.Text = "Data Inserted";
        con.Close();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("update registration set email='"+TextBox2.Text+"' ,msg='"+TextBox3.Text+"' where name='"+TextBox1.Text+"'", con);
        cmd.ExecuteNonQuery();
        Label1.Text = "Data Updated";
        con.Close();
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("delete from registration where name='" + TextBox1.Text + "'", con);
        cmd.ExecuteNonQuery();
        Label1.Text = "Data Deleted";
        con.Close();
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from registration ", con);
        SqlDataReader dr = cmd.ExecuteReader();
        GridView1.DataSource = dr;
        GridView1.DataBind();
        con.Close();
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from registration where name='"+TextBox1.Text+"' ", con);
        SqlDataReader dr = cmd.ExecuteReader();
        GridView1.DataSource = dr;
        GridView1.DataBind();
        con.Close();
    }
}