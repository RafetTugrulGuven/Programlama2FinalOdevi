using DevExpress.Web.Bootstrap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MezunTakipDx.Pages
{
    public partial class Profil : System.Web.UI.Page
    {
        MezunTakipDbEntities db = new MezunTakipDbEntities();
      
        private void ilListele(BootstrapComboBox _cbIl)
        {

            _cbIl.DataSource = db.Sehirlers.ToList();
            _cbIl.TextField = "sehir_adi";
            _cbIl.ValueField = "sehir_id";
            _cbIl.DataBind();
        }
        private void ilceListele(BootstrapComboBox _cbIlce)
        {

            _cbIlce.DataSource = db.Ilcelers.ToList();
            _cbIlce.TextField = "ilce_adi";
            _cbIlce.ValueField = "ilce_id";
            _cbIlce.DataBind();
        }

        private void uyeBolumViewListele()
        {
            string tc = Convert.ToString(Session["KullaniciTc"]);
            grdUyeBolumler.DataSource = db.UyeBolumView.Where(s => s.uye_tc == tc).ToList();
            grdUyeBolumler.DataBind();
        }
        private void uyeCaViewListele()
        {
            string tc = Convert.ToString(Session["KullaniciTc"]);
            grdUyeCalismaAlani.DataSource = db.UyeCalismaAlaniView.Where(s => s.uye_tc == tc).ToList();
            grdUyeCalismaAlani.DataBind();
        }
        private void uyeSirketViewListele()
        {
            string tc = Convert.ToString(Session["KullaniciTc"]);
            grdUyeSirket.DataSource = db.UyeSirketView.Where(s => s.uye_tc == tc).ToList();
            grdUyeSirket.DataBind();
        }

        private void uyeBilgileri()
        {
            string tc = Convert.ToString(Session["KullaniciTc"]);
            Uyelers uy = db.Uyelers.FirstOrDefault(s => s.uye_tc == tc);
            txtAd.Text = uy.uye_ad;
            txtSoyad.Text = uy.uye_soyad;
            dtDogumTarihi.Value = uy.uye_dogumTarihi;
            cbCinsiyet.Value = uy.uye_cinsiyet;
            cbAskerlikDurumu.Value = uy.uye_askerlikDurumu;
            imgProfil.Value = uy.uye_foto;
            // cbOgrenimDurum.Value=uy.
           
            cbIlce.Value = uy.uye_dogumYeri_id;
            Ilcelers ilce= db.Ilcelers.FirstOrDefault(s => s.ilce_id == uy.uye_dogumYeri_id);
            cbIl.Value = ilce.ilce_SehirId;
            UyeMails uym= db.UyeMails.FirstOrDefault(s => s.uye_tc == tc);
            txtEposta.Text = uym.uyeMail_adres;
            UyeOgrenimDurumus od = db.UyeOgrenimDurumus.FirstOrDefault(s => s.uye_tc == tc);
            cbOgrenimDurum.Value = od.ogrenimD_id;
            var tel = db.UyeTels.Where(s => s.uye_tc == tc).ToList();
            foreach (var item in tel)
            {
                lsTel.Items.Add(item.uye_tel);
            }
            var adres = db.UyeAdres.Where(s => s.uye_tc == tc).ToList();
            foreach (var item in adres)
            {
                lsAdres.Items.Add(item.uye_adres);
            }
        }

        private void ogrenimDurumListele(BootstrapComboBox _cbOdurum)
        {

            _cbOdurum.DataSource = db.OgrenimDurumlaris.ToList();
            _cbOdurum.TextField = "ogrenimD_tanim";
            _cbOdurum.ValueField = "ogrenimD_id";
            _cbOdurum.DataBind();
        }
       
      

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["KullaniciTc"] == null)
                Response.Redirect("Giris.aspx");
            ilListele(cbIl);
            ilceListele(cbIlce);
            uyeBolumViewListele();
            ogrenimDurumListele(cbOgrenimDurum);
            uyeSirketViewListele();
            uyeCaViewListele();
            uyeBilgileri();
        }
      

      

       

      

     

    }
}