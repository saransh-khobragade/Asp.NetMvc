using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServiceDemo
{
    /// <summary>
    /// Summary description for CalculatorWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class CalculatorWebService : System.Web.Services.WebService
    {

        [WebMethod(enableSession:true)]
        public int Add(int a,int b)
        {
            List<string> calculation;

            if (Session["CAL"] == null)
            {
                calculation = new List<string>();
            }
            else
            {
                calculation = (List<string>)Session["CAL"];
            }

            string str = a.ToString() +"+"+ b.ToString() +"="+ (a + b).ToString();
            calculation.Add(str);
            Session["CAL"] = calculation;

            return a+b;
        }
        [WebMethod(EnableSession =true,CacheDuration =20,BufferResponse =true)]
        public List<string> Getcal()
        {
            if (Session["CAL"] == null)
            {
                List<string> calculation = new List<string>();
                calculation.Add("No calculation yet");
                return calculation;
            }
            else
            {
                return (List<string>)Session["CAL"];
            }
        }
    }
}
