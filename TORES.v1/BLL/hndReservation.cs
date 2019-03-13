using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using TORES.v1.DAL;

namespace TORES.v1.BLL
{
    // Veritabanında bulunan Rezervasyon tablosu(datRez) için uygulamanın Presentation Layer'ı (PL)
    // ve Data Access Layer'ı arasında köprü görevi görür.
    // Reservasyon tablosuna yapılacak işlemler için yönlendirmeler yapar.

    public class hndReservation
    {
        // Handle to the Employee DBAccess class
        ReservationDBAccess reservationDb = null;

        public hndReservation()
        {
            reservationDb = new ReservationDBAccess();
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of employees, we can put some logic here if needed
        public List<Reservation> GetReservationList()
        {
            return reservationDb.GetReservationList();
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of employees, we can put some logic here if needed
        public bool UpdateReservation(Reservation reservation)
        {
            return reservationDb.UpdateReservation(reservation);
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of employees, we can put some logic here if needed
        public Reservation GetReservationDetails(int rezID)
        {
            return reservationDb.GetRezervasyonDetay(rezID);
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of employees, we can put some logic here if needed
        public bool DeleteEmployee(int rezID)
        {
            return reservationDb.DeleteReservation(rezID);
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of employees, we can put some logic here if needed
        public bool AddNewReservation(Reservation reservation)
        {
            return reservationDb.AddNewReservation(reservation);
        }
    }
}