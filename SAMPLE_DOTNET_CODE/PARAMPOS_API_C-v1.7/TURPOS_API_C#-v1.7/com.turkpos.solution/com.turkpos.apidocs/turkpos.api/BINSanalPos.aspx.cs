using com.turkpos.apidocs.tr.com.ew.dmzws;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace com.turkpos.apidocs.turkpos.api {
    public partial class BINSanalPos : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }
        
        protected void btnSubmit_Click(object sender, EventArgs e) {
            var service = new TurkPosWSTEST();
            var gNesnesi = (Page.Master as ApiForms).GuvenlikNesnesi();
            var sonuc =
                service.BIN_SanalPos(gNesnesi, "");
            var s = Convert.ToInt32(sonuc.Sonuc);
            if (s > 0) {
                (Page.Master as ApiForms).Info(sonuc.Sonuc_Str);
                grdSonuc.DataSource = sonuc.DT_Bilgi;
                grdSonuc.DataBind();
            } else {
                grdSonuc.DataSource = null;
                grdSonuc.DataBind();
                (Page.Master as ApiForms).Error(sonuc.Sonuc_Str);
            }
        }
    }
}