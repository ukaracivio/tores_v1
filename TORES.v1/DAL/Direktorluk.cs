using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TORES.v1.DAL
{
    // Bu class DB tarafındaki datDirektorluk tablosunun birebir yapısını tutar

    public class Direktorluk
    {
        int _dirid;     // int
        string _dirtnm; // nvarchar(50)

        public int DirID
        {
            get { return _dirid; }
            set { _dirid = value; }
        }

        public string DirTnm
        {
            get { return _dirtnm; }
            set { _dirtnm = value; }
        }

    }

}