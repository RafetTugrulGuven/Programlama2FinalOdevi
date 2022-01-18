using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MezunTakipDx.Pages
{
    public partial class DuyuruEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (Session["KullaniciTc"] == null)
                Response.Redirect("Giris.aspx");
        }

        protected void btnDuyuruKayit_Click(object sender, EventArgs e)
        {
            try
            {
                MezunTakipDbEntities db = new MezunTakipDbEntities();
                Duyurulars dy = new Duyurulars();
                dy.duyuru_Basligi = txtBaslik.Text;
                dy.duyuru_Metin = txtMetin.Text;
                dy.duyuru_Resim = (byte[])imgProfil.Value;
                dy.duyuru_yayinTarihi = DateTime.Now;
                dy.duyuru_sahibiTc = Session["KullaniciTc"].ToString();
                dy.duyuru_bitisTarihi = (DateTime)dtBitisTarihi.Value;
                db.Duyurulars.Add(dy);
                db.SaveChanges();
                Session["DuyuruId"] = dy.duyuru_id;
                Response.Redirect("DuyuruKapsamlari.aspx");
            }
            catch (Exception ex)
            {

            }

        }
    }
}