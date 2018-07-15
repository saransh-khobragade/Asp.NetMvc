using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrudDataAccessLayer;
using System.Data;

namespace CrudConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //CrudReadValidateEmployeeUsingLinq();
            //GetEmployeeCrudList();
            //RegisterEmplyoyeesCrudCreate();
            //UpdateEmployeeCrudUpdate();
            //DeleteEmployeeCrudDelete();
        }

        public static void CrudReadValidateEmployeeUsingLinq()
        {
            Console.Clear();

            Repository dal = new Repository();
           
            Console.Write(" Please enter your Name : ");
            string ename = Console.ReadLine();

            Console.Write("\n\n\n Please enter your salary : ");
            int sal= Convert.ToInt32(Console.ReadLine());

            var user = new Employee() { ename = ename, salary = sal };
            
            Console.WriteLine(dal.CrudReadValidateEmployeeUsingLinq(user));
        }

        public static void GetEmployeeCrudList()
        {
            Repository dal = new Repository();
            var Emp = dal.GetEmployeeCrudList();
            
            foreach (var item in Emp)
            {
                Console.WriteLine("  " + item.ename + "\t\t" +
                                  item.salary);
            }

            Console.ReadKey();
        }

        public static void RegisterEmplyoyeesCrudCreate()
        {
            Console.Clear();

            Repository dal = new Repository();
            Console.WriteLine("\n\t-------------Employee Registration------------- \n");

            Employee user=new Employee();

            Console.Write("Please enter your name : ");
            user.ename = Console.ReadLine();

            Console.Write("Please enter your salary : ");
            user.salary = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter your ManagerId : ");
            user.mgrid = Convert.ToInt32(Console.ReadLine());

            if (dal.RegisterEmplyoyeesCrudCreate(user))
                Console.WriteLine("Registration Successfull");
            else
            {
                Console.WriteLine("Registration failed , please try again");
            }

            Console.ReadKey();
        }

        public static void UpdateEmployeeCrudUpdate()
        {
            Repository dal = new Repository();
            
            Employee emp = new Employee();
            
            Console.Write("\n\n Enter the id that you want to update: ");
            emp.id = Convert.ToByte(Console.ReadLine());

            Console.Write("\n Enter the new  name: ");
            emp.ename = Console.ReadLine();

            if (dal.UpdateEmployeeCrudUpdate(emp))
            {
                Console.WriteLine("\n\n Category updated successfully");
            }
            else
            {
                Console.WriteLine("\n\n Some error occurred. Please try again");
            }
            Console.ReadKey();
        }
        public static void DeleteEmployeeCrudDelete()
        {
            Repository dal = new Repository();
            
            Console.Write("\n\n Enter the id that you want to delete: ");
            byte id = Convert.ToByte(Console.ReadLine());

            if (dal.DeleteEmployeeCrudDelete(id))
            {
                Console.WriteLine("\n\n deleted successfully");
                
            }
            else
            {
                Console.WriteLine("\n\n Some error occured..please try again");
            }
        }
    }
}
