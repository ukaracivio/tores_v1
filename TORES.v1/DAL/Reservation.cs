using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TORES.v1.DAL
{
    // Bu class DB tarafındaki datRez tablosunun birebir yapısını tutar

    public class Reservation
    {
        int _rezid;             // int
        int _dirid;             // int
        int _odaid;             // int
        string _konu;           // nvarchar(100)
        string _reztrh;         // nvarchar(8)
        string _rezbaszaman;    // char(4)
        string _rezbitzaman;    // char(4)
        int _reznbh;            // tinyint -- yazılan saat kadar öncesinden uyarı
        int _rezypersid;        // int
        string _rezytrh;        // nvarchar(12)

        public int RezID
        {
            get { return _rezid; }
            set { _rezid = value; }
        }

        public int DirID
        {
            get { return _dirid; }
            set { _dirid = value; }
        }

        public int OdaID
        {
            get { return _odaid; }
            set { _odaid = value; }
        }

        public string Konu
        {
            get { return _konu; }
            set { _konu = value; }
        }

        public string RezTrh
        {
            get { return _reztrh; }
            set { _reztrh = value; }
        }

        public string RezBasZaman
        {
            get { return _rezbaszaman; }
            set { _rezbaszaman = value; }
        }

        public string RezBitZaman
        {
            get { return _rezbitzaman; }
            set { _rezbitzaman = value; }
        }

        public int RezNBH
        {
            get { return _reznbh; }
            set { _reznbh = value; }
        }

        public int RezYPersID
        {
            get { return _rezypersid; }
            set { _rezypersid = value; }
        }

        public string RezYTrh
        {
            get { return _rezytrh; }
            set { _rezytrh = value; }
        }

    }

}