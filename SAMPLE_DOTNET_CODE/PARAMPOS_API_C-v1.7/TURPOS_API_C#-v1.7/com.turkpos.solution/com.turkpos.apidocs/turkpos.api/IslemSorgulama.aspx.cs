using com.turkpos.apidocs.tr.com.ew.dmzws;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace com.turkpos.apidocs.turkpos.api {
    public partial class IslemSorgulama : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            
        }

        protected void btnSubmit_Click(object sender, EventArgs e) {
            var service = new TurkPosWSTEST();
            var gNesnesi = (Page.Master as ApiForms).GuvenlikNesnesiProd();
            var response =
                service.TP_Islem_Sorgulama(gNesnesi, txbGUID.Text, txbDekontID.Text, txbSiparisID.Text, txbIslemID.Text);
                             var s = Convert.ToInt32(response.Sonuc);
            if (s > 0) {
                (Page.Master as ApiForms).Info(response.Sonuc_Str);
                grdSonuc.DataSource = response.DT_Bilgi;
                grdSonuc.DataBind();
            } else {
                grdSonuc.DataSource = null;
                grdSonuc.DataBind();
                (Page.Master as ApiForms).Error(response.Sonuc_Str);
            }
        }
    }
}