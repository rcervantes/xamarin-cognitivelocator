﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CognitiveLocatorDAL.Comunes
{
    public class Sql
    {
        public IEnumerable<dynamic> RunStoredProcParams(string cnn, string sql, SqlParameter[] parameters = null)
        {
            SqlConnection conn = null;
            SqlDataReader rdr = null;
            IEnumerable<dynamic> data = default(IEnumerable<dynamic>);

            Console.WriteLine("\nCustomer Order History:\n");

            try
            {
                conn = new
                    SqlConnection(cnn);
                conn.Open();

                SqlCommand cmd = new SqlCommand(
                    sql, conn);

                cmd.CommandType = CommandType.StoredProcedure;

                if (parameters != null)
                {
                    foreach (var param in parameters)
                    {
                        cmd.Parameters.Add(param);
                    }
                }

                rdr = cmd.ExecuteReader();

                data = rdr.Cast<IDataRecord>().ToList();
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
                if (rdr != null)
                {
                    rdr.Close();
                }
            }
            return data;
        }
    }
}
