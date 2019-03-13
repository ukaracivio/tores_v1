using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;

namespace TORES.v1.DAL
{
    // Bu class datDirektorluk tablosu ile ilgili CRUD(CreateReadUpdateDelete) işlemlerini tutar.

    public class DirektorlukDBAccess
    {
        // Aşağıdaki fonksiyon datDirektorluk tablosuna yeni bir kayıt ekler.
        public bool AddNewDirektorluk(Direktorluk direktorluk)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@dirtnm", direktorluk.DirTnm)
            };

            return SQLDBHelper.ExecuteNonQuery("sp_AddDirektorluk", CommandType.StoredProcedure, parameters);
        }

        // Aşağıdaki fonksiyon datDirektorluk tablosundaki bir kayıdı günceller.
        public bool UpdateDirektorluk(Direktorluk direktorluk)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@dirid", direktorluk.DirID),
                new SqlParameter("@dirtnm", direktorluk.DirTnm)
            };

            return SQLDBHelper.ExecuteNonQuery("sp_UpdateDirektorluk", CommandType.StoredProcedure, parameters);
        }

        // Aşağıdaki fonksiyon datDirektorluk tablosundan bir kayıt siler.
        public bool DeleteDirektorluk(int dirID)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@dirid", dirID)
            };

            return SQLDBHelper.ExecuteNonQuery("sp_DeleteDirektorluk", CommandType.StoredProcedure, parameters);
        }

        // Aşağıdaki fonksiyon datDirektorluk tablosundan bir kayıdın detayını getirir.
        public Direktorluk GetDirektorlukDetay(int dirID)
        {
            Direktorluk direktorluk = null;

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@dirid", dirID)
            };

            // Bütün direktörlük kayıtları bir datatable a alınıyor
            using (DataTable table = SQLDBHelper.ExecuteParamerizedSelectCommand("sp_GetDirektorlukDetay", CommandType.StoredProcedure, parameters))
            {
                // herhangi bir kayıt geldi mi
                if (table.Rows.Count == 1)
                {
                    DataRow row = table.Rows[0];

                    direktorluk = new Direktorluk();

                    direktorluk.DirID = Convert.ToInt32(row["DirID"]);
                    direktorluk.DirTnm = row["DirTnm"].ToString();
                }
            }

            return direktorluk;
        }

        // Aşağıdaki fonksiyon datDirektorluk tablosundaki tüm kayıtları getirir.
        public List<Direktorluk> GetDirektorlukList()
        {
            List<Direktorluk> listDirektorluk = null;

            using (DataTable table = SQLDBHelper.ExecuteSelectCommand("sp_GetDirektorlukList", CommandType.StoredProcedure))
            {

                if (table.Rows.Count > 0)
                {
                    listDirektorluk = new List<Direktorluk>();

                    foreach (DataRow row in table.Rows)
                    {
                        Direktorluk direktorluk = new Direktorluk();

                        direktorluk.DirID = Convert.ToInt32(row["DirID"]);
                        direktorluk.DirTnm = row["DirTnm"].ToString();

                        listDirektorluk.Add(direktorluk);
                    }
                }
            }

            return listDirektorluk;
        }

    }
}