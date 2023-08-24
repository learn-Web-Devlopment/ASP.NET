using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""|DataDirectory|\Database.mdf"";Integrated Security=True");
    public static DataSet ds = new DataSet();
    public static SqlDataAdapter da ;
    protected void Page_Load(object sender, EventArgs e)
    {
        display();
    }

    public void display()
    {
        ds.Clear();
        string str = "select * from users";
        da = new SqlDataAdapter(str, con);
        da.Fill(ds, "users");
        GridView1.DataSource = ds;
        GridView1.DataBind();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        DataRow dr = ds.Tables["users"].NewRow();

        dr["name"] = TextBox1.Text;
        dr["email"] = TextBox2.Text;
        dr["msg"] = TextBox3.Text;

        ds.Tables["users"].Rows.Add(dr);

        SqlCommandBuilder cmdr = new SqlCommandBuilder(da);
        da.Update(ds.Tables["users"]);
        display();
    }
}