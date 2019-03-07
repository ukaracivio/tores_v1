using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

using System.Configuration;

namespace TORES.v1
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            // Web sitesi ilk ekrana gelirken web.config dosyasındaki ilgili yerden
            // öncelikle veritabanının nerede bulunduğu öğreniliyor (Server,Local)
            // buna göre ilgili ConnectionString alınıyor ve proje genelindeki clsGlobalVPF class'ındaki
            // _connStr properties'e yazılıyor

            string _DBLoc;

            _DBLoc= ConfigurationManager.AppSettings["DBLocation"].ToString();

            switch(_DBLoc)
            {
                case "S":

                    clsGlobalVPF.ConnStr = ConfigurationManager.AppSettings["ConnStrWeb"].ToString();
                    break;

                case "L":

                    clsGlobalVPF.ConnStr = ConfigurationManager.AppSettings["ConnStrLocal"].ToString();
                    break;

            }



        }
    }
}