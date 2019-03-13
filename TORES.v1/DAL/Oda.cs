using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TORES.v1.DAL
{
    // Bu class DB tarafındaki datOda tablosunun birebir yapısını tutar

    public class Oda
    {
        int _odaid;         // int
        string _odaad;      // nvarchar(50)
        int _odamevcut;     // tinyint
        char _odaint;       // char(1) - Odada internet var mı?
        char _odaproj;      // char(1) - Odada projeksiyon cihazı var mı?
        char _odavk;        // char(1) - Odada video konferans sistemi var mı?

        public int OdaID
        {
            get { return _odaid; }
            set { _odaid = value; }
        }

        public string OdaAd
        {
            get { return _odaad; }
            set { _odaad = value; }
        }

        public int OdaMevcut
        {
            get { return _odamevcut; }
            set { _odamevcut = value; }
        }

        public char OdaInt
        {
            get { return _odaint; }
            set { _odaint = value; }
        }

        public char OdaProj
        {
            get { return _odaproj; }
            set { _odaproj = value; }
        }

        public char OdaVK
        {
            get { return _odavk; }
            set { _odavk = value; }
        }

    }

}
