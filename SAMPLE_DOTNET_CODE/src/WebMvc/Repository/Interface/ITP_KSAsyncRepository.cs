using TP_KS;

namespace WebMvc.Repository.Interface
{
    public interface ITP_KSAsyncRepository
    {
        /// <summary>Kart ekleme işlemini uygular.</summary>
        /// <param name="G">ST_WS_Guvenlik Nesnesi (Zorunlu)</param>
        ///     ST_WS_Guvenlik Nesnesi:
        ///         CLIENT_CODE: Terminal ID (Zorunlu)
        ///         CLIENT_USERNAME: Kullanıcı Adı (Zorunlu)
        ///         CLIENT_PASSWORD: Şifre (Zorunlu)
        /// <param name="GUID">GUID Değeri (Zorunlu)</param>
        /// <param name="KK_Sahibi">Kredi Kartı Sahibi (Zorunlu)</param>
        /// <param name="KK_No">Kredi Kartı Numarası (Zorunlu)</param>
        /// <param name="KK_SK_Ay">Son Kullanma Tarihi (Ay - Zorunlu)</param>
        /// <param name="KK_SK_Yil">Son Kullanma Tarihi (Yıl - Zorunlu)</param>
        /// <param name="KK_Kart_Adi">Eklenecek Kredi Kartı Adı</param>
        /// <param name="KK_Islem_ID">Eklenecek Kredi Kartına Ait Tarafınıza İletilecek Tekil ID Değeri</param>
        /// <returns>ST_KS_Kart_Ekle Nenesi</returns>
        ///     ST_KS_Kart_Ekle:
        ///         Sonuc: İşlem Sonucu
        ///         Sonuc_Str: İşlem Sonucunun Açıklaması
        ///         KS_GUID: Kart Ekleme GUID Değeri
        public Task<ST_KS_Kart_Ekle> KSKartEkleAsync(ST_WS_Guvenlik G, string GUID, string KK_Sahibi, string KK_No, string KK_SK_Ay, string KK_SK_Yil, string KK_Kart_Adi, string KK_Islem_ID);
        /// <summary>Saklı kartların listelenmesi işlemini uygular.</summary>
        /// <param name="G">ST_WS_Guvenlik Nesnesi (Zorunlu)</param>
        ///     ST_WS_Guvenlik Nesnesi:
        ///         CLIENT_CODE: Terminal ID (Zorunlu)
        ///         CLIENT_USERNAME: Kullanıcı Adı (Zorunlu)
        ///         CLIENT_PASSWORD: Şifre (Zorunlu)
        /// <param name="GUID">Üye İşyeri Kart No (Zorunlu)</param>
        /// <param name="KK_Kart_Adi">Kartı Eklenmiş Kişinin Adı</param>
        /// <param name="KK_Islem_ID">Kart Ekleme İşleminin ID'si</param>
        /// <returns>ST_KS_Kart_Liste Nenesi</returns>
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
        public Task<ST_KS_Kart_Liste> KSKartListeAsync(ST_WS_Guvenlik G, string GUID, string KK_Kart_Adi, string KK_Islem_ID);
        public Task<ST_KS_Kart_Liste> KSKartListePaginationAsync(ST_WS_Guvenlik G, string GUID, string KK_Kart_Adi, string KK_Islem_ID, string sayfa_Sayi, string sayfa_index);
        /// <summary>Kart silme işlemini uygular.</summary>
        /// <param name="G">ST_WS_Guvenlik Nesnesi (Zorunlu)</param>
        ///     ST_WS_Guvenlik Nesnesi:
        ///         CLIENT_CODE: Terminal ID (Zorunlu)
        ///         CLIENT_USERNAME: Kullanıcı Adı (Zorunlu)
        ///         CLIENT_PASSWORD: Şifre (Zorunlu)
        /// <param name="KS_GUID">Saklı Kartın GUID Değeri</param>
        /// <param name="KK_Islem_ID">Eklenecek Kredi Kartına Ait Tarafınıza İletilecek Tekil ID Değeri</param>
        /// <returns>ST_Sonuc Nenesi</returns>
        ///     ST_Sonuc:
        ///         Sonuc: İşlem Sonucu
        ///         Sonuc_Str: İşlem Sonucunun Açıklaması
        public Task<ST_Sonuc> KSKartSilAsync(ST_WS_Guvenlik G, string KS_GUID, string KK_Islem_ID);
        /// <summary>Saklanmış kredi kartından tahsilat yapmak için kullanılır.</summary>
        /// <param name="G">ST_WS_Guvenlik Nesnesi (Zorunlu)</param>
        ///     ST_WS_Guvenlik Nesnesi:
        ///         CLIENT_CODE: Terminal ID (Zorunlu)
        ///         CLIENT_USERNAME: Kullanıcı Adı (Zorunlu)
        ///         CLIENT_PASSWORD: Şifre (Zorunlu)
        /// <param name="GUID">ParamPOS GUID Değeri (Zorunlu)</param>
        /// <param name="KS_GUID">KS_Kart_Ekle Metodundan Dönen GUID Değeri</param>
        /// <param name="CVV">CVV Kodu (3D işlemler için girilmelidir. Nonsecure işlemler için boş geçilebilir.)</param>
        /// <param name="KK_Sahibi_GSM">Kredi Kartı Sahibi GSM No (Başında 0 Olmadan - Zorunlu)</param>
        /// <param name="Hata_URL">Ödeme İşlemi Başarısız Olursa Yönlenecek Sayfa Adresi (Zorunlu)</param>
        /// <param name="Basarili_URL">Ödeme İşlemi Başarılı Olursa Yönlenecek Sayfa Adresi (Zorunlu)</param>
        /// <param name="Siparis_ID">Siparişe Özel Tekil ID (Zorunlu)</param>
        /// <param name="Siparis_Aciklama">Siparişe Ait Açıklama</param>
        /// <param name="Taksit">Seçilen Taksit Sayısı (Tek çekim için 1 gönderiniz. - Zorunlu)</param>
        /// <param name="Islem_Tutar">Sipariş Tutarı (Virgüllü - Zorunlu)</param>
        /// <param name="Toplam_Tutar">Komisyon Dahil Sipariş Tutarı (Virgüllü - Zorunlu)</param>
        /// <param name="Islem_Guvenlik_Tip">Güvenlik Tipi (NS (NonSecure) veya 3D gönderilir. - Zorunlu)</param>
        /// <param name="Islem_ID">İşleme Ait Sipariş ID haricinde Tekil ID </param>
        /// <param name="IPAdr">IP Adresi</param>
        /// <param name="Ref_URL">Ödemenin Gerçekleştiği Sayfanın URL'i</param>
        /// <param name="Data1">Extra Alan 1</param>
        /// <param name="Data2">Extra Alan 2</param>
        /// <param name="Data3">Extra Alan 3</param>
        /// <param name="Data4">Extra Alan 4</param>
        /// <param name="KK_Islem_ID">Kartına Ait Tarafınızdan İletilen Tekil ID Değeri</param>
        /// <returns>ST_TP_Islem_Odeme Nenesi</returns>
        ///     ST_TP_Islem_Odeme:
        ///         Islem_ID: SID Değeri
        ///         UCD_URL: 3D URL'i
        ///         Sonuc: İşlem Sonucu
        ///         Sonuc_Str: İşlem Sonucunun Açıklaması
        public Task<ST_TP_Islem_Odeme> KSTahsilatAsync(ST_WS_Guvenlik G, string GUID, string KS_GUID, string CVV, string KK_Sahibi_GSM, string Hata_URL, string Basarili_URL, string Siparis_ID, string Siparis_Aciklama, int Taksit, string Islem_Tutar, string Toplam_Tutar, string Islem_Guvenlik_Tip, string Islem_ID, string IPAdr, string Ref_URL, string Data1, string Data2, string Data3, string Data4, string KK_Islem_ID);
        public Task<ST_TP_Islem_Odeme> KSTahsilatColendiAsync(ST_WS_Guvenlik G, string MGUID, string GUID, string KS_GUID, string CVV, string KK_Sahibi_GSM, string Hata_URL, string Basarili_URL, string Siparis_ID, string Siparis_Aciklama, int Taksit, string Islem_Tutar, string Toplam_Tutar, string Islem_Guvenlik_Tip, string Islem_ID, string IPAdr, string Ref_URL, string Data1, string Data2, string Data3, string Data4, string KK_Islem_ID);
    }
}