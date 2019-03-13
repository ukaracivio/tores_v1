using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using TORES.v1.DAL;

namespace TORES.v1.BLL
{
    // Veritabanında bulunan Direktörlük tablosu(datDirektorluk) için uygulamanın Presentation Layer'ı (PL)
    // ve Data Access Layer'ı arasında köprü görevi görür.
    // Direktörlük tablosuna yapılacak işlemler için yönlendirmeler yapar.

    public class hndDirektorluk
    {
        // Handle to the Employee DBAccess class
        DirektorlukDBAccess direktorlukDb = null;

        public hndDirektorluk()
        {
            direktorlukDb = new DirektorlukDBAccess();
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of employees, we can put some logic here if needed
        public List<Direktorluk> GetDirektorlukList()
        {
            return direktorlukDb.GetDirektorlukList();
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of employees, we can put some logic here if needed
        public bool UpdateDirektorluk(Direktorluk direktorluk)
        {
            return direktorlukDb.UpdateDirektorluk(direktorluk);
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of employees, we can put some logic here if needed
        public Direktorluk GetDirektorlukDetails(int dirID)
        {
            return direktorlukDb.GetDirektorlukDetay(dirID);
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of employees, we can put some logic here if needed
        public bool DeleteDirektorluk(int dirID)
        {
            return direktorlukDb.DeleteDirektorluk(dirID);
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of employees, we can put some logic here if needed
        public bool AddNewDirektorluk(Direktorluk direktorluk)
        {
            return direktorlukDb.AddNewDirektorluk(direktorluk);
        }

    }
}