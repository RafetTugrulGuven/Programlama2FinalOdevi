using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MezunTakipDx.Pages
{
    public partial class Giris : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                MezunTakipDbEntities db = new MezunTakipDbEntities();
                var tclist = db.UyeMails.Join(db.Uyelers, m => m.uye_tc, s => s.uye_tc, (m, s) => new {
                    m.uyeMail_adres,
                    s.uye_sifre,
                    s.uye_tc,
                    adSoyad= s.uye_ad+" "+s.uye_soyad
                });

                var tc = tclist.FirstOrDefault(s => s.uye_sifre == sifre.Text && s.uyeMail_adres == ePosta.Text);

                
  
                if (tc != null)
                {
                    Session["KullaniciTc"] = tc.uye_tc.ToString();
                    Session["KullaniciAdSoyad"] = tc.adSoyad.ToString();
                    Response.Redirect("Default.aspx");
                }
                else
                {
                    string script = "alert(\"E-posta veya Şifre Hatalı!\");";
                    ScriptManager.RegisterStartupScript(this, GetType(),
                                          "ServerControlScript", script, true);
               //     Response.Redirect("Giris.aspx");

                }
            }
            catch(Exception ex) { }

        }
    }
}