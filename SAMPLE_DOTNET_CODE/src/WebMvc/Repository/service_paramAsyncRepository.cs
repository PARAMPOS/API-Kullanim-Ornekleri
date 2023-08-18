using service_param;
using WebMvc.Repository.Interface;

namespace WebMvc.Repository
{
    /// <inheritdoc />
    public class service_paramAsyncRepository : Iservice_paramAsyncRepository
    {
        private readonly service_paramSoapClient client;
        public service_paramAsyncRepository(service_paramSoapClient client)
        {
            this.client = client;
        }
        public async Task<int> AOKontrolAsync(string TKN, string KN)
        {
            return await client.AO_KontrolAsync(TKN, KN);
        }
        public async Task<string> AidatAlSMSAsync(ST_WS_Guvenlik g, string GSM, string AdSoyad, string Metin)
        {
            return await client.AidatAl_SMSAsync(g, GSM, AdSoyad, Metin);
        }
        public async Task<ArrayOfXElement> BKMFSHRaporAsync(string Vergi_No, string TC_Kimlik_No)
        {
            return await client.BKM_FSH_RaporAsync(Vergi_No, TC_Kimlik_No);
        }
        public async Task<ST_Genel_Sonuc> BKMRaporAsync(string Tip, DateTime T1, DateTime T2)
        {
            return await client.BKM_RaporAsync(Tip, T1, T2);
        }
        public async Task<ST_Genel_Sonuc> BaroKartCubbeListeAsync(ST_WS_Guvenlik G, string Kart_No, string Tarih_Bas, string Tarih_Bit, string Uygulama_Tip)
        {
            return await client.BaroKart_Cubbe_ListeAsync(G, Kart_No, Tarih_Bas, Tarih_Bit, Uygulama_Tip);
        }
        public async Task<string> BildirimGonderAsync(ST_WS_Guvenlik G, string Kart_No, ST_Bildirim_Data Bildirim_Data, string Uygulama_Tip, string Uygulama_Adi, string IPAdr)
        {
            return await client.Bildirim_GonderAsync(G, Kart_No, Bildirim_Data, Uygulama_Tip, Uygulama_Adi, IPAdr);
        }
        public async Task<object> BildirimGonderv2Async(string deviceToken, string title, string body, string data)
        {
            return await client.Bildirim_Gonder_v2Async(deviceToken, title, body, data);
        }
        public async Task<object> BildirimGonderv3Async(string deviceToken, string title, string body, string data)
        {
            return await client.Bildirim_Gonder_v3Async(deviceToken, title, body, data);
        }
        public async Task<Dekont_Bilgisi_KKResponse> DekontBilgisiKKAsync(ServiceSecuritySoapHeader ServiceSecuritySoapHeader, ST_WS_Guvenlik G, string Kart_No, string Dekont_No, string Uygulama_Tip)
        {
            return await client.Dekont_Bilgisi_KKAsync(ServiceSecuritySoapHeader, G, Kart_No, Dekont_No, Uygulama_Tip);
        }
        public async Task<ST_Genel_Sonuc> DekontBilgisiSaltAsync(ST_WS_Guvenlik G, string Kart_No, string Dekont_No, string Uygulama_Tip)
        {
            return await client.Dekont_Bilgisi_SaltAsync(G, Kart_No, Dekont_No, Uygulama_Tip);
        }
        public async Task<ST_Sonuc> DekontEPostaGonderAsync(ST_WS_Guvenlik G, string Kart_No, string Dekont_ID, string E_Posta, string Tip, string Uygulama_Tip)
        {
            return await client.Dekont_EPosta_GonderAsync(G, Kart_No, Dekont_ID, E_Posta, Tip, Uygulama_Tip);
        }
        public async Task<int> EPGonderAsync(string Kart_No, string too, string cc, string htmlfile, string Konu, string Data1, string Data2, string Data3, string Data4, string Data5)
        {
            return await client.EP_GonderAsync(Kart_No, too, cc, htmlfile, Konu, Data1, Data2, Data3, Data4, Data5);
        }
        public async Task<int> EPGonder2Async(string Kart_Grup, string Kart_No, string Kisi_TC, string too, string cc, string htmlfile, string Konu, string Data1, string Data2, string Data3, string Data4, string Data5)
        {
            return await client.EP_Gonder2Async(Kart_Grup, Kart_No, Kisi_TC, too, cc, htmlfile, Konu, Data1, Data2, Data3, Data4, Data5);
        }
        public async Task<string> EPGonder3Async(string Kart_No, string too, string cc, string htmlfile, string Konu, string Data1, string Data2, string Data3, string Data4, string Data5, string Tip, string Att)
        {
            return await client.EP_Gonder3Async(Kart_No, too, cc, htmlfile, Konu, Data1, Data2, Data3, Data4, Data5, Tip, Att);
        }
        public async Task<string> EPGonder4Async(string UserMail, string Kart_No, string too, string cc, string htmlfile, string Konu, string Data1, string Data2, string Data3, string Data4, string Data5, string Tip, string Att)
        {
            return await client.EP_Gonder4Async(UserMail, Kart_No, too, cc, htmlfile, Konu, Data1, Data2, Data3, Data4, Data5, Tip, Att);
        }
        public async Task<string> EPGonder5Async(string KN, string T, string C, string HF, string KO, string D1, string D2, string D3, string D4, string D5, string Tip, string Att)
        {
            return await client.EP_Gonder5Async(KN, T, C, HF, KO, D1, D2, D3, D4, D5, Tip, Att);
        }
        public async Task<ST_Genel_Sonuc> EkstreDonemlerAsync(ST_WS_Guvenlik G, string Kart_No, string Ip_Adr, string Uygulama_Tip)
        {
            return await client.Ekstre_DonemlerAsync(G, Kart_No, Ip_Adr, Uygulama_Tip);
        }
        public async Task<ST_Sonuc> HashDataAsync(ST_WS_Guvenlik G, string KK_No, string KK_SK_Ay, string KK_SK_Yil, string KK_CVV, string KK_Sahibi)
        {
            return await client.Hash_DataAsync(G, KK_No, KK_SK_Ay, KK_SK_Yil, KK_CVV, KK_Sahibi);
        }
        public async Task<ST_KK_Cozumle> HashDecryptAsync(ST_WS_Guvenlik G, string Hash)
        {
            return await client.Hash_DecryptAsync(G, Hash);
        }
        public async Task<Hesap_EkstreResponse> HesapEkstreAsync(ServiceSecuritySoapHeader ServiceSecuritySoapHeader, ST_WS_Guvenlik G, string Kart_No, string Donem, string Uygulama_Tip)
        {
            return await client.Hesap_EkstreAsync(ServiceSecuritySoapHeader, G, Kart_No, Donem, Uygulama_Tip);
        }
        public async Task<Hesap_Ekstre_Base64Response> HesapEkstreBase64Async(ServiceSecuritySoapHeader ServiceSecuritySoapHeader, ST_WS_Guvenlik G, string Kart_No, string Donem, string Uygulama_Tip, int Kredi)
        {
            return await client.Hesap_Ekstre_Base64Async(ServiceSecuritySoapHeader, G, Kart_No, Donem, Uygulama_Tip, Kredi);
        }
        public async Task<ST_Genel_Sonuc> IlIlceListeAsync(string Islem_Tip, string Il_Kodu, string Uygulama_Tip)
        {
            return await client.Il_Ilce_ListeAsync(Islem_Tip, Il_Kodu, Uygulama_Tip);
        }
        public async Task<Iletisim_BilgiResponse> IletisimBilgiAsync(ServiceSecuritySoapHeader ServiceSecuritySoapHeader, ST_WS_Guvenlik G, string Kart_No, string Uygulama_Tip)
        {
            return await client.Iletisim_BilgiAsync(ServiceSecuritySoapHeader, G, Kart_No, Uygulama_Tip);
        }
        public async Task<Iletisim_Bilgi_GuncelleResponse> IletisimBilgiGuncelleAsync(ServiceSecuritySoapHeader ServiceSecuritySoapHeader, ST_WS_Guvenlik G, string Kart_No, string Kisi_E_Posta, string Kisi_GSM, string Kisi_Adres, string Kisi_Il, string Kisi_Ilce, string Fatura_Adres, string Fatura_Il, string Fatura_Ilce, string Vergi_Dairesi, string Vergi_No, string Uygulama_Tip)
        {
            return await client.Iletisim_Bilgi_GuncelleAsync(ServiceSecuritySoapHeader, G, Kart_No, Kisi_E_Posta, Kisi_GSM, Kisi_Adres, Kisi_Il, Kisi_Ilce, Fatura_Adres, Fatura_Il, Fatura_Ilce, Vergi_Dairesi, Vergi_No, Uygulama_Tip);
        }
        public async Task<ST_Islem_Harcama> IslemHarcamaAsync(ST_WS_Guvenlik G, string Kart_No, string Urun_ID, string Terminal_ID, string Terminal_Detay_ID, string Tutar, string Aciklama, string MC_UID, string IPAdr)
        {
            return await client.Islem_HarcamaAsync(G, Kart_No, Urun_ID, Terminal_ID, Terminal_Detay_ID, Tutar, Aciklama, MC_UID, IPAdr);
        }
        public async Task<ST_Login_Param> IslemLoginGenelAsync(ST_WS_Guvenlik G, string Kart_No, string Sifre, string Uygulama_Adi, string Uygulama_Tip, string Cihaz_UID, string Cihaz_Push_Key)
        {
            return await client.Islem_Login_GenelAsync(G, Kart_No, Sifre, Uygulama_Adi, Uygulama_Tip, Cihaz_UID, Cihaz_Push_Key);
        }
        public async Task<ST_Login_Param> IslemLoginGenel2Async(ST_WS_Guvenlik G, string Kart_No, string Sifre, string Uygulama_Adi, string Uygulama_Tip, string Cihaz_UID, string Cihaz_Push_Key)
        {
            return await client.Islem_Login_Genel2Async(G, Kart_No, Sifre, Uygulama_Adi, Uygulama_Tip, Cihaz_UID, Cihaz_Push_Key);
        }
        public async Task<ST_Login_AA> IslemLoginGenelAAAsync(ST_WS_Guvenlik G, string Kart_No, string Sifre, string Uygulama_Adi, string Uygulama_Tip, string Cihaz_UID, string Cihaz_Push_Key)
        {
            return await client.Islem_Login_Genel_AAAsync(G, Kart_No, Sifre, Uygulama_Adi, Uygulama_Tip, Cihaz_UID, Cihaz_Push_Key);
        }
        public async Task<ST_Login_Param> IslemLoginPINAsync(ST_WS_Guvenlik G, string Cihaz_UID, string PIN, string Uygulama_Adi, string Uygulama_Tip, string IPAdr)
        {
            return await client.Islem_Login_PINAsync(G, Cihaz_UID, PIN, Uygulama_Adi, Uygulama_Tip, IPAdr);
        }
        public async Task<CL_Res_TL> KKTLYUKLETKSAsync(ST_WS_Guvenlik G, string Kart_No, string KK_No, string KK_Sahibi, string KK_AY, string KK_YIL, string KK_CVC, double Yukleme_Tutar, int Taksit)
        {
            return await client.KK_TL_YUKLE_TKSAsync(G, Kart_No, KK_No, KK_Sahibi, KK_AY, KK_YIL, KK_CVC, Yukleme_Tutar, Taksit);
        }
        public async Task<ST_Genel_Sonuc> KKTaksitListeAsync(ST_WS_Guvenlik G, string Kart_No, string KK_BIN)
        {
            return await client.KK_Taksit_ListeAsync(G, Kart_No, KK_BIN);
        }
        public async Task<ST_Tahsilat> KSNonsecureTahsilatAsync(ST_WS_Guvenlik G, string Kart_No, string KK_GUID, int Taksit, string Tutar)
        {
            return await client.KS_Nonsecure_TahsilatAsync(G, Kart_No, KK_GUID, Taksit, Tutar);
        }
        public async Task<Kart_Bakiye_BilgiResponse> KartBakiyeBilgiAsync(ServiceSecuritySoapHeader ServiceSecuritySoapHeader, ST_WS_Guvenlik G, string Kart_No, string Uygulama_Tip)
        {
            return await client.Kart_Bakiye_BilgiAsync(ServiceSecuritySoapHeader, G, Kart_No, Uygulama_Tip);
        }
        public async Task<Kisi_BilgiResponse> KisiBilgiAsync(ServiceSecuritySoapHeader ServiceSecuritySoapHeader, ST_WS_Guvenlik G, string Kart_No, string Device_ID, string Uygulama_Tip)
        {
            return await client.Kisi_BilgiAsync(ServiceSecuritySoapHeader, G, Kart_No, Device_ID, Uygulama_Tip);
        }
        public async Task<ST_Limit_Bilgi> LimitBilgiAsync(ST_WS_Guvenlik G, string Kart_No, double Tutar, string IPAdr, string Uygulama_Tip)
        {
            return await client.Limit_BilgiAsync(G, Kart_No, Tutar, IPAdr, Uygulama_Tip);
        }
        public async Task<string> OpetSatisAsync(ST_WS_Guvenlik G, DateTime SaleEnd, DateTime ProcessTime, int StationID, string StationName, int FleetID, string FleetName, int GroupID, string GroupName, string LicensePlateNr, int ProductID, string ProductName, double Total, double Volume, double UnitPrice, int Odometer, int ECRReceiptNr, string InvoicePeriodNr, string CityName, int CityID)
        {
            return await client.Opet_SatisAsync(G, SaleEnd, ProcessTime, StationID, StationName, FleetID, FleetName, GroupID, GroupName, LicensePlateNr, ProductID, ProductName, Total, Volume, UnitPrice, Odometer, ECRReceiptNr, InvoicePeriodNr, CityName, CityID);
        }
        public async Task<ST_Bakiye> OpetYakitKartBakiyeAsync(ST_WS_Guvenlik G, string KN)
        {
            return await client.Opet_YakitKart_BakiyeAsync(G, KN);
        }
        public async Task<ST_Sonuc> PINIslemAsync(ST_WS_Guvenlik G, string Tip, string Kart_No, string Cihaz_UID, string PIN1, string PIN1_Tekrar, string Uygulama_Tip, string IPAdr)
        {
            return await client.PIN_IslemAsync(G, Tip, Kart_No, Cihaz_UID, PIN1, PIN1_Tekrar, Uygulama_Tip, IPAdr);
        }
        public async Task<ST_Sonuc> ParamBasvuruAsync(string Kisi_TC, string Kisi_Adi, string Kisi_Soyadi, string Kisi_GSM, string Kisi_EPosta, string PIN_Kodu, string IPAdr, string Uygulama_Tip)
        {
            return await client.Param_BasvuruAsync(Kisi_TC, Kisi_Adi, Kisi_Soyadi, Kisi_GSM, Kisi_EPosta, PIN_Kodu, IPAdr, Uygulama_Tip);
        }
        public async Task<ST_Sonuc> ParamBasvuruBelgeGonderAsync(ST_WS_Guvenlik G, string Basvuru_ID, string Belge, string Belge_Tip, string IPAdr, string Uygulama_Tip)
        {
            return await client.Param_Basvuru_BelgeGonderAsync(G, Basvuru_ID, Belge, Belge_Tip, IPAdr, Uygulama_Tip);
        }
        public async Task<ProxyAccountResponse> ParamFastKolasAddProxyAccountAsync(ST_WS_Guvenlik G, string Kart_No, string SystemRefNo, string IdentityNo, string AddressType, string AddressValue, string AccountOwner, string AccountNo, string AccountType, string TradeName, string InformChannel, string Description, string IPAdr)
        {
            return await client.Param_FastKolas_AddProxyAccountAsync(G, Kart_No, SystemRefNo, IdentityNo, AddressType, AddressValue, AccountOwner, AccountNo, AccountType, TradeName, InformChannel, Description, IPAdr);
        }
        public async Task<BaseResponse> ParamFastKolasDeleteProxyAccountAsync(ST_WS_Guvenlik G, string Kart_No, string SystemRefNo, string IPAdr)
        {
            return await client.Param_FastKolas_DeleteProxyAccountAsync(G, Kart_No, SystemRefNo, IPAdr);
        }
        public async Task<GetRecipientProxyAccountResponse> ParamFastKolasGetRecipientProxyAccountAsync(ST_WS_Guvenlik G, string Kart_No, string AddressType, string AddressValue, string SenderIdentityNo, string IPAdr)
        {
            return await client.Param_FastKolas_GetRecipientProxyAccountAsync(G, Kart_No, AddressType, AddressValue, SenderIdentityNo, IPAdr);
        }
        public async Task<QueryProxyAccountResponse> ParamFastKolasGetTransferProxyAccountAsync(ST_WS_Guvenlik G, string Kart_No, string TransferStartDate, string TransferEndDate, string IPAdr)
        {
            return await client.Param_FastKolas_GetTransferProxyAccountAsync(G, Kart_No, TransferStartDate, TransferEndDate, IPAdr);
        }
        public async Task<QueryProxyAccountResponse> ParamFastKolasQueryProxyAccountAsync(ST_WS_Guvenlik G, string Kart_No, string AddressType, string AddressValue, string IdentityNo, string SystemRefNo, string IPAdr)
        {
            return await client.Param_FastKolas_QueryProxyAccountAsync(G, Kart_No, AddressType, AddressValue, IdentityNo, SystemRefNo, IPAdr);
        }
        public async Task<ProxyAccountResponse> ParamFastKolasUpdateProxyAccountAsync(ST_WS_Guvenlik G, string Kart_No, string SystemRefNo, string IdentityNo, string AddressType, string AddressValue, string AccountOwner, string AccountNo, string AccountType, string TradeName, string InformChannel, string Description, string IPAdr)
        {
            return await client.Param_FastKolas_UpdateProxyAccountAsync(G, Kart_No, SystemRefNo, IdentityNo, AddressType, AddressValue, AccountOwner, AccountNo, AccountType, TradeName, InformChannel, Description, IPAdr);
        }
        public async Task<ST_Transfer_Sonuc> ParamFastTransferYapAsync(ST_WS_Guvenlik G, string Kart_No, string Tip, string Alici_IBAN_Kart_No, string Alici_Unvan, string Tutar, string Aciklama, string Kullanici_Kart_No, string IPAdr, string Uygulama_Tip, int Kredi, int Transfer_Yeri, int Transfer_Tipi, string QueryRefNo, string KolayAdres)
        {
            return await client.Param_Fast_Transfer_YapAsync(G, Kart_No, Tip, Alici_IBAN_Kart_No, Alici_Unvan, Tutar, Aciklama, Kullanici_Kart_No, IPAdr, Uygulama_Tip, Kredi, Transfer_Yeri, Transfer_Tipi, QueryRefNo, KolayAdres);
        }
        public async Task<ST_Genel_Sonuc> ParamIBANIslemAsync(ST_WS_Guvenlik G, string T1, string T2, long SID)
        {
            return await client.Param_IBAN_IslemAsync(G, T1, T2, SID);
        }
        public async Task<ST_Genel_Sonuc> ParamIslemAsync(ST_WS_Guvenlik G, string T1, string T2, long SID)
        {
            return await client.Param_IslemAsync(G, T1, T2, SID);
        }
        public async Task<Param_QR_KontrolResponse> ParamQRKontrolAsync(ServiceSecuritySoapHeader ServiceSecuritySoapHeader, ST_WS_Guvenlik G, string Kart_No, string QR_Data, string Cihaz_UID, string IPAdr, string Uygulama_Tip)
        {
            return await client.Param_QR_KontrolAsync(ServiceSecuritySoapHeader, G, Kart_No, QR_Data, Cihaz_UID, IPAdr, Uygulama_Tip);
        }
        public async Task<ST_Genel_Sonuc> ParamSahtecilikIslemAsync(ST_WS_Guvenlik G, string T1, string T2, long SID)
        {
            return await client.Param_Sahtecilik_IslemAsync(G, T1, T2, SID);
        }
        public async Task<ST_Genel_Sonuc> ParamSanalPOSIslemAsync(ST_WS_Guvenlik G, string T1, string T2, long SID)
        {
            return await client.Param_SanalPOS_IslemAsync(G, T1, T2, SID);
        }
        public async Task<ST_Genel_Sonuc> ParamSanalPOSLimitAsync(ST_WS_Guvenlik G)
        {
            return await client.Param_SanalPOS_LimitAsync(G);
        }
        public async Task<ST_Transfer_Hesap> ParamTransferHesapAsync(ST_WS_Guvenlik G, string Kart_No, string Uygulama_Tip)
        {
            return await client.Param_Transfer_HesapAsync(G, Kart_No, Uygulama_Tip);
        }
        public async Task<Param_Transfer_QR_UretResponse> ParamTransferQRUretAsync(ServiceSecuritySoapHeader ServiceSecuritySoapHeader, ST_WS_Guvenlik G, string Kart_No, string Tutar, string Aciklama, string Odeme_Alan, string Cihaz_UID, string IPAdr, string Uygulama_Tip)
        {
            return await client.Param_Transfer_QR_UretAsync(ServiceSecuritySoapHeader, G, Kart_No, Tutar, Aciklama, Odeme_Alan, Cihaz_UID, IPAdr, Uygulama_Tip);
        }
        public async Task<Param_Transfer_QR_Uret_SuresizResponse> ParamTransferQRUretSuresizAsync(ServiceSecuritySoapHeader ServiceSecuritySoapHeader, ST_WS_Guvenlik G, string Kart_No, string Tutar, string Aciklama, string Odeme_Alan, string Tarih, string Cihaz_UID, string IPAdr, string Uygulama_Tip)
        {
            return await client.Param_Transfer_QR_Uret_SuresizAsync(ServiceSecuritySoapHeader, G, Kart_No, Tutar, Aciklama, Odeme_Alan, Tarih, Cihaz_UID, IPAdr, Uygulama_Tip);
        }
        public async Task<ST_Transfer_Sonuc> ParamTransferYapAsync(ST_WS_Guvenlik G, string Kart_No, string Tip, string Alici_IBAN_Kart_No, string Alici_Unvan, string Tutar, string Aciklama, string Kullanici_Kart_No, string IPAdr, string Uygulama_Tip)
        {
            return await client.Param_Transfer_YapAsync(G, Kart_No, Tip, Alici_IBAN_Kart_No, Alici_Unvan, Tutar, Aciklama, Kullanici_Kart_No, IPAdr, Uygulama_Tip);
        }
        public async Task<Param_Transfer_Yap_QRResponse> ParamTransferYapQRAsync(ServiceSecuritySoapHeader ServiceSecuritySoapHeader, ST_WS_Guvenlik G, string Kart_No, string QR_Data, string Cuzdan, string Cihaz_UID, string IPAdr, string Uygulama_Tip)
        {
            return await client.Param_Transfer_Yap_QRAsync(ServiceSecuritySoapHeader, G, Kart_No, QR_Data, Cuzdan, Cihaz_UID, IPAdr, Uygulama_Tip);
        }
        public async Task<ST_Transfer_Sonuc> ParamTransferYapv2Async(ST_WS_Guvenlik G, string Kart_No, string Tip, string Alici_IBAN_Kart_No, string Alici_Unvan, string Tutar, string Aciklama, string Kullanici_Kart_No, string IPAdr, string Uygulama_Tip, int Kredi)
        {
            return await client.Param_Transfer_Yap_v2Async(G, Kart_No, Tip, Alici_IBAN_Kart_No, Alici_Unvan, Tutar, Aciklama, Kullanici_Kart_No, IPAdr, Uygulama_Tip, Kredi);
        }
        public async Task<ST_Sonuc> PromosyonKodKullanimAsync(ST_WS_Guvenlik G, string Kart_No, string Promosyon_Kodu, string Cihaz_UID, string Uygulama_Tip)
        {
            return await client.Promosyon_Kod_KullanimAsync(G, Kart_No, Promosyon_Kodu, Cihaz_UID, Uygulama_Tip);
        }
        public async Task<ST_Genel_Sonuc> PromosyonKodUretAsync(ST_WS_Guvenlik G, string Kart_No, string Cihaz_UID, string Uygulama_Tip)
        {
            return await client.Promosyon_Kod_UretAsync(G, Kart_No, Cihaz_UID, Uygulama_Tip);
        }
        public async Task<SMS_DogrulamaResponse> SMSDogrulamaAsync(ServiceSecuritySoapHeader ServiceSecuritySoapHeader, ST_WS_Guvenlik G, string Kart_No, string SMS_Onay_Kod, string SMS_Onay_No, string Uygulama_Tip)
        {
            return await client.SMS_DogrulamaAsync(ServiceSecuritySoapHeader, G, Kart_No, SMS_Onay_Kod, SMS_Onay_No, Uygulama_Tip);
        }
        public async Task<ST_Genel_Sonuc> SMSDogrulama3Async(ST_WS_Guvenlik G, string Kart_No, string SMS_Onay_Kod, string SMS_Onay_No, string Uygulama_Tip, string Uygulama_Adi, string Cihaz_UID, string Cihaz_Push_Key)
        {
            return await client.SMS_Dogrulama3Async(G, Kart_No, SMS_Onay_Kod, SMS_Onay_No, Uygulama_Tip, Uygulama_Adi, Cihaz_UID, Cihaz_Push_Key);
        }
        public async Task<SMS_Dogrulama_MobilResponse> SMSDogrulamaMobilAsync(ServiceSecuritySoapHeader ServiceSecuritySoapHeader, ST_WS_Guvenlik G, string Cihaz_UID, string SMS_Onay_Kod, string SMS_Onay_No, string Uygulama_Tip)
        {
            return await client.SMS_Dogrulama_MobilAsync(ServiceSecuritySoapHeader, G, Cihaz_UID, SMS_Onay_Kod, SMS_Onay_No, Uygulama_Tip);
        }
        public async Task<SMS_GonderResponse> SMSGonderAsync(ServiceSecuritySoapHeader ServiceSecuritySoapHeader, ST_WS_Guvenlik G, string Kart_No, string GSM_No, string Aciklama, string Uygulama_Tip)
        {
            return await client.SMS_GonderAsync(ServiceSecuritySoapHeader, G, Kart_No, GSM_No, Aciklama, Uygulama_Tip);
        }
        public async Task<SMS_Gonder2Response> SMSGonder2Async(ServiceSecuritySoapHeader ServiceSecuritySoapHeader, ST_WS_Guvenlik G, string Kart_No, string Aciklama, string Uygulama_Tip)
        {
            return await client.SMS_Gonder2Async(ServiceSecuritySoapHeader, G, Kart_No, Aciklama, Uygulama_Tip);
        }
        public async Task<SMS_Gonder_MobilResponse> SMSGonderMobilAsync(ServiceSecuritySoapHeader ServiceSecuritySoapHeader, ST_WS_Guvenlik G, string Cihaz_UID, string GSM_No, string Uygulama_Tip)
        {
            return await client.SMS_Gonder_MobilAsync(ServiceSecuritySoapHeader, G, Cihaz_UID, GSM_No, Uygulama_Tip);
        }
        public async Task<Sifre_DegistirResponse> SifreDegistirAsync(ServiceSecuritySoapHeader ServiceSecuritySoapHeader, string Kart_No, string Eski_Sifre, string Yeni_Sifre, string Uygulama_Tip)
        {
            return await client.Sifre_DegistirAsync(ServiceSecuritySoapHeader, Kart_No, Eski_Sifre, Yeni_Sifre, Uygulama_Tip);
        }
        public async Task<Sifremi_UnuttumResponse> SifremiUnuttumAsync(ServiceSecuritySoapHeader ServiceSecuritySoapHeader, ST_WS_Guvenlik G, string Kart_No, string IP_Adr, string Uygulama_Tip)
        {
            return await client.Sifremi_UnuttumAsync(ServiceSecuritySoapHeader, G, Kart_No, IP_Adr, Uygulama_Tip);
        }
        public async Task<ST_Sonuc> SurumKontrolAsync(ST_WS_Guvenlik G, string Surum, string Mobil_Tip, string Uygulama_Tip)
        {
            return await client.Surum_KontrolAsync(G, Surum, Mobil_Tip, Uygulama_Tip);
        }
        public async Task<string> TC2ImgAsync(ST_WS_Guvenlik G, string Tip, string Kart_Tip, string Kisi_TC)
        {
            return await client.TC2ImgAsync(G, Tip, Kart_Tip, Kisi_TC);
        }
        public async Task<ST_Genel_Sonuc> TLYukleKomisyonBilgiAsync(ST_WS_Guvenlik G, string Kart_No, string KK_No, int Taksit, string Tutar, string KK_AY, string KK_YIL, string CVV)
        {
            return await client.TL_Yukle_Komisyon_BilgiAsync(G, Kart_No, KK_No, Taksit, Tutar, KK_AY, KK_YIL, CVV);
        }
        public async Task<ST_TL_Yukle_UCD> TLYukleUCDAsync(ST_WS_Guvenlik G, string Kart_No, double Tutar, string SanalPOS_ID, string SanalPOS_Tip, int SanalPOS_Taksit, string KK_No, string KK_Sahibi, string KK_SK_Ay, string KK_SK_Yil, string KK_CVC, string Ip_Adr, string Uygulama_Tip, string Uygulama_Adi, string Odeme_Imza)
        {
            return await client.TL_Yukle_UCDAsync(G, Kart_No, Tutar, SanalPOS_ID, SanalPOS_Tip, SanalPOS_Taksit, KK_No, KK_Sahibi, KK_SK_Ay, KK_SK_Yil, KK_CVC, Ip_Adr, Uygulama_Tip, Uygulama_Adi, Odeme_Imza);
        }
        public async Task<ST_Sonuc> TokenOlusturAsync(ST_WS_Guvenlik G)
        {
            return await client.Token_OlusturAsync(G);
        }
        public async Task<ST_Transfer_Komisyon_Islem> TransferFastKomisyonIslemv2Async(ST_WS_Guvenlik G, string Kart_No, string Transfer_Tutari, string Transfer_Tip, int Kredi, string Uygulama_Tip, string Alici_Kart_No)
        {
            return await client.Transfer_FastKomisyon_Islem_v2Async(G, Kart_No, Transfer_Tutari, Transfer_Tip, Kredi, Uygulama_Tip, Alici_Kart_No);
        }
        public async Task<ST_Transfer_Komisyon_Islem> TransferKomisyonIslemAsync(ST_WS_Guvenlik G, string Kart_No, string Transfer_Tutari, string Transfer_Tip)
        {
            return await client.Transfer_Komisyon_IslemAsync(G, Kart_No, Transfer_Tutari, Transfer_Tip);
        }
        public async Task<ST_Transfer_Komisyon_Islem> TransferKomisyonIslemv2Async(ST_WS_Guvenlik G, string Kart_No, string Transfer_Tutari, string Transfer_Tip, int Kredi, string Uygulama_Tip, string Alici_Kart_No)
        {
            return await client.Transfer_Komisyon_Islem_v2Async(G, Kart_No, Transfer_Tutari, Transfer_Tip, Kredi, Uygulama_Tip, Alici_Kart_No);
        }
        public async Task<ST_Sonuc> TroyKuryeSorgulaAsync(string Barkod_No)
        {
            return await client.Troy_Kurye_SorgulaAsync(Barkod_No);
        }
        public async Task<ST_Sonuc> TurkPosBasvuruAsync(ST_WS_Guvenlik G, string Tip, string Kisi_Adi, string Kisi_Soyadi, string GSM, string EPosta, string Firma_Unvan, string Mersis_No, string Sektor, string VD, string VN, string Adres, string Adres_Il, string Adres_Ilce, string Web_Site, string IPAdr, string Uygulama_Tip, string AylikCiro)
        {
            return await client.TurkPos_BasvuruAsync(G, Tip, Kisi_Adi, Kisi_Soyadi, GSM, EPosta, Firma_Unvan, Mersis_No, Sektor, VD, VN, Adres, Adres_Il, Adres_Ilce, Web_Site, IPAdr, Uygulama_Tip, AylikCiro);
        }
        public async Task<ST_Sonuc> TurkPosBasvuruDosyaAsync(ST_WS_Guvenlik G, string Basvuru_ID, string Dosya_Tip, string Dosya_B64, string Ext, string IPAdr, string Uygulama_Tip)
        {
            return await client.TurkPos_Basvuru_DosyaAsync(G, Basvuru_ID, Dosya_Tip, Dosya_B64, Ext, IPAdr, Uygulama_Tip);
        }
        public async Task<ST_Sonuc> TurkPosBasvuruDurumAsync(ST_WS_Guvenlik G, string VN, string IPAdr, string Uygulama_Tip)
        {
            return await client.TurkPos_Basvuru_DurumAsync(G, VN, IPAdr, Uygulama_Tip);
        }
        public async Task<ST_UCD_Islem_Odeme_Sor> UCDIslemOdemeSorAsync(ST_WS_Guvenlik G, string Kart_No, string Islem_ID, string Uygulama_Tip)
        {
            return await client.UCD_Islem_Odeme_SorAsync(G, Kart_No, Islem_ID, Uygulama_Tip);
        }
        public async Task<ST_Sonuc> UygulamaOnermeAsync(ST_WS_Guvenlik G, string Kart_No, string Kisi_Oneren, string Kisi_Onerilen, string EPosta_Onerilen, string Mobil_Tip, string Uygulama_Tip, string IPAdr)
        {
            return await client.Uygulama_OnermeAsync(G, Kart_No, Kisi_Oneren, Kisi_Onerilen, EPosta_Onerilen, Mobil_Tip, Uygulama_Tip, IPAdr);
        }
        public async Task<WebSite_IcerikResponse> WebSiteIcerikAsync(ServiceSecuritySoapHeader ServiceSecuritySoapHeader, ST_WS_Guvenlik G, string Host, string Uygulama_Tip)
        {
            return await client.WebSite_IcerikAsync(ServiceSecuritySoapHeader, G, Host, Uygulama_Tip);
        }
    }
}