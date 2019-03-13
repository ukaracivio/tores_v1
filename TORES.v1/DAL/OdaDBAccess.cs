using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;
    
namespace TORES.v1.DAL
{
    // Bu class datOda tablosu ile ilgili CRUD(CreateReadUpdateDelete) işlemlerini tutar.

    public class OdaDBAccess
    {
        // Aşağıdaki fonksiyon datOda tablosuna yeni bir kayıt ekler.
        public bool AddNewOda(Oda oda)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@odaad", oda.OdaAd),
                new SqlParameter("@odamevcut", oda.OdaMevcut),
                new SqlParameter("@odaint", oda.OdaInt),
                new SqlParameter("@odaproj", oda.OdaProj),
                new SqlParameter("@odavk", oda.OdaVK)
            };

            return SQLDBHelper.ExecuteNonQuery("sp_AddOda", CommandType.StoredProcedure, parameters);
        }

        // Aşağıdaki fonksiyon datOda tablosundaki bir kayıdı günceller.
        public bool UpdateOda(Oda oda)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@odaid", oda.OdaID),
                new SqlParameter("@odaad", oda.OdaAd),
                new SqlParameter("@odamevcut", oda.OdaMevcut),
                new SqlParameter("@odaint", oda.OdaInt),
                new SqlParameter("@odaproj", oda.OdaProj),
                new SqlParameter("@odavk", oda.OdaVK)
            };

            return SQLDBHelper.ExecuteNonQuery("sp_UpdateOda", CommandType.StoredProcedure, parameters);
        }

        // Aşağıdaki fonksiyon datOda tablosundaki bir kayıdı siler.
        public bool DeleteOda(int odaID)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@odaid", odaID)
            };

            return SQLDBHelper.ExecuteNonQuery("sp_DeleteOda", CommandType.StoredProcedure, parameters);
        }

        // Aşağıdaki fonksiyon datOda tablosundaki bir kayıdın detayını getirir.
        public Oda GetOdaDetay(int odaID)
        {
            Oda oda = null;

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@odaid", odaID)
            };

            // Bütün oda kayıtları bir datatable a alınıyor
            using (DataTable table = SQLDBHelper.ExecuteParamerizedSelectCommand("sp_GetOdaDetay", CommandType.StoredProcedure, parameters))
            {
                // herhangi bir kayıt geldi mi
                if (table.Rows.Count == 1)
                {
                    DataRow row = table.Rows[0];

                    oda = new Oda();

                    oda.OdaID = Convert.ToInt32(row["OdaID"]);
                    oda.OdaAd = row["OdaAd"].ToString();
                    oda.OdaMevcut = Convert.ToInt32(row["OdaMevcut"]);
                    oda.OdaInt = Convert.ToChar(row["OdaInt"].ToString());
                    oda.OdaProj = Convert.ToChar(row["OdaProj"].ToString());
                    oda.OdaVK = Convert.ToChar(row["OdaVK"].ToString());
                }
            }

            return oda;
        }

        // Aşağıdaki fonksiyon datOda tablosundaki tüm kayıtları getirir.
        public List<Oda> GetOdaList()
        {
            List<Oda> listOda = null;

            using (DataTable table = SQLDBHelper.ExecuteSelectCommand("sp_GetOdaList", CommandType.StoredProcedure))
            {

                if (table.Rows.Count > 0)
                {
                    listOda = new List<Oda>();

                    foreach (DataRow row in table.Rows)
                    {
                        Oda oda = new Oda();

                        oda.OdaID = Convert.ToInt32(row["OdaID"]);
                        oda.OdaAd = row["OdaAd"].ToString();
                        oda.OdaMevcut = Convert.ToInt32(row["OdaMevcut"]);
                        oda.OdaInt = Convert.ToChar(row["OdaInt"].ToString());
                        oda.OdaProj = Convert.ToChar(row["OdaProj"].ToString());
                        oda.OdaVK = Convert.ToChar(row["OdaVK"].ToString());

                        listOda.Add(oda);
                    }
                }
            }

            return listOda;
        }

    }
}