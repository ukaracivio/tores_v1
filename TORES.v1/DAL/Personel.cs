using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TORES.v1.DAL
{
    // Bu class DB tarafındaki datPersonel tablosunun birebir yapısını tutar

    public class Personel
    {
        int _persid;            // int
        string _persad;         // nvarchar(50)
        string _perssoyad;      // nvarchar(50)
        int _persdirid;      // int -- FK
        string _persdirtnm;
        string _perstip;        // char(1)
        string _persgtz;        // nvarchar(12) -- Personelin sisteme giriş tarih ve zamanı
        string _persctz;        // nvarchar(12) -- Personelin sistemden çıkış tarih ve zamanı
        string _persuid;        // nvarchar(10) 
        string _perspass;       // nvarchar(10)

        public int PersID
        {
            get { return _persid; }
            set { _persid=value; }
        }

        public string PersAd
        {
            get { return _persad; }
            set { _persad = value; }
        }

        public string PersSoyad
        {
            get { return _perssoyad; }
            set { _perssoyad = value; }
        }

        public int PersDirID
        {
            get { return _persdirid; }
            set { _persdirid = value; }
        }

        public string PersDirTnm
        {
            get { return _persdirtnm; }
            set { _persdirtnm = value; }
        }

        public string PersTip
        {
            get { return _perstip; }
            set { _perstip = value; }
        }

        public string PersGTZ
        {
            get { return _persgtz; }
            set { _persgtz = value; }
        }

        public string PersCTZ
        {
            get { return _persctz; }
            set { _persctz = value; }
        }

        public string PersUID
        {
            get { return _persuid; }
            set { _persuid = value; }
        }

        public string PersPass
        {
            get { return _perspass; }
            set { _perspass = value; }
        }


    }
}