using service_param;

namespace WebMvc.Repository.Interface
{
    public interface Iservice_paramAsyncRepository
    {
        public Task<int> AOKontrolAsync(string TKN, string KN);
        public Task<string> AidatAlSMSAsync(ST_WS_Guvenlik g, string GSM, string AdSoyad, string Metin);
        public Task<ArrayOfXElement> BKMFSHRaporAsync(string Vergi_No, string TC_Kimlik_No);
        public Task<ST_Genel_Sonuc> BKMRaporAsync(string Tip, DateTime T1, DateTime T2);
        public Task<ST_Genel_Sonuc> BaroKartCubbeListeAsync(ST_WS_Guvenlik G, string Kart_No, string Tarih_Bas, string Tarih_Bit, string Uygulama_Tip);
        public Task<string> BildirimGonderAsync(ST_WS_Guvenlik G, string Kart_No, ST_Bildirim_Data Bildirim_Data, string Uygulama_Tip, string Uygulama_Adi, string IPAdr);
        public Task<object> BildirimGonderv2Async(string deviceToken, string title, string body, string data);
        public Task<object> BildirimGonderv3Async(string deviceToken, string title, string body, string data);
        public Task<Dekont_Bilgisi_KKResponse> DekontBilgisiKKAsync(ServiceSecuritySoapHeader ServiceSecuritySoapHeader, ST_WS_Guvenlik G, string Kart_No, string Dekont_No, string Uygulama_Tip);
        public Task<ST_Genel_Sonuc> DekontBilgisiSaltAsync(ST_WS_Guvenlik G, string Kart_No, string Dekont_No, string Uygulama_Tip);
        public Task<ST_Sonuc> DekontEPostaGonderAsync(ST_WS_Guvenlik G, string Kart_No, string Dekont_ID, string E_Posta, string Tip, string Uygulama_Tip);
        public Task<int> EPGonderAsync(string Kart_No, string too, string cc, string htmlfile, string Konu, string Data1, string Data2, string Data3, string Data4, string Data5);
        public Task<int> EPGonder2Async(string Kart_Grup, string Kart_No, string Kisi_TC, string too, string cc, string htmlfile, string Konu, string Data1, string Data2, string Data3, string Data4, string Data5);
        public Task<string> EPGonder3Async(string Kart_No, string too, string cc, string htmlfile, string Konu, string Data1, string Data2, string Data3, string Data4, string Data5, string Tip, string Att);
        public Task<string> EPGonder4Async(string UserMail, string Kart_No, string too, string cc, string htmlfile, string Konu, string Data1, string Data2, string Data3, string Data4, string Data5, string Tip, string Att);
        public Task<string> EPGonder5Async(string KN, string T, string C, string HF, string KO, string D1, string D2, string D3, string D4, string D5, string Tip, string Att);
        public Task<ST_Genel_Sonuc> EkstreDonemlerAsync(ST_WS_Guvenlik G, string Kart_No, string Ip_Adr, string Uygulama_Tip);
        public Task<ST_Sonuc> HashDataAsync(ST_WS_Guvenlik G, string KK_No, string KK_SK_Ay, string KK_SK_Yil, string KK_CVV, string KK_Sahibi);
        public Task<ST_KK_Cozumle> HashDecryptAsync(ST_WS_Guvenlik G, string Hash);
        public Task<Hesap_EkstreResponse> HesapEkstreAsync(ServiceSecuritySoapHeader ServiceSecuritySoapHeader, ST_WS_Guvenlik G, string Kart_No, string Donem, string Uygulama_Tip);
        public Task<Hesap_Ekstre_Base64Response> HesapEkstreBase64Async(ServiceSecuritySoapHeader ServiceSecuritySoapHeader, ST_WS_Guvenlik G, string Kart_No, string Donem, string Uygulama_Tip, int Kredi);
        /// <summary>İlçelerin listesine ulaşma işlemini uygular.</summary>
        /// <param name="Islem_Tip">İşlemin Tipi (Zorunlu)</param>
        /// <param name="Il_Kodu">İlin Kodu (Zorunlu)</param>
        /// <param name="Uygulama_Tip">Uygulamanın Tipi (Zorunlu)</param>
        /// <returns>ST_Genel_Sonuc Nenesi</returns>
        ///     ST_Genel_Sonuc:
        ///         DT_Bilgi:
        ///             Ilce_Kodu: İlçenin Kodu
        ///             Ilce: İlçenin İsmi
        ///         Sonuc: İşlem Sonucu
        ///         Sonuc_Str: İşlem Sonucunun Açıklaması
        public Task<ST_Genel_Sonuc> IlIlceListeAsync(string Islem_Tip, string Il_Kodu, string Uygulama_Tip);
        public Task<Iletisim_BilgiResponse> IletisimBilgiAsync(ServiceSecuritySoapHeader ServiceSecuritySoapHeader, ST_WS_Guvenlik G, string Kart_No, string Uygulama_Tip);
        public Task<Iletisim_Bilgi_GuncelleResponse> IletisimBilgiGuncelleAsync(ServiceSecuritySoapHeader ServiceSecuritySoapHeader, ST_WS_Guvenlik G, string Kart_No, string Kisi_E_Posta, string Kisi_GSM, string Kisi_Adres, string Kisi_Il, string Kisi_Ilce, string Fatura_Adres, string Fatura_Il, string Fatura_Ilce, string Vergi_Dairesi, string Vergi_No, string Uygulama_Tip);
        public Task<ST_Islem_Harcama> IslemHarcamaAsync(ST_WS_Guvenlik G, string Kart_No, string Urun_ID, string Terminal_ID, string Terminal_Detay_ID, string Tutar, string Aciklama, string MC_UID, string IPAdr);
        public Task<ST_Login_Param> IslemLoginGenelAsync(ST_WS_Guvenlik G, string Kart_No, string Sifre, string Uygulama_Adi, string Uygulama_Tip, string Cihaz_UID, string Cihaz_Push_Key);
        public Task<ST_Login_Param> IslemLoginGenel2Async(ST_WS_Guvenlik G, string Kart_No, string Sifre, string Uygulama_Adi, string Uygulama_Tip, string Cihaz_UID, string Cihaz_Push_Key);
        public Task<ST_Login_AA> IslemLoginGenelAAAsync(ST_WS_Guvenlik G, string Kart_No, string Sifre, string Uygulama_Adi, string Uygulama_Tip, string Cihaz_UID, string Cihaz_Push_Key);
        public Task<ST_Login_Param> IslemLoginPINAsync(ST_WS_Guvenlik G, string Cihaz_UID, string PIN, string Uygulama_Adi, string Uygulama_Tip, string IPAdr);
        public Task<CL_Res_TL> KKTLYUKLETKSAsync(ST_WS_Guvenlik G, string Kart_No, string KK_No, string KK_Sahibi, string KK_AY, string KK_YIL, string KK_CVC, double Yukleme_Tutar, int Taksit);
        public Task<ST_Genel_Sonuc> KKTaksitListeAsync(ST_WS_Guvenlik G, string Kart_No, string KK_BIN);
        public Task<ST_Tahsilat> KSNonsecureTahsilatAsync(ST_WS_Guvenlik G, string Kart_No, string KK_GUID, int Taksit, string Tutar);
        public Task<Kart_Bakiye_BilgiResponse> KartBakiyeBilgiAsync(ServiceSecuritySoapHeader ServiceSecuritySoapHeader, ST_WS_Guvenlik G, string Kart_No, string Uygulama_Tip);
        public Task<Kisi_BilgiResponse> KisiBilgiAsync(ServiceSecuritySoapHeader ServiceSecuritySoapHeader, ST_WS_Guvenlik G, string Kart_No, string Device_ID, string Uygulama_Tip);
        public Task<ST_Limit_Bilgi> LimitBilgiAsync(ST_WS_Guvenlik G, string Kart_No, double Tutar, string IPAdr, string Uygulama_Tip);
        public Task<string> OpetSatisAsync(ST_WS_Guvenlik G, DateTime SaleEnd, DateTime ProcessTime, int StationID, string StationName, int FleetID, string FleetName, int GroupID, string GroupName, string LicensePlateNr, int ProductID, string ProductName, double Total, double Volume, double UnitPrice, int Odometer, int ECRReceiptNr, string InvoicePeriodNr, string CityName, int CityID);
        public Task<ST_Bakiye> OpetYakitKartBakiyeAsync(ST_WS_Guvenlik G, string KN);
        public Task<ST_Sonuc> PINIslemAsync(ST_WS_Guvenlik G, string Tip, string Kart_No, string Cihaz_UID, string PIN1, string PIN1_Tekrar, string Uygulama_Tip, string IPAdr);
        public Task<ST_Sonuc> ParamBasvuruAsync(string Kisi_TC, string Kisi_Adi, string Kisi_Soyadi, string Kisi_GSM, string Kisi_EPosta, string PIN_Kodu, string IPAdr, string Uygulama_Tip);
        public Task<ST_Sonuc> ParamBasvuruBelgeGonderAsync(ST_WS_Guvenlik G, string Basvuru_ID, string Belge, string Belge_Tip, string IPAdr, string Uygulama_Tip);
        public Task<ProxyAccountResponse> ParamFastKolasAddProxyAccountAsync(ST_WS_Guvenlik G, string Kart_No, string SystemRefNo, string IdentityNo, string AddressType, string AddressValue, string AccountOwner, string AccountNo, string AccountType, string TradeName, string InformChannel, string Description, string IPAdr);
        public Task<BaseResponse> ParamFastKolasDeleteProxyAccountAsync(ST_WS_Guvenlik G, string Kart_No, string SystemRefNo, string IPAdr);
        public Task<GetRecipientProxyAccountResponse> ParamFastKolasGetRecipientProxyAccountAsync(ST_WS_Guvenlik G, string Kart_No, string AddressType, string AddressValue, string SenderIdentityNo, string IPAdr);
        public Task<QueryProxyAccountResponse> ParamFastKolasGetTransferProxyAccountAsync(ST_WS_Guvenlik G, string Kart_No, string TransferStartDate, string TransferEndDate, string IPAdr);
        public Task<QueryProxyAccountResponse> ParamFastKolasQueryProxyAccountAsync(ST_WS_Guvenlik G, string Kart_No, string AddressType, string AddressValue, string IdentityNo, string SystemRefNo, string IPAdr);
        public Task<ProxyAccountResponse> ParamFastKolasUpdateProxyAccountAsync(ST_WS_Guvenlik G, string Kart_No, string SystemRefNo, string IdentityNo, string AddressType, string AddressValue, string AccountOwner, string AccountNo, string AccountType, string TradeName, string InformChannel, string Description, string IPAdr);
        public Task<ST_Transfer_Sonuc> ParamFastTransferYapAsync(ST_WS_Guvenlik G, string Kart_No, string Tip, string Alici_IBAN_Kart_No, string Alici_Unvan, string Tutar, string Aciklama, string Kullanici_Kart_No, string IPAdr, string Uygulama_Tip, int Kredi, int Transfer_Yeri, int Transfer_Tipi, string QueryRefNo, string KolayAdres);
        public Task<ST_Genel_Sonuc> ParamIBANIslemAsync(ST_WS_Guvenlik G, string T1, string T2, long SID);
        public Task<ST_Genel_Sonuc> ParamIslemAsync(ST_WS_Guvenlik G, string T1, string T2, long SID);
        public Task<Param_QR_KontrolResponse> ParamQRKontrolAsync(ServiceSecuritySoapHeader ServiceSecuritySoapHeader, ST_WS_Guvenlik G, string Kart_No, string QR_Data, string Cihaz_UID, string IPAdr, string Uygulama_Tip);
        public Task<ST_Genel_Sonuc> ParamSahtecilikIslemAsync(ST_WS_Guvenlik G, string T1, string T2, long SID);
        public Task<ST_Genel_Sonuc> ParamSanalPOSIslemAsync(ST_WS_Guvenlik G, string T1, string T2, long SID);
        public Task<ST_Genel_Sonuc> ParamSanalPOSLimitAsync(ST_WS_Guvenlik G);
        public Task<ST_Transfer_Hesap> ParamTransferHesapAsync(ST_WS_Guvenlik G, string Kart_No, string Uygulama_Tip);
        public Task<Param_Transfer_QR_UretResponse> ParamTransferQRUretAsync(ServiceSecuritySoapHeader ServiceSecuritySoapHeader, ST_WS_Guvenlik G, string Kart_No, string Tutar, string Aciklama, string Odeme_Alan, string Cihaz_UID, string IPAdr, string Uygulama_Tip);
        public Task<Param_Transfer_QR_Uret_SuresizResponse> ParamTransferQRUretSuresizAsync(ServiceSecuritySoapHeader ServiceSecuritySoapHeader, ST_WS_Guvenlik G, string Kart_No, string Tutar, string Aciklama, string Odeme_Alan, string Tarih, string Cihaz_UID, string IPAdr, string Uygulama_Tip);
        public Task<ST_Transfer_Sonuc> ParamTransferYapAsync(ST_WS_Guvenlik G, string Kart_No, string Tip, string Alici_IBAN_Kart_No, string Alici_Unvan, string Tutar, string Aciklama, string Kullanici_Kart_No, string IPAdr, string Uygulama_Tip);
        public Task<Param_Transfer_Yap_QRResponse> ParamTransferYapQRAsync(ServiceSecuritySoapHeader ServiceSecuritySoapHeader, ST_WS_Guvenlik G, string Kart_No, string QR_Data, string Cuzdan, string Cihaz_UID, string IPAdr, string Uygulama_Tip);
        public Task<ST_Transfer_Sonuc> ParamTransferYapv2Async(ST_WS_Guvenlik G, string Kart_No, string Tip, string Alici_IBAN_Kart_No, string Alici_Unvan, string Tutar, string Aciklama, string Kullanici_Kart_No, string IPAdr, string Uygulama_Tip, int Kredi);
        public Task<ST_Sonuc> PromosyonKodKullanimAsync(ST_WS_Guvenlik G, string Kart_No, string Promosyon_Kodu, string Cihaz_UID, string Uygulama_Tip);
        public Task<ST_Genel_Sonuc> PromosyonKodUretAsync(ST_WS_Guvenlik G, string Kart_No, string Cihaz_UID, string Uygulama_Tip);
        public Task<SMS_DogrulamaResponse> SMSDogrulamaAsync(ServiceSecuritySoapHeader ServiceSecuritySoapHeader, ST_WS_Guvenlik G, string Kart_No, string SMS_Onay_Kod, string SMS_Onay_No, string Uygulama_Tip);
        public Task<ST_Genel_Sonuc> SMSDogrulama3Async(ST_WS_Guvenlik G, string Kart_No, string SMS_Onay_Kod, string SMS_Onay_No, string Uygulama_Tip, string Uygulama_Adi, string Cihaz_UID, string Cihaz_Push_Key);
        public Task<SMS_Dogrulama_MobilResponse> SMSDogrulamaMobilAsync(ServiceSecuritySoapHeader ServiceSecuritySoapHeader, ST_WS_Guvenlik G, string Cihaz_UID, string SMS_Onay_Kod, string SMS_Onay_No, string Uygulama_Tip);
        public Task<SMS_GonderResponse> SMSGonderAsync(ServiceSecuritySoapHeader ServiceSecuritySoapHeader, ST_WS_Guvenlik G, string Kart_No, string GSM_No, string Aciklama, string Uygulama_Tip);
        public Task<SMS_Gonder2Response> SMSGonder2Async(ServiceSecuritySoapHeader ServiceSecuritySoapHeader, ST_WS_Guvenlik G, string Kart_No, string Aciklama, string Uygulama_Tip);
        public Task<SMS_Gonder_MobilResponse> SMSGonderMobilAsync(ServiceSecuritySoapHeader ServiceSecuritySoapHeader, ST_WS_Guvenlik G, string Cihaz_UID, string GSM_No, string Uygulama_Tip);
        public Task<Sifre_DegistirResponse> SifreDegistirAsync(ServiceSecuritySoapHeader ServiceSecuritySoapHeader, string Kart_No, string Eski_Sifre, string Yeni_Sifre, string Uygulama_Tip);
        public Task<Sifremi_UnuttumResponse> SifremiUnuttumAsync(ServiceSecuritySoapHeader ServiceSecuritySoapHeader, ST_WS_Guvenlik G, string Kart_No, string IP_Adr, string Uygulama_Tip);
        public Task<ST_Sonuc> SurumKontrolAsync(ST_WS_Guvenlik G, string Surum, string Mobil_Tip, string Uygulama_Tip);
        public Task<string> TC2ImgAsync(ST_WS_Guvenlik G, string Tip, string Kart_Tip, string Kisi_TC);
        public Task<ST_Genel_Sonuc> TLYukleKomisyonBilgiAsync(ST_WS_Guvenlik G, string Kart_No, string KK_No, int Taksit, string Tutar, string KK_AY, string KK_YIL, string CVV);
        public Task<ST_TL_Yukle_UCD> TLYukleUCDAsync(ST_WS_Guvenlik G, string Kart_No, double Tutar, string SanalPOS_ID, string SanalPOS_Tip, int SanalPOS_Taksit, string KK_No, string KK_Sahibi, string KK_SK_Ay, string KK_SK_Yil, string KK_CVC, string Ip_Adr, string Uygulama_Tip, string Uygulama_Adi, string Odeme_Imza);
        public Task<ST_Sonuc> TokenOlusturAsync(ST_WS_Guvenlik G);
        public Task<ST_Transfer_Komisyon_Islem> TransferFastKomisyonIslemv2Async(ST_WS_Guvenlik G, string Kart_No, string Transfer_Tutari, string Transfer_Tip, int Kredi, string Uygulama_Tip, string Alici_Kart_No);
        public Task<ST_Transfer_Komisyon_Islem> TransferKomisyonIslemAsync(ST_WS_Guvenlik G, string Kart_No, string Transfer_Tutari, string Transfer_Tip);
        public Task<ST_Transfer_Komisyon_Islem> TransferKomisyonIslemv2Async(ST_WS_Guvenlik G, string Kart_No, string Transfer_Tutari, string Transfer_Tip, int Kredi, string Uygulama_Tip, string Alici_Kart_No);
        public Task<ST_Sonuc> TroyKuryeSorgulaAsync(string Barkod_No);
        public Task<ST_Sonuc> TurkPosBasvuruAsync(ST_WS_Guvenlik G, string Tip, string Kisi_Adi, string Kisi_Soyadi, string GSM, string EPosta, string Firma_Unvan, string Mersis_No, string Sektor, string VD, string VN, string Adres, string Adres_Il, string Adres_Ilce, string Web_Site, string IPAdr, string Uygulama_Tip, string AylikCiro);
        public Task<ST_Sonuc> TurkPosBasvuruDosyaAsync(ST_WS_Guvenlik G, string Basvuru_ID, string Dosya_Tip, string Dosya_B64, string Ext, string IPAdr, string Uygulama_Tip);
        public Task<ST_Sonuc> TurkPosBasvuruDurumAsync(ST_WS_Guvenlik G, string VN, string IPAdr, string Uygulama_Tip);
        public Task<ST_UCD_Islem_Odeme_Sor> UCDIslemOdemeSorAsync(ST_WS_Guvenlik G, string Kart_No, string Islem_ID, string Uygulama_Tip);
        public Task<ST_Sonuc> UygulamaOnermeAsync(ST_WS_Guvenlik G, string Kart_No, string Kisi_Oneren, string Kisi_Onerilen, string EPosta_Onerilen, string Mobil_Tip, string Uygulama_Tip, string IPAdr);
        public Task<WebSite_IcerikResponse> WebSiteIcerikAsync(ServiceSecuritySoapHeader ServiceSecuritySoapHeader, ST_WS_Guvenlik G, string Host, string Uygulama_Tip);
    }
}