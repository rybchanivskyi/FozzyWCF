using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFozzyWCFClient.CelsiusToFahrenheit;

namespace WebFozzyWCFClient
{
    public partial class Convertor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Calculate_Click(object sender, EventArgs e)
        {
            try
            {
                double celcius = double.Parse(Celsius.Text);

                CelsiusToFahrenheitClient client = new CelsiusToFahrenheitClient("BasicHttpBinding_ICelsiusToFahrenheit");

                Label1.Text = client.ConvertToFahrenheit(celcius).ToString();

                client.Close();
            }
            catch (Exception ex)
            {
                Label1.Text = ex.Message;
            }

        }
    }
}