using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FunctionStoreProcedureDataAccessLibrary;

namespace FunctionStoreProcedureConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //GetNextEmployeeIdScalarFunction();
            //CheckEmployeeByScalarFunctionWithPara();
            //GetEmployeeByTableFunction();
            InsertEmployeeByStoredProcedure();
        }
        public static void GetNextEmployeeIdScalarFunction()
        {
            Console.Clear();
            Repository dal = new Repository();
            Console.WriteLine("\n\n New Employee id is : " + dal.GetNextEmployeeIdScalarFunction());
            Console.ReadLine();
        }

        public static void CheckEmployeeByScalarFunctionWithPara()
        {
            Repository dal = new Repository();
            Console.Write("\n\n Please enter your name : ");
            string name = Console.ReadLine();

            if (dal.CheckEmployeeByScalarFunctionWithPara(name)==-1)
            {
                Console.WriteLine("\n\n The name id that you have entered is not present in the database \n\n");
            }
            else
            {
                Console.WriteLine("\n\n The name id that you have entered is present in the database \n\n");
            }
            Console.ReadKey();
        }
        public static void GetEmployeeByTableFunction()
        {
            
            Repository dal = new Repository();
            var lstproducts = dal.GetEmployeeByTableFunction();
            
            if (lstproducts.Count != 0)
            {
                foreach (var item in lstproducts)
                {
                    Console.WriteLine("id: " + item.id);
                    Console.WriteLine("Name: " + item.ename);
                    Console.WriteLine("salary: " + item.salary);
                    Console.WriteLine("mgrid: " + item.mgrid);
                    Console.WriteLine("------------------------------------\n");
                }
            }
            else
            {
                Console.WriteLine("employee details not found.... Try again...!!!\n");
            }
            Console.ReadKey();
        }

        public static void InsertEmployeeByStoredProcedure()
        {
            Console.Clear();
            Repository dal = new Repository();

            Console.Write("\n Please enter name: ");
            string name = Console.ReadLine();

            Console.Write("\n Please enter your salary: ");
            int salary = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n Please enter your mgrid: ");
            int mgrid = Convert.ToInt32(Console.ReadLine());

            long purchaseid = 0;

            int result = dal.InsertEmployeeByStoredProcedure(name, salary, mgrid, out purchaseid);
            if (result == 1)
            {
                Console.WriteLine("\nYou have successfully insert: " + purchaseid);
            }
            
        }




    }
}
