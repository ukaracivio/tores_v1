using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;

namespace TORES.v1.DAL
{
    // Bu class datRez tablosu ile ilgili CRUD(CreateReadUpdateDelete) işlemlerini tutar.

    public class ReservationDBAccess
    {
        // Aşağıdaki fonksiyon datRez tablosuna yeni bir kayıt ekler.
        public bool AddNewReservation(Reservation reservation)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@dirid", reservation.DirID),
                new SqlParameter("@odaid", reservation.OdaID),
                new SqlParameter("@konu", reservation.Konu),
                new SqlParameter("@reztrh", reservation.RezTrh),
                new SqlParameter("@rezbaszaman", reservation.RezBasZaman),
                new SqlParameter("@rezbitzaman", reservation.RezBitZaman),
                new SqlParameter("@reznbh", reservation.RezNBH),
                new SqlParameter("@rezypersid", reservation.RezYPersID),
                new SqlParameter("@rezytrh", reservation.RezYTrh)
            };

            return SQLDBHelper.ExecuteNonQuery("sp_AddReservation", CommandType.StoredProcedure, parameters);
        }

        // Aşağıdaki fonksiyon datRez tablosundaki kayıdı günceller.
        public bool UpdateReservation(Reservation reservation)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@rezid", reservation.RezID),
                new SqlParameter("@dirid", reservation.DirID),
                new SqlParameter("@odaid", reservation.OdaID),
                new SqlParameter("@konu", reservation.Konu),
                new SqlParameter("@reztrh", reservation.RezTrh),
                new SqlParameter("@rezbaszaman", reservation.RezBasZaman),
                new SqlParameter("@rezbitzaman", reservation.RezBitZaman),
                new SqlParameter("@reznbh", reservation.RezNBH),
                new SqlParameter("@rezypersid", reservation.RezYPersID),
                new SqlParameter("@rezytrh", reservation.RezYTrh)
            };

            return SQLDBHelper.ExecuteNonQuery("sp_UpdateReservation", CommandType.StoredProcedure, parameters);
        }

        // Aşağıdaki fonksiyon datRez tablosundan bir kayıt siler.
        public bool DeleteReservation(int rezID)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@rezid", rezID)
            };

            return SQLDBHelper.ExecuteNonQuery("sp_DeleteReservation", CommandType.StoredProcedure, parameters);
        }

        // Aşağıdaki fonksiyon datRez tablosundaki bir kayıdın detayını getirir.
        public Reservation GetRezervasyonDetay(int rezID)
        {
            Reservation reservation = null;

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@rezid", rezID)
            };

            // Bütün rezervasyon kayıtları bir datatable a alınıyor
            using (DataTable table = SQLDBHelper.ExecuteParamerizedSelectCommand("sp_GetRezervasyonDetay", CommandType.StoredProcedure, parameters))
            {
                // herhangi bir kayıt geldi mi
                if (table.Rows.Count == 1)
                {
                    DataRow row = table.Rows[0];

                    reservation = new Reservation();

                    reservation.RezID = Convert.ToInt32(row["RezID"]);
                    reservation.DirID = Convert.ToInt32(row["DirID"]);
                    reservation.OdaID = Convert.ToInt32(row["OdaID"]);
                    reservation.Konu = row["Konu"].ToString();
                    reservation.RezTrh = row["RezTrh"].ToString();
                    reservation.RezBasZaman = row["RezBasZaman"].ToString();
                    reservation.RezBitZaman = row["RezBitZaman"].ToString();
                    reservation.RezNBH = Convert.ToInt32(row["RezNBH"]);
                    reservation.RezYPersID = Convert.ToInt32(row["RezYPersID"]);
                    reservation.RezYTrh = row["RezYTrh"].ToString();
                }
            }

            return reservation;
        }

        // Aşağıdaki fonksiyon datRez tablosundaki tüm kayıtları getirir.
        public List<Reservation> GetReservationList()
        {
            List<Reservation> listReservation = null;

            using (DataTable table = SQLDBHelper.ExecuteSelectCommand("sp_GetReservationList", CommandType.StoredProcedure))
            {

                if (table.Rows.Count > 0)
                {
                    listReservation = new List<Reservation>();

                    foreach (DataRow row in table.Rows)
                    {
                        Reservation reservation = new Reservation();

                        reservation.RezID = Convert.ToInt32(row["RezID"]);
                        reservation.DirID = Convert.ToInt32(row["DirID"]);
                        reservation.OdaID = Convert.ToInt32(row["OdaID"]);
                        reservation.Konu = row["Konu"].ToString();
                        reservation.RezTrh = row["RezTrh"].ToString();
                        reservation.RezBasZaman = row["RezBasZaman"].ToString();
                        reservation.RezBitZaman = row["RezBitZaman"].ToString();
                        reservation.RezNBH = Convert.ToInt32(row["RezNBH"]);
                        reservation.RezYPersID = Convert.ToInt32(row["RezYPersID"]);
                        reservation.RezYTrh = row["RezYTrh"].ToString();

                        listReservation.Add(reservation);
                    }
                }
            }

            return listReservation;
        }

    }
}