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
        int bs = Convert.ToInt32(TextBox1.Text);
        double hraV;
        double daV;
        
        if (bs > 20000)
        {
            hraV = bs * 30 / 100;
            daV = bs * 95 / 100;

            hrapr.Text = "30%";
            hra.Text = hraV.ToString();

            dapr.Text = "95%";
            da.Text = daV.ToString();

            gs.Text = (bs + hraV + daV).ToString();
        }else if (bs <= 10000)
        {
            hraV = bs * 20 / 100;
            daV = bs * 80 / 100;

            hrapr.Text = "20%";
            hra.Text = hraV.ToString();

            dapr.Text = "80%";
            da.Text = daV.ToString();

            gs.Text = (bs + hraV + daV).ToString();
        }else if (bs <= 20000)
        {
            hraV = bs * 25 / 100;
            daV = bs * 90 / 100;
            
            hrapr.Text = "25%";
            hra.Text = hraV.ToString();

            dapr.Text = "90%";
            da.Text = daV.ToString();

            gs.Text = (bs + hraV + daV).ToString();
        }
    }
}