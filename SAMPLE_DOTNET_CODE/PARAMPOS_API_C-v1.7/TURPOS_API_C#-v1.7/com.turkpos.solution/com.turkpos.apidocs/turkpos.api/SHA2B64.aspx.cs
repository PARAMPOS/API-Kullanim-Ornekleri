using com.turkpos.apidocs.tr.com.ew.dmzws;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace com.turkpos.apidocs.turkpos.api {
    public partial class SHA2B64 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void btnSubmit_Click(object sender, EventArgs e) {
            var service = new TurkPosWSTEST();
            var result =
                service.SHA2B64(txbMetin.Text);
            lblSonuc.Text = result;
            if (String.IsNullOrEmpty(result)) {
                (Page.Master as ApiForms).Info("İşlem Başarısız");
            } else {
                (Page.Master as ApiForms).Info("İşlem Başarılı");
            }
        }
    }
}