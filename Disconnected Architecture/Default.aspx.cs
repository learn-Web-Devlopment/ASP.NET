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
    public static SqlDataAdapter da;

    protected void Page_Load(object sender, EventArgs e)
    {
        

        display();
    }

    public void display()
    {
        ds.Clear();
        string str = "select * from feedback";
        da = new SqlDataAdapter(str, con);
        da.Fill(ds, "feedback");
        GridView1.DataSource = ds;
        GridView1.DataBind();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
       DataRow dr = ds.Tables["feedback"].NewRow();

        dr["name"] = TextBox1.Text;
        dr["email"] = TextBox2.Text;
        dr["message"] = TextBox3.Text;

        ds.Tables["feedback"].Rows.Add(dr);

        SqlCommandBuilder cmdr = new SqlCommandBuilder(da);
        da.Update(ds.Tables["feedback"]);
        display();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        string filter = "Id=" + Convert.ToInt32(TextBox1.Text);
        DataRow[] dr = ds.Tables["feedback"].Select(filter);
        dr[0].Delete();
        SqlCommandBuilder cmdr = new SqlCommandBuilder(da);
        da.Update(ds.Tables["feedback"]);
        display();
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        string str = "select * from feedback";
        da = new SqlDataAdapter(str,con);
        DataRow[] dr = ds.Tables[0].Select("Id=" + Convert.ToInt32(TextBox1.Text));

        dr[0]["email"] = TextBox2.Text;
        dr[0]["message"] = TextBox3.Text;
        SqlCommandBuilder cmdr = new SqlCommandBuilder(da);
        da.Update(ds.Tables["feedback"]);
        display();

    }
}