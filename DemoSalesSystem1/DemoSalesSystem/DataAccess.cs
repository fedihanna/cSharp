using System;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using System.IO;

namespace DemoSalesSystem
{
    class DataAccess
    {
        static string path =  "E:\\IT COURSE 2015-16 (PART 4)\\PROG 2500 Andrew Mooney\\DemoSalesSystem1\\DemoSalesSystem";
        static string connString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=" + path + "\\Database.mdf;Integrated Security=True";

        #region Sql Object Methods

        public static SqlConnection GetConnection(string connectionString)
        {
            SqlConnection sqlConn = new SqlConnection(connectionString);
            return sqlConn;
        }

        public static SqlConnection GetConnection()
        {
            SqlConnection sqlConn = GetConnection(DefaultConnectionString());
            return sqlConn;
        }

        public static SqlCommand GetCommand(string storedProc, string connectionString)
        {
            SqlCommand sqlCommand = new SqlCommand(storedProc, GetConnection(connectionString));
            return sqlCommand;
        }

        public static SqlCommand GetCommand(string storedProc)
        {
            SqlCommand sqlCommand = GetCommand(storedProc, DefaultConnectionString());
            return sqlCommand;
        }

        public static SqlCommand GetStoredProcCommand(string storedProc, List<SqlParameter> commandParameters, string connectionString)
        {
            SqlCommand sqlCommand = GetCommand(storedProc, connectionString);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.AttachParameters(commandParameters);
            return sqlCommand;
        }

        public static SqlCommand GetStoredProcCommand(string storedProc, SqlParameter commandParameter, string connectionString)
        {
            SqlCommand sqlCommand = GetCommand(storedProc, connectionString);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add(commandParameter);
            return sqlCommand;
        }

        public static SqlCommand GetStoredProcCommand(string storedProc, string connectionString)
        {
            SqlCommand sqlCommand = GetCommand(storedProc, connectionString);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            return sqlCommand;
        }

        public static SqlCommand GetStoredProcCommand(string storedProc, List<SqlParameter> commandParameters)
        {
            SqlCommand sqlCommand = GetCommand(storedProc);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.AttachParameters(commandParameters);
            return sqlCommand;
        }

        public static SqlCommand GetStoredProcCommand(string storedProc, SqlParameter commandParameter)
        {
            SqlCommand sqlCommand = GetCommand(storedProc);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add(commandParameter);
            return sqlCommand;
        }

        public static SqlCommand GetStoredProcCommand(string storedProc)
        {
            SqlCommand sqlCommand = GetCommand(storedProc);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            return sqlCommand;
        }

        #endregion

        #region Connection String Methods

        /// <summary>
        /// Modified
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetConnectionString()
        {
            return connString;
        }

        private static string DefaultConnectionString()
        {
            return GetConnectionString();
        }

        #endregion

        #region ExecuteScalar

        public static object ExecuteScalar(string storedProc, string connectionString)
        {
            SqlCommand sqlCommand = GetStoredProcCommand(storedProc, connectionString);
            return ExecuteScalar(sqlCommand);
        }

        public static object ExecuteScalar(string storedProc, SqlParameter commandParameter, string connectionString)
        {
            SqlCommand sqlCommand = GetStoredProcCommand(storedProc, commandParameter, connectionString);
            return ExecuteScalar(sqlCommand);
        }

        public static object ExecuteScalar(string storedProc, List<SqlParameter> commandParameters, string connectionString)
        {
            SqlCommand sqlCommand = GetStoredProcCommand(storedProc, commandParameters, connectionString);
            return ExecuteScalar(sqlCommand);
        }

        public static object ExecuteScalar(string storedProc)
        {
            SqlCommand sqlCommand = GetStoredProcCommand(storedProc);
            return ExecuteScalar(sqlCommand);
        }

        public static object ExecuteScalar(string storedProc, SqlParameter commandParameter)
        {
            SqlCommand sqlCommand = GetStoredProcCommand(storedProc, commandParameter);
            return ExecuteScalar(sqlCommand);
        }

        public static object ExecuteScalar(string storedProc, List<SqlParameter> commandParameters)
        {
            SqlCommand sqlCommand = GetStoredProcCommand(storedProc, commandParameters);
            return ExecuteScalar(sqlCommand);
        }

        private static object ExecuteScalar(SqlCommand sqlCommand)
        {
            Object scalarResult;
            sqlCommand.Connection.Open();
            scalarResult = sqlCommand.ExecuteScalar();
            sqlCommand.Connection.Close();
            sqlCommand.Parameters.Clear();// added line
            return scalarResult;
        }

        #endregion

        #region ExecuteNonquery

        public static void ExecuteNonquery(string storedProc, SqlParameter commandParameter, string connectionString)
        {
            SqlCommand sqlCommand = GetStoredProcCommand(storedProc, commandParameter, connectionString);
            sqlCommand.Connection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlCommand.Connection.Close();
        }

