using TurkPosWSTEST;
using WebMvc.Repository.Interface;

namespace WebMvc.Repository
{
    /// <inheritdoc />
    public class TurkPosWSTESTAsyncRepository : ITurkPosWSTESTAsyncRepository
    {
        private readonly TurkPosWSTESTSoapClient client;
        public TurkPosWSTESTAsyncRepository(TurkPosWSTESTSoapClient client)
        {
            this.client = client;
        }
        public async Task<ST_Genel_Sonuc> BINSanalPosAsync(ST_WS_Guvenlik G, string BIN)
        {
            return await client.BIN_SanalPosAsync(G, BIN);
        }
        public async Task<ST_Genel_Sonuc> BINSanalPos2Async(ST_WS_Guvenlik G, string BIN)
        {
            return await client.BIN_SanalPos2Async(G, BIN);
        }
        public async Task<ST_Sonuc_DT> IlListeAsync(ST_WS_Guvenlik G)
        {
            return await client.Il_ListeAsync(G);
        }
        public async Task<ST_KK_Saklama> KKSaklamaAsync(ST_WS_Guvenlik G, string Kart_No, string KK_Sahibi, string KK_No, string KK_SK_Ay, string KK_SK_Yil, string KK_CVV, string Data1, string Data2, string Data3)
        {
            return await client.KK_SaklamaAsync(G, Kart_No, KK_Sahibi, KK_No, KK_SK_Ay, KK_SK_Yil, KK_CVV, Data1, Data2, Data3);
        }
        public async Task<ST_Genel_Sonuc> KKSakliListeAsync(ST_WS_Guvenlik G, string Kart_No, string KS_KK_Kisi_ID)
        {
            return await client.KK_Sakli_ListeAsync(G, Kart_No, KS_KK_Kisi_ID);
        }
        public async Task<CL_Res_MP_OCR> MPOrderCancelRefundAsync(CL_Req_MP_OCR d)
        {
            return await client.MP_OrderCancelRefundAsync(d);
        }
        public async Task<CL_Res_MP_ODA> MPOrderDetailAddAsync(CL_Req_MP_ODA d)
        {
            return await client.MP_OrderDetailAddAsync(d);
        }
        public async Task<CL_Res_MP_ODL> MPOrderDetailListAsync(CL_Req_MP_ODL d)
        {
            return await client.MP_OrderDetailListAsync(d);
        }
        public async Task<CL_Res_MP_ODQ> MPOrderDetailQueryAsync(CL_Req_MP_ODQ d)
        {
            return await client.MP_OrderDetailQueryAsync(d);
        }
        public async Task<CL_Res_MP_ODS> MPOrderDetailStatusAsync(CL_Req_MP_ODS d)
        {
            return await client.MP_OrderDetailStatusAsync(d);
        }
        public async Task<CL_Res_MP_ODU> MPOrderDetailUpdateAsync(CL_Req_MP_ODU d)
        {
            return await client.MP_OrderDetailUpdateAsync(d);
        }
        public async Task<ST_Genel_Sonuc> MoneyPayIslemSorgulamaAsync(ST_WS_Guvenlik G, string GUID, string Siparis_ID, string Tarih_Bas, string Tarih_Bit)
        {
            return await client.MoneyPay_Islem_SorgulamaAsync(G, GUID, Siparis_ID, Tarih_Bas, Tarih_Bit);
        }
        public async Task<IslemIzlemeRes> ParamPazaryeriIslemIzlemeAsync(ST_WS_Guvenlik G, IslemIzlemeReq islemIzlemeReq)
        {
            return await client.Param_Pazaryeri_Islem_IzlemeAsync(G, islemIzlemeReq);
        }
        public async Task<CL_Res_Payment_Hopi> PaymentHopiAsync(CL_Req_Payment_Hopi d)
        {
            return await client.Payment_HopiAsync(d);
        }
        public async Task<Sonuc_Uyelik> PazaryeriTPAltUyeIsyeriEklemeAsync(ST_WS_Guvenlik G, string ETS_GUID, int Tip, string Ad_Soyad, string Unvan, string TC_VN, string Kisi_DogumTarihi, string GSM_No, string IBAN_No, string IBAN_Unvan, string Adres, string Il, string Ilce, string EPosta, string Website, string MCC_Kod, string Yetkili_Kisi_TC, string Yetkili_Kisi_DogumTarihi, string Vergi_Daire, string Bagli_Olunan_Hesap)
        {
            return await client.Pazaryeri_TP_AltUyeIsyeri_EklemeAsync(G, ETS_GUID, Tip, Ad_Soyad, Unvan, TC_VN, Kisi_DogumTarihi, GSM_No, IBAN_No, IBAN_Unvan, Adres, Il, Ilce, EPosta, Website, MCC_Kod, Yetkili_Kisi_TC, Yetkili_Kisi_DogumTarihi, Vergi_Daire, Bagli_Olunan_Hesap);
        }
        public async Task<Sonuc_Uyelik> PazaryeriTPAltUyeIsyeriEklemev2Async(ST_WS_Guvenlik G, string ETS_GUID, int Tip, string Ad_Soyad, string Unvan, string TC_VN, string Kisi_DogumTarihi, string GSM_No, string IBAN_No, string IBAN_Unvan, string Adres, string Il, string Ilce, string EPosta, string Website, string MCC_Kod, string Yetkili_Kisi_TC, string Yetkili_Kisi_DogumTarihi, string Vergi_Daire, string Bagli_Olunan_Hesap, string SAPId, string MagentoId)
        {
            return await client.Pazaryeri_TP_AltUyeIsyeri_Ekleme_v2Async(G, ETS_GUID, Tip, Ad_Soyad, Unvan, TC_VN, Kisi_DogumTarihi, GSM_No, IBAN_No, IBAN_Unvan, Adres, Il, Ilce, EPosta, Website, MCC_Kod, Yetkili_Kisi_TC, Yetkili_Kisi_DogumTarihi, Vergi_Daire, Bagli_Olunan_Hesap, SAPId, MagentoId);
        }
        public async Task<Sonuc_Uyelik> PazaryeriTPAltUyeIsyeriGuncellemeAsync(ST_WS_Guvenlik G, string GUID_AltUyeIsyeri, string Ad_Soyad, string Unvan, string GSM_No, string IBAN_No, string IBAN_Unvan, string Adres, string Il, string Ilce, string EPosta, string Website, string MCC_Kod, string Vergi_Daire, string Bagli_Olunan_Hesap)
        {
            return await client.Pazaryeri_TP_AltUyeIsyeri_GuncellemeAsync(G, GUID_AltUyeIsyeri, Ad_Soyad, Unvan, GSM_No, IBAN_No, IBAN_Unvan, Adres, Il, Ilce, EPosta, Website, MCC_Kod, Vergi_Daire, Bagli_Olunan_Hesap);
        }
        public async Task<Sonuc_Uyelik> PazaryeriTPAltUyeIsyeriGuncellemev2Async(ST_WS_Guvenlik G, string GUID_AltUyeIsyeri, string Ad_Soyad, string Unvan, string GSM_No, string IBAN_No, string IBAN_Unvan, string Adres, string Il, string Ilce, string EPosta, string Website, string MCC_Kod, string Vergi_Daire, string Bagli_Olunan_Hesap, string SAPId, string MagentoId)
        {
            return await client.Pazaryeri_TP_AltUyeIsyeri_Guncelleme_v2Async(G, GUID_AltUyeIsyeri, Ad_Soyad, Unvan, GSM_No, IBAN_No, IBAN_Unvan, Adres, Il, Ilce, EPosta, Website, MCC_Kod, Vergi_Daire, Bagli_Olunan_Hesap, SAPId, MagentoId);
        }
        public async Task<Sonuc_Uyelik_Liste> PazaryeriTPAltUyeIsyeriListeAsync(ST_WS_Guvenlik G, string ETS_GUID, string Limit, string Skip)
        {
            return await client.Pazaryeri_TP_AltUyeIsyeri_ListeAsync(G, ETS_GUID, Limit, Skip);
        }
        public async Task<object> PazaryeriTPAltUyeIsyeriSilmeAsync(ST_WS_Guvenlik G, string GUID_AltUyeIsyeri)
        {
            return await client.Pazaryeri_TP_AltUyeIsyeri_SilmeAsync(G, GUID_AltUyeIsyeri);
        }
        public async Task<STC_SonucII> PazaryeriTPIptalIadeAsync(ST_WS_Guvenlik G, string PYSiparis_GUID, string GUID, string Durum, string Siparis_ID, double SiparisTutar, double OdenecekTutar)
        {
            return await client.Pazaryeri_TP_Iptal_IadeAsync(G, PYSiparis_GUID, GUID, Durum, Siparis_ID, SiparisTutar, OdenecekTutar);
        }
        public async Task<ST_Genel_Sonuc> PazaryeriTPIslemSorgulamaAsync(ST_WS_Guvenlik G, string ETS_GUID, string GUID_AltUyeIsyeri, string PYSiparis_GUID, long SanalPOS_Islem_ID, string Tarih_Bas, string Tarih_Bit)
        {
            return await client.Pazaryeri_TP_Islem_SorgulamaAsync(G, ETS_GUID, GUID_AltUyeIsyeri, PYSiparis_GUID, SanalPOS_Islem_ID, Tarih_Bas, Tarih_Bit);
        }
        public async Task<Sonuc_Limit2> PazaryeriTPLimitKontrolAsync(string ETS_GUID, string GUID_AltUyeIsyeri, string Tutar_Odenecek)
        {
            return await client.Pazaryeri_TP_Limit_KontrolAsync(ETS_GUID, GUID_AltUyeIsyeri, Tutar_Odenecek);
        }
        public async Task<SE_Sonuc> PazaryeriTPSiparisDetayEkleAsync(ST_WS_Guvenlik G, string ETS_GUID, string Tutar_Urun, string Tutar_Odenecek, string SanalPOS_Islem_ID, string GUID_AltUyeIsyeri)
        {
            return await client.Pazaryeri_TP_Siparis_Detay_EkleAsync(G, ETS_GUID, Tutar_Urun, Tutar_Odenecek, SanalPOS_Islem_ID, GUID_AltUyeIsyeri);
        }
        public async Task<STC_Sonuc> PazaryeriTPSiparisOnayAsync(ST_WS_Guvenlik G, string PYSiparis_GUID, string Durum)
        {
            return await client.Pazaryeri_TP_Siparis_OnayAsync(G, PYSiparis_GUID, Durum);
        }
        public async Task<ST_TP_Islem_Odeme> PosOdemeAsync(ST_WS_Guvenlik G, string GUID, string KK_Sahibi, string KK_No, string KK_SK_Ay, string KK_SK_Yil, string KK_CVC, string KK_Sahibi_GSM, string Hata_URL, string Basarili_URL, string Siparis_ID, string Siparis_Aciklama, int Taksit, string Islem_Tutar, string Toplam_Tutar, string Islem_Hash, string Islem_Guvenlik_Tip, string Islem_ID, string IPAdr, string Ref_URL, string Data1, string Data2, string Data3, string Data4, string Data5, string Data6, string Data7, string Data8, string Data9, string Data10)
        {
            return await client.Pos_OdemeAsync(G, GUID, KK_Sahibi, KK_No, KK_SK_Ay, KK_SK_Yil, KK_CVC, KK_Sahibi_GSM, Hata_URL, Basarili_URL, Siparis_ID, Siparis_Aciklama, Taksit, Islem_Tutar, Toplam_Tutar, Islem_Hash, Islem_Guvenlik_Tip, Islem_ID, IPAdr, Ref_URL, Data1, Data2, Data3, Data4, Data5, Data6, Data7, Data8, Data9, Data10);
        }
        public async Task<ST_Genel_Sonuc> PosPluginBildirimAsync(ST_WS_Guvenlik G, string ETS_GUID, string Domain_Adres, string Yazilim_Bilgisi, string Yazilim_Surum_Bilgisi)
        {
            return await client.Pos_Plugin_BildirimAsync(G, ETS_GUID, Domain_Adres, Yazilim_Bilgisi, Yazilim_Surum_Bilgisi);
        }
        public async Task<string> SHA2B64Async(string Data)
        {
            return await client.SHA2B64Async(Data);
        }
        public async Task<ST_Sonuc> TPIslemCheckoutAsync(string CLIENT_CODE, string GUID, string IPAdr)
        {
            return await client.TP_Islem_CheckoutAsync(CLIENT_CODE, GUID, IPAdr);
        }
        public async Task<ST_TP_Islem_Odeme> TPIslemCheckoutOdemeWNSAsync(ST_WS_Guvenlik G, int SanalPOS_ID, string GUID, string KK_Sahibi, string KK_No, string KK_SK_Ay, string KK_SK_Yil, string KK_CVC, string KK_Sahibi_GSM, string Hata_URL, string Basarili_URL, string Siparis_ID, string Siparis_Aciklama, int Taksit, string Islem_Tutar, string Toplam_Tutar, string Islem_Hash, string Islem_Guvenlik_Tip, string Islem_ID, string IPAdr, string Ref_URL, string Data1, string Data2, string Data3, string Data4, string Data5, string Firma_IPAdr)
        {
            return await client.TP_Islem_Checkout_Odeme_WNSAsync(G, SanalPOS_ID, GUID, KK_Sahibi, KK_No, KK_SK_Ay, KK_SK_Yil, KK_CVC, KK_Sahibi_GSM, Hata_URL, Basarili_URL, Siparis_ID, Siparis_Aciklama, Taksit, Islem_Tutar, Toplam_Tutar, Islem_Hash, Islem_Guvenlik_Tip, Islem_ID, IPAdr, Ref_URL, Data1, Data2, Data3, Data4, Data5, Firma_IPAdr);
        }
        public async Task<ST_CheckOut_Sonuc> TPIslemCheckoutSKAsync(string CLIENT_CODE, string GUID, string IPAdr, string KK_BIN, string Tutar)
        {
            return await client.TP_Islem_Checkout_SKAsync(CLIENT_CODE, GUID, IPAdr, KK_BIN, Tutar);
        }
        public async Task<ST_Sonuc> TPIslemDekontGonderAsync(ST_WS_Guvenlik G, string GUID, string Dekont_ID, string E_Posta)
        {
            return await client.TP_Islem_Dekont_GonderAsync(G, GUID, Dekont_ID, E_Posta);
        }
        public async Task<ST_Sonuc> TPIslemIptalIadeAsync(ST_WS_Guvenlik G, string GUID, string Durum, string Dekont_ID)
        {
            return await client.TP_Islem_Iptal_IadeAsync(G, GUID, Durum, Dekont_ID);
        }
        public async Task<ST_Sonuc_II> TPIslemIptalIade2Async(ST_WS_Guvenlik G, string GUID, string Durum, string Siparis_ID)
        {
            return await client.TP_Islem_Iptal_Iade2Async(G, GUID, Durum, Siparis_ID);
        }
        public async Task<ST_Sonuc> TPIslemIptalIadeKismiAsync(ST_WS_Guvenlik G, string GUID, string Durum, string Dekont_ID, double Tutar)
        {
            return await client.TP_Islem_Iptal_Iade_KismiAsync(G, GUID, Durum, Dekont_ID, Tutar);
        }
        public async Task<ST_Sonuc_II> TPIslemIptalIadeKismi2Async(ST_WS_Guvenlik G, string GUID, string Durum, string Siparis_ID, double Tutar)
        {
            return await client.TP_Islem_Iptal_Iade_Kismi2Async(G, GUID, Durum, Siparis_ID, Tutar);
        }
        public async Task<ST_Sonuc_II> TPIslemIptalIadeKismi3Async(ST_WS_Guvenlik G, string GUID, string Durum, string Siparis_ID, double Tutar, string Ref_No)
        {
            return await client.TP_Islem_Iptal_Iade_Kismi3Async(G, GUID, Durum, Siparis_ID, Tutar, Ref_No);
        }
        public async Task<ST_Sonuc4> TPIslemIptalIadeKismi4Async(ST_WS_Guvenlik G, string GUID, string Durum, string Siparis_ID, double Tutar)
        {
            return await client.TP_Islem_Iptal_Iade_Kismi4Async(G, GUID, Durum, Siparis_ID, Tutar);
        }
        public async Task<ST_Sonuc_WP> TPIslemIptalIadeKismiWPAsync(ST_WS_Guvenlik G, string GUID, string Durum, string Siparis_ID, double Tutar, string Ref_No)
        {
            return await client.TP_Islem_Iptal_Iade_Kismi_WPAsync(G, GUID, Durum, Siparis_ID, Tutar, Ref_No);
        }
        public async Task<ST_Sonuc> TPIslemIptalOnProvAsync(ST_WS_Guvenlik G, string GUID, string Prov_ID, string Siparis_ID)
        {
            return await client.TP_Islem_Iptal_OnProvAsync(G, GUID, Prov_ID, Siparis_ID);
        }
        public async Task<ST_Genel_Sonuc> TPIslemIzlemeAsync(ST_WS_Guvenlik G, string GUID, string Tarih_Bas, string Tarih_Bit, string Islem_Tip, string Islem_Durum)
        {
            return await client.TP_Islem_IzlemeAsync(G, GUID, Tarih_Bas, Tarih_Bit, Islem_Tip, Islem_Durum);
        }
        public async Task<ST_TP_Islem_Odeme> TPIslemOdemeAsync(ST_WS_Guvenlik G, int SanalPOS_ID, string GUID, string KK_Sahibi, string KK_No, string KK_SK_Ay, string KK_SK_Yil, string KK_CVC, string KK_Sahibi_GSM, string Hata_URL, string Basarili_URL, string Siparis_ID, string Siparis_Aciklama, int Taksit, string Islem_Tutar, string Toplam_Tutar, string Islem_Hash, string Islem_ID, string IPAdr, string Ref_URL, string Data1, string Data2, string Data3, string Data4, string Data5)
        {
            return await client.TP_Islem_OdemeAsync(G, SanalPOS_ID, GUID, KK_Sahibi, KK_No, KK_SK_Ay, KK_SK_Yil, KK_CVC, KK_Sahibi_GSM, Hata_URL, Basarili_URL, Siparis_ID, Siparis_Aciklama, Taksit, Islem_Tutar, Toplam_Tutar, Islem_Hash, Islem_ID, IPAdr, Ref_URL, Data1, Data2, Data3, Data4, Data5);
        }
        public async Task<ST_TP_Islem_Odeme_BKM> TPIslemOdemeBKMAsync(ST_WS_Guvenlik G, string GUID, string Customer_Info, string Customer_GSM, string Error_URL, string Success_URL, string Order_ID, string Order_Description, string Amount, string Payment_Hash, string Transaction_ID, string IPAddress, string Referrer_URL)
        {
            return await client.TP_Islem_Odeme_BKMAsync(G, GUID, Customer_Info, Customer_GSM, Error_URL, Success_URL, Order_ID, Order_Description, Amount, Payment_Hash, Transaction_ID, IPAddress, Referrer_URL);
        }
        public async Task<ST_TP_Islem_Odeme_OnProv> TPIslemOdemeOnProvAsync(ST_WS_Guvenlik G, string GUID, string KK_Sahibi, string KK_No, string KK_SK_Ay, string KK_SK_Yil, string KK_CVC, string KK_Sahibi_GSM, string Hata_URL, string Basarili_URL, string Siparis_ID, string Siparis_Aciklama, string Islem_Tutar, string Toplam_Tutar, string Islem_Hash, string Islem_Guvenlik_Tip, string Islem_ID, string IPAdr, string Ref_URL, string Data1, string Data2, string Data3, string Data4, string Data5)
        {
            return await client.TP_Islem_Odeme_OnProvAsync(G, GUID, KK_Sahibi, KK_No, KK_SK_Ay, KK_SK_Yil, KK_CVC, KK_Sahibi_GSM, Hata_URL, Basarili_URL, Siparis_ID, Siparis_Aciklama, Islem_Tutar, Toplam_Tutar, Islem_Hash, Islem_Guvenlik_Tip, Islem_ID, IPAdr, Ref_URL, Data1, Data2, Data3, Data4, Data5);
        }
        public async Task<ST_TP_Islem_Odeme_OnProvKapa> TPIslemOdemeOnProvKapaAsync(ST_WS_Guvenlik G, string GUID, string Prov_ID, string Prov_Tutar, string Siparis_ID)
        {
            return await client.TP_Islem_Odeme_OnProv_KapaAsync(G, GUID, Prov_ID, Prov_Tutar, Siparis_ID);
        }
        public async Task<ST_TP_Islem_Odeme_OnProv> TPIslemOdemeOnProvWKSAsync(ST_WS_Guvenlik G, string GUID, string KS_Kart_No, string KK_GUID, string KK_Sahibi_GSM, string Hata_URL, string Basarili_URL, string Siparis_ID, string Siparis_Aciklama, string Islem_Tutar, string Toplam_Tutar, string Islem_Hash, string Islem_Guvenlik_Tip, string Islem_ID, string IPAdr, string Ref_URL, string Data1, string Data2, string Data3, string Data4, string Data5)
        {
            return await client.TP_Islem_Odeme_OnProv_WKSAsync(G, GUID, KS_Kart_No, KK_GUID, KK_Sahibi_GSM, Hata_URL, Basarili_URL, Siparis_ID, Siparis_Aciklama, Islem_Tutar, Toplam_Tutar, Islem_Hash, Islem_Guvenlik_Tip, Islem_ID, IPAdr, Ref_URL, Data1, Data2, Data3, Data4, Data5);
        }
        public async Task<ST_WMD_UCD> TPIslemOdemeOnProvWMDAsync(ST_WS_Guvenlik G, string GUID, string KK_Sahibi, string KK_No, string KK_SK_Ay, string KK_SK_Yil, string KK_CVC, string KK_Sahibi_GSM, string Hata_URL, string Basarili_URL, string Siparis_ID, string Siparis_Aciklama, string Islem_Tutar, string Toplam_Tutar, string Islem_Hash, string Islem_Guvenlik_Tip, string Islem_ID, string IPAdr, string Ref_URL, string Data1, string Data2, string Data3, string Data4, string Data5, int Taksit)
        {
            return await client.TP_Islem_Odeme_OnProv_WMDAsync(G, GUID, KK_Sahibi, KK_No, KK_SK_Ay, KK_SK_Yil, KK_CVC, KK_Sahibi_GSM, Hata_URL, Basarili_URL, Siparis_ID, Siparis_Aciklama, Islem_Tutar, Toplam_Tutar, Islem_Hash, Islem_Guvenlik_Tip, Islem_ID, IPAdr, Ref_URL, Data1, Data2, Data3, Data4, Data5, Taksit);
        }
        public async Task<ST_TP_Islem_Odeme> TPIslemOdemeWDAsync(ST_WS_Guvenlik G, int Doviz_Kodu, string GUID, string KK_Sahibi, string KK_No, string KK_SK_Ay, string KK_SK_Yil, string KK_CVC, string KK_Sahibi_GSM, string Hata_URL, string Basarili_URL, string Siparis_ID, string Siparis_Aciklama, string Islem_Tutar, string Toplam_Tutar, string Islem_Hash, string Islem_Guvenlik_Tip, string Islem_ID, string IPAdr, string Ref_URL, string Data1, string Data2, string Data3, string Data4, string Data5)
        {
            return await client.TP_Islem_Odeme_WDAsync(G, Doviz_Kodu, GUID, KK_Sahibi, KK_No, KK_SK_Ay, KK_SK_Yil, KK_CVC, KK_Sahibi_GSM, Hata_URL, Basarili_URL, Siparis_ID, Siparis_Aciklama, Islem_Tutar, Toplam_Tutar, Islem_Hash, Islem_Guvenlik_Tip, Islem_ID, IPAdr, Ref_URL, Data1, Data2, Data3, Data4, Data5);
        }
        public async Task<ST_TP_Islem_Odeme> TPIslemOdemeWKSAsync(ST_WS_Guvenlik G, int SanalPOS_ID, string GUID, string KS_Kart_No, string KK_GUID, string KK_Sahibi_GSM, string Hata_URL, string Basarili_URL, string Siparis_ID, string Siparis_Aciklama, int Taksit, string Islem_Tutar, string Toplam_Tutar, string Islem_Hash, string Islem_Guvenlik_Tip, string Islem_ID, string IPAdr, string Ref_URL, string Data1, string Data2, string Data3, string Data4, string Data5)
        {
            return await client.TP_Islem_Odeme_WKSAsync(G, SanalPOS_ID, GUID, KS_Kart_No, KK_GUID, KK_Sahibi_GSM, Hata_URL, Basarili_URL, Siparis_ID, Siparis_Aciklama, Taksit, Islem_Tutar, Toplam_Tutar, Islem_Hash, Islem_Guvenlik_Tip, Islem_ID, IPAdr, Ref_URL, Data1, Data2, Data3, Data4, Data5);
        }
        public async Task<ST_TP_Islem_Odeme> TPIslemOdemeWNSAsync(ST_WS_Guvenlik G, int SanalPOS_ID, string GUID, string KK_Sahibi, string KK_No, string KK_SK_Ay, string KK_SK_Yil, string KK_CVC, string KK_Sahibi_GSM, string Hata_URL, string Basarili_URL, string Siparis_ID, string Siparis_Aciklama, int Taksit, string Islem_Tutar, string Toplam_Tutar, string Islem_Hash, string Islem_Guvenlik_Tip, string Islem_ID, string IPAdr, string Ref_URL, string Data1, string Data2, string Data3, string Data4, string Data5, string Firma_IPAdr)
        {
            return await client.TP_Islem_Odeme_WNSAsync(G, SanalPOS_ID, GUID, KK_Sahibi, KK_No, KK_SK_Ay, KK_SK_Yil, KK_CVC, KK_Sahibi_GSM, Hata_URL, Basarili_URL, Siparis_ID, Siparis_Aciklama, Taksit, Islem_Tutar, Toplam_Tutar, Islem_Hash, Islem_Guvenlik_Tip, Islem_ID, IPAdr, Ref_URL, Data1, Data2, Data3, Data4, Data5);
        }
        public async Task<ST_Genel_Sonuc> TPIslemSorgulamaAsync(ST_WS_Guvenlik G, string GUID, string Dekont_ID, string Siparis_ID, string Islem_ID)
        {
            return await client.TP_Islem_SorgulamaAsync(G, GUID, Dekont_ID, Siparis_ID, Islem_ID);
        }
        public async Task<ST_Genel_Sonuc2> TPIslemSorgulama4Async(ST_WS_Guvenlik G, string GUID, string Dekont_ID, string Siparis_ID, string Islem_ID)
        {
            return await client.TP_Islem_Sorgulama4Async(G, GUID, Dekont_ID, Siparis_ID, Islem_ID);
        }
        public async Task<ST_Genel_Sonuc3> TPIslemSorgulama5Async(ST_WS_Guvenlik G, string GUID, string Dekont_ID, string Siparis_ID, string Islem_ID)
        {
            return await client.TP_Islem_Sorgulama5Async(G, GUID, Dekont_ID, Siparis_ID, Islem_ID);
        }
        public async Task<ST_WMD_UCD> TPIslemSorgulama6Async(ST_WS_Guvenlik G, string GUID, string Siparis_ID)
        {
            return await client.TP_Islem_Sorgulama6Async(G, GUID, Siparis_ID);
        }
        public async Task<ST_Islem_Sorgulama_WP> TPIslemSorgulamaWPAsync(ST_WS_Guvenlik G, string GUID, string Dekont_ID, string Siparis_ID, string Islem_ID, string Ref_No)
        {
            return await client.TP_Islem_Sorgulama_WPAsync(G, GUID, Dekont_ID, Siparis_ID, Islem_ID, Ref_No);
        }
        public async Task<ST_TP_Islem_Odeme> TPKKVerifyAsync(ST_WS_Guvenlik G, string KK_No, string KK_SK_Ay, string KK_SK_Yil, string KK_CVC, string Return_URL, string Data1, string Data2, string Data3, string Data4, string Data5)
        {
            return await client.TP_KK_VerifyAsync(G, KK_No, KK_SK_Ay, KK_SK_Yil, KK_CVC, Return_URL, Data1, Data2, Data3, Data4, Data5);
        }
        public async Task<CL_Res_Odeme> TPModalPaymentAsync(CL_Req_Odeme d)
        {
            return await client.TP_Modal_PaymentAsync(d);
        }
        public async Task<CL_Multiple_Payment> TPMultiplePaymentAsync(CL_Payment Payment_Info)
        {
            return await client.TP_Multiple_PaymentAsync(Payment_Info);
        }
        public async Task<CL_Multiple_Payment_Status> TPMultiplePaymentStatusAsync(CL_Payment_Status Payment_Info)
        {
            return await client.TP_Multiple_Payment_StatusAsync(Payment_Info);
        }
        public async Task<ST_Genel_Sonuc> TPMutabakatDetayAsync(ST_WS_Guvenlik G, string GUID, string Tarih)
        {
            return await client.TP_Mutabakat_DetayAsync(G, GUID, Tarih);
        }
        public async Task<ST_Genel_Sonuc> TPMutabakatOzetAsync(ST_WS_Guvenlik G, string GUID, string Tarih_Bas, string Tarih_Bit)
        {
            return await client.TP_Mutabakat_OzetAsync(G, GUID, Tarih_Bas, Tarih_Bit);
        }
        public async Task<ST_Genel_Sonuc> TPOzelOranListeAsync(ST_WS_Guvenlik G, string GUID)
        {
            return await client.TP_Ozel_Oran_ListeAsync(G, GUID);
        }
        public async Task<ST_Sonuc> TPOzelOranSKGuncelleAsync(ST_WS_Guvenlik G, string GUID, string Ozel_Oran_SK_ID, string MO_1, string MO_2, string MO_3, string MO_4, string MO_5, string MO_6, string MO_7, string MO_8, string MO_9, string MO_10, string MO_11, string MO_12)
        {
            return await client.TP_Ozel_Oran_SK_GuncelleAsync(G, GUID, Ozel_Oran_SK_ID, MO_1, MO_2, MO_3, MO_4, MO_5, MO_6, MO_7, MO_8, MO_9, MO_10, MO_11, MO_12);
        }
        public async Task<ST_Genel_Sonuc> TPOzelOranSKListeAsync(ST_WS_Guvenlik G, string GUID)
        {
            return await client.TP_Ozel_Oran_SK_ListeAsync(G, GUID);
        }
        public async Task<ST_WMD_Pay> TPWMDPayAsync(ST_WS_Guvenlik G, string GUID, string UCD_MD, string Islem_GUID, string Siparis_ID)
        {
            return await client.TP_WMD_PayAsync(G, GUID, UCD_MD, Islem_GUID, Siparis_ID);
        }
        public async Task<ST_WMD_UCD> TPWMDUCDAsync(ST_WS_Guvenlik G, string GUID, string KK_Sahibi, string KK_No, string KK_SK_Ay, string KK_SK_Yil, string KK_CVC, string KK_Sahibi_GSM, string Hata_URL, string Basarili_URL, string Siparis_ID, string Siparis_Aciklama, int Taksit, string Islem_Tutar, string Toplam_Tutar, string Islem_Hash, string Islem_Guvenlik_Tip, string Islem_ID, string IPAdr, string Ref_URL, string Data1, string Data2, string Data3, string Data4, string Data5)
        {
            return await client.TP_WMD_UCDAsync(G, GUID, KK_Sahibi, KK_No, KK_SK_Ay, KK_SK_Yil, KK_CVC, KK_Sahibi_GSM, Hata_URL, Basarili_URL, Siparis_ID, Siparis_Aciklama, Taksit, Islem_Tutar, Toplam_Tutar, Islem_Hash, Islem_Guvenlik_Tip, Islem_ID, IPAdr, Ref_URL, Data1, Data2, Data3, Data4, Data5);
        }
        public async Task<ST_WMD_UCD> TPWMDUCDPuanAsync(ST_WS_Guvenlik G, string GUID, string KK_Sahibi, string KK_No, string KK_SK_Ay, string KK_SK_Yil, string KK_CVC, string KK_Sahibi_GSM, string Hata_URL, string Basarili_URL, string Siparis_ID, string Siparis_Aciklama, int Taksit, string Islem_Tutar, string Toplam_Tutar, string Islem_Hash, string Islem_Guvenlik_Tip, string Islem_ID, string IPAdr, string Ref_URL, string Data1, string Data2, string Data3, string Data4, string Data5, string Pos_ID, string Islem_Tip)
        {
            return await client.TP_WMD_UCD_PuanAsync(G, GUID, KK_Sahibi, KK_No, KK_SK_Ay, KK_SK_Yil, KK_CVC, KK_Sahibi_GSM, Hata_URL, Basarili_URL, Siparis_ID, Siparis_Aciklama, Taksit, Islem_Tutar, Toplam_Tutar, Islem_Hash, Islem_Guvenlik_Tip, Islem_ID, IPAdr, Ref_URL, Data1, Data2, Data3, Data4, Data5, Pos_ID, Islem_Tip);
        }
        public async Task<ST_WMD_UCD> TPWMDUCDWPAsync(ST_WS_Guvenlik G, string GUID, string KK_Sahibi, string KK_No, string KK_SK_Ay, string KK_SK_Yil, string KK_CVC, string KK_Sahibi_GSM, string Hata_URL, string Basarili_URL, string Siparis_ID, string Siparis_Aciklama, int Taksit, string Islem_Tutar, string Toplam_Tutar, string Islem_Hash, string Islem_Guvenlik_Tip, string Islem_ID, string IPAdr, string Ref_URL, string Data1, string Data2, string Data3, string Data4, string Data5, string Puan, string Pos_ID, string Islem_Tip)
        {
            return await client.TP_WMD_UCD_WPAsync(G, GUID, KK_Sahibi, KK_No, KK_SK_Ay, KK_SK_Yil, KK_CVC, KK_Sahibi_GSM, Hata_URL, Basarili_URL, Siparis_ID, Siparis_Aciklama, Taksit, Islem_Tutar, Toplam_Tutar, Islem_Hash, Islem_Guvenlik_Tip, Islem_ID, IPAdr, Ref_URL, Data1, Data2, Data3, Data4, Data5, Puan, Pos_ID, Islem_Tip);
        }
        public async Task<ST_WMD_UCD_v2> TPWMDUCDv2Async(ST_WS_Guvenlik G, string GUID, string KK_Sahibi, string KK_No, string KK_SK_Ay, string KK_SK_Yil, string KK_CVC, string KK_Sahibi_GSM, string Hata_URL, string Basarili_URL, string Siparis_ID, string Siparis_Aciklama, int Taksit, string Islem_Tutar, string Toplam_Tutar, string Islem_Hash, string Islem_Guvenlik_Tip, string Islem_ID, string IPAdr, string Ref_URL, string Data1, string Data2, string Data3, string Data4, string Data5)
        {
            return await client.TP_WMD_UCD_v2Async(G, GUID, KK_Sahibi, KK_No, KK_SK_Ay, KK_SK_Yil, KK_CVC, KK_Sahibi_GSM, Hata_URL, Basarili_URL, Siparis_ID, Siparis_Aciklama, Taksit, Islem_Tutar, Toplam_Tutar, Islem_Hash, Islem_Guvenlik_Tip, Islem_ID, IPAdr, Ref_URL, Data1, Data2, Data3, Data4, Data5);
        }
        public async Task<ST_Vadeli_Islem_Izleme_Sonuc> VadeliIslemIzlemeAsync(ST_WS_Guvenlik G, string GUID, string Tarih_Bas, string Tarih_Bit, string Siparis_No)
        {
            return await client.Vadeli_Islem_IzlemeAsync(G, GUID, Tarih_Bas, Tarih_Bit, Siparis_No);
        }
    }
}