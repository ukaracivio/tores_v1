using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Configuration;

namespace TORES.v1
{
    // Bu class uygulamanın genelinde kullanılacak değerleri saklamak için yaratılmıştır
    //

    public static class clsGlobalVPF
    {
        static string _connStr;
        static int _persID;
        static string _persAd;
        static string _persSoyad;
        static string _persDirTnm;
        static string _persTip;

        public static string ConnStr
        {
            get{ return _connStr; }
            set{ _connStr = value; }
        }

        public static int PersID
        {
            get { return _persID; }
            set { _persID = value; }
        }

        public static string PersAd
        {
            get { return _persAd; }
            set { _persAd = value; }
        }

        public static string PersSoyad
        {
            get { return _persSoyad; }
            set { _persSoyad = value; }
        }

        public static string PersDirTnm
        {
            get { return _persDirTnm; }
            set { _persDirTnm = value; }
        }

        public static string PersTip
        {
            get { return _persTip; }
            set { _persTip = value; }
        }

        // Aşağıdaki fonksiyon gelen tarih bilgisini yyyyaagg string formatına çevirir
        public static string ConvertDateToString(DateTime _datetime)
        {
            string yil, ay, gun;
            string yag;

            yil = _datetime.Year.ToString();
            ay = _datetime.Month.ToString();
            gun = _datetime.Day.ToString();

            if (ay.Length <2)
            {
                ay = "0" + ay;
            }

            if (gun.Length < 2)
            {
                gun = "0" + gun;
            }

            yag = yil+ay+gun;

            return yag;

        }

    }
}