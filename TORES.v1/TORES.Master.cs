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

            string Ad, Soyad;

            Ad = clsGlobalVPF.PersAd;
            Soyad = clsGlobalVPF.PersSoyad;

            lbelAdSoyad.Text = Ad + " " + Soyad;

        }
    }
}