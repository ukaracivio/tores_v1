using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;

namespace TORES.v1.DAL
{
    public class SQLDBHelper
    {

        // Bu fonksiyon herhangi bir parametreye sahip OLMAYAN R (CRUD) operasyonunu gerçekleştirir.
        internal static DataTable ExecuteSelectCommand(string CommandName, CommandType cmdType)
        {
            DataTable table = null;
            using (SqlConnection con = new SqlConnection(clsGlobalVPF.ConnStr))
            {
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandType = cmdType;
                    cmd.CommandText = CommandName;

                    try
                    {
                        if (con.State != ConnectionState.Open)
                        {
                            con.Open();
                        }

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            table = new DataTable();
                            da.Fill(table);
                        }
                    }
                    catch
                    {
                        throw;
                    }
                }
            }

            return table;
        }

        // Bu fonksiyon PARAMETRELİ R (CRUD) operasyonunu gerçekleştirir.
        internal static DataTable ExecuteParamerizedSelectCommand(string CommandName, CommandType cmdType, SqlParameter[] param)
        {
            DataTable table = new DataTable();

            using (SqlConnection con = new SqlConnection(clsGlobalVPF.ConnStr))
            {
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandType = cmdType;
                    cmd.CommandText = CommandName;
                    cmd.Parameters.AddRange(param);

                    try
                    {
                        if (con.State != ConnectionState.Open)
                        {
                            con.Open();
                        }

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(table);
                        }
                    }
                    catch
                    {
                        throw;
                    }
                }
            }

            return table;
        }

        // Bu fonksiyon PARAMETRELİ CUD (CRUD) operasyonunu gerçekleştirir.
        internal static bool ExecuteNonQuery(string CommandName, CommandType cmdType, SqlParameter[] pars)
        {
            int result = 0;

            using (SqlConnection con = new SqlConnection(clsGlobalVPF.ConnStr))
            {
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandType = cmdType;
                    cmd.CommandText = CommandName;
                    cmd.Parameters.AddRange(pars);

                    try
                    {
                        if (con.State != ConnectionState.Open)
                        {
                            con.Open();
                        }

                        result = cmd.ExecuteNonQuery();
                    }
                    catch
                    {
                        throw;
                    }
                }
            }

            return (result > 0);
        }

    }
}