        public static void ExecuteNonquery(string storedProc, SqlParameter commandParameter)
        {
            SqlCommand sqlCommand = GetStoredProcCommand(storedProc, commandParameter);
            sqlCommand.Connection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlCommand.Connection.Close();
        }

        public static void ExecuteNonquery(string storedProc, List<SqlParameter> commandParameters, string connectionString)
        {
            SqlCommand sqlCommand = GetStoredProcCommand(storedProc, commandParameters, connectionString);
            sqlCommand.Connection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlCommand.Connection.Close();
        }

        public static void ExecuteNonquery(string storedProc, List<SqlParameter> commandParameters)
        {
            SqlCommand sqlCommand = GetStoredProcCommand(storedProc, commandParameters);
            sqlCommand.Connection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlCommand.Connection.Close();
        }

        #endregion

        #region ExecuteReader

        public static SqlDataReader ExecuteReader(string storedProc, List<SqlParameter> commandParameters, string connectionString)
        {
            SqlCommand sqlCommand = GetStoredProcCommand(storedProc, commandParameters, connectionString);
            sqlCommand.Connection.Open();
            return sqlCommand.ExecuteReader();
        }

        public static SqlDataReader ExecuteReader(string storedProc, SqlParameter commandParameter, string connectionString)
        {
            SqlCommand sqlCommand = GetStoredProcCommand(storedProc, commandParameter, connectionString);
            sqlCommand.Connection.Open();
            return sqlCommand.ExecuteReader();
        }

        public static SqlDataReader ExecuteReader(string storedProc, string connectionString)
        {
            SqlCommand sqlCommand = GetStoredProcCommand(storedProc, connectionString);
            sqlCommand.Connection.Open();
            return sqlCommand.ExecuteReader();
        }

        public static SqlDataReader ExecuteReader(string storedProc, List<SqlParameter> commandParameters)
        {
            SqlCommand sqlCommand = GetStoredProcCommand(storedProc, commandParameters);
            sqlCommand.Connection.Open();
            return sqlCommand.ExecuteReader();
        }

        public static SqlDataReader ExecuteReader(string storedProc, SqlParameter commandParameter)
        {
            SqlCommand sqlCommand = GetStoredProcCommand(storedProc, commandParameter);
            sqlCommand.Connection.Open();
            return sqlCommand.ExecuteReader();
        }

        public static SqlDataReader ExecuteReader(string storedProc)
        {
            SqlCommand sqlCommand = GetStoredProcCommand(storedProc);
            sqlCommand.Connection.Open();
            return sqlCommand.ExecuteReader();
        }

        #endregion

        #region Fill DataSet methods

        public static void FillDataSet(string storedProc, List<SqlParameter> commandParameters, DataSet dataSet, string connectionString)
        {
            SqlCommand sqlCommand = GetStoredProcCommand(storedProc, commandParameters, connectionString);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            dataAdapter.Fill(dataSet);
            sqlCommand.Connection.Close();
        }

        public static void FillDataSet(string storedProc, SqlParameter commandParameter, DataSet dataSet, string connectionString)
        {
            SqlCommand sqlCommand = GetStoredProcCommand(storedProc, commandParameter, connectionString);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            dataAdapter.Fill(dataSet);
            sqlCommand.Connection.Close();
        }

        public static void FillDataSet(string storedProc, DataSet dataSet, string connectionString)
        {
            SqlCommand sqlCommand = GetStoredProcCommand(storedProc, connectionString);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            dataAdapter.Fill(dataSet);
            sqlCommand.Connection.Close();
        }

        public static void FillDataSet(string storedProc, List<SqlParameter> commandParameters, DataSet dataSet)
        {
            SqlCommand sqlCommand = GetStoredProcCommand(storedProc, commandParameters);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            dataAdapter.Fill(dataSet);
            sqlCommand.Connection.Close();
        }

        public static void FillDataSet(string storedProc, SqlParameter commandParameter, DataSet dataSet)
        {
            SqlCommand sqlCommand = GetStoredProcCommand(storedProc, commandParameter);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            dataAdapter.Fill(dataSet);
            sqlCommand.Connection.Close();
        }

        public static void FillDataSet(string storedProc, DataSet dataSet)
        {
            SqlCommand sqlCommand = GetStoredProcCommand(storedProc);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            dataAdapter.Fill(dataSet);
            sqlCommand.Connection.Close();
        }

        #endregion

        #region Fill DataTable methods

        public static void FillDataTable(string storedProc, List<SqlParameter> commandParameters, DataTable dataTable, string connectionString)
        {
            SqlCommand sqlCommand = GetStoredProcCommand(storedProc, commandParameters, connectionString);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            dataAdapter.Fill(dataTable);
            sqlCommand.Connection.Close();
        }

