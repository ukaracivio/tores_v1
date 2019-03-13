using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;

namespace TORES.v1.DAL
{
    // Bu class datPersonel tablosu ile ilgili CRUD(CreateReadUpdateDelete) işlemlerini tutar.

    public class PersonelDBAccess
    {
        // Aşağıdaki fonksiyon datPersonel tablosuna yeni bir kayıt ekler.
        public bool AddNewPersonel(Personel personel)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@persad", personel.PersAd),
                new SqlParameter("@perssoyad", personel.PersSoyad),
                new SqlParameter("@persdirid", personel.PersDirID),
                new SqlParameter("@perstip", personel.PersTip),
                new SqlParameter("@persgtz", personel.PersGTZ),
                new SqlParameter("@persctz", personel.PersCTZ),
                new SqlParameter("@persuid", personel.PersUID),
                new SqlParameter("@perspass", personel.PersPass),
            };

            return SQLDBHelper.ExecuteNonQuery("sp_AddPersonel", CommandType.StoredProcedure, parameters);
        }

        // Aşağıdaki fonksiyon datPersonel tablosundaki bir kayıdı günceller.
        public bool UpdatePersonel(Personel personel)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@persid", personel.PersGTZ),
                new SqlParameter("@persad", personel.PersAd),
                new SqlParameter("@perssoyad", personel.PersSoyad),
                new SqlParameter("@persdirid", personel.PersDirID),
                new SqlParameter("@perstip", personel.PersTip),
                new SqlParameter("@persgtz", personel.PersGTZ),
                new SqlParameter("@persctz", personel.PersCTZ),
                new SqlParameter("@persuid", personel.PersUID),
                new SqlParameter("@perspass", personel.PersPass),
            };

            return SQLDBHelper.ExecuteNonQuery("sp_UpdatePersonel", CommandType.StoredProcedure, parameters);
        }

        // Aşağıdaki fonksiyon datPersonel tablosundan bir kayıt siler.
        public bool DeletePersonel(int persID)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@persid", persID)
            };

            return SQLDBHelper.ExecuteNonQuery("sp_DeletePersonel", CommandType.StoredProcedure, parameters);
        }

        // Aşağıdaki fonksiyon datPersonel tablosundan ilgili kaydın detayını getirir.
        public Personel GetPersonelDetay(int persID)
        {
            Personel personel = null;

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@persid", persID)
            };

            // Bütün personel listesi bir datatable a alınıyor
            using (DataTable table = SQLDBHelper.ExecuteParamerizedSelectCommand("sp_GetPersonelDetay", CommandType.StoredProcedure, parameters))
            {
                // herhangi bir kayıt geldi mi
                if (table.Rows.Count == 1)
                {
                    DataRow row = table.Rows[0];

                    personel = new Personel();

                    personel.PersID = Convert.ToInt32(row["PersID"]);
                    personel.PersAd = row["PersAd"].ToString();
                    personel.PersSoyad = row["PersSoyad"].ToString();
                    personel.PersDirID = Convert.ToInt32(row["PersDirID"]);
                    personel.PersTip = row["PersTip"].ToString();
                    personel.PersGTZ = row["PersGTZ"].ToString();
                    personel.PersCTZ = row["PersCTZ"].ToString();
                    personel.PersUID = row["PersUID"].ToString();
                    personel.PersPass = row["PersPass"].ToString();
                }
            }

            return personel;
        }

        // Aşağıdaki fonksiyon datPersonel tablosundaki tüm kayıtları getirir.
        public List<Personel> GetPersonelList()
        {
            List<Personel> listPersonel = null;

            using (DataTable table = SQLDBHelper.ExecuteSelectCommand("sp_GetPersonelList", CommandType.StoredProcedure))
            {

                if (table.Rows.Count > 0)
                {
                    listPersonel = new List<Personel>();

                    foreach (DataRow row in table.Rows)
                    {
                        Personel personel = new Personel();

                        personel.PersID = Convert.ToInt32(row["PersID"]);
                        personel.PersAd = row["PersAd"].ToString();
                        personel.PersSoyad = row["PersSoyad"].ToString();
                        personel.PersDirID = Convert.ToInt32(row["PersDirID"]);
                        personel.PersTip = row["PersTip"].ToString();
                        personel.PersGTZ = row["PersGTZ"].ToString();
                        personel.PersCTZ = row["PersCTZ"].ToString();
                        personel.PersUID = row["PersUID"].ToString();
                        personel.PersPass = row["PersPass"].ToString();

                        listPersonel.Add(personel);
                    }
                }
            }

            return listPersonel;
        }

        // Aşağıdaki fonksiyon datPersonel tablosundan Login bilgilerine göre araştırma yapar.
        public bool PersonelLoginControl(string KulAd,string KulSifre)
        {
            Personel personel = null;

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@kulad", KulAd),
                new SqlParameter("@kulsifre", KulSifre),
            };

            // Bütün personel listesi bir datatable a alınıyor
            using (DataTable table = SQLDBHelper.ExecuteParamerizedSelectCommand("sp_GetUserLogin", CommandType.StoredProcedure, parameters))
            {
                // herhangi bir kayıt geldi mi
                if (table.Rows.Count == 1)
                {
                    DataRow row = table.Rows[0];

                    personel = new Personel();


                    personel.PersID = Convert.ToInt32(row["PersID"]);
                    personel.PersAd = row["PersAd"].ToString();
                    personel.PersSoyad = row["PersSoyad"].ToString();
                    personel.PersDirTnm = row["DirTnm"].ToString();
                    personel.PersTip = row["PersTip"].ToString();

                    clsGlobalVPF.PersID = Convert.ToInt32(row["PersID"]);
                    clsGlobalVPF.PersAd = row["PersAd"].ToString();
                    clsGlobalVPF.PersSoyad = row["PersSoyad"].ToString();
                    clsGlobalVPF.PersDirTnm = row["DirTnm"].ToString();
                    clsGlobalVPF.PersTip = row["PersTip"].ToString();

                    return true;
                }
                else
                    return false;
            }

        }

    }
}