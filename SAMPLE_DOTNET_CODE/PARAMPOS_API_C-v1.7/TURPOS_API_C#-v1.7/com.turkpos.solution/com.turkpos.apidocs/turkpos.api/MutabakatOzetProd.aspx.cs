using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using com.turkpos.apidocs.tr.com.ew.dmzws;

namespace com.turkpos.apidocs.turkpos.api {
    public partial class MutabakatOzetProd : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void btnSubmit_Click(object sender, EventArgs e) {
            var service = new TurkPosWSTEST();
            var gNesnesi = (Page.Master as ApiForms).GuvenlikNesnesiProd();
            var response =
                service.TP_Mutabakat_Ozet(gNesnesi, txbGUID.Text, 
                clnBaslangic.SelectedDate.ToString("dd.MM.yyyy HH:mm:ss"),
                clnBitis.SelectedDate.ToString("dd.MM.yyyy HH:mm:ss")
                );
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