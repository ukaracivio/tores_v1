﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Configuration;

namespace TORES.v1
{
    public static class clsGlobalVPF
    {
        static string _connStr;
        static int _persID;
        static string _persAd;
        static string _persSoyad;
        static string _persDir;


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

        public static string PersDir
        {
            get { return _persDir; }
            set { _persDir = value; }
        }

    }
}