using Microsoft.AspNetCore.Mvc;
using System.Xml;
using System.Xml.Serialization;
using TP_KS;
using TurkPosWSTEST;
using WebMvc.DTOs.BIN_SanalPos;
using WebMvc.DTOs.KK_Sakli_Liste;
using WebMvc.DTOs.Pos_Odeme;
using WebMvc.DTOs.TP_Islem_Izleme;
using WebMvc.DTOs.TP_Islem_Odeme_OnProv_WMD;
using WebMvc.DTOs.TP_Islem_Odeme_WKS;
using WebMvc.DTOs.TP_Mutabakat_Detay;
using WebMvc.DTOs.TP_Mutabakat_Ozet;
using WebMvc.DTOs.TP_Ozel_Oran_Liste;
using WebMvc.DTOs.TP_Ozel_Oran_SK_Liste;
using WebMvc.DTOs.TP_WMD_UCD;
using WebMvc.DTOs.TP_KK_Verify;
using WebMvc.DTOs.TP_Islem_Odeme_BKM;
using WebMvc.DTOs.KS_Tahsilat;
using WebMvc.DTOs.KS_Kart_Liste;
using WebMvc.ModelBinders;
using WebMvc.Models.BINSanalPos;
using WebMvc.Models.KKSaklama;
using WebMvc.Models.KKSakliListe;
using WebMvc.Models.PosOdeme;
using WebMvc.Models.TPIslemDekontGonder;
using WebMvc.Models.TPIslemIptalIadeKismi2;
using WebMvc.Models.TPIslemIptalOnProv;
using WebMvc.Models.TPIslemIzleme;
using WebMvc.Models.TPIslemOdemeBKM;
using WebMvc.Models.TPIslemOdemeOnProvKapa;
using WebMvc.Models.TPIslemOdemeOnProvWKS;
using WebMvc.Models.TPIslemOdemeOnProvWMD;
using WebMvc.Models.TPIslemOdemeWD;
using WebMvc.Models.TPIslemSorgulama4;
using WebMvc.Models.TPKKVerify;
using WebMvc.Models.TPMutabakatDetay;
using WebMvc.Models.TPMutabakatOzet;
using WebMvc.Models.TPOzelOranListe;
using WebMvc.Models.TPOzelOranSKGuncelle;
using WebMvc.Models.TPOzelOranSKListe;
using WebMvc.Models.TPWMDUCD;
using WebMvc.Models.KSKartEkle;
using WebMvc.Models.KSKartListe;
using WebMvc.Models.KSKartSil;
using WebMvc.Models.KSTahsilat;
using WebMvc.Models.PazaryeriTPAltUyeIsyeriEkleme;
using WebMvc.Models.PazaryeriTPAltUyeIsyeriGuncelleme;
using WebMvc.DTOs.Pazaryeri_TP_AltUyeIsyeri_Liste;
using WebMvc.Models.PazaryeriTPAltUyeIsyeriListe;
using WebMvc.Models.PazaryeriTPSiparisOnay;
using WebMvc.Models.PazaryeriTPSiparisDetayEkle;
using WebMvc.DTOs.Pazaryeri_TP_Islem_Sorgulama;
using WebMvc.Models.PazaryeriTPIslemSorgulama;
using WebMvc.Models.PazaryeriTPIptalIade;
using WebMvc.DTOs.Il_Ilce_Liste;
using WebMvc.Models.IlIlceListe;
using WebMvc.DTOs.Il_Liste;
using WebMvc.Models.IlListe;
using WebMvc.Models.PazaryeriTPLimitKontrol;
using WebMvc.Models.PazaryeriTPAltUyeIsyeriSilme;
using WebMvc.DTOs.Pazaryeri_TP_AltUyeIsyeri_Silme;
using System.Net;

