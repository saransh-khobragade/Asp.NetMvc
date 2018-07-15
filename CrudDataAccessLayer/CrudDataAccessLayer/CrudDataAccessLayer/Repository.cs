using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudDataAccessLayer
{
    public class Repository
    {
        private CompanyEntities Context { get; set; }
        public Repository()
        {
            Context = new CompanyEntities();
        }
        public string CrudReadValidateEmployeeUsingLinq(Employee user)
        {
            string roleName = "";
            var objUser = (from usr in Context.Employees
                           where usr.ename == user.ename && usr.salary == user.salary
                           select usr).FirstOrDefault<Employee>();
            if (objUser != null)
            {
                roleName = objUser.ename;
            }
            else
            {
                roleName = "Invalid Details";
            }
            return roleName;
        }

        public List<Employee> GetEmployeeCrudList()
        {
            List<Employee> Emp = null;
            try
            {
                Emp = (from c in Context.Employees
                                 orderby c.ename ascending
                                 select c).ToList<Employee>();
            }
            catch (Exception)
            {
                Emp = null;
            }
            return Emp;
        }

        public bool RegisterEmplyoyeesCrudCreate(Employee employee)
        {
            bool status = false;
            try
            {
               
                Context.Employees.Add(employee);
                Context.SaveChanges();
                status = true;
            }
            catch (Exception)
            {
                status = false;
            }
            return status;
        }

        public bool UpdateEmployeeCrudUpdate(Employee emp)
        {
            bool status = false;
            try
            {
                Employee employee = Context.Employees.Where(e => e.id == emp.id).FirstOrDefault<Employee>();
                employee.ename = emp.ename;
                Context.SaveChanges();
                status = true;
            }
            catch (Exception)
            {
                status = false;
            }
            return status;
        }

        public bool DeleteEmployeeCrudDelete(byte id)
        {
            bool status = false;
            try
            {
                var emp = (from e in Context.Employees
                                where e.id == id
                                select e).FirstOrDefault<Employee>();

                Context.Employees.Remove(emp);
                Context.SaveChanges();
                status = true;
            }
            catch (Exception)
            {
                status = false;
            }
            return status;
        }

    }


}
