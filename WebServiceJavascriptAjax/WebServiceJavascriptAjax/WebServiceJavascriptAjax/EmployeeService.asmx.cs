using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace WebServiceJavascriptAjax
{
    /// <summary>
    /// Summary description for EmployeeService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class EmployeeService : System.Web.Services.WebService
    {

        [WebMethod]
        public Employee GetEmployeeById(int ID)
        {
            Employee emp = new Employee(); ;
            string cs = ConfigurationManager.ConnectionStrings["MyDatabase"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("GetEmployeeById", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter parameter = new SqlParameter("@id", ID);
                cmd.Parameters.Add(parameter);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    emp.id = Convert.ToInt32(reader["id"]);
                    emp.ename = reader["ename"].ToString();
                    emp.salary = Convert.ToInt32(reader["salary"]);
                    emp.mgrid = Convert.ToInt32(reader["mgrid"]);
                }
            }
            return emp;
        }
    }
}
