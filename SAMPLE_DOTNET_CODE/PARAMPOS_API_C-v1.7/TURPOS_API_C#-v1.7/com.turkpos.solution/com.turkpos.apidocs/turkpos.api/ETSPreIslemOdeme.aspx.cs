
using com.turkpos.apidocs.tr.com.ew.dmzws;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace com.turkpos.apidocs.turkpos.api {
    public partial class ETSPreIslemOdeme : System.Web.UI.Page {

        protected void btnSubmit_Click(object sender, EventArgs e) {

            if (grdOranListe.SelectedIndex > -1) {
                var hash_ = "";
                var service = new TurkPosWSTEST();
                var gNesnesi = (Page.Master as ApiForms).GuvenlikNesnesiProd();
                var spid = Convert.ToInt32(grdOranListe.SelectedDataKey["SanalPOS_ID"]);
                var hataUrl = "http://localhost:64317/turkpos.api/sonuc.aspx";
                var basariliUrl = "http://localhost:64317/turkpos.api/sonuc.aspx";
                var odemeUrl = String.Format("{0}://{1}/", Request.Url.Scheme, Request.Url.Authority, "turkpos.api/ETSPreIslemOdeme.aspx");
                var Islem_Hash = "10738" + "0c13d406-873b-403b-9c09-a5766840d98c" + Convert.ToInt32(grdOranListe.SelectedDataKey["SanalPOS_ID"].ToString()) + "1" + "10,00" + "10,00" + "sipariş1" + hataUrl + basariliUrl;
               // var stSonucPreIslemOdeme =
               //          service.TP_Islem_Odeme(gNesnesi, Convert.ToInt32(grdOranListe.SelectedDataKey["SanalPOS_ID"].ToString()), txbAnahtar.Text, "Albert Einstein", "4444444444444444", "04", "14", "444", "5360331719"
               //, hataUrl, basariliUrl, "sipariş1", "sipariş açıklama", 1, "10,50", "5", "2", "1000,50", "127.0.0.1",
               //odemeUrl, "", "", "", "", "");
                hash_ = service.SHA2B64(Islem_Hash);
                var stSonucPreIslemOdeme = service.TP_Islem_Odeme(gNesnesi, Convert.ToInt32(grdOranListe.SelectedDataKey["SanalPOS_ID"].ToString()), "0c13d406-873b-403b-9c09-a5766840d98c", "Albert Einstein", "4546711234567894", "12", "2026", "000", "5360331719", hataUrl, basariliUrl, "sipariş1", "sipariş açıklama", 1, "10,00", "10,00", hash_,  "123", "127.0.0.1", odemeUrl, "", "", "", "","");

                var s = Convert.ToInt32(stSonucPreIslemOdeme.Sonuc);
                if (s > 0) {
                    var msg = String.Format(@"PostParam: {0}\n{1}\n{2}\n{3}\n{4}\n{5}\n",
                        "TURKPOS_RETVAL_Sonuc", "TURKPOS_RETVAL_Sonuc_Str", "TURKPOS_RETVAL_Dekont_ID",
                        "TURKPOS_RETVAL_Tahsilat_Tutari", "TURKPOS_RETVAL_Odeme_Tutari", "TURKPOS_RETVAL_Siparis_ID");
                    (Page.Master as ApiForms).Info(msg);
                    Response.Redirect(stSonucPreIslemOdeme.UCD_URL);

                } else {
                    (Page.Master as ApiForms).Error(stSonucPreIslemOdeme.Sonuc_Str);
                }
            } else {
                (Page.Master as ApiForms).Error("Lütfen Seçiminizi Yapınız");
            }
        }

        protected void grdOranListe_SelectedIndexChanged(object sender, EventArgs e) {

            var spid = grdOranListe.SelectedDataKey["SanalPOS_ID"].ToString();
            (Page.Master as ApiForms).Info(String.Format("Seçilen SanalPOS_ID:{0}", spid));

        }

        protected void btnList_Click(object sender, EventArgs e) {

            if (!String.IsNullOrEmpty(txbAnahtar.Text)) {
                var service = new TurkPosWSTEST();
                var gNesnesi = (Page.Master as ApiForms).GuvenlikNesnesiProd();
                var ozelOranListe =
                    service.TP_Ozel_Oran_SK_Liste(gNesnesi, txbAnahtar.Text);
                var s = Convert.ToInt32(ozelOranListe.Sonuc);
                if (s > 0) {
                    (Page.Master as ApiForms).Info(ozelOranListe.Sonuc_Str);
                    grdOranListe.DataSource = ozelOranListe.DT_Bilgi;
                    grdOranListe.DataBind();
                } else {
                    grdOranListe.DataSource = null;
                    grdOranListe.DataBind();
                    (Page.Master as ApiForms).Error(ozelOranListe.Sonuc_Str);
                }
                btnSubmit.Visible = true;
            } else {
                (Page.Master as ApiForms).Error("Lütfen Anahtarınızı Giriniz");
            }

        }
    }
}