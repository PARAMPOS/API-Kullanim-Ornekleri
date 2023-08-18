using System;
using com.turkpos.apidocs.tr.com.ew.dmzws;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace com.turkpos.apidocs.turkpos.api
{
    public partial class sonuc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            txbSonuc.Text = Request.Form["TURKPOS_RETVAL_Sonuc"];
            txbSonuc_Str.Text = Request.Form["TURKPOS_RETVAL_Sonuc_Str"];
            txbGUID.Text = Request.Form["TURKPOS_RETVAL_GUID"];
            txbIslemTarih.Text = Request.Form["TURKPOS_RETVAL_Islem_Tarih"];
            txbDekontID.Text = Request.Form["TURKPOS_RETVAL_Dekont_ID"];
            txbTahsilat.Text = Request.Form["TURKPOS_RETVAL_Tahsilat_Tutari"];
            txbOdeme.Text = Request.Form["TURKPOS_RETVAL_Odeme_Tutari"];
            txbSiparisID.Text = Request.Form["TURKPOS_RETVAL_Siparis_ID"];
            txbIslemID.Text = Request.Form["TURKPOS_RETVAL_Islem_ID"];
            txbData.Text = Request.Form["TURKPOS_RETVAL_Ext_Data"];





        }

    }
}