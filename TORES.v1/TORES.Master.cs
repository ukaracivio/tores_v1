using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace TORES.v1
{
    public partial class TORES : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string Ad, Soyad, DirTnm,PersTip;

            Ad = clsGlobalVPF.PersAd;
            Soyad = clsGlobalVPF.PersSoyad;
            DirTnm = clsGlobalVPF.PersDirTnm;
            PersTip = clsGlobalVPF.PersTip;

            lbelAdSoyad.Text = Ad + " " + Soyad;
            lbelDirektorluk.Text = DirTnm;
            lbelPersTip.Text = PersTip;

            // Artıkın menü adımlarının görünmemesi sağlanacak...PersTip'e göre

            switch(PersTip)
            {
                case "1": // Dir.Admin

                    hlnkMenu5.Enabled = false;
                    break;

                case "2": // Kullanıcı
                    hlnkRezOnay.Enabled = false;
                    hlnkRezOnOnay.Enabled = false;
                    hlnkMenu5.Enabled = false;
                    break;
            }

        }
    }
}