using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using TORES.v1.DAL;

namespace TORES.v1.BLL
{
    // Veritabanında bulunan Toplantı odası tablosu(datOda) için uygulamanın Presentation Layer'ı (PL)
    // ve Data Access Layer'ı arasında köprü görevi görür.
    // Oda tablosuna yapılacak işlemler için yönlendirmeler yapar.

    public class hndOda
    {
        // Handle to the Employee DBAccess class
        OdaDBAccess odaDb = null;

        public hndOda()
        {
            odaDb = new OdaDBAccess();
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of employees, we can put some logic here if needed
        public List<Oda> GetOdaList()
        {
            return odaDb.GetOdaList();
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of employees, we can put some logic here if needed
        public bool UpdateOda(Oda oda)
        {
            return odaDb.UpdateOda(oda);
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of employees, we can put some logic here if needed
        public Oda GetOdalukDetails(int odaID)
        {
            return odaDb.GetOdaDetay(odaID);
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of employees, we can put some logic here if needed
        public bool DeleteOda(int odaID)
        {
            return odaDb.DeleteOda(odaID);
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of employees, we can put some logic here if needed
        public bool AddNewOda(Oda oda)
        {
            return odaDb.AddNewOda(oda);
        }

    }
}