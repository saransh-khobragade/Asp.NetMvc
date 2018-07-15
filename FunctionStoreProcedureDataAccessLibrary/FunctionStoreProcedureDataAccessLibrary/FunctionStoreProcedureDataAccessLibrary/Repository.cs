using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Core.Objects;

namespace FunctionStoreProcedureDataAccessLibrary
{
    public class Repository
    {
        private CompanyEntities Context { get; set; }
        public Repository()
        {
            Context = new CompanyEntities();
        }

        public Int32 GetNextEmployeeIdScalarFunction()
        {
            Int32 id;
            try
            {
                // SQL server specific usage 
                id = Context.Database.SqlQuery<Int32>("SELECT dbo.GetNextEmployeeId()").FirstOrDefault();
                // Provider independant usage
                //	productid = ((IObjectContextAdapter)Context).ObjectContext.ExecuteStoreQuery<string>("SELECT dbo.ufn_GenerateNewProductId()").FirstOrDefault();
            }
            catch (Exception)
            {
                id = -1;
            }
            return id;
        }

        public int CheckEmployeeByScalarFunctionWithPara(string emailId)
        {
            int status;
            try
            {
                status = Context.Database.SqlQuery<int>("select dbo.CheckEmployee({0})", emailId).FirstOrDefault();
            }
            catch
            {
                status = -1;
            }
            return status;
        }
        public List<ShowEmployees_Result> GetEmployeeByTableFunction()
        {
            List<ShowEmployees_Result> lst = null;
            try
            {
                lst = Context.ShowEmployees().ToList<ShowEmployees_Result>();
            }
            catch (Exception)
            {
                lst = null;
            }
            return lst;
        }
        public int InsertEmployeeByStoredProcedure(string ename,int salary,int mgrid, out long id)
        {
            id = -1;
            System.Nullable<int> returnvalue = -98;
            try
            {
                var IdParameter = new ObjectParameter("Id", typeof(Int64));
                returnvalue = Context.InsertEmployee(ename, salary, mgrid, IdParameter);
                id = Convert.ToInt32(IdParameter.Value);
            }
            catch (Exception)
            {
                returnvalue = -98;
            }
            return Convert.ToInt32(returnvalue);
        }

    }
}