        public static void FillDataTable(string storedProc, SqlParameter commandParameter, DataTable dataTable, string connectionString)
        {
            SqlCommand sqlCommand = GetStoredProcCommand(storedProc, commandParameter, connectionString);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            dataAdapter.Fill(dataTable);
            sqlCommand.Connection.Close();
        }

        public static void FillDataTable(string storedProc, DataTable dataTable, string connectionString)
        {
            SqlCommand sqlCommand = GetStoredProcCommand(storedProc, connectionString);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            dataAdapter.Fill(dataTable);
            sqlCommand.Connection.Close();
        }

        public static void FillDataTable(string storedProc, List<SqlParameter> commandParameters, DataTable dataTable)
        {
            SqlCommand sqlCommand = GetStoredProcCommand(storedProc, commandParameters);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            dataAdapter.Fill(dataTable);
            sqlCommand.Connection.Close();
        }

        public static void FillDataTable(string storedProc, SqlParameter commandParameter, DataTable dataTable)
        {
            SqlCommand sqlCommand = GetStoredProcCommand(storedProc, commandParameter);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            dataAdapter.Fill(dataTable);
            sqlCommand.Connection.Close();
        }

        public static void FillDataTable(string storedProc, DataTable dataTable)
        {
            SqlCommand sqlCommand = GetStoredProcCommand(storedProc);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            dataAdapter.Fill(dataTable);
            sqlCommand.Connection.Close();
        }

        #endregion

        #region Get DataTable methods

        public static DataTable GetDataTable(string storedProc, List<SqlParameter> commandParameters, string connectionString)
        {
            DataTable dtResults = new DataTable();
            FillDataTable(storedProc, commandParameters, dtResults, connectionString);
            return dtResults;
        }

        public static DataTable GetDataTable(string storedProc, SqlParameter commandParameter, string connectionString)
        {
            DataTable dtResults = new DataTable();
            FillDataTable(storedProc, commandParameter, dtResults, connectionString);
            return dtResults;
        }

        public static DataTable GetDataTable(string storedProc, string connectionString)
        {
            DataTable dtResults = new DataTable();
            FillDataTable(storedProc, dtResults, connectionString);
            return dtResults;
        }

        public static DataTable GetDataTable(string storedProc, List<SqlParameter> commandParameters)
        {
            DataTable dtResults = new DataTable();
            FillDataTable(storedProc, commandParameters, dtResults);
            return dtResults;
        }

        public static DataTable GetDataTable(string storedProc, SqlParameter commandParameter)
        {
            DataTable dtResults = new DataTable();
            FillDataTable(storedProc, commandParameter, dtResults);
            return dtResults;
        }

        public static DataTable GetDataTable(string storedProc)
        {
            DataTable dtResults = new DataTable();
            FillDataTable(storedProc, dtResults);
            return dtResults;
        }

        #endregion

        #region Get DataSet methods

        public static DataSet GetDataSet(string storedProc, List<SqlParameter> commandParameters, string connectionString)
        {
            DataSet dsResults = new DataSet();
            FillDataSet(storedProc, commandParameters, dsResults, connectionString);
            return dsResults;
        }

        public static DataSet GetDataSet(string storedProc, SqlParameter commandParameter, string connectionString)
        {
            DataSet dsResults = new DataSet();
            FillDataSet(storedProc, commandParameter, dsResults, connectionString);
            return dsResults;
        }

        public static DataSet GetDataSet(string storedProc, string connectionString)
        {
            DataSet dsResults = new DataSet();
            FillDataSet(storedProc, dsResults, connectionString);
            return dsResults;
        }

        public static DataSet GetDataSet(string storedProc, List<SqlParameter> commandParameters)
        {
            DataSet dsResults = new DataSet();
            FillDataSet(storedProc, commandParameters, dsResults);
            return dsResults;
        }

        public static DataSet GetDataSet(string storedProc, SqlParameter commandParameter)
        {
            DataSet dsResults = new DataSet();
            FillDataSet(storedProc, commandParameter, dsResults);
            return dsResults;
        }

        public static DataSet GetDataSet(string storedProc)
        {
            DataSet dsResults = new DataSet();
            FillDataSet(storedProc, dsResults);
            return dsResults;
        }

        #endregion

    }

    internal static class SqlDatabaseExtensions
    {
        public static void AttachParameters(this SqlCommand command, List<SqlParameter> commandParameters)
        {

            //command.Parameters.Clear();

            command.Parameters.AddRange(commandParameters.ToArray()); //new line

            //if (commandParameters != null)
            //{
            //    foreach (SqlParameter p in commandParameters)
            //    {
            //        if (p != null)
            //        {
            //            // Check for derived output value with no value assigned 
            //            if ((p.Direction == ParameterDirection.InputOutput ||
            //                p.Direction == ParameterDirection.Input) &&
            //                (p.Value == null))
            //            {
            //                p.Value = DBNull.Value;
            //            }
            //            command.Parameters.Add(p);
            //        }
            //    }
            //}
        }
    }
}