namespace WebMvc.Controllers
{
    public class SonucController : Controller
    {
        /// <summary>Il_Ilce_Liste metodunun sonuç sayfasını görüntüler.</summary>
        /// <param name="result">ST_Genel_Sonuc Nesnesi (Zorunlu)</param>
        ///     ST_Genel_Sonuc:
        ///         DT_Bilgi:
        ///             Ilce_Kodu: İlçenin Kodu
        ///             Ilce: İlçenin İsmi
        ///         Sonuc: İşlem Sonucu
        ///         Sonuc_Str: İşlem Sonucunun Açıklaması
        /// <returns>IActionResult Nesnesi</returns>
        [HttpGet]
        [HttpPost]
        public IActionResult IlIlceListe([FromForm][ModelBinder(typeof(FormDataXmlBinder))] service_param.ST_Genel_Sonuc result)
        {
            List<Il_Ilce_ListeDT_BilgiDTO>? dt_bilgi = new();
            if (result.DT_Bilgi != null)
            {
                XmlSerializer serializer = new(typeof(Il_Ilce_ListeDT_BilgiDTO));
                using StringReader reader = new(result.DT_Bilgi.Any1.InnerXml);
                using XmlReader xmlReader = XmlReader.Create(reader);
                xmlReader.ReadToDescendant("Temp");
                while (xmlReader.MoveToNextAttribute()) dt_bilgi.Add((Il_Ilce_ListeDT_BilgiDTO)serializer.Deserialize(xmlReader)!);
            }
            IlIlceListeSonucViewModel model = new() { DT_Bilgi = dt_bilgi, Sonuc = result.Sonuc, Sonuc_Str = result.Sonuc_Str };
            return View(model);
        }
        /// <summary>BIN_SanalPos metodunun sonuç sayfasını görüntüler.</summary>
        /// <param name="result">ST_Genel_Sonuc Nesnesi (Zorunlu)</param>
        ///     ST_Genel_Sonuc:
        ///         DT_Bilgi:
        ///             BIN: BIN Değeri
        ///             SanalPOS_ID: SanalPOS ID değeri
        ///             Kart_Banka: Banka Adı
        ///             DKK: Debit Kredi Kartı
        ///             Kart_Tip: Kart Tipi
        ///             Kart_Org: Kart Bilgisi
        ///             Banka_Kodu: Banka Kodu
        ///             Kart_Ticari: Kartın Ticarete Uygunluğu
        ///             Kart_Marka: Kart Markası
        ///         Sonuc: İşlem Sonucu
        ///         Sonuc_Str: İşlem Sonucunun Açıklaması
        /// <returns>IActionResult Nesnesi</returns>
        [HttpGet]
        [HttpPost]
        public IActionResult BINSanalPos([FromForm][ModelBinder(typeof(FormDataXmlBinder))] ST_Genel_Sonuc result)
        {
            List<BIN_SanalPosDT_BilgiDTO>? dt_bilgi = new();
            if (result.DT_Bilgi != null)
            {
                XmlSerializer serializer = new(typeof(BIN_SanalPosDT_BilgiDTO));
                using StringReader reader = new(result.DT_Bilgi.Any1.InnerXml);
                using XmlReader xmlReader = XmlReader.Create(reader);
                xmlReader.ReadToDescendant("Temp");
                while (xmlReader.MoveToNextAttribute()) dt_bilgi.Add((BIN_SanalPosDT_BilgiDTO)serializer.Deserialize(xmlReader)!);
            }
            BINSanalPosSonucViewModel model = new() { DT_Bilgi = dt_bilgi, Sonuc = result.Sonuc, Sonuc_Str = result.Sonuc_Str };
            return View(model);
        }
        /// <summary>Il_Liste metodunun sonuç sayfasını görüntüler.</summary>
        /// <param name="result">ST_Sonuc_DT Nesnesi (Zorunlu)</param>
        ///     ST_Sonuc_DT:
        ///         Sonuc: İşlem Sonucu
        ///         Sonuc_Str: İşlem Sonucunun Açıklaması
        ///         DT_Bilgi:
        ///             Plaka: İl Kodu
        ///             IL: İl Adı
        /// <returns>IActionResult Nesnesi</returns>
        [HttpGet]
        [HttpPost]
        public IActionResult IlListe([FromForm][ModelBinder(typeof(FormDataXmlBinder))] ST_Sonuc_DT result)
        {
            List<Il_ListeDTDTO>? dt = new();
            if (result.DT != null)
            {
                XmlSerializer serializer = new(typeof(Il_ListeDTDTO));
                using StringReader reader = new(result.DT.Any1.InnerXml);
                using XmlReader xmlReader = XmlReader.Create(reader);
                xmlReader.ReadToDescendant("Temp");
                while (xmlReader.MoveToNextAttribute()) dt.Add((Il_ListeDTDTO)serializer.Deserialize(xmlReader)!);
            }
            IlListeSonucViewModel model = new() { DT = dt, Sonuc = result.Sonuc, Sonuc_Str = result.Sonuc_Str };
            return View(model);
        }
        /// <summary>KK_Saklama metodunun sonuç sayfasını görüntüler.</summary>
        /// <param name="result">ST_Genel_Sonuc Nesnesi (Zorunlu)</param>
        ///     ST_Genel_Sonuc:
        ///         DT_Bilgi:
        ///             ID: Kart Saklama ID'si
        ///             KK_GUID: Kart Saklama GUID Değeri
        ///             Tarih: Saklama Tarihi
        ///             KK_No: Kredi Kartı BIN Kodu
        ///             KK_Tip: Kart Tipi
        ///             KK_Banka: Kart Bankası
        ///             KK_Marka: Kart Markası
        ///             Kart_Adi: Kart Adı
        ///             KK_Hash: Kredi Kartı Hash Değeri
        ///             KK_KD: Kart Türü
        ///             KK_SK: Kredi Kartı Son Kullanma Tarihi
        ///             Data2: Extra Alan 2
        ///         Sonuc: İşlem Sonucu
        ///         Sonuc_Str: İşlem Sonucunun Açıklaması
        /// <returns>IActionResult Nesnesi</returns>
        [HttpGet]
        [HttpPost]
        public IActionResult KKSaklama([FromForm] ST_KK_Saklama result)
        {
            KKSaklamaSonucViewModel model = new() { Sonuc = result };
            return View(model);
        }
        /// <summary>KK_Sakli_Liste metodunun sonuç sayfasını görüntüler.</summary>
        /// <param name="result">ST_KK_Saklama Nesnesi (Zorunlu)</param>
        ///     ST_KK_Saklama:
        ///         GUID: GUID Değeri
        ///         Sonuc: İşlem Sonucu:
        ///         Sonuc_Str: İşlem Sonucunun Açıklaması
        /// <returns>IActionResult Nesnesi</returns>
        [HttpGet]
        [HttpPost]
        public IActionResult KKSakliListe([FromForm][ModelBinder(typeof(FormDataXmlBinder))] ST_Genel_Sonuc result)
        {
            List<KK_Sakli_ListeDT_BilgiDTO>? dt_bilgi = new();
            if (result.DT_Bilgi != null)
            {
                XmlSerializer serializer = new(typeof(KK_Sakli_ListeDT_BilgiDTO));
                using StringReader reader = new(result.DT_Bilgi.Any1.InnerXml);
                using XmlReader xmlReader = XmlReader.Create(reader);
                xmlReader.ReadToDescendant("Temp");
                while (xmlReader.MoveToNextAttribute()) dt_bilgi.Add((KK_Sakli_ListeDT_BilgiDTO)serializer.Deserialize(xmlReader)!);
            }
            KKSakliListeSonucViewModel model = new() { DT_Bilgi = dt_bilgi, Sonuc = result.Sonuc, Sonuc_Str = result.Sonuc_Str };
            return View(model);
        }
        /// <summary>Pazaryeri_TP_AltUyeIsyeri_Ekleme metodunun sonuç sayfasını görüntüler.</summary>
        /// <param name="result">Sonuc_Uyelik Nesnesi (Zorunlu)</param>
        ///     Sonuc_Uyelik:
        ///         Sonuc: İşlem Sonucu
        ///         Sonuc_Str: İşlem Sonucunun Açıklaması
        ///         GUID_AltUyeIsyeri: Alt Üye İş Yerinin GUID Değeri
        /// <returns>IActionResult Nesnesi</returns>
        [HttpGet]
        [HttpPost]
        public IActionResult PazaryeriTPAltUyeIsyeriEkleme([FromForm] Sonuc_Uyelik result)
        {
            PazaryeriTPAltUyeIsyeriEklemeSonucViewModel model = new() { Sonuc = result };
            return View(model);
        }
        /// <summary>Pazaryeri_TP_AltUyeIsyeri_Guncelleme metodunun sonuç sayfasını görüntüler.</summary>
        /// <param name="result">Sonuc_Uyelik Nesnesi (Zorunlu)</param>
        ///     Sonuc_Uyelik:
        ///         Sonuc: İşlem Sonucu
        ///         Sonuc_Str: İşlem Sonucunun Açıklaması
        ///         GUID_AltUyeIsyeri: Alt Üye İş Yerinin GUID Değeri
        /// <returns>IActionResult Nesnesi</returns>
        [HttpGet]
        [HttpPost]
        public IActionResult PazaryeriTPAltUyeIsyeriGuncelleme([FromForm] Sonuc_Uyelik result)
        {
            PazaryeriTPAltUyeIsyeriGuncellemeSonucViewModel model = new() { Sonuc = result };
            return View(model);
        }
        /// <summary>Pazaryeri_TP_AltUyeIsyeri_Liste metodunun sonuç sayfasını görüntüler.</summary>
        /// <param name="result">Sonuc_Uyelik_Liste Nesnesi (Zorunlu)</param>
        ///     Sonuc_Uyelik_Liste:
        ///         Toplam_Kayit: 	Toplam Kayıt
        ///         DT_Bilgi:
        ///             ID: ID değeri
        ///             ETS_GUID: Pazaryerine Ait GUID Değeri
        ///             Durum: Durum Değeri
        ///             Tip: Tip Değeri
        ///             Ad_Soyad: Kişi Adı ve Soyadı
        ///             Unvan: Firma Ünvanı
        ///             TC_VN: TC Kimlik Numarası ya da Vergi Numarası
        ///             Yetkili_Kisi_TC:
        ///             GSM_No: Üye İşyeri GSM
        ///             IBAN_No: Üye İşyeri IBAN Numarası
        ///             Adres: Üye İşyeri Adresi
        ///             Il: Mernis İl Kodu
        ///             Ilce:Mernis İlçe Kodu
        ///             Website: Üye İşyeri Web Adresi
        ///             MCC_Kod: Ürün Kategori Kodu
        ///             GUID: GUID Değeri
        ///             Tarih: Tarih
        ///             Vergi_Daire: Vergi Daire Alanı
        ///         Sonuc: İşlem Sonucu
        ///         Sonuc_Str: İşlem Sonucunun Açıklaması
        ///         GUID_AltUyeIsyeri: Alt Üye İş Yerinin GUID Değeri
        /// <returns>IActionResult Nesnesi</returns>
        [HttpGet]
        [HttpPost]
        public IActionResult PazaryeriTPAltUyeIsyeriListe([FromForm][ModelBinder(typeof(FormDataXmlBinder))] Sonuc_Uyelik_Liste result)
        {
            List<Pazaryeri_TP_AltUyeIsyeri_ListeDT_BilgiDTO>? dt_bilgi = new();
            if (result.DT_Bilgi != null)
            {
                XmlSerializer serializer = new(typeof(Pazaryeri_TP_AltUyeIsyeri_ListeDT_BilgiDTO));
                using StringReader reader = new(result.DT_Bilgi.Any1.InnerXml);
                using XmlReader xmlReader = XmlReader.Create(reader);
                xmlReader.ReadToDescendant("Temp1");
                while (xmlReader.MoveToNextAttribute()) dt_bilgi.Add((Pazaryeri_TP_AltUyeIsyeri_ListeDT_BilgiDTO)serializer.Deserialize(xmlReader)!);
            }
            PazaryeriTPAltUyeIsyeriListeSonucViewModel model = new() { Toplam_Kayit = result.Toplam_Kayit, DT_Bilgi = dt_bilgi, Sonuc = result.Sonuc, Sonuc_Str = result.Sonuc_Str, GUID_AltUyeIsyeri = result.GUID_AltUyeIsyeri };
            return View(model);
        }
        /// <summary>Pazaryeri_TP_AltUyeIsyeri_Silme metodunun sonuç sayfasını görüntüler.</summary>
        /// <param name="result">Sonuc_Uyelik Nesnesi</param>
        ///     Sonuc_Uyelik:
        ///         Sonuc: İşlem Sonucu
        ///         Sonuc_Str: İşlem Sonucunun Açıklaması
        ///         GUID_AltUyeIsyeri: Alt Üye İş Yerinin GUID Değeri
        /// <returns>IActionResult Nesnesi</returns>
        [HttpGet]
        [HttpPost]
        public IActionResult PazaryeriTPAltUyeIsyeriSilme([FromForm] Pazaryeri_TP_AltUyeIsyeri_SilmeResponseDTO result)
        {
            PazaryeriTPAltUyeIsyeriSilmeSonucViewModel model = new() { Sonuc = result };
            return View(model);
        }
        /// <summary>Pazaryeri_TP_Iptal_Iade metodunun sonuç sayfasını görüntüler.</summary>
        /// <param name="result">STC_SonucII Nesnesi (Zorunlu)</param>
        ///     STC_SonucII:
        ///         Durum: Durum Kodu
        ///         Durum_Str: Durum Açıklaması
        ///         Sonuc: İşlem Sonucu
        ///         Sonuc_Str: İşlem Sonucunun Açıklaması (Sonuc değeri 0'dan büyükse işlem başarılıdır, aksi halde başarısızdır.)
        /// <returns>IActionResult Nesnesi</returns>
        [HttpGet]
        [HttpPost]
        public IActionResult PazaryeriTPIptalIade([FromForm] STC_SonucII result)
        {
            PazaryeriTPIptalIadeSonucViewModel model = new() { Sonuc = result };
            return View(model);
        }
        /// <summary>Pazaryeri_TP_Islem_Sorgulama metodunun sonuç sayfasını görüntüler.</summary>
        /// <param name="result">ST_Genel_Sonuc Nesnesi (Zorunlu)</param>
        ///     ST_Genel_Sonuc:
        ///         DT_Bilgi:
        ///             PYSiparis_GUID: Pazaryeri Sipariş GUID Değeri
        ///             Durum: Sipariş Durum Kodu
        ///             Durum_Str: Sipariş Durum Açıklaması
        ///             Tutar_Urun: Ürün Tutarı
        ///             Tutar_Odenecek: Ödenecek Tutar
        ///             GUID_AltUyeIsyeri: Alt Üye İş Yerinin GUID Değeri
        ///             SanalPOS_Islem_ID: SanalPOS İşlem ID
        ///             Tarih: Tarih (dd.MM.yyyy HH:mm:ss – 20.11.2015 15:15:00)
        ///         Sonuc: İşlem Sonucu
        ///         Sonuc_Str: İşlem Sonucunun Açıklaması
        /// <returns>IActionResult Nesnesi</returns>
        [HttpGet]
        [HttpPost]
        public IActionResult PazaryeriTPIslemSorgulama([FromForm][ModelBinder(typeof(FormDataXmlBinder))] ST_Genel_Sonuc result)
        {
            List<Pazaryeri_TP_Islem_SorgulamaDT_BilgiDTO>? dt_bilgi = new();
            if (result.DT_Bilgi != null)
            {
                XmlSerializer serializer = new(typeof(Pazaryeri_TP_Islem_SorgulamaDT_BilgiDTO));
                using StringReader reader = new(result.DT_Bilgi.Any1.InnerXml);
                using XmlReader xmlReader = XmlReader.Create(reader);
                xmlReader.ReadToDescendant("Temp");
                while (xmlReader.MoveToNextAttribute()) dt_bilgi.Add((Pazaryeri_TP_Islem_SorgulamaDT_BilgiDTO)serializer.Deserialize(xmlReader)!);
            }
            PazaryeriTPIslemSorgulamaSonucViewModel model = new() { DT_Bilgi = dt_bilgi, Sonuc = result.Sonuc, Sonuc_Str = result.Sonuc_Str };
            return View(model);
        }
        /// <summary>Pazaryeri_TP_Islem_Sorgulama metodunun sonuç sayfasını görüntüler.</summary>
        /// <param name="result">Sonuc_Limit2 Nesnesi (Zorunlu)</param>
        ///     Sonuc_Limit2:
        ///         Sonuc: İşlem Sonucu
        ///         Sonuc_Str: İşlem Sonucunun Açıklaması
        ///         AltUyeIsyeri: Alt Üye İşyeri Bilgisi
        ///         Odeme_Alma_Durumu: True/False olarak dönmektedir (True ise müşteri limiti aşmamış demektir. Ödeme alınarak, sipariş eklenebilir. False ise limit yetersiz; ödeme alınmaz ve sipariş eklenemez.).
        ///         Toplam_Tahsilat_Tutari: Toplam Tahsilat Tutari
        ///         Pazaryeri_Limit: Pazaryeri Bireysel Müşteri Harcama Limiti
        ///         Yeni_Odenecek_Tutar: Yeni Ödenecek Tutar
        /// <returns>IActionResult Nesnesi</returns>
        [HttpGet]
        [HttpPost]
        public IActionResult PazaryeriTPLimitKontrol([FromForm] Sonuc_Limit2 result)
        {
            PazaryeriTPLimitKontrolSonucViewModel model = new() { Sonuc = result };
            return View(model);
        }
        /// <summary>Pazaryeri_TP_Siparis_Detay_Ekle metodunun sonuç sayfasını görüntüler.</summary>
        /// <param name="result">SE_Sonuc Nesnesi (Zorunlu)</param>
        ///     SE_Sonuc:
        ///         Sonuc: İşlem Sonucu
        ///         Sonuc_Str: İşlem Sonucunun Açıklaması
        ///         GUID_AltUyeIsyeri: Alt Üye İş Yerinin GUID Değeri
        ///         Tutar_Urun: Toplam ürün tutarı
        ///         Tutar_Odenecek: Ödenecek Tutar
        ///         PYSiparis_GUID: Pazaryeri Sipariş GUID Değeri
        ///         SanalPOS_Islem_ID: SanalPOS işlem ID
        ///         Toplam_Tahsilat_Tutari: Toplam Tahsilat Tutarı
        ///         Pazaryeri_Limit: Pazaryeri Limiti
        ///         Yeni_Odenecek_Tutar: Yeni Ödenecek Tutar
        /// <returns>IActionResult Nesnesi</returns>
        [HttpGet]
        [HttpPost]
        public IActionResult PazaryeriTPSiparisDetayEkle([FromForm] SE_Sonuc result)
        {
            PazaryeriTPSiparisDetayEkleSonucViewModel model = new() { Sonuc = result };
            return View(model);
        }
        /// <summary>Pazaryeri_TP_Siparis_Onay metodunun sonuç sayfasını görüntüler.</summary>
        /// <param name="result">STC_Sonuc Nesnesi (Zorunlu)</param>
        ///     STC_Sonuc:
        ///         POS_Islem_Id: İşlem ID değeri
        ///         GUID_AltUyeIsyeri: Alt Üye İş Yerinin GUID Değeri
        ///         Tutar_Urun: Toplam ürün tutarı
        ///         Tutar_Odenecek: Ödenecek Tutar
        ///         Durum: Durum kodu
        ///         Durum_Str: Durum Açıklaması
        ///         Sonuc: İşlem Sonucu
        ///         Sonuc_Str: İşlem Sonucunun Açıklaması
        /// <returns>IActionResult Nesnesi</returns>
        [HttpGet]
        [HttpPost]
        public IActionResult PazaryeriTPSiparisOnay([FromForm] STC_Sonuc result)
        {
            PazaryeriTPSiparisOnaySonucViewModel model = new() { Sonuc = result };
            return View(model);
        }
        /// <summary>Pos_Odeme metodunun sonuç sayfasını görüntüler.</summary>
        /// <param name="sonucNonSecure">ST_TP_Islem_Odeme Nenesi</param>
        ///     ST_TP_Islem_Odeme:
        ///         Islem_ID: SID Değeri
        ///         UCD_URL: 3D URL'i
        ///         Sonuc: İşlem Sonucu
        ///         Sonuc_Str: İşlem Sonucunun Açıklaması
        ///         Banka_Sonuc_Kod: Bankadan Gönderilen Kod
        ///         Siparis_ID: Sipariş ID'si
        ///         Komisyon_Oran: Komisyon Oranı
        /// <param name="sonuc3DSecure">Pos_OdemePostDTO Nenesi</param>
        ///     Pos_OdemePostDTO:
        ///         TURKPOS_RETVAL_Sonuc: Sonuç Değeri
        ///         TURKPOS_RETVAL_Sonuc_Str: Sonucun Açıklaması
        ///         TURKPOS_RETVAL_GUID: Üye İşyeri Ait Anahtar
        ///         TURKPOS_RETVAL_Islem_Tarih: İşlem Tarihi
        ///         TURKPOS_RETVAL_Dekont_ID: Dekont Numarası
        ///         TURKPOS_RETVAL_Tahsilat_Tutar: Müşteriden Tahsil Edilen Tutar
        ///         TURKPOS_RETVAL_Odeme_Tutari: Net Ututar (Tahsilat tutarından komisyon tutarının çıkarılmış halidir.)
        ///         TURKPOS_RETVAL_Siparis_ID: Servise Gönderdiğiniz İşleme Ait Tekil Siparis_ID
        ///         TURKPOS_RETVAL_Islem_ID: Servise Gönderdiğiniz Islem ID'si
        ///         TURKPOS_RETVAL_Ext_Data: Metottaki Data1, Data2, Data3, Data4, Data5 parametrelerinin “|” ile birleştirilmiş hali döner (Ext_Data = Data1 & "|" & Data2 & "|" & Data3 & "|" & Data4 & "|" & Data5).
        ///         TURKPOS_RETVAL_Banka_Sonuc_Kod: Banka Sonucunun Kodu
        ///         TURKPOS_RETVAL_Hash: Dönen Cevaba Ait Hash Değeri
        /// <returns>IActionResult Nesnesi</returns>
        [HttpGet]
        [HttpPost]
        public IActionResult PosOdeme([FromForm] TurkPosWSTEST.ST_TP_Islem_Odeme sonucNonSecure, [FromForm] Pos_OdemePostDTO sonuc3DSecure)
        {
            PosOdemeSonucViewModel model = new();
            if (sonucNonSecure.Sonuc != null && sonuc3DSecure.TURKPOS_RETVAL_Sonuc == null)
            {
                model.SonucNonSecure = sonucNonSecure;
                model.Sonuc3DSecure = null;
            }
            else if (sonucNonSecure.Sonuc == null && sonuc3DSecure.TURKPOS_RETVAL_Sonuc != null)
            {
                if (Request.Cookies.TryGetValue("PosOdemeCookie", out string? json_posodeme))
                {
                    PosOdemeCookieModel cookie = System.Text.Json.JsonSerializer.Deserialize<PosOdemeCookieModel>(json_posodeme!)!;
                    model.SonucNonSecure = cookie.ST_TP_Islem_Odeme;
                }
                else model.SonucNonSecure = null;
                model.Sonuc3DSecure = sonuc3DSecure;
            }
            else
            {
                model.SonucNonSecure = sonucNonSecure;
                model.Sonuc3DSecure = sonuc3DSecure;
            }
            return View(model);
        }
        /// <summary>TP_Islem_Dekont_Gonder metodunun sonuç sayfasını görüntüler.</summary>
        /// <param name="result">ST_Sonuc Nenesi</param>
        ///     ST_Sonuc:
        ///         Sonuc: İşlem Sonucu
        ///         Sonuc_Str: İşlem Sonucunun Açıklaması
        ///         Banka_Sonuc_Kod: Bankanın Sonuç Kodu
        /// <returns>IActionResult Nesnesi</returns>
        [HttpGet]
        [HttpPost]
        public IActionResult TPIslemDekontGonder([FromForm] TurkPosWSTEST.ST_Sonuc result)
        {
            TPIslemDekontGonderSonucViewModel model = new() { Sonuc = result };
            return View(model);
        }
        /// <summary>TP_Islem_Iptal_Iade_Kismi2 metodunun sonuç sayfasını görüntüler.</summary>
        /// <param name="result">ST_Sonuc_II Nenesi</param>
        ///     ST_Sonuc_II:
        ///         Sonuc: İşlem Sonucu
        ///         Sonuc_Str: İşlem Sonucunun Açıklaması
        ///         Banka_Sonuc_Kod: Bankanın Sonuç Kodu
        ///         Bank_AuthCode: Bankanın Auth Code Değeri
        ///         Bank_Trans_ID: Bankanın Transaction ID Değeri
        ///         Bank_Extra: Banka Extra Değeri
        ///         Bank_HostRefNum: Bankanın RRN Değeri
        /// <returns>IActionResult Nesnesi</returns>
        [HttpGet]
        [HttpPost]
        public IActionResult TPIslemIptalIadeKismi2([FromForm] ST_Sonuc_II result)
        {
            TPIslemIptalIadeKismi2SonucViewModel model = new() { Sonuc = result };
            return View(model);
        }
        /// <summary>TP_Islem_Izleme metodunun sonuç sayfasını görüntüler.</summary>
        /// <param name="result">ST_Genel_Sonuc Nenesi</param>
        ///     ST_Genel_Sonuc:
        ///         DT_Bilgi:
        ///             SanalPOS_Islem_ID: Sanal Pos İşlem ID
        ///             SanalPOS_Islem_ID_Orj: İptal ve iade işlemlerinde orijinal işlemin ORDER ID'sidir
        ///             Sonuc_Str: İşlem Sonuç Açıklama
        ///             Tip_Str: Satış/İade/İptal
        ///             Tarih: Tarih
        ///             Odeme_Yapan_Bilgisi: Ödeme Yapan Bilgisi
        ///             Odeme_Yapan_AdSoyad: Ödeme Yapan Adı ve Soyadı
        ///             Odeme_Yapan_GSM: Ödeme Yapan GSM Numarası
        ///             Odeme_Yapan_TC: Ödeme Yapan TC Numarası
        ///             Odeme_Aciklama: Ödemeye Ait Açıklama
        ///             Taksit: Taksit Bilgisi
        ///             SanalPOS_Banka: Sanal Pos
        ///             Komisyon_Oran: Komisyon Oranı
        ///             Komisyon_Tutar: Komisyon Tutar
        ///             Net_Tutar: Net Tutar
        ///             Tutar: Tutar Bilgisi
        ///             Islem_Guvenlik: NS veya 3D
        ///             Dekont_ID: İşlemin Dekont ID'si
        ///             ORJ_ORDER_ID: İptal ve iade işlemlerinde orjinal işlemin ORDER ID'sidir.
        ///             Sonuc: Sonuç Değeri
        ///             Kaynak:	Kaynak
        ///             Toplam_Iade_Tutar: Toplam İade Tutarı
        ///             ORJ_Tarih: Tarih
        ///             PB:	Para Birimi
        ///         Sonuc: İşlem Sonucu
        ///         Sonuc_Str: İşlem Sonucunun Açıklaması
        /// <returns>IActionResult Nesnesi</returns>
        [HttpGet]
        [HttpPost]
        public IActionResult TPIslemIptalOnProv([FromForm] TurkPosWSTEST.ST_Sonuc result)
        {
            TPIslemIptalOnProvSonucViewModel model = new() { Sonuc = result };
            return View(model);
        }
        /// <summary>TP_Islem_Iptal_OnProv metodunun sonuç sayfasını görüntüler.</summary>
        /// <param name="result">ST_Sonuc Nenesi</param>
        ///     ST_Sonuc:
        ///         Sonuc: İşlem Sonucu
        ///         Sonuc_Str: İşlem Sonucunun Açıklaması
        ///         Banka_Sonuc_Kod: Bankanın Sonuç Kodu
        /// <returns>IActionResult Nesnesi</returns>
        [HttpGet]
        [HttpPost]
        public IActionResult TPIslemIzleme([FromForm][ModelBinder(typeof(FormDataXmlBinder))] ST_Genel_Sonuc result)
        {
            List<TP_Islem_IzlemeDT_BilgiDTO>? dt_bilgi = new();
            if (result.DT_Bilgi != null)
            {
                XmlSerializer serializer = new(typeof(TP_Islem_IzlemeDT_BilgiDTO));
                using StringReader reader = new(result.DT_Bilgi.Any1.InnerXml);
                using XmlReader xmlReader = XmlReader.Create(reader);
                xmlReader.ReadToDescendant("Temp");
                while (xmlReader.MoveToNextAttribute()) dt_bilgi.Add((TP_Islem_IzlemeDT_BilgiDTO)serializer.Deserialize(xmlReader)!);
            }
            TPIslemIzlemeSonucViewModel model = new() { DT_Bilgi = dt_bilgi, Sonuc = result.Sonuc, Sonuc_Str = result.Sonuc_Str };
            return View(model);
        }
        /// <summary>TP_Islem_Odeme_BKM metodunun sonuç sayfasını görüntüler.</summary>
        /// <param name="result">ST_TP_Islem_Odeme_BKM Nenesi</param>
        ///     ST_TP_Islem_Odeme_BKM:
        ///         Redirect_URL: İşlem Sonucu
        ///         Response_Code: İşlem Sonucunun Açıklaması
        ///         Response_Message: BKM Express URL'i
        /// <param name="resultPost">TP_Islem_Odeme_BKMPOSTDTO Nenesi</param>
        ///     TP_Islem_Odeme_BKMPOSTDTO:
        ///         TURKPOS_RETVAL_Sonuc: Sonuç Değeri
        ///         TURKPOS_RETVAL_Sonuc_Str: Sonucun Açıklaması
        ///         TURKPOS_RETVAL_GUID: Üye İşyeri Ait Anahtar
        ///         TURKPOS_RETVAL_Islem_Tarih: İşlem Tarihi
        ///         TURKPOS_RETVAL_Dekont_ID: Dekont Numarası
        ///         TURKPOS_RETVAL_Tahsilat_Tutar: Müşteriden Tahsil Edilen Tutar
        ///         TURKPOS_RETVAL_Odeme_Tutari: Net Ututar (Tahsilat tutarından komisyon tutarının çıkarılmış halidir.)
        ///         TURKPOS_RETVAL_Siparis_ID: Servise Gönderdiğiniz İşleme Ait Tekil Siparis_ID
        ///         TURKPOS_RETVAL_Islem_ID: Servise Gönderdiğiniz Islem ID'si
        ///         TURKPOS_RETVAL_Banka_Sonuc_Kod: Banka Sonucunun Kodu
        /// <returns>IActionResult Nesnesi</returns>
        [HttpGet]
        [HttpPost]
        public IActionResult TPIslemOdemeBKM([FromForm] ST_TP_Islem_Odeme_BKM result, [FromForm] TP_Islem_Odeme_BKMPOSTDTO resultPost)
        {
            TPIslemOdemeBKMSonucViewModel model = new() { Sonuc = result.Response_Code != 1 ? result : null, SonucPOST = resultPost.TURKPOS_RETVAL_Sonuc == null ? null : resultPost };
            return View(model);
        }
        /// <summary>TP_Islem_Odeme_OnProv_Kapa metodunun sonuç sayfasını görüntüler.</summary>
        /// <param name="result">ST_TP_Islem_Odeme_OnProvKapa Nenesi</param>
        ///     ST_TP_Islem_Odeme_OnProvKapa:
        ///         Sonuc: İşlem Sonucu:
        ///         Sonuc_Str: İşlem Sonucunun Açıklaması:
        ///         Prov_ID: Provizyon ID'si
        ///         Dekont_ID: 	İşlemin Dekont ID'si
        ///         Banka_Sonuc_Kod: Bankanın Sonuç Kodu
        ///         Siparis_ID: Sipariş ID'si
        ///         Bank_Trans_ID: Bankanın Transaction ID Değeri
        ///         Bank_AuthCode: Bankanın Auth Code Değeri
        ///         Bank_HostMsg: Banka HostMsg Değeri
        ///         Bank_Extra: Banka Extra Değeri
        ///         Bank_HostRefNum: Bankanın RRN Değeri
        /// <returns>IActionResult Nesnesi</returns>
        [HttpGet]
        [HttpPost]
        public IActionResult TPIslemOdemeOnProvKapa([FromForm] ST_TP_Islem_Odeme_OnProvKapa result)
        {
            TPIslemOdemeOnProvKapaSonucViewModel model = new() { Sonuc = result };
            return View(model);
        }
        /// <summary>KK_Tashilat metodunun sonuç sayfasını görüntüler.</summary>
        /// <param name="sonucNonSecure">ST_TP_Islem_Odeme_OnProv Nesnesi (Zorunlu)</param>
        ///     ST_TP_Islem_Odeme_OnProv:
        ///         Sonuc: İşlem Sonucu
        ///         Sonuc_Str: İşlem Sonucunun Açıklaması
        ///         Islem_ID: SID Değeri
        ///         UCD_URL: 3D URL'i
        ///         Islem_GUID: İşlem GUID Değeri
        ///         Banka_Sonuc_Kod: Bankanın Sonuç Kodu
        ///         Siparis_ID: Sipariş ID'si
        /// <param name="sonuc3DSecure">TP_Islem_Odeme_WKSPostDTO Nesnesi (Zorunlu)</param>
        ///     Pos_OdemePostDTO:
        ///         TURKPOS_RETVAL_Sonuc: Sonuç Değeri
        ///         TURKPOS_RETVAL_Sonuc_Str: Sonucun Açıklaması
        ///         TURKPOS_RETVAL_GUID: Üye İşyeri Ait Anahtar
        ///         TURKPOS_RETVAL_Islem_Tarih: İşlem Tarihi
        ///         TURKPOS_RETVAL_Dekont_ID: Dekont Numarası
        ///         TURKPOS_RETVAL_Tahsilat_Tutar: Müşteriden Tahsil Edilen Tutar
        ///         TURKPOS_RETVAL_Odeme_Tutari: Net Ututar (Tahsilat tutarından komisyon tutarının çıkarılmış halidir.)
        ///         TURKPOS_RETVAL_Siparis_ID: Servise Gönderdiğiniz İşleme Ait Tekil Siparis_ID
        ///         TURKPOS_RETVAL_Islem_ID: Servise Gönderdiğiniz Islem ID'si
        ///         TURKPOS_RETVAL_Ext_Data: Metottaki Data1, Data2, Data3, Data4, Data5 parametrelerinin “|” ile birleştirilmiş hali döner (Ext_Data = Data1 & "|" & Data2 & "|" & Data3 & "|" & Data4 & "|" & Data5).
        ///         TURKPOS_RETVAL_Banka_Sonuc_Kod: Banka Sonucunun Kodu
        ///         TURKPOS_RETVAL_Hash: Dönen Cevaba Ait Hash Değeri
        /// <returns>IActionResult Nesnesi</returns>
        [HttpGet]
        [HttpPost]
        public IActionResult TPIslemOdemeOnProvWKS([FromForm] TurkPosWSTEST.ST_TP_Islem_Odeme_OnProv sonucNonSecure, [FromForm] TP_Islem_Odeme_WKSPostDTO sonuc3DSecure)
        {
            TPIslemOdemeOnProvWKSSonucViewModel model = new() { Sonuc3DSecure = sonuc3DSecure.TURKPOS_RETVAL_Sonuc == null ? null : sonuc3DSecure, SonucNonSecure = sonucNonSecure.Sonuc == null ? null : sonucNonSecure };
            return View(model);
        }
        /// <summary>TP_Islem_Odeme_OnProv_WMD metodunun sonuç sayfasını görüntüler.</summary>
        /// <param name="sonucNonSecure">ST_WMD_UCD Nenesi</param>
        ///     ST_WMD_UCD:
        ///         Islem_ID: SID Değeri
        ///         Islem_GUID: İşlem GUID Değeri
        ///         UCD_HTML: 3D HTML Kodu
        ///         UCD_MD: 3D MD Değeri
        ///         Sonuc: İşlem Sonucu
        ///         Sonuc_Str: İşlem Sonucunun Açıklaması
        ///         Bank_Trans_ID: Bankanın Transaction ID Değeri
        ///         Bank_AuthCode: Bankanın Auth Code Değeri
        ///         Bank_HostMsg: Banka HostMsg Değeri
        ///         Banka_Sonuc_Kod: Bankanın Sonuç Kodu
        ///         Bank_Extra: Banka Extra Değeri
        ///         Siparis_ID: Sipariş ID'si
        ///         Bank_HostRefNum: Bankanın HostMsg Değeri
        ///         Ext_Data: Ekstra Veri
        /// <param name="sonuc3DSecure">TP_Islem_Odeme_OnProv_WMDPostDTO Nenesi</param>
        ///     Pos_OdemePostDTO:
        ///         md: TP_WMD_Pay Metodunun UCD_MD Parametresine Gönderilecek MD Değeri
        ///         mdStatus: 3D Doğrulama Sonucu (1: Başarılı - Diğer durumlarda 3D doğrulama başarısızdır.)
        ///         orderId: Siparis_ID Değeri
        ///         transactionAmount: İşlem Tutarı
        ///         islemGUID: İşlemin GUID Değeri
        ///         islemHash: İşlemin Hash değeri
        ///         bankResult: Banka Sonucu
        ///         dc: dc Değeri
        ///         dcURL: dcURL Değeri
        /// <param name="tpwmdpay">ST_WMD_Pay Nenesi</param>
        ///     ST_WMD_Pay:
        ///         Sonuc: İşlem Sonucu
        ///         Sonuc_Ack: İşlem Sonucunun Açıklaması
        ///         Dekont_ID: 	İşlemin Dekont ID'si
        ///         Siparis_ID: Sipariş ID Değeri
        ///         UCD_MD: 3D MD Değeri
        ///         Bank_Trans_ID: Bankanın Transaction ID Değeri
        ///         Bank_AuthCode: Bankanın Auth Code Değeri
        ///         Bank_HostMsg: Banka HostMsg Değeri
        ///         Bank_Extra: Banka Extra Değeri
        ///         Banka_Sonuc_Kod: Bankanın Sonuç Kodu
        ///         Bank_HostRefNum: Bankanın HostMsg Değeri
        ///         Komisyon_Oran: Komisyon Oranı
        /// <param name="cookie">TPIslemOdemeOnProvWMDCookieModel Nenesi</param>
        ///     TPIslemOdemeOnProvWMDCookieModel:
        ///         IslemID: İşlem ID
        ///         G: ST_WS_Guvenlik Nesnesi
        ///             ST_WS_Guvenlik Nesnesi:
        ///                 CLIENT_CODE: Terminal ID
        ///                 CLIENT_USERNAME: Kullanıcı Adı
        ///                 CLIENT_PASSWORD: Şifre
        ///                 GUID: Üye İşyerine Ait Anahtar
        /// <returns>IActionResult Nesnesi</returns>
        [HttpGet]
        [HttpPost]
        public IActionResult TPIslemOdemeOnProvWMD([FromForm] ST_WMD_UCD sonucNonSecure, [FromForm] TP_Islem_Odeme_OnProv_WMDPostDTO sonuc3DSecure, [FromForm] ST_WMD_Pay tpwmdpay, [FromForm] TPIslemOdemeOnProvWMDCookieModel cookie)
        {
            TPIslemOdemeOnProvWMDSonucViewModel model = new()
            {
                SonucNonSecure = sonucNonSecure.Sonuc == null || tpwmdpay.Dekont_ID != null ? null : sonucNonSecure,
                Sonuc3DSecure = sonuc3DSecure.islemGUID == null ? null : sonuc3DSecure,
                Completed3DSecure = tpwmdpay,
                Onaylandı = tpwmdpay.Sonuc > 0 ? 1 : null,
                IslemID = cookie.IslemID,
            };
            return View(model);
        }
        /// <summary>TP_Islem_Odeme_WD metodunun sonuç sayfasını görüntüler.</summary>
        /// <param name="sonucNonSecure">ST_TP_Islem_Odeme Nenesi</param>
        ///     ST_TP_Islem_Odeme:
        ///         Islem_ID: SID Değeri
        ///         UCD_URL: 3D URL'i
        ///         Sonuc: İşlem Sonucu
        ///         Sonuc_Str: İşlem Sonucunun Açıklaması
        ///         Banka_Sonuc_Kod: Bankadan Gönderilen Kod
        ///         Siparis_ID: Sipariş ID'si
        ///         Komisyon_Oran: Komisyon Oranı
        /// <param name="sonuc3DSecure">TPIslemOdemeWDPostDTO Nenesi</param>
        ///     TPIslemOdemeWDPostDTO:
        ///         TURKPOS_RETVAL_Islem_ID: Servise Gönderdiğiniz Islem ID'si
        ///         TURKPOS_RETVAL_Sonuc: Sonuç Değeri
        ///         TURKPOS_RETVAL_Sonuc_Str: Sonucun Açıklaması
        ///         TURKPOS_RETVAL_GUID: Üye İşyeri Ait Anahtar
        ///         TURKPOS_RETVAL_Islem_Tarih: İşlem Tarihi
        ///         TURKPOS_RETVAL_Dekont_ID: Dekont Numarası
        ///         TURKPOS_RETVAL_Tahsilat_Tutar: Müşteriden Tahsil Edilen Tutar
        ///         TURKPOS_RETVAL_Odeme_Tutari: Net Ututar (Tahsilat tutarından komisyon tutarının çıkarılmış halidir.)
        ///         TURKPOS_RETVAL_Siparis_ID: Servise Gönderdiğiniz İşleme Ait Tekil Siparis_ID
        ///         TURKPOS_RETVAL_Ext_Data: Metottaki Data1, Data2, Data3, Data4, Data5 parametrelerinin “|” ile birleştirilmiş hali döner (Ext_Data = Data1 & "|" & Data2 & "|" & Data3 & "|" & Data4 & "|" & Data5).
        ///         TURKPOS_RETVAL_Banka_Sonuc_Kod: Banka Sonucunun Kodu
        ///         TURKPOS_RETVAL_PB: PB değeri
        ///         TURKPOS_RETVAL_KK_No: Kredi Karti Numarası (İlk 6 ve Son 4 Hanesi)
        ///         TURKPOS_RETVAL_Taksit: Taksit Değeri
        ///         TURKPOS_RETVAL_Hash: Dönen Cevaba Ait Hash Değeri
        ///         TURKPOS_RETVAL_Islem_GUID: İşlemin GUID değeri
        ///         TURKPOS_RETVAL_SanalPOS_Islem_ID: SanalPOS İşlemin ID'si
        /// <returns>IActionResult Nesnesi</returns>
        [HttpGet]
        [HttpPost]
        public IActionResult TPIslemOdemeWD([FromForm] TurkPosWSTEST.ST_TP_Islem_Odeme sonucNonSecure, [FromForm] TPIslemOdemeWDPostDTO sonuc3DSecure)
        {
            TPIslemOdemeWDSonucViewModel model = new() { SonucNonSecure = sonucNonSecure.Sonuc == null ? null : sonucNonSecure, Sonuc3DSecure = sonuc3DSecure.TURKPOS_RETVAL_Sonuc == null ? null : sonuc3DSecure };
            return View(model);
        }
        /// <summary>TP_Islem_Sorgulama4 metodunun sonuç sayfasını görüntüler.</summary>
        /// <param name="result">ST_Genel_Sonuc2 Nenesi</param>
        ///     ST_Genel_Sonuc2:
        ///         DT_Bilgi:
        ///             Odemme_Sonuc: Ödeme Sonucu (1: Başarılı, 12: İptal, 13: İade)
        ///             Odeme_Sonuc_Aciklama: Ödeme Sonuç Açıklama
        ///             Dekont_ID: Dekont Bilgisi( Başarısız ise “0” döner; başarılı ise “0” dan büyük döner.)
        ///             Siparis_ID: Sipariş ID
        ///             Islem_ID: Metoda Gönderilen Islem ID'si
        ///             Durum: İşlem Durumu (SUCCESS - PARTIAL_REFUND - FAIL - BANK_FAIL - CANCEL - REFUND)
        ///             Tarih: İşlemin Gerçekleşme Tarihi
        ///             Toplam_Tutar: Komisyon Dahil Sipariş Tutarı
        ///             Komisyon_Oran: Komisyon Oranı
        ///             Komisyon_Tutar: Komisyon Tutarı
        ///             Banka_Sonuc_Aciklama: Banka Açıklaması
        ///             Taksit: Taksit Bilgisi
        ///             Ext_Data: Ödeme Metodundaki Data1, Data2, Data3, Data4, Data5 alanlarının “ | ” ile birleştirilmiş hali döner.
        ///             Toplam_Iade_Tutar: Toplam İade Tutarı
        ///             KK_No: Kredi Kartı Numarası
        ///             Bank_Extra: Banka Extra Değeri
        ///             Islem_Tip: İşlem Türü (SALE - PRE_AUTH - POST_AUTH)
        ///             Bank_Trans_ID: Bankanın Transaction ID Değeri
        ///             Bank_AuthCode: Bankanın Auth Code Değeri
        ///             Bank_HostRefNum: Bankanın RRN Değeri
        ///         Sonuc: İşlem Sonucu
        ///         Sonuc_Str: İşlem Sonucunun Açıklaması
        /// <returns>IActionResult Nesnesi</returns>
        [HttpGet]
        [HttpPost]
        public IActionResult TPIslemSorgulama4([FromForm] ST_Genel_Sonuc2 result)
        {
            TPIslemSorgulama4SonucViewModel model = new() { Sonuc = result };
            return View(model);
        }
        /// <summary>TP_KK_Verify metodunun sonuç sayfasını görüntüler.</summary>
        /// <param name="result">ST_TP_Islem_Odeme Nenesi</param>
        ///     ST_TP_Islem_Odeme:
        ///         Islem_ID: SID Değeri
        ///         UCD_URL: 3D URL'i
        ///         Sonuc: İşlem Sonucu
        ///         Sonuc_Str: İşlem Sonucunun Açıklaması
        ///         Banka_Sonuc_Kod: Bankadan Gönderilen Kod
        ///         Siparis_ID: Sipariş ID'si
        ///         Komisyon_Oran: Komisyon Oranı
        /// <param name="resultPost">TP_KK_VerifyPostDTO Nenesi</param>
        ///     TP_KK_VerifyPostDTO:
        ///         KK_VERIFY_Sonuc: İşlem Sonucu
        ///         KK_VERIFY_Sonuc_Str: İşlem Sonuç Açıklama
        ///         KK_VERIFY_Data1: Extra Alan 1
        ///         KK_VERIFY_Data2: Extra Alan 2
        ///         KK_VERIFY_Data3: Extra Alan 3
        ///         KK_VERIFY_Data4: Extra Alan 4
        ///         KK_VERIFY_Data5: Extra Alan 5
        /// <returns>IActionResult Nesnesi</returns>
        [HttpGet]
        [HttpPost]
        public IActionResult TPKKVerify([FromForm] TurkPosWSTEST.ST_TP_Islem_Odeme result, [FromForm] TP_KK_VerifyPostDTO resultPost)
        {
            TPKKVerifySonucViewModel model = new() { Sonuc = result.Sonuc == null ? null : result, SonucPost = resultPost.KK_VERIFY_Sonuc == null ? null : resultPost };
            return View(model);
        }
        /// <summary>TP_Mutabakat_Detay metodunun sonuç sayfasını görüntüler.</summary>
        /// <param name="result">ST_Genel_Sonuc Nenesi</param>
        ///     ST_Genel_Sonuc:
        ///         DT_Bilgi:
        ///             GUNSONU_TARIHI: Gün Sonu Tarihi
        ///             ISLEM_TARIHI: İşlem Tarihi
        ///             VALOR_TARIHI: Valör Tarihi
        ///             KART_NO: Kart Numarası
        ///             TRANSACTION_TIPI: İşlem Tipi
        ///             PROVIZYON_NO: Provizyon Numarası
        ///             TAKSIT_SIRA: Taksit Sırası
        ///             TAKSIT_SAYISI: Taksit Sayısı
        ///             PROVIZYON_TUTARI: Provizyon tutarı
        ///             KOMISYON_TUTARI: Komisyon Tutarı
        ///             KOMISYON_ORANI: Komisyon Oranı
        ///             NET_TUTAR: 	Net Tutar
        ///             SIPARIS_NO: Sipariş Numarası
        ///             ANA_KART_TIPI: Anakart Tipi
        ///             ALT_KART_TIPI: Alt Kart Tipi
        ///         Sonuc: İşlem Sonucu
        ///         Sonuc_Str: İşlem Sonucunun Açıklaması
        /// <returns>IActionResult Nesnesi</returns>
        [HttpGet]
        [HttpPost]
        public IActionResult TPMutabakatDetay([FromForm][ModelBinder(typeof(FormDataXmlBinder))] ST_Genel_Sonuc result)
        {
            TP_Mutabakat_DetayDT_BilgiDTO? dt_bilgi = null;
            if (result.DT_Bilgi != null)
            {
                XmlSerializer serializer = new(typeof(TP_Mutabakat_DetayDT_BilgiDTO));
                using StringReader reader = new(result.DT_Bilgi.Any1.InnerXml);
                using XmlReader xmlReader = XmlReader.Create(reader);
                xmlReader.ReadToDescendant("Temp");
                dt_bilgi = serializer.Deserialize(xmlReader) as TP_Mutabakat_DetayDT_BilgiDTO;
            }
            TPMutabakatDetaySonucViewModel model = new() { DT_Bilgi = dt_bilgi, Sonuc = result.Sonuc, Sonuc_Str = result.Sonuc_Str };
            return View(model);
        }
        /// <summary>TP_Mutabakat_Ozet metodunun sonuç sayfasını görüntüler.</summary>
        /// <param name="result">ST_Genel_Sonuc Nenesi</param>
        ///     ST_Genel_Sonuc:
        ///         DT_Bilgi:
        ///             Basarili_Islem_Sayi: Başarılı İşlem Sayısı
        ///             Basarili_Islem_Toplam_Tutar: Başarılı İşlem Toplam Tutarı
        ///             Iptal_Islem_Sayi: İptal İşlem Toplam Tutarı
        ///             Iptal_Islem_Toplam_Tutar: Özel Oranların Pasif Olacağı Tarih (Örn. dd.MM.yyyy)
        ///             Iade_Islem_Sayi: İade İşlem Sayısı
        ///             Iade_Islem_Toplam_Tutar: İade İşlem Sayısı
        ///         Sonuc: İşlem Sonucu
        ///         Sonuc_Str: İşlem Sonucunun Açıklaması
        /// <returns>IActionResult Nesnesi</returns>
        [HttpGet]
        [HttpGet]
        [HttpPost]
        public IActionResult TPMutabakatOzet([FromForm][ModelBinder(typeof(FormDataXmlBinder))] ST_Genel_Sonuc result)
        {
            TP_Mutabakat_OzetDT_BilgiDTO? dt_bilgi = null;
            if (result.DT_Bilgi != null)
            {
                XmlSerializer serializer = new(typeof(TP_Mutabakat_OzetDT_BilgiDTO));
                using StringReader reader = new(result.DT_Bilgi.Any1.InnerXml);
                using XmlReader xmlReader = XmlReader.Create(reader);
                xmlReader.ReadToDescendant("DT_Mutabakat_Ozet");
                dt_bilgi = serializer.Deserialize(xmlReader) as TP_Mutabakat_OzetDT_BilgiDTO;
            }
            TPMutabakatOzetSonucViewModel model = new() { DT_Bilgi = dt_bilgi, Sonuc = result.Sonuc, Sonuc_Str = result.Sonuc_Str };
            return View(model);
        }
        /// <summary>TP_Ozel_Oran_Liste metodunun sonuç sayfasını görüntüler.</summary>
        /// <param name="result">ST_Genel_Sonuc Nenesi</param>
        ///     ST_Genel_Sonuc:
        ///         DT_Bilgi:
        ///             Ozel_Oran_ID: Özel Oran ID si
        ///             GUID: Üye İşyerine Ait Anahtar
        ///             Tarih_Bas: 	Özel Oranların Aktif Olacağı Tarih (Örn. dd.MM.yyyy)
        ///             Tarih_Bit: 	Özel Oranların Pasif Olacağı Tarih (Örn. dd.MM.yyyy)
        ///             SanalPOS_ID: Sanal Pos Numarası
        ///             Kredi_Karti_Banka: Kredi Kartı Markası (Bonus, Axess vs.)
        ///             Kredi_Karti_Banka_Gorsel: Kredi Kartı Marka Görseli
        ///             MO_01: Tek Çekim Oranı
        ///             MO_02: 2. Taksit Oranı
        ///             MO_03: 3. Taksit Oranı
        ///             MO_04: 4. Taksit Oranı
        ///             MO_05: 5. Taksit Oranı
        ///             MO_06: 6. Taksit Oranı
        ///             MO_07: 7. Taksit Oranı
        ///             MO_08: 8. Taksit Oranı
        ///             MO_09: 9. Taksit Oranı
        ///             MO_10: 10. Taksit Oranı
        ///             MO_11: 11. Taksit Oranı
        ///             MO_12: 12.  Taksit Oranı
        ///         Sonuc: İşlem Sonucu
        ///         Sonuc_Str: İşlem Sonucunun Açıklaması
        /// <returns>IActionResult Nesnesi</returns>
        [HttpGet]
        [HttpPost]
        public IActionResult TPOzelOranListe([FromForm][ModelBinder(typeof(FormDataXmlBinder))] ST_Genel_Sonuc result)
        {
            List<TP_Ozel_Oran_ListeDT_BilgiDTO>? dt_bilgi = new();
            if (result.DT_Bilgi != null)
            {
                XmlSerializer serializer = new(typeof(TP_Ozel_Oran_ListeDT_BilgiDTO));
                using StringReader reader = new(result.DT_Bilgi.Any1.InnerXml);
                using XmlReader xmlReader = XmlReader.Create(reader);
                xmlReader.ReadToDescendant("DT_Ozel_Oranlar");
                while (xmlReader.MoveToNextAttribute()) dt_bilgi.Add((TP_Ozel_Oran_ListeDT_BilgiDTO)serializer.Deserialize(xmlReader)!);
            }
            TPOzelOranListeSonucViewModel model = new() { DT_Bilgi = dt_bilgi, Sonuc = result.Sonuc, Sonuc_Str = result.Sonuc_Str };
            return View(model);
        }
        /// <summary>TP_Ozel_Oran_SK_Guncelle metodunun sonuç sayfasını görüntüler.</summary>
        /// <param name="result">ST_Sonuc Nenesi</param>
        ///     ST_Sonuc:
        ///         Sonuc_Str: İşlem Sonucunun Açıklaması
        /// <returns>IActionResult Nesnesi</returns>
        [HttpGet]
        [HttpPost]
        public IActionResult TPOzelOranSKGuncelle([FromForm] TurkPosWSTEST.ST_Sonuc result)
        {
            TPOzelOranSKGuncelleSonucViewModel model = new() { Sonuc = result };
            return View(model);
        }
        /// <summary>TP_Ozel_Oran_SK_Liste metodunun sonuç sayfasını görüntüler.</summary>
        /// <param name="result">ST_Genel_Sonuc Nenesi</param>
        ///     ST_Genel_Sonuc:
        ///         DT_Bilgi:
        ///             Ozel_Oran_SK_ID: Özel Oran SK Liste den gelen ID'si
        ///             GUID: Üye İşyerine Ait Anahtar
        ///             SanalPOS_ID: Sanal Pos Numarası
        ///             Kredi_Karti_Banka: Kredi Kartı Markası (Bonus, Axess vs.)
        ///             Kredi_Karti_Banka_Gorsel: Kredi Kartı Marka Görseli
        ///             MO_01: Tek Çekim Oranı
        ///             MO_02: 2. Taksit Oranı
        ///             MO_03: 3. Taksit Oranı
        ///             MO_04: 4. Taksit Oranı
        ///             MO_05: 5. Taksit Oranı
        ///             MO_06: 6. Taksit Oranı
        ///             MO_07: 7. Taksit Oranı
        ///             MO_08: 8. Taksit Oranı
        ///             MO_09: 9. Taksit Oranı
        ///             MO_10: 10. Taksit Oranı
        ///             MO_11: 11. Taksit Oranı
        ///             MO_12: 12.  Taksit Oranı
        ///         Sonuc: İşlem Sonucu
        ///         Sonuc_Str: İşlem Sonucunun Açıklaması
        /// <returns>IActionResult Nesnesi</returns>
        [HttpGet]
        [HttpPost]
        public IActionResult TPOzelOranSKListe([FromForm][ModelBinder(typeof(FormDataXmlBinder))] ST_Genel_Sonuc result)
        {
            List<TP_Ozel_Oran_SK_ListeDT_BilgiDTO>? dt_bilgi = new();
            if (result.DT_Bilgi != null)
            {
                XmlSerializer serializer = new(typeof(TP_Ozel_Oran_SK_ListeDT_BilgiDTO));
                using StringReader reader = new(result.DT_Bilgi.Any1.InnerXml);
                using XmlReader xmlReader = XmlReader.Create(reader);
                xmlReader.ReadToDescendant("DT_Ozel_Oranlar_SK");
                while (xmlReader.MoveToNextAttribute()) dt_bilgi.Add((TP_Ozel_Oran_SK_ListeDT_BilgiDTO)serializer.Deserialize(xmlReader)!);
            }
            TPOzelOranSKListeSonucViewModel model = new() { DT_Bilgi = dt_bilgi, Sonuc = result.Sonuc, Sonuc_Str = result.Sonuc_Str };
            return View(model);
        }
        /// <summary>TP_WMD_UCD metodunun sonuç sayfasını görüntüler.</summary>
        /// <param name="sonucNonSecure">ST_WMD_UCD Nenesi</param>
        ///     ST_WMD_UCD:
        ///         Islem_ID: SID Değeri
        ///         Islem_GUID: İşlem GUID Değeri
        ///         UCD_HTML: 3D HTML Kodu
        ///         UCD_MD: 3D MD Değeri
        ///         Sonuc: İşlem Sonucu
        ///         Sonuc_Str: İşlem Sonucunun Açıklaması
        ///         Bank_Trans_ID: Bankanın Transaction ID Değeri
        ///         Bank_AuthCode: Bankanın Auth Code Değeri
        ///         Bank_HostMsg: Banka HostMsg Değeri
        ///         Banka_Sonuc_Kod: Bankanın Sonuç Kodu
        ///         Bank_Extra: Banka Extra Değeri
        ///         Siparis_ID: Sipariş ID'si
        ///         Bank_HostRefNum: Bankanın HostMsg Değeri
        ///         Ext_Data: Ekstra Veri
        /// <param name="sonuc3DSecure">TP_WMD_UCDPostDTO Nenesi</param>
        ///     Pos_OdemePostDTO:
        ///         md: TP_WMD_Pay Metodunun UCD_MD Parametresine Gönderilecek MD Değeri
        ///         mdStatus: 3D Doğrulama Sonucu (1: Başarılı - Diğer durumlarda 3D doğrulama başarısızdır.)
        ///         orderId: Siparis_ID Değeri
        ///         transactionAmount: İşlem Tutarı
        ///         islemGUID: İşlemin GUID Değeri
        ///         islemHash: İşlemin Hash değeri
        ///         bankResult: Banka Sonucu
        ///         dc: dc Değeri
        ///         dcURL: dcURL Değeri
        /// <param name="tpwmdpay">ST_WMD_Pay Nenesi</param>
        ///     ST_WMD_Pay:
        ///         Sonuc: İşlem Sonucu
        ///         Sonuc_Ack: İşlem Sonucunun Açıklaması
        ///         Dekont_ID: 	İşlemin Dekont ID'si
        ///         Siparis_ID: Sipariş ID Değeri
        ///         UCD_MD: 3D MD Değeri
        ///         Bank_Trans_ID: Bankanın Transaction ID Değeri
        ///         Bank_AuthCode: Bankanın Auth Code Değeri
        ///         Bank_HostMsg: Banka HostMsg Değeri
        ///         Bank_Extra: Banka Extra Değeri
        ///         Banka_Sonuc_Kod: Bankanın Sonuç Kodu
        ///         Bank_HostRefNum: Bankanın HostMsg Değeri
        ///         Komisyon_Oran: Komisyon Oranı
        /// <param name="cookie">TPWMDUCDCookieModel Nenesi</param>
        ///     TPWMDUCDCookieModel:
        ///         IslemID: İşlem ID
        ///         G: ST_WS_Guvenlik Nesnesi
        ///             ST_WS_Guvenlik Nesnesi:
        ///                 CLIENT_CODE: Terminal ID
        ///                 CLIENT_USERNAME: Kullanıcı Adı
        ///                 CLIENT_PASSWORD: Şifre
        ///                 GUID: Üye İşyerine Ait Anahtar
        /// <returns>IActionResult Nesnesi</returns>
        [HttpGet]
        [HttpPost]
        public IActionResult TPWMDUCD([FromForm] ST_WMD_UCD sonucNonSecure, [FromForm] TP_WMD_UCDPostDTO sonuc3DSecure, [FromForm] ST_WMD_Pay tpwmdpay, [FromForm] TPWMDUCDCookieModel cookie)
        {
            TPWMDUCDSonucViewModel model = new()
            {
                Sonuc3DSecure = sonuc3DSecure.islemGUID == null ? null : sonuc3DSecure,
                SonucNonSecure = sonucNonSecure.Sonuc == null || tpwmdpay.Dekont_ID != null ? null : sonucNonSecure,
                Completed3DSecure = tpwmdpay,
                Onaylandı = tpwmdpay.Sonuc > 0 ? 1 : null,
                IslemID = cookie.IslemID,
            };
            return View(model);
        }
        /// <summary>KS_Kart_Ekle metodunun sonuç sayfasını görüntüler.</summary>
        /// <param name="result">ST_KS_Kart_Ekle Nesnesi (Zorunlu)</param>
        ///     ST_KS_Kart_Ekle:
        ///         Sonuc: İşlem Sonucu
        ///         Sonuc_Str: İşlem Sonucunun Açıklaması
        ///         KS_GUID: Kart Ekleme GUID Değeri
        /// <returns>IActionResult Nesnesi</returns>
        [HttpGet]
        [HttpPost]
        public IActionResult KSKartEkle([FromForm] TP_KS.ST_KS_Kart_Ekle result)
        {
            KSKartEkleSonucViewModel model = new() { Sonuc = result };
            return View(model);
        }
        /// <summary>KS_Kart_Liste metodunun sonuç sayfasını görüntüler.</summary>
        /// <param name="result">ST_KS_Kart_Liste Nesnesi (Zorunlu)</param>
        ///     ST_KS_Kart_Liste:
        ///         Sonuc: İşlem Sonucu
        ///         Sonuc_Str: İşlem Sonucunun Açıklaması
        ///         DT_Bilgi:
        ///             ID: Kart Saklama ID'si
        ///             KK_GUID: Kart Saklama GUID Değeri
        ///             Tarih: Saklama Tarihi
        ///             KK_No: Kredi Kartı BIN Kodu
        ///             KK_Tip: Kart Tipi
        ///             KK_Banka: Kart Bankası
        ///             KK_Marka: Kart Markası
        ///             Kart_Adi: Kart Adı
        ///             KK_Hash: Kredi Kartı Hash Değeri
        ///             KK_KD: Kart Türü
        ///             KK_SK: Kredi Kartı Son Kullanma Tarihi
        ///             Data2: Extra Alan 2
        /// <returns>IActionResult Nesnesi</returns>
        [HttpGet]
        [HttpPost]
        public IActionResult KSKartListe([FromForm][ModelBinder(typeof(FormDataXmlBinder))] TP_KS.ST_KS_Kart_Liste result)
        {
            List<KS_Kart_ListeDT_BilgiDTO>? dt_bilgi = new();
            if (result.DT_Bilgi != null)
            {
                XmlSerializer serializer = new(typeof(KS_Kart_ListeDT_BilgiDTO));
                using StringReader reader = new(result.DT_Bilgi.Any1.InnerXml);
                using XmlReader xmlReader = XmlReader.Create(reader);
                xmlReader.ReadToDescendant("Temp");
                while (xmlReader.MoveToNextAttribute()) dt_bilgi.Add((KS_Kart_ListeDT_BilgiDTO)serializer.Deserialize(xmlReader)!);
            }
            KSKartListeSonucViewModel model = new() { DT_Bilgi = dt_bilgi, Sonuc = result.Sonuc, Sonuc_Str = result.Sonuc_Str };
            return View(model);
        }
        /// <summary>KS_Kart_Sil metodunun sonuç sayfasını görüntüler.</summary>
        /// <param name="result">ST_Sonuc Nenesi</param>
        ///     ST_Sonuc:
        ///         Sonuc: İşlem Sonucu
        ///         Sonuc_Str: İşlem Sonucunun Açıklaması
        /// <returns>IActionResult Nesnesi</returns>
        [HttpGet]
        [HttpPost]
        public IActionResult KSKartSil([FromForm] TP_KS.ST_Sonuc result)
        {
            KSKartSilSonucViewModel model = new() { Sonuc = result };
            return View(model);
        }
        /// <summary>KK_Tashilat metodunun sonuç sayfasını görüntüler.</summary>
        /// <param name="result">ST_TP_Islem_Odeme Nesnesi (Zorunlu)</param>
        ///     ST_TP_Islem_Odeme:
        ///         Islem_ID: SID Değeri
        ///         UCD_URL: 3D URL'i
        ///         Sonuc: İşlem Sonucu
        ///         Sonuc_Str: İşlem Sonucunun Açıklaması
        /// <param name="resultPost">KS_TahsilatPOSTDTO Nesnesi (Zorunlu)</param>
        ///     Pos_OdemePostDTO:
        ///         TURKPOS_RETVAL_Sonuc: Sonuç Değeri
        ///         TURKPOS_RETVAL_Sonuc_Str: Sonucun Açıklaması
        ///         TURKPOS_RETVAL_GUID: Üye İşyeri Ait Anahtar
        ///         TURKPOS_RETVAL_Islem_Tarih: İşlem Tarihi
        ///         TURKPOS_RETVAL_Dekont_ID: Dekont Numarası
        ///         TURKPOS_RETVAL_Tahsilat_Tutar: Müşteriden Tahsil Edilen Tutar
        ///         TURKPOS_RETVAL_Odeme_Tutari: Net Ututar (Tahsilat tutarından komisyon tutarının çıkarılmış halidir.)
        ///         TURKPOS_RETVAL_Siparis_ID: Servise Gönderdiğiniz İşleme Ait Tekil Siparis_ID
        ///         TURKPOS_RETVAL_Islem_ID: Servise Gönderdiğiniz Islem ID'si
        ///         TURKPOS_RETVAL_Ext_Data: Metottaki Data1, Data2, Data3, Data4, Data5 parametrelerinin “|” ile birleştirilmiş hali döner (Ext_Data = Data1 & "|" & Data2 & "|" & Data3 & "|" & Data4 & "|" & Data5).
        /// <returns>IActionResult Nesnesi</returns>
        [HttpGet]
        [HttpPost]
        public IActionResult KSTahsilat([FromForm] TP_KS.ST_TP_Islem_Odeme result, [FromForm] KS_TahsilatPOSTDTO resultPost)
        {
            KSTahsilatSonucViewModel model = new() { Sonuc = result.Sonuc == null ? null : result, SonucPOST = resultPost.TURKPOS_RETVAL_Sonuc == null ? null : resultPost };
            return View(model);
        }
    }
}