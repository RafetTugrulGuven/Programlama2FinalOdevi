using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web;
using DevExpress.Web.Bootstrap;

namespace MezunTakipDx {
    public partial class SiteMaster : System.Web.UI.MasterPage {
        protected void Page_Load(object sender, EventArgs e) {

            if (Session["KullaniciTc"] != null)
            {
                TopMenu.Items[2].Visible = false;
                TopMenu.Items[3].Visible = false;
                TopMenu.Items[5].Visible = true;
                TopMenu.Items[4].Visible = true;
                TopMenu.Items[4].Text = Session["KullaniciAdSoyad"].ToString();
            }
        }

        protected void TopMenu_ItemClick(object source, DevExpress.Web.Bootstrap.BootstrapMenuItemEventArgs e)
        {


            if (e.Item.Name == "Cikis") { Session["KullaniciTc"] = null; Session["KullaniciAdSoyad"] = null;  }

            Response.Redirect("Giris.aspx");
        }
    }
}