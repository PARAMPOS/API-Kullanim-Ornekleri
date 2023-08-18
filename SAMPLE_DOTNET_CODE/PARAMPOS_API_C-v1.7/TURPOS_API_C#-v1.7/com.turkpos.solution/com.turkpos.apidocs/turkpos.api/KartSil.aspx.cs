using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using com.turkpos.apidocs.tr.com.ew.dmzws1;

namespace com.turkpos.apidocs.turkpos.api
{
    public partial class KartSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            var service = new TP_KS();
            var gNesnesi = new ST_WS_Guvenlik();
            gNesnesi.CLIENT_CODE = 10738;
            gNesnesi.CLIENT_USERNAME = "Test";
            gNesnesi.CLIENT_PASSWORD = "Test";
            
            

            var response = service.KS_Kart_Sil(gNesnesi, txbKS_GUID.Text, txbKK_Islem_ID.Text);
            var s = Convert.ToInt32(response.Sonuc);

            if (s > 0)
            {
                (Page.Master as ApiForms).Info(response.Sonuc_Str);
            }
            else
            {
                (Page.Master as ApiForms).Error(response.Sonuc_Str);
            }


        }
    }
}