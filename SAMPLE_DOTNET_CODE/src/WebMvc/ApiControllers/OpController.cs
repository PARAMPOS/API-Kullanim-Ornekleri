using Microsoft.AspNetCore.Mvc;
using TP_KS;
using TurkPosWSTEST;
using WebMvc.DTOs.BIN_SanalPos;
using WebMvc.DTOs.Il_Liste;
using WebMvc.DTOs.KK_Saklama;
using WebMvc.DTOs.KK_Sakli_Liste;
using WebMvc.DTOs.KS_Kart_Ekle;
using WebMvc.DTOs.KS_Kart_Liste;
using WebMvc.DTOs.KS_Kart_Liste_Pagination;
using WebMvc.DTOs.KS_Kart_Sil;
using WebMvc.DTOs.KS_Tahsilat;
using WebMvc.DTOs.KS_Tahsilat_Colendi;
using WebMvc.DTOs.MoneyPay_Islem_Sorgulama;
using WebMvc.DTOs.MP_OrderCancelRefund;
using WebMvc.DTOs.MP_OrderDetailAdd;
using WebMvc.DTOs.MP_OrderDetailList;
using WebMvc.DTOs.MP_OrderDetailQuery;
using WebMvc.DTOs.MP_OrderDetailStatus;
using WebMvc.DTOs.MP_OrderDetailUpdate;
using WebMvc.DTOs.Param_Pazaryeri_Islem_Izleme;
using WebMvc.DTOs.Payment_Hopi;
using WebMvc.DTOs.Pazaryeri_TP_AltUyeIsyeri_Ekleme;
using WebMvc.DTOs.Pazaryeri_TP_AltUyeIsyeri_Ekleme_v2;
using WebMvc.DTOs.Pazaryeri_TP_AltUyeIsyeri_Guncelleme;
using WebMvc.DTOs.Pazaryeri_TP_AltUyeIsyeri_Guncelleme_v2;
using WebMvc.DTOs.Pazaryeri_TP_AltUyeIsyeri_Liste;
using WebMvc.DTOs.Pazaryeri_TP_AltUyeIsyeri_Silme;
using WebMvc.DTOs.Pazaryeri_TP_Iptal_Iade;
using WebMvc.DTOs.Pazaryeri_TP_Islem_Sorgulama;
using WebMvc.DTOs.Pazaryeri_TP_Limit_Kontrol;
using WebMvc.DTOs.Pazaryeri_TP_Siparis_Detay_Ekle;
using WebMvc.DTOs.Pazaryeri_TP_Siparis_Onay;
using WebMvc.DTOs.Pos_Plugin_Bildirim;
using WebMvc.DTOs.SHA2B64;
using WebMvc.DTOs.TP_Islem_Checkout;
using WebMvc.DTOs.TP_Islem_Checkout_Odeme_WNS;
using WebMvc.DTOs.TP_Islem_Checkout_SK;
using WebMvc.DTOs.TP_Islem_Dekont_Gonder;
using WebMvc.DTOs.TP_Islem_Iptal_Iade;
using WebMvc.DTOs.TP_Islem_Iptal_Iade_Kismi;
using WebMvc.DTOs.TP_Islem_Iptal_Iade_Kismi_WP;
using WebMvc.DTOs.TP_Islem_Iptal_Iade_Kismi2;
using WebMvc.DTOs.TP_Islem_Iptal_Iade_Kismi3;
using WebMvc.DTOs.TP_Islem_Iptal_Iade_Kismi4;
using WebMvc.DTOs.TP_Islem_Iptal_Iade2;
using WebMvc.DTOs.TP_Islem_Iptal_OnProv;
using WebMvc.DTOs.TP_Islem_Izleme;
using WebMvc.DTOs.TP_Islem_Odeme;
using WebMvc.DTOs.TP_Islem_Odeme_BKM;
using WebMvc.DTOs.TP_Islem_Odeme_OnProv;
using WebMvc.DTOs.TP_Islem_Odeme_OnProv_Kapa;
using WebMvc.DTOs.TP_Islem_Odeme_OnProv_WKS;
using WebMvc.DTOs.TP_Islem_Odeme_OnProv_WMD;
using WebMvc.DTOs.TP_Islem_Odeme_WD;
using WebMvc.DTOs.TP_Islem_Odeme_WKS;
using WebMvc.DTOs.TP_Islem_Odeme_WNS;
using WebMvc.DTOs.TP_Islem_Sorgulama;
using WebMvc.DTOs.TP_Islem_Sorgulama_WP;
using WebMvc.DTOs.TP_Islem_Sorgulama4;
using WebMvc.DTOs.TP_Islem_Sorgulama5;
using WebMvc.DTOs.TP_Islem_Sorgulama6;
using WebMvc.DTOs.TP_KK_Verify;
using WebMvc.DTOs.TP_Modal_Payment;
using WebMvc.DTOs.TP_Multiple_Payment;
using WebMvc.DTOs.TP_Multiple_Payment_Status;
using WebMvc.DTOs.TP_Mutabakat_Detay;
using WebMvc.DTOs.TP_Mutabakat_Ozet;
using WebMvc.DTOs.TP_Ozel_Oran_Liste;
using WebMvc.DTOs.TP_Ozel_Oran_SK_Guncelle;
using WebMvc.DTOs.TP_Ozel_Oran_SK_Liste;
using WebMvc.DTOs.TP_WMD_Pay;
using WebMvc.DTOs.TP_WMD_UCD;
using WebMvc.DTOs.TP_WMD_UCD_Puan;
using WebMvc.DTOs.TP_WMD_UCD_v2;
using WebMvc.DTOs.TP_WMD_UCD_WP;
using WebMvc.DTOs.Vadeli_Islem_Izleme;

