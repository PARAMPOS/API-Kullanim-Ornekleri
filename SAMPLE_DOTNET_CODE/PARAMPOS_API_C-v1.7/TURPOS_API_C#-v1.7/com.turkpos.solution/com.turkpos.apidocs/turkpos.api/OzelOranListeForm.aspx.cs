using com.turkpos.apidocs.tr.com.ew.dmzws;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace com.turkpos.apidocs.turkpos.api {
    public partial class OzelOranListeForm : System.Web.UI.Page {

        protected void btnSubmit_Click(object sender, EventArgs e) {

            var service = new TurkPosWSTEST();
            var gNesnesi = (Page.Master as ApiForms).GuvenlikNesnesi();
            var ozelOranListe =
                service.TP_Ozel_Oran_Liste(gNesnesi, txbAnahtar.Text);
            var s = Convert.ToInt32(ozelOranListe.Sonuc);
            if (s > 0) {
                (Page.Master as ApiForms).Info(ozelOranListe.Sonuc_Str);
                grdSonuc.DataSource = ozelOranListe.DT_Bilgi;
                grdSonuc.DataBind();
            } else {
                grdSonuc.DataSource = null;
                grdSonuc.DataBind();
                (Page.Master as ApiForms).Error(ozelOranListe.Sonuc_Str);
            }

        }

    }

}