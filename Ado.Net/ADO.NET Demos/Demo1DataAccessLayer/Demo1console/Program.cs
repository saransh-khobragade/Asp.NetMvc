using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo1DataAccessLayer;
using System.Data.SqlClient;
using System.Data;

namespace Demo1console
{
    class Program
    {
        static void Main(string[] args)
        {
            TestConnection();
            //AddEmployeeByExecuteNonQuery();
            //RegisterEmpployeeInlineQuery();
            //InsertEmployeeByStoredProcedure();
            //FetchEmployeesCountByExecuteScalar();
            //CountEmployeeByExecuteScalar();
            //FetchEmpoyeesByExecuteReader();
            //GetEmployeeByDataAdapterDisconnected();
            GetEmployeesByTablevaluedFunction();
            Console.ReadLine();
        }
        public static void TestConnection()
        {
            Console.Clear();
            Demo1DataAccessLayer.DataAccessLayer dal = new Demo1DataAccessLayer.DataAccessLayer();
            if (dal.TestConnection())
            {
                Console.WriteLine("\n\n Connection successful \n");
            }
            else
            {
                Console.WriteLine("\n\n Some error occurred \n");
            }
           
        }

        public static void AddEmployeeByExecuteNonQuery()
        {
            Demo1DataAccessLayer.DataAccessLayer dal = new Demo1DataAccessLayer.DataAccessLayer();
            if (dal.AddEmployeeByExecuteNonQuery())
            {
                Console.WriteLine("\n\n Employee info added successfully \n");
            }
            else
            {
                Console.WriteLine("\n\n Some error occurred , please try again \n");
            }
        }

        public static void RegisterEmpployeeInlineQuery()
        {
            Console.Clear();
            Demo1DataAccessLayer.DataAccessLayer dal = new
            Demo1DataAccessLayer.DataAccessLayer();
            Console.WriteLine("\n\t----------Employee Registration---------\n\n\n");
            Console.Write(" Please enter your Name : ");
            string ename = Console.ReadLine();
            Console.Write(" Please enter your Salary : ");
            int salary = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Please enter your ManagerId : ");
            int mgrid = Convert.ToInt32(Console.ReadLine());

            if (dal.RegisterEmpployeeInlineQuery(ename,salary,mgrid))
            {
                Console.WriteLine("\n\n Employee Registration Successful \n");
            }
            else
            {
                Console.WriteLine("\n\n Employee Registration failed, please try again \n");

            }
        }

        public static void InsertEmployeeByStoredProcedure()
        {
            Console.Clear();
            Demo1DataAccessLayer.DataAccessLayer dal = new Demo1DataAccessLayer.DataAccessLayer();
            
            Console.WriteLine("\n\t----------Employee Registration---------\n\n\n");
            Console.Write(" Please enter your Name : ");
            string ename = Console.ReadLine();
            Console.Write(" Please enter your Salary : ");
            int salary = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Please enter your ManagerId : ");
            int mgrid = Convert.ToInt32(Console.ReadLine());

            long id;
            int result = dal.InsertEmployeeByStoredProcedure(ename, salary, mgrid, out id);

            if (result == 1)
            {
                Console.WriteLine("\n\n Employee Id is : " + id + "\n");
            }
            else
            {
                Console.WriteLine("\n\n Some error occured..please try again \n");
            }
        }

        public static void FetchEmployeesCountByExecuteScalar()
        {
            DataAccessLayer dal = new DataAccessLayer();
            int numberOfProducts = dal.FetchEmployeesCountByExecuteScalar();
            Console.WriteLine("Total Number of products: " + numberOfProducts);
        }

        public static void CountEmployeeByExecuteScalar()
        {
            DataAccessLayer dal = new DataAccessLayer();
            Console.Write("\n\n Please enter your name : ");
            string ename = Console.ReadLine();

            Console.WriteLine("\n\nCount is "+ dal.CountEmployeeByExecuteScalar(ename));
            
        }

        public static void FetchEmpoyeesByExecuteReader()
        {
            DataAccessLayer dal = new DataAccessLayer();
            SqlDataReader reader = dal.FetchEmpoyeesByExecuteReader();
            Console.WriteLine("\n---Available Employees--\n\n");
            Console.WriteLine("-----------------------------\n");
            //if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Console.WriteLine("  " + reader["ename"].ToString() + "\t\t" + reader["salary"].ToString());
         
                }
            }

            
        }


        public static void GetEmployeeByDataAdapterDisconnected()
        {
            DataAccessLayer dal = new DataAccessLayer();
            DataTable dt = dal.GetEmployeeByDataAdapterDisconnected();
            Console.WriteLine("\nEmployee ID     Employee name \n-----------------------------------");
            foreach (DataRow item in dt.Rows)
            {
                Console.WriteLine(item[0].ToString() + "\t\t" + item[1].ToString());
            }
        }

        public static void GetEmployeesByTablevaluedFunction()
        {
            Console.Clear();
            DataAccessLayer dal = new  DataAccessLayer();
            DataTable dt = dal.GetEmployeesByTablevaluedFunction();
            Console.WriteLine("\nEmployee ID     Employee name \n-----------------------------------");
            foreach (DataRow item in dt.Rows)
            {
                Console.WriteLine(item[0].ToString() + "\t\t" + item[1].ToString());
            }
        }

    }
}
