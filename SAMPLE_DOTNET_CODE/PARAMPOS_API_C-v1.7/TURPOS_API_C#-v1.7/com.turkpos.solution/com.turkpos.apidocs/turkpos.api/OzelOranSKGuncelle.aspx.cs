using com.turkpos.apidocs.tr.com.ew.dmzws;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace com.turkpos.apidocs.turkpos.api {
    public partial class OzelOranSKGuncelle : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

            if (!Page.IsPostBack) {
                var service = new TurkPosWSTEST();
                var gNesnesi = (Page.Master as ApiForms).GuvenlikNesnesi();
                var ozelOranListe =
                    service.TP_Ozel_Oran_Liste(gNesnesi, "0c13d406-873b-403b-9c09-a5766840d98c");
                var s = Convert.ToInt32(ozelOranListe.Sonuc);
                if (s > 0) {
                    (Page.Master as ApiForms).Info(ozelOranListe.Sonuc_Str);
                    grdSKListe.DataSource = ozelOranListe.DT_Bilgi;
                    grdSKListe.DataBind();
                } else {
                    grdSKListe.DataSource = null;
                    grdSKListe.DataBind();
                    (Page.Master as ApiForms).Error(ozelOranListe.Sonuc_Str);
                }
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e) {

            if (ValidateForm()) {
                var service = new TurkPosWSTEST();
                var gNesnesi = (Page.Master as ApiForms).GuvenlikNesnesi();
                var ooid = grdSKListe.SelectedDataKey["Ozel_Oran_ID"].ToString();
                var stSonuc =
                    service.TP_Ozel_Oran_SK_Guncelle(gNesnesi, txbAnahtar.Text,
                        ooid,
                        txbMO1.Text,
                        txbMO2.Text,
                        txbMO3.Text,
                        txbMO4.Text,
                        txbMO5.Text,
                        txbMO6.Text,
                        txbMO7.Text,
                        txbMO8.Text,
                        txbMO9.Text,
                        txbM10.Text,
                        txbM11.Text,
                        txbM12.Text
                    );
                var s = Convert.ToInt32(stSonuc.Sonuc);
                
                if (s > 0) {
                    (Page.Master as ApiForms).Info(stSonuc.Sonuc_Str);
                } else {
                    (Page.Master as ApiForms).Error(stSonuc.Sonuc_Str);
                }
            } else {
                (Page.Master as ApiForms).Error("Lütfen Gerekli Alanları Doldurunuz.");
            }
        }

        protected void grdSKListe_SelectedIndexChanged(object sender, EventArgs e) {

            var ooid = grdSKListe.SelectedDataKey["Ozel_Oran_ID"].ToString();
            (Page.Master as ApiForms).Info(String.Format("Seçilen Ozel_Oran_ID:{0}", ooid));

        }

        private Boolean ValidateForm() {

            var validated = grdSKListe.SelectedIndex > -1;
            validated = ValidateTextBox(txbAnahtar, validated);
            validated = ValidateTextBox(txbMO1, validated);
            validated = ValidateTextBox(txbMO2, validated);
            validated = ValidateTextBox(txbMO3, validated);
            validated = ValidateTextBox(txbMO4, validated);
            validated = ValidateTextBox(txbMO5, validated);
            validated = ValidateTextBox(txbMO6, validated);
            validated = ValidateTextBox(txbMO7, validated);
            validated = ValidateTextBox(txbMO8, validated);
            validated = ValidateTextBox(txbMO9, validated);
            validated = ValidateTextBox(txbM10, validated);
            validated = ValidateTextBox(txbM11, validated);
            validated = ValidateTextBox(txbM12, validated);
            return validated;

        }

        private bool ValidateTextBox(TextBox txt, bool validated) {
            var v = true;
            if (String.IsNullOrEmpty(txt.Text)) {
                v = false;
                txt.BorderColor = Color.Red;
            } else {
                txt.BorderColor = Color.Empty;
            }
            return validated && v;
        }

    }
}