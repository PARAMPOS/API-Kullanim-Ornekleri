using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;
using System.Web;
using TP_KS;
using TurkPosWSTEST;
using WebMvc.DTOs.TP_WMD_Pay;
using WebMvc.Helpers;
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
using WebMvc.Repository.Interface;
using WebMvc.Models.PazaryeriTPAltUyeIsyeriEkleme;
using WebMvc.Models.PazaryeriTPAltUyeIsyeriGuncelleme;
using WebMvc.Models.PazaryeriTPAltUyeIsyeriListe;
using WebMvc.Models.PazaryeriTPSiparisOnay;
using WebMvc.Models.PazaryeriTPSiparisDetayEkle;
using WebMvc.Models.PazaryeriTPIslemSorgulama;
using WebMvc.Models.PazaryeriTPIptalIade;
using WebMvc.Models.IlIlceListe;
using WebMvc.Models.IlListe;
using WebMvc.Models.PazaryeriTPLimitKontrol;
using WebMvc.Models.PazaryeriTPAltUyeIsyeriSilme;
using WebMvc.DTOs.Pos_Odeme;

namespace WebMvc.Controllers
{
    public class OpController : Controller
    {
        private readonly Iservice_paramAsyncRepository service_paramAsyncRepository;
        private readonly ITP_KSAsyncRepository TP_KSAsyncRepository;
        private readonly ITurkPosWSTESTAsyncRepository TurkPosWSTESTAsyncRepository;
        public OpController(Iservice_paramAsyncRepository service_paramAsyncRepository, ITP_KSAsyncRepository TP_KSAsyncRepository, ITurkPosWSTESTAsyncRepository TurkPosWSTESTAsyncRepository)
        {
            this.service_paramAsyncRepository = service_paramAsyncRepository;
            this.TP_KSAsyncRepository = TP_KSAsyncRepository;
            this.TurkPosWSTESTAsyncRepository = TurkPosWSTESTAsyncRepository;
        }
        [HttpGet]
        public IActionResult AOKontrol()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AidatAlSMS()
        {
            return View();
        }
        [HttpGet]
        public IActionResult BKMFSHRapor()
        {
            return View();
        }
        [HttpGet]
        public IActionResult BKMRapor()
        {
            return View();
        }
        [HttpGet]
        public IActionResult BaroKartCubbeListe()
        {
            return View();
        }
        [HttpGet]
        public IActionResult BildirimGonder()
        {
            return View();
        }
        [HttpGet]
        public IActionResult BildirimGonderv2()
        {
            return View();
        }
        [HttpGet]
        public IActionResult BildirimGonderv3()
        {
            return View();
        }
        [HttpGet]
        public IActionResult DekontBilgisiKK()
        {
            return View();
        }
        [HttpGet]
        public IActionResult DekontBilgisiSalt()
        {
            return View();
        }
        [HttpGet]
        public IActionResult DekontEPostaGonder()
        {
            return View();
        }
        [HttpGet]
        public IActionResult EPGonder()
        {
            return View();
        }
        [HttpGet]
        public IActionResult EPGonder2()
        {
            return View();
        }
        [HttpGet]
        public IActionResult EPGonder3()
        {
            return View();
        }
        [HttpGet]
        public IActionResult EPGonder4()
        {
            return View();
        }
        [HttpGet]
        public IActionResult EPGonder5()
        {
            return View();
        }
        [HttpGet]
        public IActionResult EkstreDonemler()
        {
            return View();
        }
        [HttpGet]
        public IActionResult HashData()
        {
            return View();
        }
        [HttpGet]
        public IActionResult HashDecrypt()
        {
            return View();
        }
        [HttpGet]
        public IActionResult HesapEkstre()
        {
            return View();
        }
        [HttpGet]
        public IActionResult HesapEkstreBase64()
        {
            return View();
        }
        [HttpGet]
        public IActionResult IlIlceListe() // Ýlçe Listesi sayfasýný görüntüler.
        {
            return View(new IlIlceListeViewModel());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> IlIlceListeAsync([FromForm] IlIlceListeViewModel model) // Ýlçe Listesi sayfasýndan gönderilen formu iþler.
        {
            service_param.ST_Genel_Sonuc result = await service_paramAsyncRepository.IlIlceListeAsync(model.Islem_Tip, model.Il_Kodu, model.Uygulama_Tip);
            return RedirectHelper.PostRedirectXml("/Sonuc/IlIlceListe", result);
        }
        [HttpGet]
        public IActionResult IletisimBilgi()
        {
            return View();
        }
        [HttpGet]
        public IActionResult IletisimBilgiGuncelle()
        {
            return View();
        }
        [HttpGet]
        public IActionResult IslemHarcama()
        {
            return View();
        }
        [HttpGet]
        public IActionResult IslemLoginGenel()
        {
            return View();
        }
        [HttpGet]
        public IActionResult IslemLoginGenel2()
        {
            return View();
        }
        [HttpGet]
        public IActionResult IslemLoginGenelAA()
        {
            return View();
        }
        [HttpGet]
        public IActionResult IslemLoginPIN()
        {
            return View();
        }
        [HttpGet]
        public IActionResult KKTLYUKLETKS()
        {
            return View();
        }
        [HttpGet]
        public IActionResult KKTaksitListe()
        {
            return View();
        }
        [HttpGet]
        public IActionResult KSNonsecureTahsilat()
        {
            return View();
        }
        [HttpGet]
        public IActionResult KartBakiyeBilgi()
        {
            return View();
        }
        [HttpGet]
        public IActionResult KisiBilgi()
        {
            return View();
        }
        [HttpGet]
        public IActionResult LimitBilgi()
        {
            return View();
        }
        [HttpGet]
        public IActionResult OpetSatis()
        {
            return View();
        }
        [HttpGet]
        public IActionResult OpetYakitKartBakiye()
        {
            return View();
        }
        [HttpGet]
        public IActionResult PINIslem()
        {
            return View();
        }
        [HttpGet]
        public IActionResult ParamBasvuru()
        {
            return View();
        }
        [HttpGet]
        public IActionResult ParamBasvuruBelgeGonder()
        {
            return View();
        }
        [HttpGet]
        public IActionResult ParamFastKolasAddProxyAccount()
        {
            return View();
        }
        [HttpGet]
        public IActionResult ParamFastKolasDeleteProxyAccount()
        {
            return View();
        }
        [HttpGet]
        public IActionResult ParamFastKolasGetRecipientProxyAccount()
        {
            return View();
        }
        [HttpGet]
        public IActionResult ParamFastKolasGetTransferProxyAccount()
        {
            return View();
        }
        [HttpGet]
        public IActionResult ParamFastKolasQueryProxyAccount()
        {
            return View();
        }
        [HttpGet]
        public IActionResult ParamFastKolasUpdateProxyAccount()
        {
            return View();
        }
        [HttpGet]
        public IActionResult ParamFastTransferYap()
        {
            return View();
        }
        [HttpGet]
        public IActionResult ParamIBANIslem()
        {
            return View();
        }
        [HttpGet]
        public IActionResult ParamIslem()
        {
            return View();
        }
        [HttpGet]
        public IActionResult ParamQRKontrol()
        {
            return View();
        }
        [HttpGet]
        public IActionResult ParamSahtecilikIslem()
        {
            return View();
        }
        [HttpGet]
        public IActionResult ParamSanalPOSIslem()
        {
            return View();
        }
        [HttpGet]
        public IActionResult ParamSanalPOSLimit()
        {
            return View();
        }
        [HttpGet]
        public IActionResult ParamTransferHesap()
        {
            return View();
        }
        [HttpGet]
        public IActionResult ParamTransferQRUret()
        {
            return View();
        }
        [HttpGet]
        public IActionResult ParamTransferQRUretSuresiz()
        {
            return View();
        }
        [HttpGet]
        public IActionResult ParamTransferYap()
        {
            return View();
        }
        [HttpGet]
        public IActionResult ParamTransferYapQR()
        {
            return View();
        }
        [HttpGet]
        public IActionResult ParamTransferYapv2()
        {
            return View();
        }
        [HttpGet]
        public IActionResult PromosyonKodKullanim()
        {
            return View();
        }
        [HttpGet]
        public IActionResult PromosyonKodUret()
        {
            return View();
        }
        [HttpGet]
        public IActionResult SMSDogrulama()
        {
            return View();
        }
        [HttpGet]
        public IActionResult SMSDogrulama3()
        {
            return View();
        }
        [HttpGet]
        public IActionResult SMSDogrulamaMobil()
        {
            return View();
        }
        [HttpGet]
        public IActionResult SMSGonder()
        {
            return View();
        }
        [HttpGet]
        public IActionResult SMSGonder2()
        {
            return View();
        }
        [HttpGet]
        public IActionResult SMSGonderMobil()
        {
            return View();
        }
        [HttpGet]
        public IActionResult SifreDegistir()
        {
            return View();
        }
        [HttpGet]
        public IActionResult SifremiUnuttum()
        {
            return View();
        }
        [HttpGet]
        public IActionResult SurumKontrol()
        {
            return View();
        }
        [HttpGet]
        public IActionResult TC2Img()
        {
            return View();
        }
        [HttpGet]
        public IActionResult TLYukleKomisyonBilgi()
        {
            return View();
        }
        [HttpGet]
        public IActionResult TLYukleUCD()
        {
            return View();
        }
        [HttpGet]
        public IActionResult TokenOlustur()
        {
            return View();
        }
        [HttpGet]
        public IActionResult TransferFastKomisyonIslemv2()
        {
            return View();
        }
        [HttpGet]
        public IActionResult TransferKomisyonIslem()
        {
            return View();
        }
        [HttpGet]
        public IActionResult TransferKomisyonIslemv2()
        {
            return View();
        }
        [HttpGet]
        public IActionResult TroyKuryeSorgula()
        {
            return View();
        }
        [HttpGet]
        public IActionResult TurkPosBasvuru()
        {
            return View();
        }
        [HttpGet]
        public IActionResult TurkPosBasvuruDosya()
        {
            return View();
        }
        [HttpGet]
        public IActionResult TurkPosBasvuruDurum()
        {
            return View();
        }
        [HttpGet]
        public IActionResult UCDIslemOdemeSor()
        {
            return View();
        }
        [HttpGet]
        public IActionResult UygulamaOnerme()
        {
            return View();
        }
        [HttpGet]
        public IActionResult WebSiteIcerik()
        {
            return View();
        }

        [HttpGet]
        public IActionResult KSKartEkle()  // Kart Ekleme sayfasýný görüntüler.
        {
            return View(new KSKartEkleViewModel());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> KSKartEkleAsync([FromForm] KSKartEkleViewModel model) // Kart Ekleme sayfasýndan gönderilen formu iþler.
        {
            ST_KS_Kart_Ekle result = await TP_KSAsyncRepository.KSKartEkleAsync(model.G, model.GUID, model.KK_Sahibi, model.KK_No, model.KK_SK_Ay, model.KK_SK_Yil, model.KK_Kart_Adi, model.KK_Islem_ID);
            return RedirectHelper.PostRedirect("/Sonuc/KSKartEkle", result);
        }
        [HttpGet]
        public IActionResult KSKartListe() // Kart Listesi sayfasýný görüntüler.
        {
            return View(new KSKartListeViewModel());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> KSKartListeAsync([FromForm] KSKartListeViewModel model) // Kart Listesi sayfasýndan gönderilen formu iþler.
        {
            ST_KS_Kart_Liste result = await TP_KSAsyncRepository.KSKartListeAsync(model.G, model.GUID, model.KK_Kart_Adi, model.KK_Islem_ID);
            return RedirectHelper.PostRedirectXml("/Sonuc/KSKartListe", result);
        }
        [HttpGet]
        public IActionResult KSKartListePagination()
        {
            return View();
        }
        [HttpGet]
        public IActionResult KSKartSil() // Saklý Kart Silme sayfasýný görüntüler. 
        {
            return View(new KSKartSilViewModel());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> KSKartSilAsync([FromForm] KSKartSilViewModel model) // Saklý Kart Silme sayfasýndan gönderilen formu iþler.
        {
            TP_KS.ST_Sonuc result = await TP_KSAsyncRepository.KSKartSilAsync(model.G, model.KS_GUID, model.KK_Islem_ID);
            return RedirectHelper.PostRedirect("/Sonuc/KSKartSil", result);
        }
        [HttpGet]
        public IActionResult KSTahsilat() // Kart Saklamalý Ödeme sayfasýný görüntüler.
        {
            return View(new KSTahsilatViewModel());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> KSTahsilatAsync([FromForm] KSTahsilatViewModel model) // Kart Saklamalý Ödeme sayfasýndan gönderilen formu iþler.
        {
            TP_KS.ST_TP_Islem_Odeme result = await TP_KSAsyncRepository.KSTahsilatAsync(model.G, model.GUID, model.KS_GUID, model.CVV, model.KK_Sahibi_GSM, model.Hata_URL, model.Basarili_URL, model.Siparis_ID, model.Siparis_Aciklama, model.Taksit, model.Islem_Tutar, model.Toplam_Tutar, model.Islem_Guvenlik_Tip, model.Islem_ID, model.IPAdr, model.Ref_URL, model.Data1, model.Data2, model.Data3, model.Data4, model.KK_Islem_ID);
            Regex urlRegex = new Regex("^https?:\\/\\/(?:www\\.)?[-a-zA-Z0-9@:%._\\+~#=]{1,256}\\.[a-zA-Z0-9()]{1,6}\\b(?:[-a-zA-Z0-9()@:%_\\+.~#?&\\/=]*)$");
            if (!urlRegex.IsMatch(result.UCD_URL)) return RedirectHelper.PostRedirect("/Sonuc/KSTahsilat", result);
            else return Redirect(result.UCD_URL);
        }
        [HttpGet]
        public IActionResult KSTahsilatColendi()
        {
            return View();
        }
        [HttpGet]
        public IActionResult BINSanalPos() // BIN Kodlarý sayfasýný görüntüler.
        {
            return View(new BINSanalPosViewModel());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> BINSanalPosAsync([FromForm] BINSanalPosViewModel model) // BIN Kodlarý sayfasýndan gönderilen formu iþler.
        {
            ST_Genel_Sonuc result = await TurkPosWSTESTAsyncRepository.BINSanalPosAsync(model.G, model.BIN);
            return RedirectHelper.PostRedirectXml("/Sonuc/BINSanalPos", result);
        }
        [HttpGet]
        public IActionResult BINSanalPos2()
        {
            return View();
        }
        [HttpGet]
        public IActionResult IlListe() // Ýl Liste sayfasýný görüntüler.
        {
            return View(new IlListeViewModel());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> IlListeAsync([FromForm] IlListeViewModel model) // Ýl Liste sayfasýndan gönderilen formu iþler.
        {
            ST_Sonuc_DT result = await TurkPosWSTESTAsyncRepository.IlListeAsync(model.G);
            return RedirectHelper.PostRedirectXml("/Sonuc/IlListe", result);
        }
        [HttpGet]
        public IActionResult KKSaklama() // Kart Saklama sayfasýný görüntüler.
        {
            return View(new KKSaklamaViewModel());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> KKSaklamaAsync([FromForm] KKSaklamaViewModel model) // Kart Saklama sayfasýndan gönderilen formu iþler.
        {
            ST_KK_Saklama result = await TurkPosWSTESTAsyncRepository.KKSaklamaAsync(model.G, model.Kart_No, model.KK_Sahibi, model.KK_No, model.KK_SK_Ay, model.KK_SK_Yil, model.KK_CVV, model.Data1, model.Data2, model.Data3);
            return RedirectHelper.PostRedirect("/Sonuc/KKSaklama", result);
        }
        [HttpGet]
        public IActionResult KKSakliListe() // Kart Saklama Listesi sayfasýný görüntüler.
        {
            return View(new KKSakliListeViewModel());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> KKSakliListeAsync([FromForm] KKSakliListeViewModel model) // Kart Saklama Listesi sayfasýndan gönderilen formu iþler.
        {
            ST_Genel_Sonuc result = await TurkPosWSTESTAsyncRepository.KKSakliListeAsync(model.G, model.Kart_No, model.KS_KK_Kisi_ID);
            return RedirectHelper.PostRedirectXml("/Sonuc/KKSakliListe", result);
        }
        [HttpGet]
        public IActionResult MPOrderCancelRefund()
        {
            return View();
        }
        [HttpGet]
        public IActionResult MPOrderDetailAdd()
        {
            return View();
        }
        [HttpGet]
        public IActionResult MPOrderDetailList()
        {
            return View();
        }
        [HttpGet]
        public IActionResult MPOrderDetailQuery()
        {
            return View();
        }
        [HttpGet]
        public IActionResult MPOrderDetailStatus()
        {
            return View();
        }
        [HttpGet]
        public IActionResult MPOrderDetailUpdate()
        {
            return View();
        }
        [HttpGet]
        public IActionResult MoneyPayIslemSorgulama()
        {
            return View();
        }
        [HttpGet]
        public IActionResult ParamPazaryeriIslemIzleme()
        {
            return View();
        }
        [HttpGet]
        public IActionResult PaymentHopi()
        {
            return View();
        }
        [HttpGet]
        public IActionResult PazaryeriTPAltUyeIsyeriEkleme() // Alt Üye Ýþ Yeri Ekleme sayfasýný görüntüler.
        {
            return View(new PazaryeriTPAltUyeIsyeriEklemeViewModel());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PazaryeriTPAltUyeIsyeriEklemeAsync([FromForm] PazaryeriTPAltUyeIsyeriEklemeViewModel model) // Alt Üye Ýþ Yeri Ekleme sayfasýndan gönderilen formu iþler.
        {
            Sonuc_Uyelik result = await TurkPosWSTESTAsyncRepository.PazaryeriTPAltUyeIsyeriEklemeAsync(model.G, model.ETS_GUID, model.Tip, model.Ad_Soyad, model.Unvan, model.TC_VN, model.Kisi_DogumTarihi, model.GSM_No, model.IBAN_No, model.IBAN_Unvan, model.Adres, model.Il, model.Ilce, model.EPosta, model.Website, model.MCC_Kod, model.Yetkili_Kisi_TC, model.Yetkili_Kisi_DogumTarihi, model.Vergi_Daire, model.Bagli_Olunan_Hesap);
            return RedirectHelper.PostRedirect("/Sonuc/PazaryeriTPAltUyeIsyeriEkleme", result);
        }
        [HttpGet]
        public IActionResult PazaryeriTPAltUyeIsyeriEklemev2()
        {
            return View();
        }
        [HttpGet]
        public IActionResult PazaryeriTPAltUyeIsyeriGuncelleme() // Alt Üye Ýþ Yeri Güncelleme sayfasýný görüntüler.
        {
            return View(new PazaryeriTPAltUyeIsyeriGuncellemeViewModel());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PazaryeriTPAltUyeIsyeriGuncellemeAsync([FromForm] PazaryeriTPAltUyeIsyeriGuncellemeViewModel model) // Alt Üye Ýþ Yeri Güncelleme sayfasýndan gönderilen formu iþler.
        {
            Sonuc_Uyelik result = await TurkPosWSTESTAsyncRepository.PazaryeriTPAltUyeIsyeriGuncellemeAsync(model.G, model.GUID_AltUyeIsyeri, model.Ad_Soyad, model.Unvan, model.GSM_No, model.IBAN_No, model.IBAN_Unvan, model.Adres, model.Il, model.Ilce, model.EPosta, model.Website, model.MCC_Kod, model.Vergi_Daire, model.Bagli_Olunan_Hesap);
            return RedirectHelper.PostRedirect("/Sonuc/PazaryeriTPAltUyeIsyeriGuncelleme", result);
        }
        [HttpGet]
        public IActionResult PazaryeriTPAltUyeIsyeriGuncellemev2()
        {
            return View();
        }

        [HttpGet]
        public IActionResult PazaryeriTPAltUyeIsyeriListe() // Alt Üye Ýþ Yeri Listesi sayfasýný görüntüler.
        {
            return View(new PazaryeriTPAltUyeIsyeriListeViewModel());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PazaryeriTPAltUyeIsyeriListeAsync([FromForm] PazaryeriTPAltUyeIsyeriListeViewModel model) // Alt Üye Ýþ Yeri Listesi sayfasýndan gelen formu iþler..
        {
            Sonuc_Uyelik_Liste result = await TurkPosWSTESTAsyncRepository.PazaryeriTPAltUyeIsyeriListeAsync(model.G, model.ETS_GUID, model.Limit, model.Skip);
            return RedirectHelper.PostRedirectXml("/Sonuc/PazaryeriTPAltUyeIsyeriListe", result);
        }
        [HttpGet]
        public IActionResult PazaryeriTPAltUyeIsyeriSilme() // Alt Uye Isyeri Silme sayfasýný görüntüler.
        {
            return View(new PazaryeriTPAltUyeIsyeriSilmeViewModel());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PazaryeriTPAltUyeIsyeriSilmeAsync([FromForm] PazaryeriTPAltUyeIsyeriSilmeViewModel model) // Alt Uye Isyeri Silme sayfasýndan gönderilen formu iþler.
        {
            object result = await TurkPosWSTESTAsyncRepository.PazaryeriTPAltUyeIsyeriSilmeAsync(model.G, model.GUID_AltUyeIsyeri);
            return RedirectHelper.PostRedirect("/Sonuc/PazaryeriTPAltUyeIsyeriSilme", result);
        }
        [HttpGet]
        public IActionResult PazaryeriTPIptalIade() // Ýptal Ýade sayfasýný görüntüler.
        {
            return View(new PazaryeriTPIptalIadeViewModel());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PazaryeriTPIptalIadeAsync([FromForm] PazaryeriTPIptalIadeViewModel model) // Ýptal Ýade sayfasýndan gönderilen formu iþler.
        {
            STC_SonucII result = await TurkPosWSTESTAsyncRepository.PazaryeriTPIptalIadeAsync(model.G, model.PYSiparis_GUID, model.GUID, model.Durum, model.Siparis_ID, model.SiparisTutar, model.OdenecekTutar);
            return RedirectHelper.PostRedirect("/Sonuc/PazaryeriTPIptalIade", result);
        }
        [HttpGet]
        public IActionResult PazaryeriTPIslemSorgulama() // Pazaryeri Ýþlem Sorgulama sayfasýný görüntüler.
        {
            return View(new PazaryeriTPIslemSorgulamaViewModel());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PazaryeriTPIslemSorgulamaAsync([FromForm] PazaryeriTPIslemSorgulamaViewModel model) // Pazaryeri Ýþlem Sorgulama sayfasýndan gönderilen formu iþler.
        {
            ST_Genel_Sonuc result = await TurkPosWSTESTAsyncRepository.PazaryeriTPIslemSorgulamaAsync(model.G, model.ETS_GUID, model.GUID_AltUyeIsyeri, model.PYSiparis_GUID, model.SanalPOS_Islem_ID, model.Tarih_Bas, model.Tarih_Bit);
            return RedirectHelper.PostRedirectXml("/Sonuc/PazaryeriTPIslemSorgulama", result);
        }
        [HttpGet]
        public IActionResult PazaryeriTPLimitKontrol() // Pazaryeri TP Limit Kontrol sayfasýný görüntüler.
        {
            return View(new PazaryeriTPLimitKontrolViewModel());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PazaryeriTPLimitKontrolAsync([FromForm] PazaryeriTPLimitKontrolViewModel model) // Pazaryeri TP Limit Kontrol sayfasýndan gönderilen formu iþler.
        {
            Sonuc_Limit2 result = await TurkPosWSTESTAsyncRepository.PazaryeriTPLimitKontrolAsync(model.ETS_GUID, model.GUID_AltUyeIsyeri, model.Tutar_Odenecek);
            return RedirectHelper.PostRedirect("/Sonuc/PazaryeriTPLimitKontrol", result);
        }
        [HttpGet]
        public IActionResult PazaryeriTPSiparisDetayEkle() // Sipariþ Detay Ekleme sayfasýný görüntüler.
        {
            return View(new PazaryeriTPSiparisDetayEkleViewModel());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PazaryeriTPSiparisDetayEkleAsync([FromForm] PazaryeriTPSiparisDetayEkleViewModel model) // Sipariþ Detay Ekleme sayfasýndan gönderilen formu iþler.
        {
            SE_Sonuc result = await TurkPosWSTESTAsyncRepository.PazaryeriTPSiparisDetayEkleAsync(model.G, model.ETS_GUID, model.Tutar_Urun, model.Tutar_Odenecek, model.SanalPOS_Islem_ID, model.GUID_AltUyeIsyeri);
            return RedirectHelper.PostRedirect("/Sonuc/PazaryeriTPSiparisDetayEkle", result);
        }
        [HttpGet]
        public IActionResult PazaryeriTPSiparisOnay() // Sipariþ Onay sayfasýný görüntüler.
        {
            return View(new PazaryeriTPSiparisOnayViewModel());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PazaryeriTPSiparisOnayAsync([FromForm] PazaryeriTPSiparisOnayViewModel model) // Sipariþ Onay sayfasýndan gönderilen formu iþler.
        {
            STC_Sonuc result = await TurkPosWSTESTAsyncRepository.PazaryeriTPSiparisOnayAsync(model.G, model.PYSiparis_GUID, model.Durum);
            return RedirectHelper.PostRedirect("/Sonuc/PazaryeriTPSiparisOnay", result);
        }
        [HttpGet]
        public IActionResult PosOdeme() // Satýþ - 3D Pay / NS sayfasýný görüntüler.
        {
            return View(new PosOdemeViewModel());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PosOdemeAsync([FromForm] PosOdemeViewModel model) // Satýþ - 3D Pay / NS sayfasýndan gönderilen formu iþler.
        {
            TurkPosWSTEST.ST_TP_Islem_Odeme result = await TurkPosWSTESTAsyncRepository.PosOdemeAsync(model.G, model.GUID, model.KK_Sahibi, model.KK_No, model.KK_SK_Ay, model.KK_SK_Yil, model.KK_CVC, model.KK_Sahibi_GSM, model.Hata_URL, model.Basarili_URL, model.Siparis_ID, model.Siparis_Aciklama, model.Taksit, model.Islem_Tutar, model.Toplam_Tutar, model.Islem_Hash, model.Islem_Guvenlik_Tip, model.Islem_ID, model.IPAdr, model.Ref_URL, model.Data1, model.Data2, model.Data3, model.Data4, model.Data5, model.Data6, model.Data7, model.Data8, model.Data9, model.Data10);
            Regex urlRegex = new Regex("^https?:\\/\\/(?:www\\.)?[-a-zA-Z0-9@:%._\\+~#=]{1,256}\\.[a-zA-Z0-9()]{1,6}\\b(?:[-a-zA-Z0-9()@:%_\\+.~#?&\\/=]*)$");
            if (model.Islem_Guvenlik_Tip == "NS" || !urlRegex.IsMatch(result.UCD_URL)) return RedirectHelper.PostRedirect("/Sonuc/PosOdeme", result);
            else
            {
                string jsonG = System.Text.Json.JsonSerializer.Serialize(new PosOdemeCookieModel() { ST_TP_Islem_Odeme = result });
                Response.Cookies.Append("PosOdemeCookie", jsonG, new CookieOptions() { Expires = DateTime.Now.AddMinutes(3) });
                return Redirect(result.UCD_URL);
            }
        }
        [HttpPost]
        public IActionResult PosOdemePos3DS([FromForm] Pos_OdemePostDTO pos_OdemePostDTO)
        {
            return RedirectHelper.PostRedirect("/Sonuc/PosOdeme", pos_OdemePostDTO);

        }
        [HttpGet]
        public IActionResult PosPluginBildirim()
        {
            return View();
        }
        [HttpGet]
        public IActionResult SHA2B64()
        {
            return View();
        }
        [HttpGet]
        public IActionResult TPIslemCheckout()
        {
            return View();
        }
        [HttpGet]
        public IActionResult TPIslemCheckoutOdemeWNS()
        {
            return View();
        }
        [HttpGet]
        public IActionResult TPIslemCheckoutSK()
        {
            return View();
        }
        [HttpGet]
        public IActionResult TPIslemDekontGonder() // Dekont sayfasýný görüntüler.
        {
            return View(new TPIslemDekontGonderViewModel());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TPIslemDekontGonderAsync([FromForm] TPIslemDekontGonderViewModel model) // Dekont sayfasýndan gönderilen formu iþler.
        {
            TurkPosWSTEST.ST_Sonuc result = await TurkPosWSTESTAsyncRepository.TPIslemDekontGonderAsync(model.G, model.GUID, model.Dekont_ID, model.E_Posta);
            return RedirectHelper.PostRedirect("/Sonuc/TPIslemDekontGonder", result);
        }
        [HttpGet]
        public IActionResult TPIslemIptalIade()
        {
            return View();
        }
        [HttpGet]
        public IActionResult TPIslemIptalIade2()
        {
            return View();
        }
        [HttpGet]
        public IActionResult TPIslemIptalIadeKismi()
        {
            return View();
        }
        [HttpGet]
        public IActionResult TPIslemIptalIadeKismi2() // Ýþlem Ýptal ve Ýadeleri sayfasýný görüntüler.
        {
            return View(new TPIslemIptalIadeKismi2ViewModel());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TPIslemIptalIadeKismi2Async([FromForm] TPIslemIptalIadeKismi2ViewModel model) // Ýþlem Ýptal ve Ýadeleri sayfasýndan gönderilen formu iþler.
        {
            ST_Sonuc_II result = await TurkPosWSTESTAsyncRepository.TPIslemIptalIadeKismi2Async(model.G, model.GUID, model.Durum, model.Siparis_ID, model.Tutar);
            return RedirectHelper.PostRedirect("/Sonuc/TPIslemIptalIadeKismi2", result);
        }
        [HttpGet]
        public IActionResult TPIslemIptalIadeKismi3()
        {
            return View();
        }
        [HttpGet]
        public IActionResult TPIslemIptalIadeKismi4()
        {
            return View();
        }
        [HttpGet]
        public IActionResult TPIslemIptalIadeKismiWP()
        {
            return View();
        }
        [HttpGet]
        public IActionResult TPIslemIptalOnProv() // Ön Provizyon - Iptal sayfasýný görüntüler.
        {
            return View(new TPIslemIptalOnProvViewModel());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TPIslemIptalOnProvAsync([FromForm] TPIslemIptalOnProvViewModel model) // Ön Provizyon - Iptal sayfasýndan gönderilen formu iþler.
        {
            TurkPosWSTEST.ST_Sonuc result = await TurkPosWSTESTAsyncRepository.TPIslemIptalOnProvAsync(model.G, model.GUID, model.Prov_ID, model.Siparis_ID);
            return RedirectHelper.PostRedirect(Url.Action("TPIslemIptalOnProv", "Sonuc")!, result);
        }
        [HttpGet]
        public IActionResult TPIslemIzleme() // Ýþlem Ýzleme Metodu sayfasýný görüntüler.
        {
            return View(new TPIslemIzlemeViewModel());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TPIslemIzlemeAsync([FromForm] TPIslemIzlemeViewModel model) // Ýþlem Ýzleme Metodu sayfasýndan gönderilen formu iþler
        {
            ST_Genel_Sonuc result = await TurkPosWSTESTAsyncRepository.TPIslemIzlemeAsync(model.G, model.GUID, model.Tarih_Bas, model.Tarih_Bit, model.Islem_Tip, model.Islem_Durum);
            return RedirectHelper.PostRedirectXml("/sonuc/TPIslemIzleme", result);
        }
        [HttpGet]
        public IActionResult TPIslemOdeme()
        {
            return View();
        }
        [HttpGet]
        public IActionResult TPIslemOdemeBKM() // BKM Express ile Ödeme sayfasýný görüntüler.
        {
            return View(new TPIslemOdemeBKMViewModel());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TPIslemOdemeBKMAsync([FromForm] TPIslemOdemeBKMViewModel model) // BKM Express ile Ödeme sayfasýndan gönderilen formu iþler.
        {
            ST_TP_Islem_Odeme_BKM result = await TurkPosWSTESTAsyncRepository.TPIslemOdemeBKMAsync(model.G, model.GUID, model.Customer_Info, model.Customer_GSM, model.Error_URL, model.Success_URL, model.Order_ID, model.Order_Description, model.Amount, model.Payment_Hash, model.Transaction_ID, model.IPAddress, model.Referrer_URL);
            Regex urlRegex = new Regex("^https?:\\/\\/(?:www\\.)?[-a-zA-Z0-9@:%._\\+~#=]{1,256}\\.[a-zA-Z0-9()]{1,6}\\b(?:[-a-zA-Z0-9()@:%_\\+.~#?&\\/=]*)$");
            if (!urlRegex.IsMatch(result.Redirect_URL)) return RedirectHelper.PostRedirect("/Sonuc/TPIslemOdemeBKM", result);
            else return Redirect(result.Redirect_URL);
        }
        [HttpGet]
        public IActionResult TPIslemOdemeOnProv()
        {
            return View();
        }
        [HttpGet]
        public IActionResult TPIslemOdemeOnProvKapa() // Ön Provizyon - Kapama sayfasýný görüntüler.
        {
            return View(new TPIslemOdemeOnProvKapaViewModel());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TPIslemOdemeOnProvKapaAsync([FromForm] TPIslemOdemeOnProvKapaViewModel model) // Ön Provizyon - Kapama sayfasýndan gönderilen formu iþler.
        {
            ST_TP_Islem_Odeme_OnProvKapa result = await TurkPosWSTESTAsyncRepository.TPIslemOdemeOnProvKapaAsync(model.G, model.GUID, model.Prov_ID, model.Prov_Tutar, model.Siparis_ID);
            return RedirectHelper.PostRedirect(Url.Action("TPIslemOdemeOnProvKapa", "Sonuc")!, result);
        }
        [HttpGet]
        public IActionResult TPIslemOdemeOnProvWKS() // Saklý kart ile Ön Provizyon sayfasýný görüntüler.
        {
            return View(new TPIslemOdemeOnProvWKSViewModel());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TPIslemOdemeOnProvWKSAsync([FromForm] TPIslemOdemeOnProvWKSViewModel model) // Saklý kart ile Ön Provizyon sayfasýndan gönderilen formu iþler.
        {
            ST_TP_Islem_Odeme_OnProv result = await TurkPosWSTESTAsyncRepository.TPIslemOdemeOnProvWKSAsync(model.G, model.GUID, model.KS_Kart_No, model.KK_GUID, model.KK_Sahibi_GSM, model.Hata_URL, model.Basarili_URL, model.Siparis_ID, model.Siparis_Aciklama, model.Islem_Tutar, model.Toplam_Tutar, model.Islem_Hash, model.Islem_Guvenlik_Tip, model.Islem_ID, model.IPAdr, model.Ref_URL, model.Data1, model.Data2, model.Data3, model.Data4, model.Data5);
            Regex urlRegex = new Regex("^https?:\\/\\/(?:www\\.)?[-a-zA-Z0-9@:%._\\+~#=]{1,256}\\.[a-zA-Z0-9()]{1,6}\\b(?:[-a-zA-Z0-9()@:%_\\+.~#?&\\/=]*)$");
            if (model.Islem_Guvenlik_Tip == "NS" || !urlRegex.IsMatch(result.UCD_URL)) return RedirectHelper.PostRedirect("/Sonuc/TPIslemOdemeOnProvWKS", result);
            else return Redirect(result.UCD_URL);
        }
        [HttpGet]
        public IActionResult TPIslemOdemeOnProvWMD() // Ön Provizyon - 3D Model / NS sayfasýný görüntüler.
        {
            return View(new TPIslemOdemeOnProvWMDViewModel());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TPIslemOdemeOnProvWMDAsync([FromForm] TPIslemOdemeOnProvWMDViewModel model) // Ön Provizyon - 3D Model / NS sayfasýndan gönderilen formu iþler.
        {
            ST_WMD_UCD result = await TurkPosWSTESTAsyncRepository.TPIslemOdemeOnProvWMDAsync(model.G, model.GUID, model.KK_Sahibi, model.KK_No, model.KK_SK_Ay, model.KK_SK_Yil, model.KK_CVC, model.KK_Sahibi_GSM, model.Hata_URL, model.Basarili_URL, model.Siparis_ID, model.Siparis_Aciklama, model.Islem_Tutar, model.Toplam_Tutar, model.Islem_Hash, model.Islem_Guvenlik_Tip, model.Islem_ID, model.IPAdr, model.Ref_URL, model.Data1, model.Data2, model.Data3, model.Data4, model.Data5, model.Taksit);
            if (model.Islem_Guvenlik_Tip == "NS" || result.Sonuc == "-400") return RedirectHelper.PostRedirect("/Sonuc/TPIslemOdemeOnProvWMD", result);
            else
            {
                string jsonG = System.Text.Json.JsonSerializer.Serialize(new TPIslemOdemeOnProvWMDCookieModel(model.G, model.GUID, result.Islem_ID));
                Response.Cookies.Append("TPIslemOdemeOnProvWMDCookie", jsonG, new CookieOptions() { Expires = DateTime.Now.AddMinutes(3) });
                return View("3DPage", HttpUtility.HtmlDecode(result.UCD_HTML));
            }
        }
        [HttpGet]
        public IActionResult TPIslemOdemeWD() // Doviz ile Ödeme sayfasýný görüntüler.
        {
            return View(new TPIslemOdemeWDViewModel());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TPIslemOdemeWDAsync([FromForm] TPIslemOdemeWDViewModel model) // Doviz ile Ödeme sayfasýndan gönderilen formu iþler.
        {
            TurkPosWSTEST.ST_TP_Islem_Odeme result = await TurkPosWSTESTAsyncRepository.TPIslemOdemeWDAsync(model.G, model.Doviz_Kodu, model.GUID, model.KK_Sahibi, model.KK_No, model.KK_SK_Ay, model.KK_SK_Yil, model.KK_CVC, model.KK_Sahibi_GSM, model.Hata_URL, model.Basarili_URL, model.Siparis_ID, model.Siparis_Aciklama, model.Islem_Tutar, model.Toplam_Tutar, model.Islem_Hash, model.Islem_Guvenlik_Tip, model.Islem_ID, model.IPAdr, model.Ref_URL, model.Data1, model.Data2, model.Data3, model.Data4, model.Data5);
            Regex urlRegex = new Regex("^https?:\\/\\/(?:www\\.)?[-a-zA-Z0-9@:%._\\+~#=]{1,256}\\.[a-zA-Z0-9()]{1,6}\\b(?:[-a-zA-Z0-9()@:%_\\+.~#?&\\/=]*)$");
            if (model.Islem_Guvenlik_Tip == "NS" || !urlRegex.IsMatch(result.UCD_URL)) return RedirectHelper.PostRedirect("/Sonuc/TPIslemOdemeWD", result);
            else return Redirect(result.UCD_URL);
        }
        [HttpGet]
        public IActionResult TPIslemOdemeWKS()
        {
            return View();
        }
        [HttpGet]
        public IActionResult TPIslemOdemeWNS()
        {
            return View();
        }
        [HttpGet]
        public IActionResult TPIslemSorgulama()
        {
            return View();
        }
        [HttpGet]
        public IActionResult TPIslemSorgulama4() // Ýþlem Sorgulama sayfasýný görüntüler.
        {
            return View(new TPIslemSorgulama4ViewModel());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TPIslemSorgulama4Async([FromForm] TPIslemSorgulama4ViewModel model) // Ýþlem Sorgulama sayfasýndan gönderilen formu iþler.
        {
            ST_Genel_Sonuc2 result = await TurkPosWSTESTAsyncRepository.TPIslemSorgulama4Async(model.G, model.GUID, model.Dekont_ID, model.Siparis_ID, model.Islem_ID);
            return RedirectHelper.PostRedirect("/Sonuc/TPIslemSorgulama4", result);
        }
        [HttpGet]
        public IActionResult TPIslemSorgulama5()
        {
            return View();
        }
        [HttpGet]
        public IActionResult TPIslemSorgulama6()
        {
            return View();
        }
        [HttpGet]
        public IActionResult TPIslemSorgulamaWP()
        {
            return View();
        }
        [HttpGet]
        public IActionResult TPKKVerify() // Kart Doðrulama sayfasýný görüntüler.
        {
            return View(new TPKKVerifyViewModel());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TPKKVerifyAsync([FromForm] TPKKVerifyViewModel model) // Kart Doðrulama sayfasýnda gönderilen formu görüntüler.
        {
            TurkPosWSTEST.ST_TP_Islem_Odeme result = await TurkPosWSTESTAsyncRepository.TPKKVerifyAsync(model.G, model.KK_No, model.KK_SK_Ay, model.KK_SK_Yil, model.KK_CVC, model.Return_URL, model.Data1, model.Data2, model.Data3, model.Data4, model.Data5);
            Regex urlRegex = new Regex("^https?:\\/\\/(?:www\\.)?[-a-zA-Z0-9@:%._\\+~#=]{1,256}\\.[a-zA-Z0-9()]{1,6}\\b(?:[-a-zA-Z0-9()@:%_\\+.~#?&\\/=]*)$");
            if (!urlRegex.IsMatch(result.UCD_URL)) return RedirectHelper.PostRedirect("/Sonuc/TPKKVerify", result);
            else return Redirect(result.UCD_URL);
        }
        [HttpGet]
        public IActionResult TPModalPayment()
        {
            return View();
        }
        [HttpGet]
        public IActionResult TPMultiplePayment()
        {
            return View();
        }
        [HttpGet]
        public IActionResult TPMultiplePaymentStatus()
        {
            return View();
        }
        [HttpGet]
        public IActionResult TPMutabakatDetay() // Mutabakat Detay sayfasýný görüntüler.
        {
            return View(new TPMutabakatDetayViewModel());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TPMutabakatDetayAsync([FromForm] TPMutabakatDetayViewModel model) // Mutabakat Detay sayfasýndan gönderilen formu iþler.
        {
            ST_Genel_Sonuc result = await TurkPosWSTESTAsyncRepository.TPMutabakatDetayAsync(model.G, model.GUID, model.Tarih);
            return RedirectHelper.PostRedirectXml("/Sonuc/TPMutabakatDetay", result);
        }
        [HttpGet]
        public IActionResult TPMutabakatOzet() // Ýþlem Özetleri sayfasýný görüntüler.
        {
            return View(new TPMutabakatOzetViewModel());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TPMutabakatOzetAsync([FromForm] TPMutabakatOzetViewModel model) // Ýþlem Özetleri sayfasýndan gönderilen formu iþler.
        {
            ST_Genel_Sonuc result = await TurkPosWSTESTAsyncRepository.TPMutabakatOzetAsync(model.G, model.GUID, model.Tarih_Bas, model.Tarih_Bit);
            return RedirectHelper.PostRedirectXml("/Sonuc/TPMutabakatOzet", result);
        }
        [HttpGet]
        public IActionResult TPOzelOranListe() // Firma Pos Oranlarý sayfasýný görüntüler.
        {
            return View(new TPOzelOranListeViewModel());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TPOzelOranListeAsync([FromForm] TPOzelOranListeViewModel model) // Firma Pos Oranlarý sayfasýndan gönderilen formu iþler.
        {
            ST_Genel_Sonuc result = await TurkPosWSTESTAsyncRepository.TPOzelOranListeAsync(model.G, model.GUID);
            return RedirectHelper.PostRedirectXml("/Sonuc/TPOzelOranListe", result);
        }
        [HttpGet]
        public IActionResult TPOzelOranSKGuncelle() // Özelleþtirilmiþ Pos Oranlarý sayfasýný görüntüler.
        {
            return View(new TPOzelOranSKGuncelleViewModel());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TPOzelOranSKGuncelleAsync([FromForm] TPOzelOranSKGuncelleViewModel model) // Özelleþtirilmiþ Pos Oranlarý sayfasýndan gönderilen formu iþler.
        {
            TurkPosWSTEST.ST_Sonuc result = await TurkPosWSTESTAsyncRepository.TPOzelOranSKGuncelleAsync(model.G, model.GUID, model.Ozel_Oran_SK_ID, model.MO_1, model.MO_2, model.MO_3, model.MO_4, model.MO_5, model.MO_6, model.MO_7, model.MO_8, model.MO_9, model.MO_10, model.MO_11, model.MO_12);
            return RedirectHelper.PostRedirect("/Sonuc/TPOzelOranSKGuncelle", result);
        }
        [HttpGet]
        public IActionResult TPOzelOranSKListe() // Kullanýcý Pos Oranlarý sayfasýný görüntüler.
        {
            return View(new TPOzelOranSKListeViewModel());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TPOzelOranSKListeAsync([FromForm] TPOzelOranSKListeViewModel model) // Kullanýcý Pos Oranlarý sayfasýnýndan gönderilen formu iþler.
        {
            ST_Genel_Sonuc result = await TurkPosWSTESTAsyncRepository.TPOzelOranSKListeAsync(model.G, model.GUID);
            return RedirectHelper.PostRedirectXml("/Sonuc/TPOzelOranSKListe", result);
        }
        [HttpGet]
        public IActionResult TPWMDPay()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> TPWMDPayAsync([FromForm] TP_WMD_PayPostDTO dto) // Model oluþturma sayfalarýndan gönderilen formlarý iþler.
        {
            if (Request.Cookies.TryGetValue("TPWMDUCDCookie", out string? json_tpwmducd))
            {
                if (dto.mdStatus == "1")
                {
                    TPWMDUCDCookieModel cookie = System.Text.Json.JsonSerializer.Deserialize<TPWMDUCDCookieModel>(json_tpwmducd!)!;
                    ST_WMD_Pay result = await TurkPosWSTESTAsyncRepository.TPWMDPayAsync(cookie.G, cookie.GUID, dto.md, dto.islemGUID, dto.orderId);
                    return RedirectHelper.PostRedirect("/Sonuc/TPWMDUCD", dto, result, cookie);
                }
                else return RedirectHelper.PostRedirect("/Sonuc/TPWMDUCD", dto);
            }
            else if (Request.Cookies.TryGetValue("TPIslemOdemeOnProvWMDCookie", out string? json_tpislemodemeonprovwmd))
            {
                if (dto.mdStatus == "1")
                {
                    TPIslemOdemeOnProvWMDCookieModel cookie = System.Text.Json.JsonSerializer.Deserialize<TPIslemOdemeOnProvWMDCookieModel>(json_tpislemodemeonprovwmd!)!;
                    ST_WMD_Pay result = await TurkPosWSTESTAsyncRepository.TPWMDPayAsync(cookie.G, cookie.GUID, dto.md, dto.islemGUID, dto.orderId);
                    return RedirectHelper.PostRedirect("/Sonuc/TPIslemOdemeOnProvWMD", dto, result, cookie);
                }
                else return RedirectHelper.PostRedirect("/Sonuc/TPIslemOdemeOnProvWMD", dto);
            }
            else return BadRequest();
        }
        [HttpGet]
        public IActionResult TPWMDUCD() // Satýþ - 3D Model / NS sayfasýný görüntüler.
        {
            TPWMDUCDViewModel model = new();
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TPWMDUCDAsync([FromForm] TPWMDUCDViewModel model) // Satýþ - 3D Model / NS sayfasýndan gönderilen formu iþler.
        {
            ST_WMD_UCD result = await TurkPosWSTESTAsyncRepository.TPWMDUCDAsync(model.G, model.GUID, model.KK_Sahibi, model.KK_No, model.KK_SK_Ay, model.KK_SK_Yil, model.KK_CVC, model.KK_Sahibi_GSM, model.Hata_URL, model.Basarili_URL, model.Siparis_ID, model.Siparis_Aciklama, model.Taksit, model.Islem_Tutar, model.Toplam_Tutar, model.Islem_Hash, model.Islem_Guvenlik_Tip, model.Islem_ID, model.IPAdr, model.Ref_URL, model.Data1, model.Data2, model.Data3, model.Data4, model.Data5);
            if (model.Islem_Guvenlik_Tip == "NS" || result.Sonuc != "1") return RedirectHelper.PostRedirect("/Sonuc/TPWMDUCD", result);
            else
            {
                string jsonG = System.Text.Json.JsonSerializer.Serialize(new TPWMDUCDCookieModel(model.G, model.GUID));
                Response.Cookies.Append("TPWMDUCDCookie", jsonG, new CookieOptions() { Expires = DateTime.Now.AddMinutes(3) });
                return View("3DPage", HttpUtility.HtmlDecode(result.UCD_HTML));
            }
        }
        [HttpGet]
        public IActionResult TPWMDUCDPuan()
        {
            return View();
        }
        [HttpGet]
        public IActionResult TPWMDUCDWP()
        {
            return View();
        }
        [HttpGet]
        public IActionResult TPWMDUCDv2()
        {
            return View();
        }
        [HttpGet]
        public IActionResult VadeliIslemIzleme()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ModelOnayla([FromForm] TP_WMD_PayPostDTO sonuc3DSecure)
        {
            return RedirectHelper.PostRedirect("/Op/TPWMDPay", sonuc3DSecure);
        }
    }
}