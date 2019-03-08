using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace TORES.v1
{
    public partial class Login : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            lbelKulAd.Font.Bold = true;
            lbelKulSifre.Font.Bold = true;
        }

        protected void btonOK_Click(object sender, EventArgs e)
        {
            // textbox a girilen değerler db den kontrol ediliyor...
            string kulad, kulsifre, SQLText ;

            kulad = tboxKulAd.Text.Trim();
            kulsifre = tboxKulSifre.Text.Trim();
            //kulad = "ukaracivi";
            //kulsifre = "12345";


            SqlConnection connLocal = new SqlConnection();

            //connLocal.ConnectionString = "Data Source=302--00; Initial Catalog=TORESv1; User ID=sa; Password=1234;";
            //connLocal.ConnectionString = ConfigurationManager.AppSettings["ConnStr"].ToString() ;

            connLocal.ConnectionString = clsGlobalVPF.ConnStr;
            connLocal.Open();

            SQLText = "";
            SQLText += "SELECT PersID,PersAd,PersSoyad,(SELECT DirTnm FROM datDirektorluk WHERE DirID=PersDirID) AS DirTnm,PersTip FROM datPersonel WHERE ";
            SQLText += "PersUID='" +kulad + "' AND ";
            SQLText += "PersPass='" + kulsifre + "'";

            

            SqlCommand cmd = new SqlCommand(SQLText, connLocal);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {

                clsGlobalVPF.PersID = Convert.ToInt32(dt.Rows[0][0].ToString());
                clsGlobalVPF.PersAd = dt.Rows[0][1].ToString();
                clsGlobalVPF.PersSoyad = dt.Rows[0][2].ToString();
                clsGlobalVPF.PersDir= dt.Rows[0][3].ToString();
                clsGlobalVPF.PersTip = dt.Rows[0][4].ToString();


                Server.Transfer("Default.aspx");


            }
            else
            {
                Server.Transfer("Hata.aspx");
                //Response.Redirect("Hata.aspx");
            }

            connLocal.Close();



        }
    }
}