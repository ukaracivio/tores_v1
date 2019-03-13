using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using TORES.v1.DAL;

namespace TORES.v1.BLL
{
    // Veritabanında bulunan Personel tablosu(datPersonel) için uygulamanın Presentation Layer'ı (PL)
    // ve Data Access Layer'ı arasında köprü görevi görür.
    // Personel tablosuna yapılacak işlemler için yönlendirmeler yapar.

    public class hndPersonel
    {
        // Handle to the Employee DBAccess class
        PersonelDBAccess personelDb = null;

        public hndPersonel()
        {
            personelDb = new PersonelDBAccess();
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of employees, we can put some logic here if needed
        public List<Personel> GetPersonelList()
        {
            return personelDb.GetPersonelList();
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of employees, we can put some logic here if needed
        public bool UpdatePersonel(Personel personel)
        {
            return personelDb.UpdatePersonel(personel);
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of employees, we can put some logic here if needed
        public Personel GetPersonelDetails(int persID)
        {
            return personelDb.GetPersonelDetay(persID);
        }

        // Aşağıdaki fonksiyon login bilgilerini girmiş olan kullanıcının
        // varlığını kontrol eder.Varsa gerekli bilgilerini alır.
        public bool PersonelLoginControl(string kulad,string kulsifre)
        {
            return personelDb.PersonelLoginControl(kulad,kulsifre);
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of employees, we can put some logic here if needed
        public bool DeletePersonel(int persID)
        {
            return personelDb.DeletePersonel(persID);
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of employees, we can put some logic here if needed
        public bool AddNewPersonel(Personel personel)
        {
            return personelDb.AddNewPersonel(personel);
        }

    }
}