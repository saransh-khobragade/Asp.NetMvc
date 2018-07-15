using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Demo1DataAccessLayer
{
    public class DataAccessLayer
    {
        SqlConnection conn;
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter da;
        public DataAccessLayer()
        {
                conn= new SqlConnection(ConfigurationManager.ConnectionStrings["Demo1"].ConnectionString);
                
        }
        public bool TestConnection()
        {
            bool status = false;
            try
            {
                conn.Open();
                status = true;
            }
            catch
            {
                status = false;
            }
            finally
            {
                conn.Close();
            }
            return status;
        }
        public bool AddEmployeeByExecuteNonQuery()
        {
            int success = -1;
            cmd = new SqlCommand("INSERT INTO Employees VALUES ('saransh3',30000,0)", conn);
            try
            {
                conn.Open();
                success = cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                success = -99;
            }
            finally
            {
                conn.Close();
            }
            if (success > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool RegisterEmpployeeInlineQuery(string ename, int salary, int mgrid)
        {
            int registrationSuccess;
            cmd = new SqlCommand("INSERT INTO Employees VALUES (@ename, @salary,@mgrid)", conn);
            cmd.Parameters.AddWithValue("@ename", ename);
            cmd.Parameters.AddWithValue("@salary", salary);
            cmd.Parameters.AddWithValue("@mgrid", mgrid);
            try
            {
                conn.Open();
                registrationSuccess = cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                registrationSuccess = -99;
            }
            finally
            {
                conn.Close();
            }
            if (registrationSuccess > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int InsertEmployeeByStoredProcedure(string ename,int salary, int mgrid,out Int64 id)
        {
            int returnValue;
            cmd = new SqlCommand("InsertEmployee", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ename", ename);
            cmd.Parameters.AddWithValue("@salary", salary);
            cmd.Parameters.AddWithValue("@mgrid", mgrid);

            SqlParameter prmOut = new SqlParameter("@id", SqlDbType.BigInt);
            prmOut.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(prmOut);

            SqlParameter prmReturn = new SqlParameter();
            prmReturn.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(prmReturn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                returnValue = Convert.ToInt32(prmReturn.Value);
                id = Convert.ToInt64(prmOut.Value);
            }
            catch (SqlException ex)
            {
                returnValue = -99;
                id = 0;
            }
            finally
            {
                conn.Close();
            }
            return returnValue;
        }

        public int FetchEmployeesCountByExecuteScalar()
        {
            int returnValue;
            cmd = new SqlCommand("SELECT COUNT(*) FROM Employees", conn);
            try
            {
                conn.Open();
                returnValue = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                returnValue = -99;
            }
            finally
            {
                conn.Close();
            }
            return returnValue;
        }

        public int CountEmployeeByExecuteScalar(string ename)
        {
            int returnValue;
            cmd = new SqlCommand("SELECT dbo.CountEmployee(@ename)", conn);
            cmd.Parameters.AddWithValue("@ename", ename);
            try
            {
                conn.Open();
                returnValue = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                returnValue = 0;
            }
            finally
            {
                conn.Close();
            }
            return returnValue;
        }

        public SqlDataReader FetchEmpoyeesByExecuteReader()
        {
            SqlDataReader drFetchCategories = null;
            try
            {
                cmd = new SqlCommand("SELECT * FROM Employees", conn);
                conn.Open();
                drFetchCategories = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                
            }
            catch (SqlException ex)
            {
                drFetchCategories = null;
            }
            //cnn.close() DOnt close connection unless reader will throw exception
            return drFetchCategories;
            
        }

        public DataTable GetEmployeeByDataAdapterDisconnected()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter daCategories = new SqlDataAdapter("SELECT * FROM Employees", conn);
                daCategories.Fill(dt);
            }
            catch (Exception)
            {
                dt = null;
            }
            return dt;
        }

        public DataTable GetEmployeesByTablevaluedFunction()
        {
            dt = new DataTable();
            try
            {
                
                cmd = new SqlCommand("SELECT * FROM Employees", conn);
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (SqlException ex)
            {
                dt = null;
            }
            return dt;
        }

    }

}