namespace WebMvc.ApiControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OpController : ControllerBase
    {
        [HttpPost("[action]")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> BIN_SanalPosAsync([FromBody] BIN_SanalPosRequestDTO dto)
        {
            using TurkPosWSTESTSoapClient client = new(TurkPosWSTESTSoapClient.EndpointConfiguration.TurkPos_x0020_WS_x0020_TESTSoap12);
            return Ok(await client.BIN_SanalPosAsync(dto.G, dto.BIN));
        }
        [HttpPost("[action]")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Il_ListeAsync([FromBody] Il_ListeRequestDTO dto)
        {
            using TurkPosWSTESTSoapClient client = new(TurkPosWSTESTSoapClient.EndpointConfiguration.TurkPos_x0020_WS_x0020_TESTSoap12);
            return Ok(await client.Il_ListeAsync(dto.G));
        }
        [HttpPost("[action]")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> KK_SaklamaAsync([FromBody] KK_SaklamaRequestDTO dto)
        {
            using TurkPosWSTESTSoapClient client = new(TurkPosWSTESTSoapClient.EndpointConfiguration.TurkPos_x0020_WS_x0020_TESTSoap12);
            return Ok(await client.KK_SaklamaAsync(dto.G, dto.Kart_No, dto.KK_Sahibi, dto.KK_No, dto.KK_SK_Ay, dto.KK_SK_Yil, dto.KK_CVV, dto.Data1, dto.Data2, dto.Data3));
        }
        [HttpPost("[action]")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> KK_Sakli_ListeAsync([FromBody] KK_Sakli_ListeRequestDTO dto)
        {
            using TurkPosWSTESTSoapClient client = new(TurkPosWSTESTSoapClient.EndpointConfiguration.TurkPos_x0020_WS_x0020_TESTSoap12);
            return Ok(await client.KK_Sakli_ListeAsync(dto.G, dto.Kart_No, dto.KS_KK_Kisi_ID));
        }
        [HttpPost("[action]")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> MP_Order_Cancel_RefundAsync([FromBody] MP_Order_Cancel_RefundRequestDTO dto)
        {
            using TurkPosWSTESTSoapClient client = new(TurkPosWSTESTSoapClient.EndpointConfiguration.TurkPos_x0020_WS_x0020_TESTSoap12);
            return Ok(await client.MP_OrderCancelRefundAsync(dto.d));
        }
        [HttpPost("[action]")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> MP_OrderDetailAddAsync([FromBody] MP_OrderDetailAddRequestDTO dto)
        {
            using TurkPosWSTESTSoapClient client = new(TurkPosWSTESTSoapClient.EndpointConfiguration.TurkPos_x0020_WS_x0020_TESTSoap12);
            return Ok(await client.MP_OrderDetailAddAsync(dto.d));
        }
        [HttpPost("[action]")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> MP_OrderDetailListAsync([FromBody] MP_OrderDetailListRequestDTO dto)
        {
            using TurkPosWSTESTSoapClient client = new(TurkPosWSTESTSoapClient.EndpointConfiguration.TurkPos_x0020_WS_x0020_TESTSoap12);
            return Ok(await client.MP_OrderDetailListAsync(dto.d));
        }
        [HttpPost("[action]")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> MP_OrderDetailQueryAsync([FromBody] MP_OrderDetailQuerytRequestDTO dto)
        {
            using TurkPosWSTESTSoapClient client = new(TurkPosWSTESTSoapClient.EndpointConfiguration.TurkPos_x0020_WS_x0020_TESTSoap12);
            return Ok(await client.MP_OrderDetailQueryAsync(dto.d));
        }
        [HttpPost("[action]")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> MP_OrderDetailStatusAsync([FromBody] MP_OrderDetailStatustRequestDTO dto)
        {
            using TurkPosWSTESTSoapClient client = new(TurkPosWSTESTSoapClient.EndpointConfiguration.TurkPos_x0020_WS_x0020_TESTSoap12);
            return Ok(await client.MP_OrderDetailStatusAsync(dto.d));
        }
        [HttpPost("[action]")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> MP_OrderDetailUpdateAsync([FromBody] MP_OrderDetailUpdateRequestDTO dto)
        {
            using TurkPosWSTESTSoapClient client = new(TurkPosWSTESTSoapClient.EndpointConfiguration.TurkPos_x0020_WS_x0020_TESTSoap12);
            return Ok(await client.MP_OrderDetailUpdateAsync(dto.d));
        }
        [HttpPost("[action]")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> MoneyPay_Islem_SorgulamaAsync([FromBody] MoneyPay_Islem_SorgulamaRequestDTO dto)
        {
            using TurkPosWSTESTSoapClient client = new(TurkPosWSTESTSoapClient.EndpointConfiguration.TurkPos_x0020_WS_x0020_TESTSoap12);
            return Ok(await client.MoneyPay_Islem_SorgulamaAsync(dto.G, dto.GUID, dto.Siparis_ID, dto.Tarih_Bas, dto.Tarih_Bit));
        }
        [HttpPost("[action]")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Param_Pazaryeri_Islem_IzlemeAsync([FromBody] Param_Pazaryeri_Islem_IzlemeRequestDTO dto)
        {
            using TurkPosWSTESTSoapClient client = new(TurkPosWSTESTSoapClient.EndpointConfiguration.TurkPos_x0020_WS_x0020_TESTSoap12);
            return Ok(await client.Param_Pazaryeri_Islem_IzlemeAsync(dto.G, dto.IslemIzlemeReq));
        }
        [HttpPost("[action]")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Payment_HopiAsync([FromBody] Payment_HopiRequestDTO dto)
        {
            using TurkPosWSTESTSoapClient client = new(TurkPosWSTESTSoapClient.EndpointConfiguration.TurkPos_x0020_WS_x0020_TESTSoap12);
            return Ok(await client.Payment_HopiAsync(dto.d));
        }
        [HttpPost("[action]")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Pazaryeri_TP_AltUyeIsyeri_EklemeAsync([FromBody] Pazaryeri_TP_AltUyeIsyeri_EklemeRequestDTO dto)
        {
            using TurkPosWSTESTSoapClient client = new(TurkPosWSTESTSoapClient.EndpointConfiguration.TurkPos_x0020_WS_x0020_TESTSoap12);
            return Ok(await client.Pazaryeri_TP_AltUyeIsyeri_EklemeAsync(dto.G, dto.ETS_GUID, dto.Tip, dto.Ad_Soyad, dto.Unvan, dto.TC_VN, dto.Kisi_DogumTarihi, dto.GSM_No, dto.IBAN_No, dto.IBAN_Unvan, dto.Adres, dto.Il, dto.Ilce, dto.EPosta, dto.Website, dto.MCC_Kod, dto.Yetkili_Kisi_TC, dto.Yetkili_Kisi_DogumTarihi, dto.Vergi_Daire, dto.Bagli_Olunan_Hesap));
        }
        [HttpPost("[action]")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Pazaryeri_TP_AltUyeIsyeri_Ekleme_v2Async([FromBody] Pazaryeri_TP_AltUyeIsyeri_Ekleme_v2RequestDTO dto)
        {
            using TurkPosWSTESTSoapClient client = new(TurkPosWSTESTSoapClient.EndpointConfiguration.TurkPos_x0020_WS_x0020_TESTSoap12);
            return Ok(await client.Pazaryeri_TP_AltUyeIsyeri_Ekleme_v2Async(dto.G, dto.ETS_GUID, dto.Tip, dto.Ad_Soyad, dto.Unvan, dto.TC_VN, dto.Kisi_DogumTarihi, dto.GSM_No, dto.IBAN_No, dto.IBAN_Unvan, dto.Adres, dto.Il, dto.Ilce, dto.EPosta, dto.Website, dto.MCC_Kod, dto.Yetkili_Kisi_TC, dto.Yetkili_Kisi_DogumTarihi, dto.Vergi_Daire, dto.Bagli_Olunan_Hesap, dto.SAPId, dto.MageontoId));
        }
        [HttpPost("[action]")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Pazaryeri_TP_AltUyeIsyeri_GuncellemeAsync([FromBody] Pazaryeri_TP_AltUyeIsyeri_GuncellemeRequestDTO dto)
        {
            using TurkPosWSTESTSoapClient client = new(TurkPosWSTESTSoapClient.EndpointConfiguration.TurkPos_x0020_WS_x0020_TESTSoap12);
            return Ok(await client.Pazaryeri_TP_AltUyeIsyeri_GuncellemeAsync(dto.G, dto.GUID_AltUyeIsyeri, dto.Ad_Soyad, dto.Unvan, dto.GSM_No, dto.IBAN_No, dto.IBAN_Unvan, dto.Adres, dto.Il, dto.Ilce, dto.EPosta, dto.Website, dto.MCC_Kod, dto.Vergi_Daire, dto.Bagli_Olunan_Hesap));
        }
        [HttpPost("[action]")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Pazaryeri_TP_AltUyeIsyeri_Guncelleme_v2Async([FromBody] Pazaryeri_TP_AltUyeIsyeri_Guncelleme_v2RequestDTO dto)
        {
            using TurkPosWSTESTSoapClient client = new(TurkPosWSTESTSoapClient.EndpointConfiguration.TurkPos_x0020_WS_x0020_TESTSoap12);
            return Ok(await client.Pazaryeri_TP_AltUyeIsyeri_Guncelleme_v2Async(dto.G, dto.GUID_AltUyeIsyeri, dto.Ad_Soyad, dto.Unvan, dto.GSM_No, dto.IBAN_No, dto.IBAN_Unvan, dto.Adres, dto.Il, dto.Ilce, dto.EPosta, dto.Website, dto.MCC_Kod, dto.Vergi_Daire, dto.Bagli_Olunan_Hesap, dto.SAPId, dto.MageontoId));
        }
        [HttpPost("[action]")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Pazaryeri_TP_AltUyeIsyeri_ListeAsync([FromBody] Pazaryeri_TP_AltUyeIsyeri_ListeRequestDTO dto)
        {
            using TurkPosWSTESTSoapClient client = new(TurkPosWSTESTSoapClient.EndpointConfiguration.TurkPos_x0020_WS_x0020_TESTSoap12);
            return Ok(await client.Pazaryeri_TP_AltUyeIsyeri_ListeAsync(dto.G, dto.ETS_GUID, dto.Limit, dto.Skip));
        }
        [HttpPost("[action]")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Pazaryeri_TP_AltUyeIsyeri_SilmeAsync([FromBody] Pazaryeri_TP_AltUyeIsyeri_SilmeRequestDTO dto)
        {
            using TurkPosWSTESTSoapClient client = new(TurkPosWSTESTSoapClient.EndpointConfiguration.TurkPos_x0020_WS_x0020_TESTSoap12);
            return Ok(await client.Pazaryeri_TP_AltUyeIsyeri_SilmeAsync(dto.G, dto.GUID_AltUyeIsyeri));
        }
        [HttpPost("[action]")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Pazaryeri_TP_Iptal_IadeAsync([FromBody] Pazaryeri_TP_Iptal_IadeRequestDTO dto)
        {
            using TurkPosWSTESTSoapClient client = new(TurkPosWSTESTSoapClient.EndpointConfiguration.TurkPos_x0020_WS_x0020_TESTSoap12);
            return Ok(await client.Pazaryeri_TP_Iptal_IadeAsync(dto.G, dto.PYSiparis_GUID, dto.GUID, dto.Durum, dto.Siparis_ID, dto.SiparisTutar, dto.OdenecekTutar));
        }
        [HttpPost("[action]")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Pazaryeri_TP_Islem_SorgulamaAsync([FromBody] Pazaryeri_TP_Islem_SorgulamaRequestDTO dto)
        {
            using TurkPosWSTESTSoapClient client = new(TurkPosWSTESTSoapClient.EndpointConfiguration.TurkPos_x0020_WS_x0020_TESTSoap12);
            return Ok(await client.Pazaryeri_TP_Islem_SorgulamaAsync(dto.G, dto.ETS_GUID, dto.GUID_AltUyeIsyeri, dto.PYSiparis_GUID, dto.SanalPOS_Islem_ID, dto.Tarih_Bas, dto.Tarih_Bit));
        }
        [HttpPost("[action]")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Pazaryeri_TP_Limit_KontrolAsync([FromBody] Pazaryeri_TP_Limit_KontrolRequestDTO dto)
        {
            using TurkPosWSTESTSoapClient client = new(TurkPosWSTESTSoapClient.EndpointConfiguration.TurkPos_x0020_WS_x0020_TESTSoap12);
            return Ok(await client.Pazaryeri_TP_Limit_KontrolAsync(dto.ETS_GUID, dto.GUID_AltUyeIsyeri, dto.Tutar_Odenecek));
        }
        [HttpPost("[action]")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Pazaryeri_TP_Siparis_Detay_EkleAsync([FromBody] Pazaryeri_TP_Siparis_Detay_EkleRequestDTO dto)
        {
            using TurkPosWSTESTSoapClient client = new(TurkPosWSTESTSoapClient.EndpointConfiguration.TurkPos_x0020_WS_x0020_TESTSoap12);
            return Ok(await client.Pazaryeri_TP_Siparis_Detay_EkleAsync(dto.G, dto.ETS_GUID, dto.Tutar_Urun, dto.Tutar_Odenecek, dto.SanalPOS_Islem_ID, dto.GUID_AltUyeIsyeri));
        }
        [HttpPost("[action]")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Pazaryeri_TP_Siparis_OnayAsync([FromBody] Pazaryeri_TP_Siparis_OnayRequestDTO dto)
        {
            using TurkPosWSTESTSoapClient client = new(TurkPosWSTESTSoapClient.EndpointConfiguration.TurkPos_x0020_WS_x0020_TESTSoap12);
            return Ok(await client.Pazaryeri_TP_Siparis_OnayAsync(dto.G, dto.PYSiparisGUID, dto.Durum));
        }

        [HttpPost("[action]")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Pos_Plugin_BildirimAsync([FromBody] Pos_Plugin_BildirimRequestDTO dto)
        {
            using TurkPosWSTESTSoapClient client = new(TurkPosWSTESTSoapClient.EndpointConfiguration.TurkPos_x0020_WS_x0020_TESTSoap12);
            return Ok(await client.Pos_Plugin_BildirimAsync(dto.G, dto.ETS_GUID, dto.Domain_Adres, dto.Yazilim_Bilgisi, dto.Yazilim_Surum_Bilgisi));
        }
        [HttpPost("[action]")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SHA2B64Async([FromBody] SHA2B64RequestDTO dto)
        {
            using TurkPosWSTESTSoapClient client = new(TurkPosWSTESTSoapClient.EndpointConfiguration.TurkPos_x0020_WS_x0020_TESTSoap12);
            return Ok(await client.SHA2B64Async(dto.ClientCode + dto.GUID + dto.Taksit + dto.IslemTutar + dto.ToplamTutar + dto.SiparisId + dto.HataURL + dto.BasariliURL));
        }
        [HttpPost("[action]")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TP_Islem_CheckoutAsync([FromBody] TP_Islem_CheckoutRequestDTO dto)
        {
            using TurkPosWSTESTSoapClient client = new(TurkPosWSTESTSoapClient.EndpointConfiguration.TurkPos_x0020_WS_x0020_TESTSoap12);
            return Ok(await client.TP_Islem_CheckoutAsync(dto.CLIENT_CODE, dto.GUID, dto.IPAdr));
        }
        [HttpPost("[action]")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TP_Islem_Checkout_Odeme_WNSAsync([FromBody] TP_Islem_Checkout_Odeme_WNSRequestDTO dto)
        {
            using TurkPosWSTESTSoapClient client = new(TurkPosWSTESTSoapClient.EndpointConfiguration.TurkPos_x0020_WS_x0020_TESTSoap12);
            return Ok(await client.TP_Islem_Checkout_Odeme_WNSAsync(dto.G, dto.SanalPOS_ID, dto.GUID, dto.KK_Sahibi, dto.KK_No, dto.KK_SK_Ay, dto.KK_SK_Yil, dto.KK_CVC, dto.KK_Sahibi_GSM, dto.Hata_URL, dto.Basarili_URL, dto.Siparis_ID, dto.Siparis_Aciklama, dto.Taksit, dto.Islem_Tutar, dto.Toplam_Tutar, dto.Islem_Hash, dto.Islem_Guvenlik_Tip, dto.Islem_ID, dto.IPAdr, dto.Ref_URL, dto.Data1, dto.Data2, dto.Data3, dto.Data4, dto.Data5, dto.Firma_IPAdr));
        }
        [HttpPost("[action]")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TP_Islem_Checkout_SKAsync([FromBody] TP_Islem_Checkout_SKRequestDTO dto)
        {
            using TurkPosWSTESTSoapClient client = new(TurkPosWSTESTSoapClient.EndpointConfiguration.TurkPos_x0020_WS_x0020_TESTSoap12);
            return Ok(await client.TP_Islem_Checkout_SKAsync(dto.CLIENT_CODE, dto.GUID, dto.IPAdr, dto.KKB_IN, dto.Tutar));
        }
        [HttpPost("[action]")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TP_Islem_Dekont_GonderAsync([FromBody] TP_Islem_Dekont_GonderRequestDTO dto)
        {
            using TurkPosWSTESTSoapClient client = new(TurkPosWSTESTSoapClient.EndpointConfiguration.TurkPos_x0020_WS_x0020_TESTSoap12);
            return Ok(await client.TP_Islem_Dekont_GonderAsync(dto.G, dto.GUID, dto.Dekont_ID, dto.E_Posta));
        }
        [HttpPost("[action]")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TP_Islem_Iptal_IadeAsync([FromBody] TP_Islem_Iptal_IadeRequestDTO dto)
        {
            using TurkPosWSTESTSoapClient client = new(TurkPosWSTESTSoapClient.EndpointConfiguration.TurkPos_x0020_WS_x0020_TESTSoap12);
            return Ok(await client.TP_Islem_Iptal_IadeAsync(dto.G, dto.GUID, dto.Durum, dto.Dekont_ID));
        }
        [HttpPost("[action]")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TP_Islem_Iptal_Iade2Async([FromBody] TP_Islem_Iptal_Iade2RequestDTO dto)
        {
            using TurkPosWSTESTSoapClient client = new(TurkPosWSTESTSoapClient.EndpointConfiguration.TurkPos_x0020_WS_x0020_TESTSoap12);
            return Ok(await client.TP_Islem_Iptal_Iade2Async(dto.G, dto.GUID, dto.Durum, dto.Siparis_ID));
        }
        [HttpPost("[action]")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TP_Islem_Iptal_Iade_KismiAsync([FromBody] TP_Islem_Iptal_Iade_KismiRequestDTO dto)
        {
            using TurkPosWSTESTSoapClient client = new(TurkPosWSTESTSoapClient.EndpointConfiguration.TurkPos_x0020_WS_x0020_TESTSoap12);
            return Ok(await client.TP_Islem_Iptal_Iade_KismiAsync(dto.G, dto.GUID, dto.Durum, dto.Dekont_ID, dto.Tutar));
        }
        [HttpPost("[action]")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TP_Islem_Iptal_Iade_Kismi2Async([FromBody] TP_Islem_Iptal_Iade_Kismi2RequestDTO dto)
        {
            using TurkPosWSTESTSoapClient client = new(TurkPosWSTESTSoapClient.EndpointConfiguration.TurkPos_x0020_WS_x0020_TESTSoap12);
            return Ok(await client.TP_Islem_Iptal_Iade_Kismi2Async(dto.G, dto.GUID, dto.Durum, dto.Siparis_ID, dto.Tutar));
        }
        [HttpPost("[action]")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TP_Islem_Iptal_Iade_Kismi3Async([FromBody] TP_Islem_Iptal_Iade_Kismi3RequestDTO dto)
        {
            using TurkPosWSTESTSoapClient client = new(TurkPosWSTESTSoapClient.EndpointConfiguration.TurkPos_x0020_WS_x0020_TESTSoap12);
            return Ok(await client.TP_Islem_Iptal_Iade_Kismi3Async(dto.G, dto.GUID, dto.Durum, dto.Siparis_ID, dto.Tutar, dto.Ref_No));
        }
        [HttpPost("[action]")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TP_Islem_Iptal_Iade_Kismi4Async([FromBody] TP_Islem_Iptal_Iade_Kismi4RequestDTO dto)
        {
            using TurkPosWSTESTSoapClient client = new(TurkPosWSTESTSoapClient.EndpointConfiguration.TurkPos_x0020_WS_x0020_TESTSoap12);
            return Ok(await client.TP_Islem_Iptal_Iade_Kismi4Async(dto.G, dto.GUID, dto.Durum, dto.Siparis_ID, dto.Tutar));
        }
        [HttpPost("[action]")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TP_Islem_Iptal_Iade_Kismi_WPAsync([FromBody] TP_Islem_Iptal_Iade_Kismi_WPRequestDTO dto)
        {
            using TurkPosWSTESTSoapClient client = new(TurkPosWSTESTSoapClient.EndpointConfiguration.TurkPos_x0020_WS_x0020_TESTSoap12);
            return Ok(await client.TP_Islem_Iptal_Iade_Kismi_WPAsync(dto.G, dto.GUID, dto.Durum, dto.Siparis_ID, dto.Tutar, dto.Ref_No));
        }
        [HttpPost("[action]")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TP_Islem_Iptal_OnProvAsync([FromBody] TP_Islem_Iptal_OnProvRequestDTO dto)
        {
            using TurkPosWSTESTSoapClient client = new(TurkPosWSTESTSoapClient.EndpointConfiguration.TurkPos_x0020_WS_x0020_TESTSoap12);
            return Ok(await client.TP_Islem_Iptal_OnProvAsync(dto.G, dto.GUID, dto.Prov_ID, dto.Siparis_ID));
        }
        [HttpPost("[action]")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TP_Islem_IzlemeAsync([FromBody] TP_Islem_IzlemeRequestDTO dto)
        {
            using TurkPosWSTESTSoapClient client = new(TurkPosWSTESTSoapClient.EndpointConfiguration.TurkPos_x0020_WS_x0020_TESTSoap12);
            return Ok(await client.TP_Islem_IzlemeAsync(dto.G, dto.GUID, dto.Tarih_Bas, dto.Tarih_Bit, dto.Islem_Tip, dto.Islem_Durum));
        }
        [HttpPost("[action]")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TP_Islem_OdemeAsync([FromBody] TP_Islem_OdemeRequestDTO dto)
        {
            using TurkPosWSTESTSoapClient client = new(TurkPosWSTESTSoapClient.EndpointConfiguration.TurkPos_x0020_WS_x0020_TESTSoap12);
            return Ok(await client.TP_Islem_OdemeAsync(dto.G, dto.SanalPOS_ID, dto.GUID, dto.KK_Sahibi, dto.KK_No, dto.KK_SK_Ay, dto.KK_SK_Yil, dto.KK_CVC, dto.KK_Sahibi_GSM, dto.Hata_URL, dto.Basarili_URL, dto.Siparis_ID, dto.Siparis_Aciklama, dto.Taksit, dto.Islem_Tutar, dto.Toplam_Tutar, dto.Islem_Hash, dto.Islem_ID, dto.IPAdr, dto.Ref_URL, dto.Data1, dto.Data2, dto.Data3, dto.Data4, dto.Data5));
        }
        [HttpPost("[action]")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TP_Islem_Odeme_BKMAsync([FromBody] TP_Islem_Odeme_BKMRequestDTO dto)
        {
            using TurkPosWSTESTSoapClient client = new(TurkPosWSTESTSoapClient.EndpointConfiguration.TurkPos_x0020_WS_x0020_TESTSoap12);
            return Ok(await client.TP_Islem_Odeme_BKMAsync(dto.G, dto.GUID, dto.Customer_Info, dto.Customer_GSM, dto.Error_URL, dto.Success_URL, dto.Order_ID, dto.Order_Description, dto.Amount, dto.Payment_Hash, dto.Transaction_ID, dto.IPAddress, dto.Referrer_URL));
        }
        [HttpPost("[action]")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TP_Islem_Odeme_OnProvAsync([FromBody] TP_Islem_Odeme_OnProvRequestDTO dto)
        {
            using TurkPosWSTESTSoapClient client = new(TurkPosWSTESTSoapClient.EndpointConfiguration.TurkPos_x0020_WS_x0020_TESTSoap12);
            return Ok(await client.TP_Islem_Odeme_OnProvAsync(dto.G, dto.GUID, dto.KK_Sahibi, dto.KK_No, dto.KK_SK_Ay, dto.KK_SK_Yil, dto.KK_CVC, dto.KK_Sahibi_GSM, dto.Hata_URL, dto.Basarili_URL, dto.Siparis_ID, dto.Siparis_Aciklama, dto.Islem_Tutar, dto.Toplam_Tutar, dto.Islem_Hash, dto.Islem_Guvenlik_Tip, dto.Islem_ID, dto.IPAdr, dto.Ref_URL, dto.Data1, dto.Data2, dto.Data3, dto.Data4, dto.Data5));
        }
        [HttpPost("[action]")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TP_Islem_Odeme_OnProv_KapaAsync([FromBody] TP_Islem_Odeme_OnProv_KapaRequestDTO dto)
        {
            using TurkPosWSTESTSoapClient client = new(TurkPosWSTESTSoapClient.EndpointConfiguration.TurkPos_x0020_WS_x0020_TESTSoap12);
            return Ok(await client.TP_Islem_Odeme_OnProv_KapaAsync(dto.G, dto.GUID, dto.Prov_ID, dto.Prov_Tutar, dto.Siparis_ID));
        }
        [HttpPost("[action]")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TP_Islem_Odeme_OnProv_WKSAsync([FromBody] TP_Islem_Odeme_OnProv_WKSRequestDTO dto)
        {
            using TurkPosWSTESTSoapClient client = new(TurkPosWSTESTSoapClient.EndpointConfiguration.TurkPos_x0020_WS_x0020_TESTSoap12);
            return Ok(await client.TP_Islem_Odeme_OnProv_WKSAsync(dto.G, dto.GUID, dto.KS_Kart_No, dto.KK_GUID, dto.KK_Sahibi_GSM, dto.Hata_URL, dto.Basarili_URL, dto.Siparis_ID, dto.Siparis_Aciklama, dto.Islem_Tutar, dto.Toplam_Tutar, dto.Islem_Hash, dto.Islem_Guvenlik_Tip, dto.Islem_ID, dto.IPAdr, dto.Ref_URL, dto.Data1, dto.Data2, dto.Data3, dto.Data4, dto.Data5));
        }
        [HttpPost("[action]")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TP_Islem_Odeme_OnProv_WMDAsync([FromBody] TP_Islem_Odeme_OnProv_WMDRequestDTO dto)
        {
            using TurkPosWSTESTSoapClient client = new(TurkPosWSTESTSoapClient.EndpointConfiguration.TurkPos_x0020_WS_x0020_TESTSoap12);
            return Ok(await client.TP_Islem_Odeme_OnProv_WMDAsync(dto.G, dto.GUID, dto.KK_Sahibi, dto.KK_No, dto.KK_SK_Ay, dto.KK_SK_Yil, dto.KK_CVC, dto.KK_Sahibi_GSM, dto.Hata_URL, dto.Basarili_URL, dto.Siparis_ID, dto.Siparis_Aciklama, dto.Islem_Tutar, dto.Toplam_Tutar, dto.Islem_Hash, dto.Islem_Guvenlik_Tip, dto.Islem_ID, dto.IPAdr, dto.Ref_URL, dto.Data1, dto.Data2, dto.Data3, dto.Data4, dto.Data5, dto.Taksit));
        }
        [HttpPost("[action]")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TP_Islem_Odeme_WDDAsync([FromBody] TP_Islem_Odeme_WDRequestDTO dto)
        {
            using TurkPosWSTESTSoapClient client = new(TurkPosWSTESTSoapClient.EndpointConfiguration.TurkPos_x0020_WS_x0020_TESTSoap12);
            return Ok(await client.TP_Islem_Odeme_WDAsync(dto.G, dto.DovizKodu, dto.GUID, dto.KK_Sahibi, dto.KK_No, dto.KK_SK_Ay, dto.KK_SK_Yil, dto.KK_CVC, dto.KK_Sahibi_GSM, dto.Hata_URL, dto.Basarili_URL, dto.Siparis_ID, dto.Siparis_Aciklama, dto.Islem_Tutar, dto.Toplam_Tutar, dto.Islem_Hash, dto.Islem_Guvenlik_Tip, dto.Islem_ID, dto.IPAdr, dto.Ref_URL, dto.Data1, dto.Data2, dto.Data3, dto.Data4, dto.Data5));
        }
        [HttpPost("[action]")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TP_Islem_Odeme_WKSAsync([FromBody] TP_Islem_Odeme_WKSRequestDTO dto)
        {
            using TurkPosWSTESTSoapClient client = new(TurkPosWSTESTSoapClient.EndpointConfiguration.TurkPos_x0020_WS_x0020_TESTSoap12);
            return Ok(await client.TP_Islem_Odeme_WKSAsync(dto.G, dto.SanalPOS_ID, dto.GUID, dto.KS_Kart_No, dto.KK_GUID, dto.KK_Sahibi_GSM, dto.Hata_URL, dto.Basarili_URL, dto.Siparis_ID, dto.Siparis_Aciklama, dto.Taksit, dto.Islem_Tutar, dto.Toplam_Tutar, dto.Islem_Hash, dto.Islem_Guvenlik_Tip, dto.Islem_ID, dto.IPAdr, dto.Ref_URL, dto.Data1, dto.Data2, dto.Data3, dto.Data4, dto.Data5));
        }
        [HttpPost("[action]")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TP_Islem_Odeme_WNSAsync([FromBody] TP_Islem_Odeme_WNSRequestDTO dto)
        {
            using TurkPosWSTESTSoapClient client = new(TurkPosWSTESTSoapClient.EndpointConfiguration.TurkPos_x0020_WS_x0020_TESTSoap12);
            return Ok(await client.TP_Islem_Odeme_WNSAsync(dto.G, dto.SanalPOS_ID, dto.GUID, dto.KK_Sahibi, dto.KK_No, dto.KK_SK_Ay, dto.KK_SK_Yil, dto.KK_CVC, dto.KK_Sahibi_GSM, dto.Hata_URL, dto.Basarili_URL, dto.Siparis_ID, dto.Siparis_Aciklama, dto.Taksit, dto.Islem_Tutar, dto.Toplam_Tutar, dto.Islem_Hash, dto.Islem_Guvenlik_Tip, dto.Islem_ID, dto.IPAdr, dto.Ref_URL, dto.Data1, dto.Data2, dto.Data3, dto.Data4, dto.Data5));
        }
        [HttpPost("[action]")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TP_Islem_SorgulamaAsync([FromBody] TP_Islem_SorgulamaRequestDTO dto)
        {
            using TurkPosWSTESTSoapClient client = new(TurkPosWSTESTSoapClient.EndpointConfiguration.TurkPos_x0020_WS_x0020_TESTSoap12);
            return Ok(await client.TP_Islem_SorgulamaAsync(dto.G, dto.GUID, dto.Dekont_ID, dto.Siparis_ID, dto.Islem_ID));
        }
        [HttpPost("[action]")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TP_Islem_Sorgulama4Async([FromBody] TP_Islem_Sorgulama4RequestDTO dto)
        {
            using TurkPosWSTESTSoapClient client = new(TurkPosWSTESTSoapClient.EndpointConfiguration.TurkPos_x0020_WS_x0020_TESTSoap12);
            return Ok(await client.TP_Islem_Sorgulama4Async(dto.G, dto.GUID, dto.Dekont_ID, dto.Siparis_ID, dto.Islem_ID));
        }
        [HttpPost("[action]")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TP_Islem_Sorgulama5Async([FromBody] TP_Islem_Sorgulama5RequestDTO dto)
        {
            using TurkPosWSTESTSoapClient client = new(TurkPosWSTESTSoapClient.EndpointConfiguration.TurkPos_x0020_WS_x0020_TESTSoap12);
            return Ok(await client.TP_Islem_Sorgulama5Async(dto.G, dto.GUID, dto.Dekont_ID, dto.Siparis_ID, dto.Islem_ID));
        }
        [HttpPost("[action]")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TP_Islem_Sorgulama6Async([FromBody] TP_Islem_Sorgulama6RequestDTO dto)
        {
            using TurkPosWSTESTSoapClient client = new(TurkPosWSTESTSoapClient.EndpointConfiguration.TurkPos_x0020_WS_x0020_TESTSoap12);
            return Ok(await client.TP_Islem_Sorgulama6Async(dto.G, dto.GUID, dto.Siparis_ID));
        }
        [HttpPost("[action]")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TP_Islem_Sorgulama_WPAsync([FromBody] TP_Islem_Sorgulama_WPRequestDTO dto)
        {
            using TurkPosWSTESTSoapClient client = new(TurkPosWSTESTSoapClient.EndpointConfiguration.TurkPos_x0020_WS_x0020_TESTSoap12);
            return Ok(await client.TP_Islem_Sorgulama_WPAsync(dto.G, dto.GUID, dto.Dekont_ID, dto.Siparis_ID, dto.Islem_ID, dto.Ref_No));
        }
        [HttpPost("[action]")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TP_KK_VerifyAsync([FromBody] TP_KK_VerifyRequestDTO dto)
        {
            using TurkPosWSTESTSoapClient client = new(TurkPosWSTESTSoapClient.EndpointConfiguration.TurkPos_x0020_WS_x0020_TESTSoap12);
            return Ok(await client.TP_KK_VerifyAsync(dto.G, dto.KK_No, dto.KK_SK_Ay, dto.KK_SK_Yil, dto.KK_CVC, dto.Return_URL, dto.Data1, dto.Data2, dto.Data3, dto.Data4, dto.Data5));
        }
        [HttpPost("[action]")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TP_Modal_PaymentAsync([FromBody] TP_Modal_PaymentRequestDTO dto)
        {
            using TurkPosWSTESTSoapClient client = new(TurkPosWSTESTSoapClient.EndpointConfiguration.TurkPos_x0020_WS_x0020_TESTSoap12);
            return Ok(await client.TP_Modal_PaymentAsync(dto.d));
        }
        [HttpPost("[action]")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TP_Modal_PaymentAsync([FromBody] TP_Multiple_PaymentRequestDTO dto)
        {
            using TurkPosWSTESTSoapClient client = new(TurkPosWSTESTSoapClient.EndpointConfiguration.TurkPos_x0020_WS_x0020_TESTSoap12);
            return Ok(await client.TP_Multiple_PaymentAsync(dto.Payment_Info));
        }
        [HttpPost("[action]")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TP_Multiple_Payment_StatusAsync([FromBody] TP_Multiple_Payment_StatusRequestDTO dto)
        {
            using TurkPosWSTESTSoapClient client = new(TurkPosWSTESTSoapClient.EndpointConfiguration.TurkPos_x0020_WS_x0020_TESTSoap12);
            return Ok(await client.TP_Multiple_Payment_StatusAsync(dto.Payment_Info));
        }
        [HttpPost("[action]")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TP_Mutabakat_DetayAsync([FromBody] TP_Mutabakat_DetayRequestDTO dto)
        {
            using TurkPosWSTESTSoapClient client = new(TurkPosWSTESTSoapClient.EndpointConfiguration.TurkPos_x0020_WS_x0020_TESTSoap12);
            return Ok(await client.TP_Mutabakat_DetayAsync(dto.G, dto.GUID, dto.Tarih));
        }
        [HttpPost("[action]")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TP_Mutabakat_OzetAsync([FromBody] TP_Mutabakat_OzetRequestDTO dto)
        {
            using TurkPosWSTESTSoapClient client = new(TurkPosWSTESTSoapClient.EndpointConfiguration.TurkPos_x0020_WS_x0020_TESTSoap12);
            return Ok(await client.TP_Mutabakat_OzetAsync(dto.G, dto.GUID, dto.Tarih_Bas, dto.Tarih_Bit));
        }
        [HttpPost("[action]")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TP_Ozel_Oran_ListeAsync([FromBody] TP_Ozel_Oran_ListeRequestDTO dto)
        {
            using TurkPosWSTESTSoapClient client = new(TurkPosWSTESTSoapClient.EndpointConfiguration.TurkPos_x0020_WS_x0020_TESTSoap12);
            return Ok(await client.TP_Ozel_Oran_ListeAsync(dto.G, dto.GUID));
        }
        [HttpPost("[action]")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TP_Ozel_Oran_SK_GuncelleAsync([FromBody] TP_Ozel_Oran_SK_GuncelleRequestDTO dto)
        {
            using TurkPosWSTESTSoapClient client = new(TurkPosWSTESTSoapClient.EndpointConfiguration.TurkPos_x0020_WS_x0020_TESTSoap12);
            return Ok(await client.TP_Ozel_Oran_SK_GuncelleAsync(dto.G, dto.GUID, dto.Ozel_Oran_SK_ID, dto.MO_1, dto.MO_2, dto.MO_3, dto.MO_4, dto.MO_5, dto.MO_6, dto.MO_7, dto.MO_8, dto.MO_9, dto.MO_10, dto.MO_11, dto.MO_12));
        }
        [HttpPost("[action]")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TP_Ozel_Oran_SK_ListeAsync([FromBody] TP_Ozel_Oran_SK_ListeRequestDTO dto)
        {
            using TurkPosWSTESTSoapClient client = new(TurkPosWSTESTSoapClient.EndpointConfiguration.TurkPos_x0020_WS_x0020_TESTSoap12);
            return Ok(await client.TP_Ozel_Oran_SK_ListeAsync(dto.G, dto.GUID));
        }
        [HttpPost("[action]")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TPWMDPayAsync([FromBody] TP_WMD_PayRequestDTO dto)
        {
            using TurkPosWSTESTSoapClient client = new(TurkPosWSTESTSoapClient.EndpointConfiguration.TurkPos_x0020_WS_x0020_TESTSoap12);
            return Ok(await client.TP_WMD_PayAsync(dto.G, dto.GUID, dto.UCD_MD, dto.Islem_GUID, dto.Siparis_ID));
        }

        [HttpPost("[action]")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TPWMDUCDAsync([FromBody] TP_WMD_UCDRequestDTO dto)
        {
            using TurkPosWSTESTSoapClient client = new(TurkPosWSTESTSoapClient.EndpointConfiguration.TurkPos_x0020_WS_x0020_TESTSoap12);
            return Ok(await client.TP_WMD_UCDAsync(dto.G, dto.GUID, dto.KK_Sahibi, dto.KK_No, dto.KK_SK_Ay, dto.KK_SK_Yil, dto.KK_CVC, dto.KK_Sahibi_GSM, dto.Hata_URL, dto.Basarili_URL, dto.Siparis_ID, dto.Siparis_Aciklama, dto.Taksit, dto.Islem_Tutar, dto.Toplam_Tutar, dto.Islem_Hash, dto.Islem_Guvenlik_Tip, dto.Islem_ID, dto.IPAdr, dto.Ref_URL, dto.Data1, dto.Data2, dto.Data3, dto.Data4, dto.Data5));
        }

        [HttpPost("[action]")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TP_WMD_UCD_PuanAsync([FromBody] TP_WMD_UCD_PuanRequestDTO dto)
        {
            using TurkPosWSTESTSoapClient client = new(TurkPosWSTESTSoapClient.EndpointConfiguration.TurkPos_x0020_WS_x0020_TESTSoap12);
            return Ok(await client.TP_WMD_UCD_PuanAsync(dto.G, dto.GUID, dto.KK_Sahibi, dto.KK_No, dto.KK_SK_Ay, dto.KK_SK_Yil, dto.KK_CVC, dto.KK_Sahibi_GSM, dto.Hata_URL, dto.Basarili_URL, dto.Siparis_ID, dto.Siparis_Aciklama, dto.Taksit, dto.Islem_Tutar, dto.Toplam_Tutar, dto.Islem_Hash, dto.Islem_Guvenlik_Tip, dto.Islem_ID, dto.IPAdr, dto.Ref_URL, dto.Data1, dto.Data2, dto.Data3, dto.Data4, dto.Data5, dto.PosID, dto.Islem_Tip));
        }
        [HttpPost("[action]")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TP_WMD_UCD_WPAsync([FromBody] TP_WMD_UCD_WPRequestDTO dto)
        {
            using TurkPosWSTESTSoapClient client = new(TurkPosWSTESTSoapClient.EndpointConfiguration.TurkPos_x0020_WS_x0020_TESTSoap12);
            return Ok(await client.TP_WMD_UCD_WPAsync(dto.G, dto.GUID, dto.KK_Sahibi, dto.KK_No, dto.KK_SK_Ay, dto.KK_SK_Yil, dto.KK_CVC, dto.KK_Sahibi_GSM, dto.Hata_URL, dto.Basarili_URL, dto.Siparis_ID, dto.Siparis_Aciklama, dto.Taksit, dto.Islem_Tutar, dto.Toplam_Tutar, dto.Islem_Hash, dto.Islem_Guvenlik_Tip, dto.Islem_ID, dto.IPAdr, dto.Ref_URL, dto.Data1, dto.Data2, dto.Data3, dto.Data4, dto.Data5, dto.Puan, dto.Pos_ID, dto.Islem_Tip));
        }
        [HttpPost("[action]")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TP_WMD_UCD_v2Async([FromBody] TP_WMD_UCD_v2RequestDTO dto)
        {
            using TurkPosWSTESTSoapClient client = new(TurkPosWSTESTSoapClient.EndpointConfiguration.TurkPos_x0020_WS_x0020_TESTSoap12);
            return Ok(await client.TP_WMD_UCD_v2Async(dto.G, dto.GUID, dto.KK_Sahibi, dto.KK_No, dto.KK_SK_Ay, dto.KK_SK_Yil, dto.KK_CVC, dto.KK_Sahibi_GSM, dto.Hata_URL, dto.Basarili_URL, dto.Siparis_ID, dto.Siparis_Aciklama, dto.Taksit, dto.Islem_Tutar, dto.Toplam_Tutar, dto.Islem_Hash, dto.Islem_Guvenlik_Tip, dto.Islem_ID, dto.IPAdr, dto.Ref_URL, dto.Data1, dto.Data2, dto.Data3, dto.Data4, dto.Data5));
        }
        [HttpPost("[action]")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> VadeliIslemIzleme(Vadeli_Islem_IzlemeRequestDTO dto)
        {
            using TurkPosWSTESTSoapClient client = new(TurkPosWSTESTSoapClient.EndpointConfiguration.TurkPos_x0020_WS_x0020_TESTSoap12);
            return Ok(await client.Vadeli_Islem_IzlemeAsync(dto.G, dto.GUID, dto.Tarih_Bas, dto.Tarih_Bit, dto.Siparis_No));
        }
        [HttpPost("[action]")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> KS_Kart_EkleAsync([FromBody] KS_Kart_EkleRequestDTO dto)
        {
            using TP_KSSoapClient client = new(TP_KSSoapClient.EndpointConfiguration.TP_KSSoap12);
            return Ok(await client.KS_Kart_EkleAsync(dto.G, dto.GUID, dto.KK_Sahibi, dto.KK_No, dto.KK_SK_Ay, dto.KK_SK_Yil, dto.KK_Kart_Adi, dto.KK_Islem_ID));
        }
        [HttpPost("[action]")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> KS_Kart_ListeAsync([FromBody] KS_Kart_ListeRequestDTO dto)
        {
            using TP_KSSoapClient client = new(TP_KSSoapClient.EndpointConfiguration.TP_KSSoap12);
            return Ok(await client.KS_Kart_ListeAsync(dto.G, dto.GUID, dto.KK_Kart_Adi, dto.KK_Islem_ID));
        }
        [HttpPost("[action]")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> KS_Kart_Liste_PaginationAsync([FromBody] KS_Kart_Liste_PaginationRequestDTO dto)
        {
            using TP_KSSoapClient client = new(TP_KSSoapClient.EndpointConfiguration.TP_KSSoap12);
            return Ok(await client.KS_Kart_Liste_PaginationAsync(dto.G, dto.GUID, dto.KK_Kart_Adi, dto.KK_Islem_ID, dto.Sayfa_Sayi, dto.Sayfa_Index));
        }
        [HttpPost("[action]")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> KS_Kart_SilAsync([FromBody] KS_Kart_SilRequestDTO dto)
        {
            using TP_KSSoapClient client = new(TP_KSSoapClient.EndpointConfiguration.TP_KSSoap12);
            return Ok(await client.KS_Kart_SilAsync(dto.G, dto.KS_GUID, dto.KK_Islem_ID));
        }
        [HttpPost("[action]")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> KS_TahsilatAsync([FromBody] KS_TahsilatRequestDTO dto)
        {
            using TP_KSSoapClient client = new(TP_KSSoapClient.EndpointConfiguration.TP_KSSoap12);
            return Ok(await client.KS_TahsilatAsync(dto.G, dto.GUID, dto.KS_GUID, dto.CVV, dto.KK_Sahibi_GSM, dto.Hata_URL, dto.Basarili_URL, dto.Siparis_ID, dto.Siparis_Aciklama, dto.Taksit, dto.Islem_Tutar, dto.Toplam_Tutar, dto.Islem_Guvenlik_Tip, dto.Islem_ID, dto.IPAdr, dto.Ref_URL, dto.Data1, dto.Data2, dto.Data3, dto.Data4, dto.KK_Islem_ID));
        }
        [HttpPost("[action]")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> KS_Tahsilat_ColendiAsync([FromBody] KS_Tahsilat_ColendiRequestDTO dto)
        {
            using TP_KSSoapClient client = new(TP_KSSoapClient.EndpointConfiguration.TP_KSSoap12);
            return Ok(await client.KS_Tahsilat_ColendiAsync(dto.G, dto.MGUID, dto.GUID, dto.KS_GUID, dto.CVV, dto.KK_Sahibi_GSM, dto.Hata_URL, dto.Basarili_URL, dto.Siparis_ID, dto.Siparis_Aciklama, dto.Taksit, dto.Islem_Tutar, dto.Toplam_Tutar, dto.Islem_Guvenlik_Tip, dto.Islem_ID, dto.IPAdr, dto.Ref_URL, dto.Data1, dto.Data2, dto.Data3, dto.Data4, dto.KK_Islem_ID));
        }
    }
}