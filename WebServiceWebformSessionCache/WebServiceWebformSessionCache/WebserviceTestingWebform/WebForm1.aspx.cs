using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebserviceTestingWebform
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.CalculatorWebServiceSoapClient client1 = new ServiceReference1.CalculatorWebServiceSoapClient();
            int result=client1.Add(Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox2.Text));
            TextBox3.Text = result.ToString();

            gvcal.DataSource = client1.Getcal();
            gvcal.DataBind();
            gvcal.HeaderRow.Cells[0].Text = "Recent calculation";
        }
    }
}