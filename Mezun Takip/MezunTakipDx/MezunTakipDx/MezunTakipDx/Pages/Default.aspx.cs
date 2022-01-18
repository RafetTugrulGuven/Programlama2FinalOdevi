using DevExpress.Web.Bootstrap;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MezunTakipDx {
    public partial class _Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            if (Session["KullaniciTc"] == null) 
                Response.Redirect("Giris.aspx");
           

            repeaterVeriCek();
        }
        private void repeaterVeriCek()
        {
            try
            {
                
       MezunTakipDbEntities db = new MezunTakipDbEntities();
            rpDuyurular.DataSource = db.DuyurularView.ToList();
            rpDuyurular.DataBind();
            }
            catch { }
     
        }

       

        protected void BootstrapButton1_Click(object sender, EventArgs e)
        {
            BootstrapButton btn = (BootstrapButton)sender;
            Session["DuyuruId"] =   btn.CommandArgument;
            Response.Redirect("DuyuruDetay.aspx");
        }
    }
}