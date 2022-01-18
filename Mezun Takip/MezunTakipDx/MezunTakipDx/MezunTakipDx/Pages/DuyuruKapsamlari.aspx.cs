using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MezunTakipDx.Pages
{
    public partial class DuyuruKapsamlari : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
       
            if (Session["KullaniciTc"] == null)
                Response.Redirect("Giris.aspx");
            fakulteListele();
        }
        MezunTakipDbEntities db = new MezunTakipDbEntities();
        private void fakulteListele()
        {

            cbFakulte.DataSource = db.Fakultelers.ToList();
            cbFakulte.TextField = "fakulte_adi";
            cbFakulte.ValueField = "fakulte_id";
            cbFakulte.DataBind();
        }
        private void bolumListele()
        {
            cbBolum.DataSource = db.Bolumlers.Where(s => s.bolum_FakulteId == (int)cbFakulte.Value).ToList();
            cbBolum.ValueField = "bolum_id";
            cbBolum.TextField = "bolum_adi";
            cbBolum.DataBind();
        }
        private void calismaAlaniListele()
        {
            cbCalismaAlani.DataSource = db.CalismaAlanlaris.Where(s => s.bolum_Id == (int)cbBolum.Value).ToList();
            cbCalismaAlani.TextField = "calismaAlani_adi";
            cbCalismaAlani.ValueField = "calismaAlani_id";
            cbCalismaAlani.DataBind();
        }

        protected void btnCaEkle_Click(object sender, EventArgs e)
        {
            try
            {
 DuyuruKapsamis dk = new DuyuruKapsamis();
                dk.calismaAlani_id = Convert.ToInt32( cbCalismaAlani.Value);
                dk.duyuru_id = Convert.ToInt32(Session["DuyuruId"]);
                db.DuyuruKapsamis.Add(dk);
                db.SaveChanges();
               
                cbCalismaAlani.Value = null;
            }
            catch (Exception ex)
            {
               
            }


        }

        protected void cbFakulte_ValueChanged(object sender, EventArgs e)
        {
            bolumListele();
        }

        protected void cbBolum_ValueChanged(object sender, EventArgs e)
        {
            calismaAlaniListele();
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Session["DuyuruId"] = null;
            Response.Redirect("Default.aspx");
        }
    }
}