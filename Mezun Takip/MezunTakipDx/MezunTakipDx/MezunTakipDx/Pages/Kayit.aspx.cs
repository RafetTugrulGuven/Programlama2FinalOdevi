using DevExpress.Web.Bootstrap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MezunTakipDx.Pages
{
    public partial class Kayit : System.Web.UI.Page
    {
        MezunTakipDbEntities db = new MezunTakipDbEntities();
        private void sirketListele(BootstrapComboBox _cbsirket)
        {

            _cbsirket.DataSource = db.Sirketlers.ToList();
            _cbsirket.TextField = "sirket_adi";
            _cbsirket.ValueField = "sirket_id";
            _cbsirket.DataBind();
        }
        private void ilListele(BootstrapComboBox _cbIl)
        {

            _cbIl.DataSource = db.Sehirlers.ToList();
            _cbIl.TextField = "sehir_adi";
            _cbIl.ValueField = "sehir_id";
            _cbIl.DataBind();
        }
        private void ilceListele(BootstrapComboBox _cbIlce, BootstrapComboBox _cbIl)
        {

            _cbIlce.DataSource = db.Ilcelers.Where(i => i.ilce_SehirId == (int)_cbIl.Value).ToList();
            _cbIlce.TextField = "ilce_adi";
            _cbIlce.ValueField = "ilce_id";
            _cbIlce.DataBind();
        }




        private void fakulteListele(BootstrapComboBox _cbFakulte)
        {

            _cbFakulte.DataSource = db.Fakultelers.ToList();
            _cbFakulte.TextField = "fakulte_adi";
            _cbFakulte.ValueField = "fakulte_id";
            _cbFakulte.DataBind();
        }
        private void ogrenimDurumListele(BootstrapComboBox _cbOdurum)
        {

            _cbOdurum.DataSource = db.OgrenimDurumlaris.ToList();
            _cbOdurum.TextField = "ogrenimD_tanim";
            _cbOdurum.ValueField = "ogrenimD_id";
            _cbOdurum.DataBind();
        }
        private void bolumListele(BootstrapComboBox _cbBolum, BootstrapComboBox cbFakulte)
        {
            _cbBolum.DataSource = db.Bolumlers.Where(s => s.bolum_FakulteId == (int)cbFakulte.Value).ToList();
            _cbBolum.ValueField = "bolum_id";
            _cbBolum.TextField = "bolum_adi";
            _cbBolum.DataBind();
        }
        private void calismaAlaniListele(BootstrapComboBox _cbCalismaAlani)
        {
            _cbCalismaAlani.DataSource = db.CalismaAlanlaris.Where(s => s.bolum_Id == (int)cbBolum.Value).ToList();
            _cbCalismaAlani.TextField = "calismaAlani_adi";
            _cbCalismaAlani.ValueField = "calismaAlani_id";
            _cbCalismaAlani.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            ilListele(cbIl);
            sirketListele(cbSirketAdi);
            ogrenimDurumListele(cbOgrenimDurum);
            fakulteListele(cbFakulte);
            fakulteListele(cbFakulteUye);
        }
        protected void cbFakulteUye_ValueChanged(object sender, EventArgs e)
        {
            bolumListele(cbBolumUye, cbFakulteUye);
        }

        protected void cbFakulte_ValueChanged(object sender, EventArgs e)
        {
            bolumListele(cbBolum, cbFakulte);
        }

        protected void cbBolum_ValueChanged(object sender, EventArgs e)
        {
            calismaAlaniListele(cbCalismaAlani);
        }

        protected void cbIl_ValueChanged(object sender, EventArgs e)
        {
            ilceListele(cbIlce, cbIl);
        }

        protected void cbSirketAdi_ValueChanged(object sender, EventArgs e)
        {
            if (cbSirketAdi.Value == null) return;
            Sirketlers sirket = db.Sirketlers.FirstOrDefault(s => s.sirket_adi == cbSirketAdi.Text);
            if (sirket != null)
            {
                SirketAdres sAdres = db.SirketAdres.FirstOrDefault(s => s.sirket_Id == sirket.sirket_id);
                txtSAdres.Text = sAdres.sirket_adres;
                SirketTels sTel = db.SirketTels.FirstOrDefault(s => s.sirket_Id == sirket.sirket_id);
                txtSTel.Text = sTel.sirket_tel;
                SirketWebs sWeb = db.SirketWebs.FirstOrDefault(s => s.sirket_Id == sirket.sirket_id);
                txtSWeb.Text = sWeb.sirket_web;
            }
            else
            {
                string script = "alert(\"İsmini Girdiğiniz Şirket Bulunamadı Lütfen Şirket Adresi,Telefon Numarası ve Web Adresini Giriniz.\");";
                ScriptManager.RegisterStartupScript(this, GetType(),
                                      "ServerControlScript", script, true);
            }
        }

        protected void btnUyeKayit_Click(object sender, EventArgs e)
        {
            if (txtTc.Text == "")
            {
                string script = "alert(\"Lütfen Tc Kimlik Numaranızı Giriniz.\");";
                ScriptManager.RegisterStartupScript(this, GetType(),
                                      "ServerControlScript", script, true);
                return;
            }
            if (txtEposta.Text == "")
            {
                string script = "alert(\"Lütfen Mail Adresinizi Giriniz.\");";
                ScriptManager.RegisterStartupScript(this, GetType(),
                                      "ServerControlScript", script, true);
                return;
            }
            if (txtSifre.Text == "")
            {
                string script = "alert(\"Lütfen Şifrenizi Giriniz.\");";
                ScriptManager.RegisterStartupScript(this, GetType(),
                                      "ServerControlScript", script, true);
                return;
            }
            if (txtSifre.Text != txtSifreTekrar.Text)
            {
                string script = "alert(\"Girilen Şifreler Aynı Değil.\");";
                ScriptManager.RegisterStartupScript(this, GetType(),
                                      "ServerControlScript", script, true);
                return;
            }

            Uyelers uy;
            var tcKontrol = db.Uyelers.FirstOrDefault(s => s.uye_tc == txtTc.Text);
            if (tcKontrol != null)
            {
                string script = "alert(\"Bu Tc Kimlik Numarası Daha Önce Kaydolmuştur.\");";
                ScriptManager.RegisterStartupScript(this, GetType(),
                                      "ServerControlScript", script, true);
                return;
            }
            uy = new Uyelers();
            uy.uye_tc = txtTc.Text;
            uy.uye_ad = txtAd.Text;
            uy.uye_soyad = txtSoyad.Text;
            uy.uye_dogumTarihi = (DateTime)dtDogumTarihi.Value;
            uy.uye_cinsiyet = (int)cbCinsiyet.Value;
            if(cbAskerlikDurumu.Value!=null)
            uy.uye_askerlikDurumu = (int)cbAskerlikDurumu.Value;
            uy.uye_foto = (byte[])imgProfil.Value;
            uy.uye_dogumYeri_id = (int)cbIlce.Value;
            uy.uye_sifre = txtSifre.Text;
            db.Uyelers.Add(uy);
            UyeMails uyt = new UyeMails();
            uyt.uyeMail_adres = txtEposta.Text;
            uyt.uye_tc = txtTc.Text;
            db.UyeMails.Add(uyt);
            db.SaveChanges();
          
                UyeOgrenimDurumus uyT = new UyeOgrenimDurumus();
                uyT.uye_tc = txtTc.Text;
                uyT.ogrenimD_id = (int)cbOgrenimDurum.Value;
                uyT.ogrenimD_durum = 1;
                db.UyeOgrenimDurumus.Add(uyT);
                db.SaveChanges();
           

            Session["KullaniciTc"] = txtTc.Text;
       //     BootstrapPageControl1.TabPages[0].Visible = false;
            BootstrapPageControl1.ActiveTabPage = BootstrapPageControl1.TabPages[1];


        }


        protected void btnIekle_Click(object sender, EventArgs e)
        {
            if (txtTc.Text == "")
            {
                string script = "alert(\"Lütfen Tc Kimlik Numaranızı Giriniz.\");";
                ScriptManager.RegisterStartupScript(this, GetType(),
                                      "ServerControlScript", script, true);
                return;
            }

            if (txtTel.Text != "")
            {
                UyeTels uyT = new UyeTels();
                uyT.uye_tc = txtTc.Text;
                uyT.uye_tel = txtTel.Text;
                db.UyeTels.Add(uyT);
                db.SaveChanges();
            }
            if (txtAdres.Text != "")
            {
                UyeAdres uyA = new UyeAdres();
                uyA.uye_tc = txtTc.Text;
                uyA.uye_adres = txtAdres.Text;
                db.UyeAdres.Add(uyA);
                db.SaveChanges();
            }
            txtTel.Value = null;
            txtAdres.Value = null;


        }
        protected void iileri_Click(object sender, EventArgs e)
        {
            BootstrapPageControl1.ActiveTabPage = BootstrapPageControl1.TabPages[2];
        }
        protected void btnOEkle_Click(object sender, EventArgs e)
        {
            if (txtTc.Text == "")
            {
                string script = "alert(\"Lütfen Tc Kimlik Numaranızı Giriniz.\");";
                ScriptManager.RegisterStartupScript(this, GetType(),
                                      "ServerControlScript", script, true);
                return;
            }

    
            if (cbBolumUye.Value != null)
            {
                UyeBolums uyA = new UyeBolums();
                uyA.uye_tc = txtTc.Text;
                uyA.bolum_id = (int)cbBolumUye.Value;
                db.UyeBolums.Add(uyA);
                db.SaveChanges();
            }




        }
        protected void oileri_Click(object sender, EventArgs e)
        {
            BootstrapPageControl1.ActiveTabPage = BootstrapPageControl1.TabPages[3];
        }
        protected void btnCaEkle_Click(object sender, EventArgs e)
        {
            if (txtTc.Text == "")
            {
                string script = "alert(\"Lütfen Tc Kimlik Numaranızı Giriniz.\");";
                ScriptManager.RegisterStartupScript(this, GetType(),
                                      "ServerControlScript", script, true);
                return;
            }

            if (cbCalismaAlani.Value != null)
            {
                UyeCalismaAlanis uyT = new UyeCalismaAlanis();
                uyT.uye_tc = txtTc.Text;
                uyT.calismaAlani_id = (int)cbCalismaAlani.Value;

                db.UyeCalismaAlanis.Add(uyT);
                db.SaveChanges();
            }

        }
        protected void caileri_Click(object sender, EventArgs e)
        {
            BootstrapPageControl1.ActiveTabPage = BootstrapPageControl1.TabPages[4];
        }

        protected void btnSirketEkle_Click(object sender, EventArgs e)
        {
            if (txtTc.Text == "")
            {
                string script = "alert(\"Lütfen Tc Kimlik Numaranızı Giriniz.\");";
                ScriptManager.RegisterStartupScript(this, GetType(),
                                      "ServerControlScript", script, true);
                return;
            }

            Sirketlers sirket = db.Sirketlers.FirstOrDefault(s => s.sirket_adi == cbSirketAdi.Text);

            if (sirket == null)
            {
                Sirketlers sYeni = new Sirketlers();
                sYeni.sirket_adi = cbSirketAdi.Text;
                db.Sirketlers.Add(sYeni);
                db.SaveChanges();
                SirketAdres sYeniAdres = new SirketAdres();
                sYeniAdres.sirket_Id = sYeni.sirket_id;
                sYeniAdres.sirket_adres = txtSAdres.Text;
                db.SirketAdres.Add(sYeniAdres);
                db.SaveChanges();
                SirketTels sYeniTel = new SirketTels();
                sYeniTel.sirket_Id = sYeni.sirket_id;
                sYeniTel.sirket_tel = txtSTel.Text;
                db.SirketTels.Add(sYeniTel);
                db.SaveChanges();
                SirketWebs sYeniWeb = new SirketWebs();
                sYeniWeb.sirket_Id = sYeni.sirket_id;
                sYeniWeb.sirket_web = txtSWeb.Text;
                db.SirketWebs.Add(sYeniWeb);
                db.SaveChanges();
                sirket = sYeni;
            }
            UyeSirkets us = new UyeSirkets();
            us.sirket_id = sirket.sirket_id;
            us.uye_tc = txtTc.Text;
            us.uyeSirket_durum = (int)cbCalismaDurumu.Value;
            db.UyeSirkets.Add(us);
            db.SaveChanges();
            cbSirketAdi.Value = null;
            txtSAdres.Value = null;
            txtSTel.Value = null;
            txtSWeb.Value = null;
        }

        protected void home_Click(object sender, EventArgs e)
        {
            Session["KullaniciTc"] = txtTc.Text;
            Session["KullaniciAdSoyad"] = txtAd.Text + " " + txtSoyad.Text;
            Response.Redirect("Default.aspx");
        }
    }
}