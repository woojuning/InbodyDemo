using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Connect
{
    public static class Connection
    {
        public static IDbConnection con;

        public static void Open()
        {
            string constr = null;

            if (con != null && con.State == ConnectionState.Open) return;

            if (con != null && con.State != ConnectionState.Open)
            {
                con.Open();
                return;
            }

            try
            {
                constr = @"Data Source=DESKTOP-RPM0BBL\SQLEXPRESS;Initial Catalog=Inbody;Integrated Security=True;Encrypt=False";
            }
            catch (Exception ex)
            {
                throw ex;
            }

            con = new SqlConnection(constr);
            if (con.State != ConnectionState.Open) con.Open(); 
        }

        public static IDbTransaction BeginTransaction()
        {
            return con.BeginTransaction();
        }

        public static void Commit(IDbTransaction transaction)
        {
            transaction.Commit();
        }

        public static void Rollback(IDbTransaction transaction)
        {
            transaction.Rollback();
        }

        public static void Close()
        {
            if (con == null) return;
            if (con.State == ConnectionState.Open) con.Close();
        }

        public static int Execute(string sql, DynamicParameters parameters = null, IDbTransaction transaction = null,
            CommandType? commandType = null)
        {
            int cnt = 0;

            if (transaction == null)
                Open();

            cnt = con.Execute(sql, parameters, transaction: transaction, commandType: commandType);

            if (transaction == null)
                Close();

            return cnt;
        }

        public static int ExecuteScalar(string sql, DynamicParameters parameters = null, IDbTransaction transaction = null,
         CommandType? commandType = null)
        {
            if (transaction == null)
                Open();

            var result = con.ExecuteScalar<int>(sql, parameters, transaction: transaction, commandType: commandType);

            if (transaction == null)
                Close();

            return result;
        }

        public static T QueryFirstOrDefault<T>(string sql, DynamicParameters parameters = null, IDbTransaction transaction = null,
            CommandType? commandType = null)
        {
            if (transaction == null)
                Open();

            var result = con.QueryFirstOrDefault<T>(sql, parameters, transaction: transaction, commandType: commandType);

            if (transaction == null)
                Close();

            return result;
        }

        public static List<T> Query<T>(string sql, DynamicParameters parameters = null, IDbTransaction transaction = null,
            CommandType? commandType = null)
        {
            List<T> Lists = new List<T>();

            if (transaction == null)
                Open();

            Lists = con.Query<T>(sql, parameters, transaction: transaction, commandType: commandType).ToList();

            if (transaction == null)
                Close();

            return Lists;
        }

        public static bool IsConnection()
        {
            return con.State == ConnectionState.Open;
        }
    }
}
