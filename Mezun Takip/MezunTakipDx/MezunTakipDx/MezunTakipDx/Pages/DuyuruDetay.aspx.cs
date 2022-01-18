using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MezunTakipDx.Pages
{
    public partial class DuyuruDetay : System.Web.UI.Page
    {
        MezunTakipDbEntities db = new MezunTakipDbEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["KullaniciTc"] == null)
                Response.Redirect("Giris.aspx");
            duyuruCek(Convert.ToInt32(Session["DuyuruId"]));
            string tc = Session["KullaniciTc"].ToString();
            int id = Convert.ToInt32(Session["DuyuruId"]);
            var kont = db.DuyuruBasvurus.FirstOrDefault(s => s.duyuru_id == id && s.uye_tc == tc);
            if (kont != null)
            {
                btnBasvur.Visible = false;
            }
            }
        private void duyuruBasvuruListele()
        {
            int id = Convert.ToInt32(Session["DuyuruId"]);
            grdUye.DataSource = db.DuyuruBasvuruView.Where(s => s.duyuru_id == id).ToList();
            grdUye.DataBind();
        }
        private void duyuruKapsamListele()
        {
            int id = Convert.ToInt32(Session["DuyuruId"]);
            grdCA.DataSource = db.DuyuruKapsamView.Where(s => s.duyuru_id == id).ToList();
            grdCA.DataBind();
        }
        private void duyuruCek(int id)
        {
            Duyurulars dy = db.Duyurulars.FirstOrDefault(s => s.duyuru_id==id);
            imgProfil.Value = dy.duyuru_Resim;
            txtBaslik.Text = dy.duyuru_Basligi;
            txtMetin.Text = dy.duyuru_Metin;
            dtBitisTarihi.Value = dy.duyuru_bitisTarihi;
            dtYayinTarihi.Value = dy.duyuru_yayinTarihi;
            duyuruBasvuruListele();
            duyuruKapsamListele();

        }

        protected void btnBasvur_Click(object sender, EventArgs e)
        {
            string tc = Session["KullaniciTc"].ToString();
            int id = Convert.ToInt32(Session["DuyuruId"]);
         var kont=   db.DuyuruBasvurus.FirstOrDefault(s => s.duyuru_id == id && s.uye_tc== tc);
            if (kont != null)
            {
                string script = "alert(\"Bu İlana Daha Önce Başvuru Yapılmıştır.\");";
                ScriptManager.RegisterStartupScript(this, GetType(),
                                      "ServerControlScript", script, true);
                return;
            }
            DuyuruBasvurus dbs = new DuyuruBasvurus();
            dbs.uye_tc = tc;
            dbs.duyuru_id = id;
            db.DuyuruBasvurus.Add(dbs);
            db.SaveChanges();
            Response.Redirect("Default.aspx");
        }
    }
}