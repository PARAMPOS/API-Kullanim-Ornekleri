using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using com.turkpos.apidocs.tr.com.ew.dmzws1;

namespace com.turkpos.apidocs.turkpos.api
{
    public partial class KKSakliOdeme : System.Web.UI.Page
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
            var hataUrl = "http://localhost:64317/turkpos.api/sonuc.aspx";
            var basariliUrl = "http://localhost:64317/turkpos.api/sonuc.aspx";
            var odemeUrl = String.Format("{0}://{1}/", Request.Url.Scheme, Request.Url.Authority, "turkpos.api/KKSakliOdeme.aspx");
            var response = service.KS_Tahsilat(gNesnesi, "0c13d406-873b-403b-9c09-a5766840d98c", txbKS_GUID.Text, txbCVV.Text, "5360331719", hataUrl, basariliUrl, "sipariş1", "sipariş açıklama", 1, "1,00", "1,00", "3D", "", "127.0.0.1", odemeUrl, "data1", "data2", "data3", "data4", txbKK_Islem_ID.Text);
            var s = Convert.ToInt32(response.Sonuc);
            if (s > 0)
            {
                (Page.Master as ApiForms).Info(response.Sonuc_Str);
                Response.Redirect(response.UCD_URL);
            }
            else
            {
                (Page.Master as ApiForms).Error(response.Sonuc_Str);
            }
        }

    }
}