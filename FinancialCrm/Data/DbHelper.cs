using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace FinancialCrm.Data
{
    public static class DbHelper
    {
        private static readonly string ConnectionString =
            ConfigurationManager.ConnectionStrings["FinancialCrmDb"].ConnectionString;

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }

        public static int ExecuteNonQuery(string sql, params SqlParameter[] parameters)
        {
            using (var connection = GetConnection())
            using (var command = new SqlCommand(sql, connection))
            {
                if (parameters != null)
                    command.Parameters.AddRange(parameters);

                connection.Open();
                return command.ExecuteNonQuery();
            }
        }

        public static object ExecuteScalar(string sql, params SqlParameter[] parameters)
        {
            using (var connection = GetConnection())
            using (var command = new SqlCommand(sql, connection))
            {
                if (parameters != null)
                    command.Parameters.AddRange(parameters);

                connection.Open();
                return command.ExecuteScalar();
            }
        }

        public static List<T> ExecuteReader<T>(string sql, Func<IDataRecord, T> map, params SqlParameter[] parameters)
        {
            var results = new List<T>();

            using (var connection = GetConnection())
            using (var command = new SqlCommand(sql, connection))
            {
                if (parameters != null)
                    command.Parameters.AddRange(parameters);

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                        results.Add(map(reader));
                }
            }

            return results;
        }
    }
}
