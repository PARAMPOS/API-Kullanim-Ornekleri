using TurkPosWSTEST;

namespace WebMvc.Repository.Interface
{
    public interface ITurkPosWSTESTAsyncRepository
    {
        /// <summary>Kredi kartına ait kart-banka bilgisini ve SanalPOS_ID değerini dönme işlemini uygular.</summary>
        /// <param name="G">ST_WS_Guvenlik Nesnesi (Zorunlu)</param>
        ///     ST_WS_Guvenlik Nesnesi:
        ///         CLIENT_CODE: Terminal ID (Zorunlu)
        ///         CLIENT_USERNAME: Kullanıcı Adı (Zorunlu)
        ///         CLIENT_PASSWORD: Şifre (Zorunlu)
        /// <param name="BIN">BIN Değeri (Boş bırakılırsa tüm BIN kodları döner; dolu gönderilirse BIN koduna ait bilgiler döner.)</param>
        /// <returns>ST_Genel_Sonuc Nesnesi</returns>
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
        public Task<ST_Genel_Sonuc> BINSanalPosAsync(ST_WS_Guvenlik G, string BIN);
        public Task<ST_Genel_Sonuc> BINSanalPos2Async(ST_WS_Guvenlik G, string BIN);
        /// <summary>İllerin listesine ulaşma işlemini uygular.</summary>
        /// <param name="G">ST_WS_Guvenlik Nesnesi (Zorunlu)</param>
        ///     ST_WS_Guvenlik Nesnesi:
        ///         CLIENT_CODE: Terminal ID (Zorunlu)
        ///         CLIENT_USERNAME: Kullanıcı Adı (Zorunlu)
        ///         CLIENT_PASSWORD: Şifre (Zorunlu)
        /// <returns>ST_Sonuc_DT Nesnesi</returns>
        ///     ST_Sonuc_DT:
        ///         Sonuc: İşlem Sonucu
        ///         Sonuc_Str: İşlem Sonucunun Açıklaması
        ///         DT_Bilgi:
        ///             Plaka: İl Kodu
        ///             IL: İl Adı
        public Task<ST_Sonuc_DT> IlListeAsync(ST_WS_Guvenlik G);
        /// <summary>Kart saklama işlemini uygular.</summary>
        /// <param name="G">ST_WS_Guvenlik Nesnesi (Zorunlu)</param>
        ///     ST_WS_Guvenlik Nesnesi:
        ///         CLIENT_CODE: Terminal ID (Zorunlu)
        ///         CLIENT_USERNAME: Kullanıcı Adı (Zorunlu)
        ///         CLIENT_PASSWORD: Şifre (Zorunlu)
        /// <param name="Kart_No">Kart Numarası (Zorunlu)</param>
        /// <param name="KK_Sahibi">Kredi Kartı Sahibi (Zorunlu)</param>
        /// <param name="KK_No">Kredi Kartı Numarası (Zorunlu)</param>
        /// <param name="KK_SK_Ay">Son Kullanma Tarihi (Ay - Zorunlu)</param>
        /// <param name="KK_SK_Yil">Son Kullanma Tarihi (Yıl - Zorunlu)</param>
        /// <param name="KK_CVV">CVV Kodu (Zorunlu)</param>
        /// <param name="Data1">Extra Alan 1</param>
        /// <param name="Data2">Extra Alan 2</param>
        /// <param name="Data3">Extra Alan 3</param>
        /// <returns>ST_KK_Saklama Nenesi</returns>
        ///     ST_KK_Saklama:
        ///         GUID: GUID Değeri
        ///         Sonuc: İşlem Sonucu
        ///         Sonuc_Str: İşlem Sonucunun Açıklaması
        public Task<ST_KK_Saklama> KKSaklamaAsync(ST_WS_Guvenlik G, string Kart_No, string KK_Sahibi, string KK_No, string KK_SK_Ay, string KK_SK_Yil, string KK_CVV, string Data1, string Data2, string Data3);
        /// <summary>Saklı kartların listelenmesi işlemini uygular.</summary>
        /// <param name="G">ST_WS_Guvenlik Nesnesi (Zorunlu)</param>
        ///     ST_WS_Guvenlik Nesnesi:
        ///         CLIENT_CODE: Terminal ID (Zorunlu)
        ///         CLIENT_USERNAME: Kullanıcı Adı (Zorunlu)
        ///         CLIENT_PASSWORD: Şifre (Zorunlu)
        /// <param name="Kart_No">Üye İşyeri Kart No (Zorunlu)</param>
        /// <param name="KS_KK_Kisi_ID">Kartı Saklanmış Kişinin T.C. Kimlik Numarası veya Kişiye Ait 11 Haneli Tekil Değeri</param>
        /// <returns>ST_Genel_Sonuc Nenesi</returns>
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
        public Task<ST_Genel_Sonuc> KKSakliListeAsync(ST_WS_Guvenlik G, string Kart_No, string KS_KK_Kisi_ID);
        public Task<CL_Res_MP_OCR> MPOrderCancelRefundAsync(CL_Req_MP_OCR d);
        public Task<CL_Res_MP_ODA> MPOrderDetailAddAsync(CL_Req_MP_ODA d);
        public Task<CL_Res_MP_ODL> MPOrderDetailListAsync(CL_Req_MP_ODL d);
        public Task<CL_Res_MP_ODQ> MPOrderDetailQueryAsync(CL_Req_MP_ODQ d);
        public Task<CL_Res_MP_ODS> MPOrderDetailStatusAsync(CL_Req_MP_ODS d);
        public Task<CL_Res_MP_ODU> MPOrderDetailUpdateAsync(CL_Req_MP_ODU d);
        public Task<ST_Genel_Sonuc> MoneyPayIslemSorgulamaAsync(ST_WS_Guvenlik G, string GUID, string Siparis_ID, string Tarih_Bas, string Tarih_Bit);
        public Task<IslemIzlemeRes> ParamPazaryeriIslemIzlemeAsync(ST_WS_Guvenlik G, IslemIzlemeReq islemIzlemeReq);
        public Task<CL_Res_Payment_Hopi> PaymentHopiAsync(CL_Req_Payment_Hopi d);
        /// <summary>Pazaryerine alt üye işyerini ekleme işlemini uygular.</summary>
        /// <param name="G">ST_WS_Guvenlik Nesnesi (Zorunlu)</param>
        ///     ST_WS_Guvenlik Nesnesi:
        ///         CLIENT_CODE: Terminal ID (Zorunlu)
        ///         CLIENT_USERNAME: Kullanıcı Adı (Zorunlu)
        ///         CLIENT_PASSWORD: Şifre (Zorunlu)
        /// <param name="ETS_GUID">Pazaryerine Ait GUID Değeri (Zorunlu)</param>
        /// <param name="Tip">Alt Üye İşyeri Tipi (1: Bireysel Müşteri, 2: Şahıs Şirketi, 3 = Limited / Anonim Şirket - Zorunlu)</param>
        /// <param name="Ad_Soyad">Kişi Adı ve Soyadı (Zorunlu)</param>
        /// <param name="Unvan">Firma Ünvanı (Zorunlu)</param>
        /// <param name="TC_VN">Müşteri Tipi girişine göre; TC Kimlik Numarası ya da Vergi Numarası yazılır (1. tip ve 2. tip için TC Numarası zorunludur, 3. tip için vergi numarası zorunludur.).</param>
        /// <param name="Kisi_DogumTarihi">Doğum Tarihi (Örn. dd.MM.yyyy - 1. ve 2. tip için zorunludur.)</param>
        /// <param name="GSM_No">Üye İşyeri GSM (Örn. 5xx123xxxx - Zorunlu)</param>
        /// <param name="IBAN_No">Üye İşyeri IBAN Numarası (Zorunlu)</param>
        /// <param name="IBAN_Unvan">Üye İşyeri IBAN Numarasına Ait Ad-Soyad/Unvan Bilgisi (Zorunlu)</param>
        /// <param name="Adres">Üye İşyeri Adresi (Zorunlu)</param>
        /// <param name="Il">Mernis İl Kodu (Zorunlu)</param>
        /// <param name="Ilce">Mernis İlçe Kodu (Zorunlu)</param>
        /// <param name="EPosta">Üye İşyeri E-Posta Adresi</param>
        /// <param name="Website">Üye İşyeri Web Adresi</param>
        /// <param name="MCC_Kod">Ürün Kategori Kodu</param>
        /// <param name="Yetkili_Kisi_TC">Yetkili Kişi TC kimlik Numarası (Müşteri tip bilgisi 3. tip olarak gönderildi ise zorunludur.</param>
        /// <param name="Yetkili_Kisi_DogumTarihi">Doğum Tarihi (Örn. dd.MM.yyyy - Yetkili_Kisi_TC parametresi girildi ise zorunludur.)</param>
        /// <param name="Vergi_Daire">Vergi Daire Alanı (2. tip ve 3. tip olarak gönderildi ise her koşulda zorunludur.)</param>
        /// <param name="Bagli_Olunan_Hesap">Bağlı Olunan Hesap</param>
        /// <returns>Sonuc_Uyelik Nenesi</returns>
        ///     Sonuc_Uyelik:
        ///         Sonuc: İşlem Sonucu
        ///         Sonuc_Str: İşlem Sonucunun Açıklaması
        ///         GUID_AltUyeIsyeri: Alt Üye İş Yerinin GUID Değeri
        public Task<Sonuc_Uyelik> PazaryeriTPAltUyeIsyeriEklemeAsync(ST_WS_Guvenlik G, string ETS_GUID, int Tip, string Ad_Soyad, string Unvan, string TC_VN, string Kisi_DogumTarihi, string GSM_No, string IBAN_No, string IBAN_Unvan, string Adres, string Il, string Ilce, string EPosta, string Website, string MCC_Kod, string Yetkili_Kisi_TC, string Yetkili_Kisi_DogumTarihi, string Vergi_Daire, string Bagli_Olunan_Hesap);
        public Task<Sonuc_Uyelik> PazaryeriTPAltUyeIsyeriEklemev2Async(ST_WS_Guvenlik G, string ETS_GUID, int Tip, string Ad_Soyad, string Unvan, string TC_VN, string Kisi_DogumTarihi, string GSM_No, string IBAN_No, string IBAN_Unvan, string Adres, string Il, string Ilce, string EPosta, string Website, string MCC_Kod, string Yetkili_Kisi_TC, string Yetkili_Kisi_DogumTarihi, string Vergi_Daire, string Bagli_Olunan_Hesap, string SAPId, string MagentoId);
        /// <summary>Pazaryerine eklenen alt üye işyerini bilgilerini güncelleme işlemini uygular.</summary>
        /// <param name="G">ST_WS_Guvenlik Nesnesi (Zorunlu)</param>
        ///     ST_WS_Guvenlik Nesnesi:
        ///         CLIENT_CODE: Terminal ID (Zorunlu)
        ///         CLIENT_USERNAME: Kullanıcı Adı (Zorunlu)
        ///         CLIENT_PASSWORD: Şifre (Zorunlu)
        /// <param name="GUID_AltUyeIsyeri">Alt Üye İş Yerinine Ait GUID Değeri (Zorunlu)</param>
        /// <param name="Ad_Soyad">Kişi Adı ve Soyadı</param>
        /// <param name="Unvan">Firma Ünvanı</param>
        /// <param name="GSM_No">Üye İşyeri GSM (Örn. 5xx123xxxx)</param>
        /// <param name="IBAN_No">Üye İşyeri IBAN Numarası</param>
        /// <param name="IBAN_Unvan">IBAN'a Ait Firma Ünvanı</param>
        /// <param name="Adres">Üye İşyeri Adresi</param>
        /// <param name="Il">Mernis İl Kodu</param>
        /// <param name="Ilce">Mernis İlçe Kodu</param>
        /// <param name="EPosta">Üye İşyeri E-Posta Adresi</param>
        /// <param name="Website">Üye İşyeri Web Adresi</param>
        /// <param name="MCC_Kod">Ürün Kategori Kodu</param>
        /// <param name="Vergi_Daire">Vergi Daire Alanı (Zorunlu)</param>
        /// <param name="Bagli_Olunan_Hesap">Bağlı Olunan Hesap</param>
        /// <returns>Sonuc_Uyelik Nenesi</returns>
        ///     Sonuc_Uyelik:
        ///         Sonuc: İşlem Sonucu
        ///         Sonuc_Str: İşlem Sonucunun Açıklaması
        ///         GUID_AltUyeIsyeri: Alt Üye İş Yerinin GUID Değeri
        public Task<Sonuc_Uyelik> PazaryeriTPAltUyeIsyeriGuncellemeAsync(ST_WS_Guvenlik G, string GUID_AltUyeIsyeri, string Ad_Soyad, string Unvan, string GSM_No, string IBAN_No, string IBAN_Unvan, string Adres, string Il, string Ilce, string EPosta, string Website, string MCC_Kod, string Vergi_Daire, string Bagli_Olunan_Hesap);
        public Task<Sonuc_Uyelik> PazaryeriTPAltUyeIsyeriGuncellemev2Async(ST_WS_Guvenlik G, string GUID_AltUyeIsyeri, string Ad_Soyad, string Unvan, string GSM_No, string IBAN_No, string IBAN_Unvan, string Adres, string Il, string Ilce, string EPosta, string Website, string MCC_Kod, string Vergi_Daire, string Bagli_Olunan_Hesap, string SAPId, string MagentoId);
        /// <summary>Pazaryerine ait alt üye işyerlerini listeleme işlemini uygular.</summary>
        /// <param name="G">ST_WS_Guvenlik Nesnesi (Zorunlu)</param>
        ///     ST_WS_Guvenlik Nesnesi:
        ///         CLIENT_CODE: Terminal ID (Zorunlu)
        ///         CLIENT_USERNAME: Kullanıcı Adı (Zorunlu)
        ///         CLIENT_PASSWORD: Şifre (Zorunlu)
        /// <param name="ETS_GUID">Pazaryerine Ait GUID Değeri (Zorunlu)</param>
        /// <param name="Limit">Pazaryerine Ait Alt Üye Listesinin Toplam Çekebilecegi Sayı, Limit</param>
        /// <param name="Skip">Pazaryerine Ait Alt Üye Listesinin Çekilmeye Başlayacağı Nokta</param>
        /// <returns>Sonuc_Uyelik_Liste Nenesi</returns>
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
        public Task<Sonuc_Uyelik_Liste> PazaryeriTPAltUyeIsyeriListeAsync(ST_WS_Guvenlik G, string ETS_GUID, string Limit, string Skip);
        /// <summary>Pazaryerine eklenen alt üye işyerini silme işlemini uygular.</summary>
        /// <param name="G">ST_WS_Guvenlik Nesnesi (Zorunlu)</param>
        ///     ST_WS_Guvenlik Nesnesi:
        ///         CLIENT_CODE: Terminal ID (Zorunlu)
        ///         CLIENT_USERNAME: Kullanıcı Adı (Zorunlu)
        ///         CLIENT_PASSWORD: Şifre (Zorunlu)
        /// <param name="GUID_AltUyeIsyeri">Alt Üye İş Yerinin GUID Değeri (Zorunlu)</param>
        /// <returns>object (Sonuc_Uyelik)</returns>
        ///     object (Sonuc_Uyelik):
        ///         Sonuc_Uyelik:
        ///             Sonuc: İşlem Sonucu
        ///             Sonuc_Str: İşlem Sonucunun Açıklaması
        ///             GUID_AltUyeIsyeri: Alt Üye İş Yerinin GUID Değeri
        public Task<object> PazaryeriTPAltUyeIsyeriSilmeAsync(ST_WS_Guvenlik G, string GUID_AltUyeIsyeri);
        /// <summary>Pazaryerinde üye işyerinin belirli tarihler arasındaki işlemleri sorgulaması işlemini uygular.</summary>
        /// <param name="G">ST_WS_Guvenlik Nesnesi (Zorunlu)</param>
        ///     ST_WS_Guvenlik Nesnesi:
        ///         CLIENT_CODE: Terminal ID (Zorunlu)
        ///         CLIENT_USERNAME: Kullanıcı Adı (Zorunlu)
        ///         CLIENT_PASSWORD: Şifre (Zorunlu)
        /// <param name="PYSiparis_GUID">Pazaryeri Sipariş GUID Değeri (Pazaryeri_TP_Siparis_Detay_Ekle Metodunun Sonucu)</param>
        /// <param name="GUID">Üye İşyerine Ait Anahtar (Zorunlu)</param>
        /// <param name="Durum">İptal için IPTAL İade için IADE yazılır (Zorunlu).</param>
        /// <param name="Siparis_ID">İşlemin Sipariş ID Değeri (Pos_Odeme Metodunun Sonucu - Zorunlu)</param>
        /// <param name="SiparisTutar">Sipariş Tutarı (0 ise tutarın tamamı iade edilir; 0'dan büyük bir değer gönderilirse kısmi iptal/iade işlemi gerçekleştirilir. - Zorunlu)</param>
        /// <param name="OdenecekTutar">Satıcıya Ödenecek Güncel Tutar (Zorunlu)</param>
        /// <returns>STC_SonucII Nenesi</returns>
        ///     STC_SonucII:
        ///         Durum: Durum Kodu
        ///         Durum_Str: Durum Açıklaması
        ///         Sonuc: İşlem Sonucu
        ///         Sonuc_Str: İşlem Sonucunun Açıklaması (Sonuc değeri 0'dan büyükse işlem başarılıdır, aksi halde başarısızdır.)
        public Task<STC_SonucII> PazaryeriTPIptalIadeAsync(ST_WS_Guvenlik G, string PYSiparis_GUID, string GUID, string Durum, string Siparis_ID, double SiparisTutar, double OdenecekTutar);
        /// <summary>Pazaryerinde üye işyerinin belirli tarihler arasındaki işlemleri sorgulaması işlemini uygular.</summary>
        /// <param name="G">ST_WS_Guvenlik Nesnesi (Zorunlu)</param>
        ///     ST_WS_Guvenlik Nesnesi:
        ///         CLIENT_CODE: Terminal ID (Zorunlu)
        ///         CLIENT_USERNAME: Kullanıcı Adı (Zorunlu)
        ///         CLIENT_PASSWORD: Şifre (Zorunlu)
        /// <param name="ETS_GUID">Pazaryerine Ait GUID Değeri (Zorunlu)</param>
        /// <param name="GUID_AltUyeIsyeri">Alt Üye İş Yerinin GUID Değeri (Girilerek sorgulandığında, alt üyeye ait tüm işlemler getirilir.)</param>
        /// <param name="PYSiparis_GUID">Pazaryeri Sipariş GUID Değeri (Param tarafında üretilen, pazaryerine ait siparişe ait bilgileri getirir.)</param>
        /// <param name="SanalPOS_Islem_ID">SanalPOS İşlem ID (Ödeme ile ilgili tüm sipariş bilgilerini getirir.)</param>
        /// <param name="Tarih_Bas">Başlangıç Tarihi (dd.MM.yyyy HH:mm:ss – 20.11.2015 00:00:00)</param>
        /// <param name="Tarih_Bit">Bitiş Tarihi (dd.MM.yyyy HH:mm:ss – 20.11.2015 15:15:00)</param>
        /// <returns>ST_Genel_Sonuc Nenesi</returns>
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
        public Task<ST_Genel_Sonuc> PazaryeriTPIslemSorgulamaAsync(ST_WS_Guvenlik G, string ETS_GUID, string GUID_AltUyeIsyeri, string PYSiparis_GUID, long SanalPOS_Islem_ID, string Tarih_Bas, string Tarih_Bit);
        /// <summary>Pazaryeri Bireysel Müşteri limitinin kontrol edilme işlemini uygular.</summary>
        /// <param name="ETS_GUID">Pazaryeri GUID Değeri (Zorunlu)</param>
        /// <param name="GUID_AltUyeIsyeri">Alt Üye İş Yerinin GUID Değeri (Girilerek sorgulandığında, alt üyeye ait tüm işlemler getirilir.)</param>
        /// <param name="Tutar_Odenecek">Ödenecek Tutar (Zorunlu)</param>
        /// <returns>Sonuc_Limit2 Nenesi</returns>
        ///     Sonuc_Limit2:
        ///         Sonuc: İşlem Sonucu
        ///         Sonuc_Str: İşlem Sonucunun Açıklaması
        ///         AltUyeIsyeri: Alt Üye İşyeri Bilgisi
        ///         Odeme_Alma_Durumu: True/False olarak dönmektedir (True ise müşteri limiti aşmamış demektir. Ödeme alınarak, sipariş eklenebilir. False ise limit yetersiz; ödeme alınmaz ve sipariş eklenemez.).
        ///         Toplam_Tahsilat_Tutari: Toplam Tahsilat Tutari
        ///         Pazaryeri_Limit: Pazaryeri Bireysel Müşteri Harcama Limiti
        ///         Yeni_Odenecek_Tutar: Yeni Ödenecek Tutar
        public Task<Sonuc_Limit2> PazaryeriTPLimitKontrolAsync(string ETS_GUID, string GUID_AltUyeIsyeri, string Tutar_Odenecek);
        /// <summary>
        ///     Pazaryerine sipariş detaylarının eklenmesi işlemini uygular.<br />
        ///     KURAL:Tutar_Urun ve Tutar_Odenecek parametreleri için gönderilecek tutar bilgisi; ödeme işleminden dönen Net Tutar bilgisinden büyük olamaz (Sonuc_Str = “Net tutar aşıldı.”).
        /// </summary>
        /// <param name="G">ST_WS_Guvenlik Nesnesi (Zorunlu)</param>
        ///     ST_WS_Guvenlik Nesnesi:
        ///         CLIENT_CODE: Terminal ID (Zorunlu)
        ///         CLIENT_USERNAME: Kullanıcı Adı (Zorunlu)
        ///         CLIENT_PASSWORD: Şifre (Zorunlu)
        /// <param name="ETS_GUID">Pazaryeri GUID Değeri (Zorunlu)</param>
        /// <param name="Tutar_Urun">Toplam Ürün Tutarı (Zorunlu)</param>
        /// <param name="Tutar_Odenecek">Ödenecek Tutar (Zorunlu)</param>
        /// <param name="SanalPOS_Islem_ID">SanalPOS İşlem ID (Zorunlu)</param>
        /// <param name="GUID_AltUyeIsyeri">Alt Üye İş Yerinine Ait GUID Değeri (Zorunlu)</param>
        /// <returns>SE_Sonuc Nenesi</returns>
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
        public Task<SE_Sonuc> PazaryeriTPSiparisDetayEkleAsync(ST_WS_Guvenlik G, string ETS_GUID, string Tutar_Urun, string Tutar_Odenecek, string SanalPOS_Islem_ID, string GUID_AltUyeIsyeri);
        /// <summary>Pazaryerinde, işlem sorunsuz tamamlandıysa para transferi için ürüne onay verilmesi işlemini uygular.</summary>
        /// <param name="G">ST_WS_Guvenlik Nesnesi (Zorunlu)</param>
        ///     ST_WS_Guvenlik Nesnesi:
        ///         CLIENT_CODE: Terminal ID (Zorunlu)
        ///         CLIENT_USERNAME: Kullanıcı Adı (Zorunlu)
        ///         CLIENT_PASSWORD: Şifre (Zorunlu)
        /// <param name="PYSiparis_GUID">Pazaryeri Sipariş GUID Değeri (Zorunlu)</param>
        /// <param name="Durum">
        ///     Sipariş Durum Kodu (Zorunlu)<br />
        ///     0: Onay Bekliyor<br />
        ///     1: Onaylandı (Durum 1 ise önce durum)<br />
        ///     -1: İptal (sadece sipariş iptali için geçerli olan durum kodudur. Sipariş İptali için öncelikle durum = 0 yapılır)<br />
        ///     12: İptal edildi (Sipariş ve ödeme iptali için geçerli olan durum kodu)<br />
        ///     13: İade edildi.<br />
        /// </param>
        /// <returns>STC_Sonuc Nenesi</returns>
        ///     STC_Sonuc:
        ///         POS_Islem_Id: İşlem ID değeri
        ///         GUID_AltUyeIsyeri: Alt Üye İş Yerinin GUID Değeri
        ///         Tutar_Urun: Toplam ürün tutarı
        ///         Tutar_Odenecek: Ödenecek Tutar
        ///         Durum: Durum kodu
        ///         Durum_Str: Durum Açıklaması
        ///         Sonuc: İşlem Sonucu
        ///         Sonuc_Str: İşlem Sonucunun Açıklaması
        public Task<STC_Sonuc> PazaryeriTPSiparisOnayAsync(ST_WS_Guvenlik G, string PYSiparis_GUID, string Durum);
        /// <summary>Modelsisz ödeme işlemini uygular.</summary>
        /// <param name="G">ST_WS_Guvenlik Nesnesi (Zorunlu)</param>
        ///     ST_WS_Guvenlik Nesnesi:
        ///         CLIENT_CODE: Terminal ID (Zorunlu)
        ///         CLIENT_USERNAME: Kullanıcı Adı (Zorunlu)
        ///         CLIENT_PASSWORD: Şifre (Zorunlu)
        /// <param name="GUID">Üye İşyerine Ait Anahtar (Zorunlu)</param>
        /// <param name="KK_Sahibi">Kredi Kartı Sahibi (Zorunlu)</param>
        /// <param name="KK_No">Kredi Kartı Numarası (Zorunlu)</param>
        /// <param name="KK_SK_Ay">Son Kullanma Tarihi (Ay - Zorunlu)</param>
        /// <param name="KK_SK_Yil">Son Kullanma Tarihi (Yıl - Zorunlu)</param>
        /// <param name="KK_CVC">CVC Kodu (Zorunlu)</param>
        /// <param name="KK_Sahibi_GSM">Kredi Kartı Sahibi GSM No (Başında 0 Olmadan - Zorunlu)</param>
        /// <param name="Hata_URL">Ödeme İşlemi Başarısız Olursa Yönlenecek Sayfa Adresi (Zorunlu)</param>
        /// <param name="Basarili_URL">Ödeme İşlemi Başarılı Olursa Yönlenecek Sayfa Adresi (Zorunlu)</param>
        /// <param name="Siparis_ID">Siparişe Özel Tekil ID (Zorunlu)</param>
        /// <param name="Siparis_Aciklama">Siparişe Ait Açıklama</param>
        /// <param name="Taksit">Seçilen Taksit Sayısı (Tek çekim için 1 gönderiniz. - Zorunlu)</param>
        /// <param name="Islem_Tutar">Sipariş Tutarı (Virgüllü - Zorunlu)</param>
        /// <param name="Toplam_Tutar">Komisyon Dahil Sipariş Tutarı (Virgüllü - Zorunlu)</param>
        /// <param name="Islem_Hash">İşlem Hash Değeri (Zorunlu)</param>
        /// <param name="Islem_Guvenlik_Tip">Güvenlik Tipi (NS (NonSecure) veya 3D gönderilir. - Zorunlu)</param>
        /// <param name="Islem_ID">İşleme Ait Sipariş ID haricinde Tekil ID </param>
        /// <param name="IPAdr">IP Adresi</param>
        /// <param name="Ref_URL">Ödemenin Gerçekleştiği Sayfanın URL'i</param>
        /// <param name="Data1">Extra Alan 1</param>
        /// <param name="Data2">Extra Alan 2</param>
        /// <param name="Data3">Extra Alan 3</param>
        /// <param name="Data4">Extra Alan 4</param>
        /// <param name="Data5">Extra Alan 5</param>
        /// <param name="Data6">Extra Alan 6</param>
        /// <param name="Data7">Extra Alan 7</param>
        /// <param name="Data8">Extra Alan 8</param>
        /// <param name="Data9">Extra Alan 9</param>
        /// <param name="Data10">Extra Alan 10</param>
        /// <returns>ST_TP_Islem_Odeme Nenesi</returns>
        ///     ST_TP_Islem_Odeme:
        ///         Islem_ID: SID Değeri
        ///         UCD_URL: 3D URL'i
        ///         Sonuc: İşlem Sonucu
        ///         Sonuc_Str: İşlem Sonucunun Açıklaması
        ///         Banka_Sonuc_Kod: Bankanın Sonuç Kodu
        ///         Siparis_ID: Sipariş ID'si
        ///         Komisyon_Oran: Komisyon Oranı
        public Task<ST_TP_Islem_Odeme> PosOdemeAsync(ST_WS_Guvenlik G, string GUID, string KK_Sahibi, string KK_No, string KK_SK_Ay, string KK_SK_Yil, string KK_CVC, string KK_Sahibi_GSM, string Hata_URL, string Basarili_URL, string Siparis_ID, string Siparis_Aciklama, int Taksit, string Islem_Tutar, string Toplam_Tutar, string Islem_Hash, string Islem_Guvenlik_Tip, string Islem_ID, string IPAdr, string Ref_URL, string Data1, string Data2, string Data3, string Data4, string Data5, string Data6, string Data7, string Data8, string Data9, string Data10);
        public Task<ST_Genel_Sonuc> PosPluginBildirimAsync(ST_WS_Guvenlik G, string ETS_GUID, string Domain_Adres, string Yazilim_Bilgisi, string Yazilim_Surum_Bilgisi);
        public Task<string> SHA2B64Async(string Data);
        public Task<ST_Sonuc> TPIslemCheckoutAsync(string CLIENT_CODE, string GUID, string IPAdr);
        public Task<ST_TP_Islem_Odeme> TPIslemCheckoutOdemeWNSAsync(ST_WS_Guvenlik G, int SanalPOS_ID, string GUID, string KK_Sahibi, string KK_No, string KK_SK_Ay, string KK_SK_Yil, string KK_CVC, string KK_Sahibi_GSM, string Hata_URL, string Basarili_URL, string Siparis_ID, string Siparis_Aciklama, int Taksit, string Islem_Tutar, string Toplam_Tutar, string Islem_Hash, string Islem_Guvenlik_Tip, string Islem_ID, string IPAdr, string Ref_URL, string Data1, string Data2, string Data3, string Data4, string Data5, string Firma_IPAdr);
        public Task<ST_CheckOut_Sonuc> TPIslemCheckoutSKAsync(string CLIENT_CODE, string GUID, string IPAdr, string KK_BIN, string Tutar);
        /// <summary>Dekontun e-posta olarak gönderilme işlemini uygular.</summary>
        /// <param name="G">ST_WS_Guvenlik Nesnesi (Zorunlu)</param>
        ///     ST_WS_Guvenlik Nesnesi:
        ///         CLIENT_CODE: Terminal ID (Zorunlu)
        ///         CLIENT_USERNAME: Kullanıcı Adı (Zorunlu)
        ///         CLIENT_PASSWORD: Şifre (Zorunlu)
        /// <param name="GUID">Üye İşyerine Ait Anahtar (Zorunlu)</param>
        /// <param name="Dekont_ID">İşlemin Dekont ID'si (Zorunlu)</param>
        /// <param name="E_Posta">Kişi E-posta Adresi</param>
        /// <returns>ST_Sonuc Nenesi</returns>
        ///     ST_Sonuc:
        ///         Sonuc: İşlem Sonucu
        ///         Sonuc_Str: İşlem Sonucunun Açıklaması
        ///         Banka_Sonuc_Kod: Bankanın Sonuç Kodu
        public Task<ST_Sonuc> TPIslemDekontGonderAsync(ST_WS_Guvenlik G, string GUID, string Dekont_ID, string E_Posta);
        public Task<ST_Sonuc> TPIslemIptalIadeAsync(ST_WS_Guvenlik G, string GUID, string Durum, string Dekont_ID);
        public Task<ST_Sonuc_II> TPIslemIptalIade2Async(ST_WS_Guvenlik G, string GUID, string Durum, string Siparis_ID);
        public Task<ST_Sonuc> TPIslemIptalIadeKismiAsync(ST_WS_Guvenlik G, string GUID, string Durum, string Dekont_ID, double Tutar);
        /// <summary>Başarılı bir kredi kartı işleminin iptal veya iadesini yapma işlemini uygular.</summary>
        /// <param name="G">ST_WS_Guvenlik Nesnesi (Zorunlu)</param>
        ///     ST_WS_Guvenlik Nesnesi:
        ///         CLIENT_CODE: Terminal ID (Zorunlu)
        ///         CLIENT_USERNAME: Kullanıcı Adı (Zorunlu)
        ///         CLIENT_PASSWORD: Şifre (Zorunlu)
        /// <param name="GUID">Üye İşyerine Ait Anahtar (Zorunlu)</param>
        /// <param name="Durum">İptal için IPTAL, İade için IADE (Zorunlu)</param>
        /// <param name="Siparis_ID">Siparişe Özel Tekil ID (Zorunlu)</param>
        /// <param name="Tutar">İptal/İade Tutarı (IPTAL için tüm tutar yazılmalıdır. IADE için tüm tutar veya daha küçük tutar (kısmi) yazılmalıdır. - Zorunlu)</param>
        /// <returns>ST_Sonuc_II Nenesi</returns>
        ///     ST_Sonuc_II:
        ///         Sonuc: İşlem Sonucu
        ///         Sonuc_Str: İşlem Sonucunun Açıklaması
        ///         Banka_Sonuc_Kod: Bankanın Sonuç Kodu
        ///         Bank_AuthCode: Bankanın Auth Code Değeri
        ///         Bank_Trans_ID: Bankanın Transaction ID Değeri
        ///         Bank_Extra: Banka Extra Değeri
        ///         Bank_HostRefNum: Bankanın RRN Değeri
        public Task<ST_Sonuc_II> TPIslemIptalIadeKismi2Async(ST_WS_Guvenlik G, string GUID, string Durum, string Siparis_ID, double Tutar);
        public Task<ST_Sonuc_II> TPIslemIptalIadeKismi3Async(ST_WS_Guvenlik G, string GUID, string Durum, string Siparis_ID, double Tutar, string Ref_No);
        public Task<ST_Sonuc4> TPIslemIptalIadeKismi4Async(ST_WS_Guvenlik G, string GUID, string Durum, string Siparis_ID, double Tutar);
        public Task<ST_Sonuc_WP> TPIslemIptalIadeKismiWPAsync(ST_WS_Guvenlik G, string GUID, string Durum, string Siparis_ID, double Tutar, string Ref_No);
        /// <summary>Ön provizyon işlemini iptal etme işlemini uygular.</summary>
        /// <param name="G">ST_WS_Guvenlik Nesnesi (Zorunlu)</param>
        ///     ST_WS_Guvenlik Nesnesi:
        ///         CLIENT_CODE: Terminal ID (Zorunlu)
        ///         CLIENT_USERNAME: Kullanıcı Adı (Zorunlu)
        ///         CLIENT_PASSWORD: Şifre (Zorunlu)
        /// <param name="GUID">Üye İşyerine Ait Anahtar (Zorunlu)</param>
        /// <param name="Prov_ID">Provizyon ID'si</param>
        /// <param name="Siparis_ID">Siparişe Özel Tekil ID (Zorunlu)</param>
        /// <returns>ST_Sonuc Nenesi</returns>
        ///     ST_Sonuc:
        ///         Sonuc: İşlem Sonucu
        ///         Sonuc_Str: İşlem Sonucunun Açıklaması
        ///         Banka_Sonuc_Kod: Bankanın Sonuç Kodu
        public Task<ST_Sonuc> TPIslemIptalOnProvAsync(ST_WS_Guvenlik G, string GUID, string Prov_ID, string Siparis_ID);
        /// <summary>Yapılan işlemlerin belirli tarih aralığında izleme işlemini uygular.</summary>
        /// <param name="G">ST_WS_Guvenlik Nesnesi (Zorunlu)</param>
        ///     ST_WS_Guvenlik Nesnesi:
        ///         CLIENT_CODE: Terminal ID (Zorunlu)
        ///         CLIENT_USERNAME: Kullanıcı Adı (Zorunlu)
        ///         CLIENT_PASSWORD: Şifre (Zorunlu)
        /// <param name="GUID">Üye İşyerine Ait Anahtar (Zorunlu)</param>
        /// <param name="Tarih_Bas">Başlangıç Tarihi (dd.MM.yyyy HH:mm:ss – 20.11.2015 00:00:00 - Zorunlu)</param>
        /// <param name="Tarih_Bit">Bitiş Tarihi (dd.MM.yyyy HH:mm:ss – 20.11.2015 15:15:00)</param>
        /// <param name="Islem_Tip">İptal ,İade ,Satış Gönderilmediği taktirde hepsi döner süre uzar.)</param>
        /// <param name="Islem_Durum">Başarılı, Başarısız (Başarısız gönderilmediği taktirde hepsi döner süre uzar.)</param>
        /// <returns>ST_Genel_Sonuc Nenesi</returns>
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
        public Task<ST_Genel_Sonuc> TPIslemIzlemeAsync(ST_WS_Guvenlik G, string GUID, string Tarih_Bas, string Tarih_Bit, string Islem_Tip, string Islem_Durum);
        public Task<ST_TP_Islem_Odeme> TPIslemOdemeAsync(ST_WS_Guvenlik G, int SanalPOS_ID, string GUID, string KK_Sahibi, string KK_No, string KK_SK_Ay, string KK_SK_Yil, string KK_CVC, string KK_Sahibi_GSM, string Hata_URL, string Basarili_URL, string Siparis_ID, string Siparis_Aciklama, int Taksit, string Islem_Tutar, string Toplam_Tutar, string Islem_Hash, string Islem_ID, string IPAdr, string Ref_URL, string Data1, string Data2, string Data3, string Data4, string Data5);
        /// <summary>BKM Express aracılığıyla ödeme işlemini uygular.</summary>
        /// <param name="G">ST_WS_Guvenlik Nesnesi (Zorunlu)</param>
        ///     ST_WS_Guvenlik Nesnesi:
        ///         CLIENT_CODE: Terminal ID (Zorunlu)
        ///         CLIENT_USERNAME: Kullanıcı Adı (Zorunlu)
        ///         CLIENT_PASSWORD: Şifre (Zorunlu)
        /// <param name="GUID">Üye İşyerine Ait Anahtar (Zorunlu)</param>
        /// <param name="Customer_Info">Üye İşyeri Müşterisi GSM No (Başında 0 Olmadan - Zorunlu)</param>
        /// <param name="Customer_GSM">Üye İşyerine Ait Anahtar (Zorunlu)</param>
        /// <param name="Error_URL">Ödeme İşlemi Başarısız Olursa Yönlenecek Sayfa Adresi (Zorunlu)</param>
        /// <param name="Success_URL">Ödeme İşlemi Başarılı Olursa Yönlenecek Sayfa Adresi (Zorunlu)</param>
        /// <param name="Order_ID">	Siparişe Özel Tekil ID (Zorunlu)</param>
        /// <param name="Order_Description">Siparişe Ait Açıklama</param>
        /// <param name="Amount">Sipariş Tutarı (Virgüllü - Zorunlu)</param>
        /// <param name="Payment_Hash">Ödeme Hash Değeri (Zorunlu)</param>
        /// <param name="Transaction_ID">İşleme Ait Sipariş ID Haricinde Tekil ID</param>
        /// <param name="IPAddress">IP Adresi (Zorunlu)</param>
        /// <param name="Referrer_URL">Ödemenin Gerçekleştiği Sayfanın URL'i</param>
        /// <returns>ST_TP_Islem_Odeme_BKM Nenesi</returns>
        ///     ST_TP_Islem_Odeme_BKM:
        ///         Redirect_URL: İşlem Sonucu
        ///         Response_Code: İşlem Sonucunun Açıklaması
        ///         Response_Message: BKM Express URL'i
        public Task<ST_TP_Islem_Odeme_BKM> TPIslemOdemeBKMAsync(ST_WS_Guvenlik G, string GUID, string Customer_Info, string Customer_GSM, string Error_URL, string Success_URL, string Order_ID, string Order_Description, string Amount, string Payment_Hash, string Transaction_ID, string IPAddress, string Referrer_URL);
        public Task<ST_TP_Islem_Odeme_OnProv> TPIslemOdemeOnProvAsync(ST_WS_Guvenlik G, string GUID, string KK_Sahibi, string KK_No, string KK_SK_Ay, string KK_SK_Yil, string KK_CVC, string KK_Sahibi_GSM, string Hata_URL, string Basarili_URL, string Siparis_ID, string Siparis_Aciklama, string Islem_Tutar, string Toplam_Tutar, string Islem_Hash, string Islem_Guvenlik_Tip, string Islem_ID, string IPAdr, string Ref_URL, string Data1, string Data2, string Data3, string Data4, string Data5);
        /// <summary>Ön provizyonu satışa dönüştürmek için kapama işlemini uygular.</summary>
        /// <param name="G">ST_WS_Guvenlik Nesnesi (Zorunlu)</param>
        ///     ST_WS_Guvenlik Nesnesi:
        ///         CLIENT_CODE: Terminal ID (Zorunlu)
        ///         CLIENT_USERNAME: Kullanıcı Adı (Zorunlu)
        ///         CLIENT_PASSWORD: Şifre (Zorunlu)
        /// <param name="GUID">Üye İşyerine Ait Anahtar (Zorunlu)</param>
        /// <param name="Prov_ID">Provizyon ID</param>
        /// <param name="Prov_Tutar">Kapama Yapılacak Tutar (Virgüllü - Zorunlu)</param>
        /// <param name="Siparis_ID">Siparişe Özel Tekil ID (Zorunlu)</param>
        /// <returns>ST_TP_Islem_Odeme_OnProvKapa Nenesi</returns>
        ///     ST_TP_Islem_Odeme_OnProvKapa:
        ///         Sonuc: İşlem Sonucu
        ///         Sonuc_Str: İşlem Sonucunun Açıklaması
        ///         Prov_ID: Provizyon ID'si
        ///         Dekont_ID: 	İşlemin Dekont ID'si
        ///         Banka_Sonuc_Kod: Bankanın Sonuç Kodu
        ///         Siparis_ID: Sipariş ID'si
        ///         Bank_Trans_ID: Bankanın Transaction ID Değeri
        ///         Bank_AuthCode: Bankanın Auth Code Değeri
        ///         Bank_HostMsg: Banka HostMsg Değeri
        ///         Bank_Extra: Banka Extra Değeri
        ///         Bank_HostRefNum: Bankanın RRN Değeri
        public Task<ST_TP_Islem_Odeme_OnProvKapa> TPIslemOdemeOnProvKapaAsync(ST_WS_Guvenlik G, string GUID, string Prov_ID, string Prov_Tutar, string Siparis_ID);
        /// <summary>Saklı kart ile ön provizyon işlemini uygular.</summary>
        /// <param name="G">ST_WS_Guvenlik Nesnesi (Zorunlu)</param>
        ///     ST_WS_Guvenlik Nesnesi:
        ///         CLIENT_CODE: Terminal ID (Zorunlu)
        ///         CLIENT_USERNAME: Kullanıcı Adı (Zorunlu)
        ///         CLIENT_PASSWORD: Şifre (Zorunlu)
        /// <param name="GUID">Üye İşyerine Ait Anahtar (Zorunlu)</param>
        /// <param name="KS_Kart_No">Kredi Kartı Numarası (Zorunlu)</param>
        /// <param name="KK_GUID">GUID Bilgisi (Zorunlu)</param>
        /// <param name="KK_Sahibi_GSM">Kredi Kartı Sahibi GSM No (Başında 0 Olmadan - Zorunlu)</param>
        /// <param name="Hata_URL">Ödeme İşlemi Başarısız Olursa Yönlenecek Sayfa Adresi (Zorunlu)</param>
        /// <param name="Basarili_URL">Ödeme İşlemi Başarılı Olursa Yönlenecek Sayfa Adresi (Zorunlu)</param>
        /// <param name="Siparis_ID">Siparişe Özel Tekil ID (Zorunlu)</param>
        /// <param name="Siparis_Aciklama">Siparişe Ait Açıklama</param>
        /// <param name="Islem_Tutar">Sipariş Tutarı (Virgüllü - Zorunlu)</param>
        /// <param name="Toplam_Tutar">Komisyon Dahil Sipariş Tutarı (Virgüllü - Zorunlu)</param>
        /// <param name="Islem_Hash">İşlem Hash Değeri (Zorunlu)</param>
        /// <param name="Islem_Guvenlik_Tip">Güvenlik Tipi (NS (NonSecure) veya 3D gönderilir. - Zorunlu)</param>
        /// <param name="Islem_ID">İşleme Ait Sipariş ID haricinde Tekil ID </param>
        /// <param name="IPAdr">IP Adresi</param>
        /// <param name="Ref_URL">Ödemenin Gerçekleştiği Sayfanın URL'i</param>
        /// <param name="Data1">Extra Alan 1</param>
        /// <param name="Data2">Extra Alan 2</param>
        /// <param name="Data3">Extra Alan 3</param>
        /// <param name="Data4">Extra Alan 4</param>
        /// <param name="Data5">Extra Alan 5</param>
        /// <returns>ST_TP_Islem_Odeme_OnProv Nenesi</returns>
        ///     ST_TP_Islem_Odeme_OnProv:
        ///         Sonuc: İşlem Sonucu
        ///         Sonuc_Str: İşlem Sonucunun Açıklaması
        ///         Islem_ID: SID Değeri
        ///         UCD_URL: 3D URL'i
        ///         Islem_GUID: İşlem GUID Değeri
        ///         Banka_Sonuc_Kod: Bankanın Sonuç Kodu
        ///         Siparis_ID: Sipariş ID'si
        public Task<ST_TP_Islem_Odeme_OnProv> TPIslemOdemeOnProvWKSAsync(ST_WS_Guvenlik G, string GUID, string KS_Kart_No, string KK_GUID, string KK_Sahibi_GSM, string Hata_URL, string Basarili_URL, string Siparis_ID, string Siparis_Aciklama, string Islem_Tutar, string Toplam_Tutar, string Islem_Hash, string Islem_Guvenlik_Tip, string Islem_ID, string IPAdr, string Ref_URL, string Data1, string Data2, string Data3, string Data4, string Data5);
        /// <summary>Model ile ön provizyon işlemini uygular.</summary>
        /// <param name="G">ST_WS_Guvenlik Nesnesi (Zorunlu)</param>
        ///     ST_WS_Guvenlik Nesnesi:
        ///         CLIENT_CODE: Terminal ID (Zorunlu)
        ///         CLIENT_USERNAME: Kullanıcı Adı (Zorunlu)
        ///         CLIENT_PASSWORD: Şifre (Zorunlu)
        /// <param name="GUID">Üye İşyerine Ait Anahtar (Zorunlu)</param>
        /// <param name="KK_Sahibi">Kredi Kartı Sahibi (Zorunlu)</param>
        /// <param name="KK_No">Kredi Kartı Numarası (Zorunlu)</param>
        /// <param name="KK_SK_Ay">Son Kullanma Tarihi (Ay - Zorunlu)</param>
        /// <param name="KK_SK_Yil">Son Kullanma Tarihi (Yıl - Zorunlu)</param>
        /// <param name="KK_CVC">CVC Kodu (Zorunlu)</param>
        /// <param name="KK_Sahibi_GSM">Kredi Kartı Sahibi GSM No (Başında 0 Olmadan - Zorunlu)</param>
        /// <param name="Hata_URL">Ödeme İşlemi Başarısız Olursa Yönlenecek Sayfa Adresi (Zorunlu)</param>
        /// <param name="Basarili_URL">Ödeme İşlemi Başarılı Olursa Yönlenecek Sayfa Adresi (Zorunlu)</param>
        /// <param name="Siparis_ID">Siparişe Özel Tekil ID (Zorunlu)</param>
        /// <param name="Siparis_Aciklama">Siparişe Ait Açıklama</param>
        /// <param name="Islem_Tutar">Sipariş Tutarı (Virgüllü - Zorunlu)</param>
        /// <param name="Toplam_Tutar">Komisyon Dahil Sipariş Tutarı (Virgüllü - Zorunlu)</param>
        /// <param name="Islem_Hash">İşlem Hash Değeri (Zorunlu)</param>
        /// <param name="Islem_Guvenlik_Tip">Güvenlik Tipi (NS (NonSecure) veya 3D gönderilir. - Zorunlu)</param>
        /// <param name="Islem_ID">İşleme Ait Sipariş ID haricinde Tekil ID </param>
        /// <param name="IPAdr">IP Adresi</param>
        /// <param name="Ref_URL">Ödemenin Gerçekleştiği Sayfanın URL'i</param>
        /// <param name="Data1">Extra Alan 1</param>
        /// <param name="Data2">Extra Alan 2</param>
        /// <param name="Data3">Extra Alan 3</param>
        /// <param name="Data4">Extra Alan 4</param>
        /// <param name="Data5">Extra Alan 5</param>
        /// <param name="Taksit">Seçilen Taksit Sayısı (Tek çekim için 1 gönderiniz. - Zorunlu)</param>
        /// <returns>ST_WMD_UCD Nenesi</returns>
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
        ///         Bank_HostRefNum: Bankanın RRN Değeri
        ///         Ext_Data: Ekstra Veri
        public Task<ST_WMD_UCD> TPIslemOdemeOnProvWMDAsync(ST_WS_Guvenlik G, string GUID, string KK_Sahibi, string KK_No, string KK_SK_Ay, string KK_SK_Yil, string KK_CVC, string KK_Sahibi_GSM, string Hata_URL, string Basarili_URL, string Siparis_ID, string Siparis_Aciklama, string Islem_Tutar, string Toplam_Tutar, string Islem_Hash, string Islem_Guvenlik_Tip, string Islem_ID, string IPAdr, string Ref_URL, string Data1, string Data2, string Data3, string Data4, string Data5, int Taksit);
        /// <summary>Döviz ile ödeme işlemini uygular.</summary>
        /// <param name="G">ST_WS_Guvenlik Nesnesi (Zorunlu)</param>
        ///     ST_WS_Guvenlik Nesnesi:
        ///         CLIENT_CODE: Terminal ID (Zorunlu)
        ///         CLIENT_USERNAME: Kullanıcı Adı (Zorunlu)
        ///         CLIENT_PASSWORD: Şifre (Zorunlu)
        /// <param name="Doviz_Kodu">Döviz Kodu (1000 TurkPara: TRL, 1001 TurkPara: USD, 1002 TurkPara: EUR, 1003 Turkpara: GBP - Zorunlu)</param>
        /// <param name="GUID">Üye İşyerine Ait Anahtar (Zorunlu)</param>
        /// <param name="KK_Sahibi">Kredi Kartı Sahibi (Zorunlu)</param>
        /// <param name="KK_No">Kredi Kartı Numarası (Zorunlu)</param>
        /// <param name="KK_SK_Ay">Son Kullanma Tarihi (Ay - Zorunlu)</param>
        /// <param name="KK_SK_Yil">Son Kullanma Tarihi (Yıl - Zorunlu)</param>
        /// <param name="KK_CVC">CVC Kodu (Zorunlu)</param>
        /// <param name="KK_Sahibi_GSM">Kredi Kartı Sahibi GSM No (Başında 0 Olmadan - Zorunlu)</param>
        /// <param name="Hata_URL">Ödeme İşlemi Başarısız Olursa Yönlenecek Sayfa Adresi (Zorunlu)</param>
        /// <param name="Basarili_URL">Ödeme İşlemi Başarılı Olursa Yönlenecek Sayfa Adresi (Zorunlu)</param>
        /// <param name="Siparis_ID">Siparişe Özel Tekil ID (Zorunlu)</param>
        /// <param name="Siparis_Aciklama">Siparişe Ait Açıklama</param>
        /// <param name="Islem_Tutar">Sipariş Tutarı (Virgüllü - Zorunlu)</param>
        /// <param name="Toplam_Tutar">Komisyon Dahil Sipariş Tutarı (Virgüllü - Zorunlu)</param>
        /// <param name="Islem_Hash">İşlem Hash Değeri (Zorunlu)</param>
        /// <param name="Islem_Guvenlik_Tip">Güvenlik Tipi (NS (NonSecure) veya 3D gönderilir. - Zorunlu)</param>
        /// <param name="Islem_ID">İşleme Ait Sipariş ID haricinde Tekil ID </param>
        /// <param name="IPAdr">IP Adresi</param>
        /// <param name="Ref_URL">Ödemenin Gerçekleştiği Sayfanın URL'i</param>
        /// <param name="Data1">Extra Alan 1</param>
        /// <param name="Data2">Extra Alan 2</param>
        /// <param name="Data3">Extra Alan 3</param>
        /// <param name="Data4">Extra Alan 4</param>
        /// <param name="Data5">Extra Alan 5</param>
        /// <returns>ST_TP_Islem_Odeme Nenesi</returns>
        ///     ST_TP_Islem_Odeme:
        ///         Islem_ID: SID Değeri
        ///         UCD_URL: 3D URL'i
        ///         Sonuc: İşlem Sonucu
        ///         Sonuc_Str: İşlem Sonucunun Açıklaması
        ///         Banka_Sonuc_Kod: Bankanın Sonuç Kodu
        ///         Siparis_ID: BSipariş ID'si
        ///         Komisyon_Oran: Komisyon Oranı
        public Task<ST_TP_Islem_Odeme> TPIslemOdemeWDAsync(ST_WS_Guvenlik G, int Doviz_Kodu, string GUID, string KK_Sahibi, string KK_No, string KK_SK_Ay, string KK_SK_Yil, string KK_CVC, string KK_Sahibi_GSM, string Hata_URL, string Basarili_URL, string Siparis_ID, string Siparis_Aciklama, string Islem_Tutar, string Toplam_Tutar, string Islem_Hash, string Islem_Guvenlik_Tip, string Islem_ID, string IPAdr, string Ref_URL, string Data1, string Data2, string Data3, string Data4, string Data5);
        public Task<ST_TP_Islem_Odeme> TPIslemOdemeWKSAsync(ST_WS_Guvenlik G, int SanalPOS_ID, string GUID, string KS_Kart_No, string KK_GUID, string KK_Sahibi_GSM, string Hata_URL, string Basarili_URL, string Siparis_ID, string Siparis_Aciklama, int Taksit, string Islem_Tutar, string Toplam_Tutar, string Islem_Hash, string Islem_Guvenlik_Tip, string Islem_ID, string IPAdr, string Ref_URL, string Data1, string Data2, string Data3, string Data4, string Data5);
        public Task<ST_TP_Islem_Odeme> TPIslemOdemeWNSAsync(ST_WS_Guvenlik G, int SanalPOS_ID, string GUID, string KK_Sahibi, string KK_No, string KK_SK_Ay, string KK_SK_Yil, string KK_CVC, string KK_Sahibi_GSM, string Hata_URL, string Basarili_URL, string Siparis_ID, string Siparis_Aciklama, int Taksit, string Islem_Tutar, string Toplam_Tutar, string Islem_Hash, string Islem_Guvenlik_Tip, string Islem_ID, string IPAdr, string Ref_URL, string Data1, string Data2, string Data3, string Data4, string Data5, string Firma_IPAdr);
        public Task<ST_Genel_Sonuc> TPIslemSorgulamaAsync(ST_WS_Guvenlik G, string GUID, string Dekont_ID, string Siparis_ID, string Islem_ID);
        /// <summary>İşlemin durumunu (Başarılı, Başarısız, İptal veya İade) sorgulama işlemini uygular (Dekont_ID, Siparis_ID ve Islem_ID değerlerinden herhangi birini göndererek işlem durumunu sorgulayabilrisiniz.).</summary>
        /// <param name="G">ST_WS_Guvenlik Nesnesi (Zorunlu)</param>
        ///     ST_WS_Guvenlik Nesnesi:
        ///         CLIENT_CODE: Terminal ID (Zorunlu)
        ///         CLIENT_USERNAME: Kullanıcı Adı (Zorunlu)
        ///         CLIENT_PASSWORD: Şifre (Zorunlu)
        /// <param name="GUID">Üye İşyerine ait Anahtar (Zorunlu)</param>
        /// <param name="Dekont_ID">Başarılı İşlem Sonrası POST Edilen Dekont ID</param>
        /// <param name="Siparis_ID">Başarılı İşlem Sonrası POST Edilen Sipariş ID</param>
        /// <param name="Islem_ID">TP_Islem_Odeme Metoduna Gönderilen İşlem ID</param>
        /// <returns>ST_Genel_Sonuc2 Nenesi</returns>
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
        public Task<ST_Genel_Sonuc2> TPIslemSorgulama4Async(ST_WS_Guvenlik G, string GUID, string Dekont_ID, string Siparis_ID, string Islem_ID);
        public Task<ST_Genel_Sonuc3> TPIslemSorgulama5Async(ST_WS_Guvenlik G, string GUID, string Dekont_ID, string Siparis_ID, string Islem_ID);
        public Task<ST_WMD_UCD> TPIslemSorgulama6Async(ST_WS_Guvenlik G, string GUID, string Siparis_ID);
        public Task<ST_Islem_Sorgulama_WP> TPIslemSorgulamaWPAsync(ST_WS_Guvenlik G, string GUID, string Dekont_ID, string Siparis_ID, string Islem_ID, string Ref_No);
        /// <summary>Kart doğrulama işlemini uygular.</summary>
        /// <param name="G">ST_WS_Guvenlik Nesnesi (Zorunlu)</param>
        ///     ST_WS_Guvenlik Nesnesi:
        ///         CLIENT_CODE: Terminal ID (Zorunlu)
        ///         CLIENT_USERNAME: Kullanıcı Adı (Zorunlu)
        ///         CLIENT_PASSWORD: Şifre (Zorunlu)
        /// <param name="KK_No">Kredi Kartı Numarası (Zorunlu)</param>
        /// <param name="KK_SK_Ay">Son Kullanma Tarihi (Ay - Zorunlu)</param>
        /// <param name="KK_SK_Yil">Son Kullanma Tarihi (Yıl - Zorunlu)</param>
        /// <param name="KK_CVC">CVC Kodu (Zorunlu)</param>
        /// <param name="Return_URL">Sonuç Post Parametrelerinin Döndüğü URL</param>
        /// <param name="Data1">Extra Alan 1</param>
        /// <param name="Data2">Extra Alan 2</param>
        /// <param name="Data3">Extra Alan 3</param>
        /// <param name="Data4">Extra Alan 4</param>
        /// <param name="Data5">Extra Alan 5</param>
        /// <returns>ST_TP_Islem_Odeme Nenesi</returns>
        ///     ST_TP_Islem_Odeme:
        ///         Islem_ID: SID Değeri
        ///         UCD_URL: 3D URL'i
        ///         Sonuc: İşlem Sonucu
        ///         Sonuc_Str: İşlem Sonucunun Açıklaması
        ///         Banka_Sonuc_Kod: Bankanın Sonuç Kodu
        ///         Siparis_ID: Sipariş ID'si
        ///         Komisyon_Oran: Komisyon Oranı
        public Task<ST_TP_Islem_Odeme> TPKKVerifyAsync(ST_WS_Guvenlik G, string KK_No, string KK_SK_Ay, string KK_SK_Yil, string KK_CVC, string Return_URL, string Data1, string Data2, string Data3, string Data4, string Data5);
        public Task<CL_Res_Odeme> TPModalPaymentAsync(CL_Req_Odeme d);
        public Task<CL_Multiple_Payment> TPMultiplePaymentAsync(CL_Payment Payment_Info);
        public Task<CL_Multiple_Payment_Status> TPMultiplePaymentStatusAsync(CL_Payment_Status Payment_Info);
        /// <summary>Belirli tarihte üye işyerinin mutabakat detaylarını alma işlemini uygular.</summary>
        /// <param name="G">ST_WS_Guvenlik Nesnesi (Zorunlu)</param>
        ///     ST_WS_Guvenlik Nesnesi:
        ///         CLIENT_CODE: Terminal ID (Zorunlu)
        ///         CLIENT_USERNAME: Kullanıcı Adı (Zorunlu)
        ///         CLIENT_PASSWORD: Şifre (Zorunlu)
        /// <param name="GUID">Üye İşyerine Ait Anahtar (Zorunlu)</param>
        /// <param name="Tarih">İşlem Tarihi (dd.MM.yyyy HH:mm:ss – 20.11.2015 00:00:00 - Zorunlu)</param>
        /// <returns>ST_Genel_Sonuc Nenesi</returns>
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
        public Task<ST_Genel_Sonuc> TPMutabakatDetayAsync(ST_WS_Guvenlik G, string GUID, string Tarih);
        /// <summary>Belirli tarihleri arasındaki üye işyerinin işlemleri özet biçiminde alma işlemini uygular.</summary>
        /// <param name="G">ST_WS_Guvenlik Nesnesi (Zorunlu)</param>
        ///     ST_WS_Guvenlik Nesnesi:
        ///         CLIENT_CODE: Terminal ID (Zorunlu)
        ///         CLIENT_USERNAME: Kullanıcı Adı (Zorunlu)
        ///         CLIENT_PASSWORD: Şifre (Zorunlu)
        /// <param name="GUID">Üye İşyerine Ait Anahtar (Zorunlu)</param>
        /// <param name="Tarih_Bas">Başlangıç Tarihi (dd.MM.yyyy HH:mm:ss – 20.11.2015 00:00:00 - Zorunlu)</param>
        /// <param name="Tarih_Bit">Bitiş Tarihi (dd.MM.yyyy HH:mm:ss – 20.11.2015 15:15:00 - Zorunlu)</param>
        /// <returns>ST_Genel_Sonuc Nenesi</returns>
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
        public Task<ST_Genel_Sonuc> TPMutabakatOzetAsync(ST_WS_Guvenlik G, string GUID, string Tarih_Bas, string Tarih_Bit);
        /// <summary>Firma tarafından üye işyerine özel verilmiş sanal pos oranları listeleme işlemini uygular.</summary>
        /// <param name="G">ST_WS_Guvenlik Nesnesi (Zorunlu)</param>
        ///     ST_WS_Guvenlik Nesnesi:
        ///         CLIENT_CODE: Terminal ID (Zorunlu)
        ///         CLIENT_USERNAME: Kullanıcı Adı (Zorunlu)
        ///         CLIENT_PASSWORD: Şifre (Zorunlu)
        /// <param name="GUID">Üye İşyerine Ait Anahtar (Zorunlu)</param>
        /// <returns>ST_Genel_Sonuc Nenesi</returns>
        ///     ST_Genel_Sonuc:
        ///         DT_Bilgi:
        ///             Ozel_Oran_ID: Özel Oran ID'si
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
        public Task<ST_Genel_Sonuc> TPOzelOranListeAsync(ST_WS_Guvenlik G, string GUID);
        /// <summary>Üye işyerinin, firma tarafından verilen komisyon oranlarından daha düşük bir oranı müşterisine göstermesi işlemini uygular (Bu komisyon oranı firmanın üye işyerine verdiği komisyon oranına küçük eşit olabilir. İki komisyon oranı arasındaki fark “0” dan büyükse, bu farkı üye işyeri karşılar.).</summary>
        /// <param name="G">ST_WS_Guvenlik Nesnesi (Zorunlu)</param>
        ///     ST_WS_Guvenlik Nesnesi:
        ///         CLIENT_CODE: Terminal ID (Zorunlu)
        ///         CLIENT_USERNAME: Kullanıcı Adı (Zorunlu)
        ///         CLIENT_PASSWORD: Şifre (Zorunlu)
        /// <param name="GUID">Üye İşyerine Ait Anahtar (Zorunlu)</param>
        /// <param name="Ozel_Oran_SK_ID">Ozel_Oran_SK_Listeden Dönen ID değeri (Zorunlu)</param>
        /// <param name="MO_1">Tek Çekim Oranı</param>
        /// <param name="MO_2">2. Taksit Oranı</param>
        /// <param name="MO_3">3. Taksit Oranı</param>
        /// <param name="MO_4">4. Taksit Oranı</param>
        /// <param name="MO_5">5. Taksit Oranı</param>
        /// <param name="MO_6">6. Taksit Oranı</param>
        /// <param name="MO_7">7. Taksit Oranı</param>
        /// <param name="MO_8">8. Taksit Oranı</param>
        /// <param name="MO_9">9. Taksit Oranı</param>
        /// <param name="MO_10">10. Taksit Oranı</param>
        /// <param name="MO_11">11. Taksit Oranı</param>
        /// <param name="MO_12">12. Taksit Oranı</param>
        /// <returns>ST_Sonuc Nenesi</returns>
        ///     ST_Sonuc:
        ///         Sonuc: İşlem Sonucu
        ///         Sonuc_Str: İşlem Sonucunun Açıklaması
        ///         Banka_Sonuc_Kod: Bankanın Sonuç Kodu
        public Task<ST_Sonuc> TPOzelOranSKGuncelleAsync(ST_WS_Guvenlik G, string GUID, string Ozel_Oran_SK_ID, string MO_1, string MO_2, string MO_3, string MO_4, string MO_5, string MO_6, string MO_7, string MO_8, string MO_9, string MO_10, string MO_11, string MO_12);
        /// <summary>Üye işyerinin müşterisine göstereceği komisyon oranlarını listeleme işlemini uygular.</summary>
        /// <param name="G">ST_WS_Guvenlik Nesnesi (Zorunlu)</param>
        ///     ST_WS_Guvenlik Nesnesi:
        ///         CLIENT_CODE: Terminal ID (Zorunlu)
        ///         CLIENT_USERNAME: Kullanıcı Adı (Zorunlu)
        ///         CLIENT_PASSWORD: Şifre (Zorunlu)
        /// <param name="GUID">Üye İşyerine Ait Anahtar (Zorunlu)</param>
        /// <returns>ST_Genel_Sonuc Nenesi</returns>
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
        public Task<ST_Genel_Sonuc> TPOzelOranSKListeAsync(ST_WS_Guvenlik G, string GUID);
        public Task<ST_WMD_Pay> TPWMDPayAsync(ST_WS_Guvenlik G, string GUID, string UCD_MD, string Islem_GUID, string Siparis_ID);
        /// <summary>Model ile ödeme işlemini uygular.</summary>
        /// <param name="G">ST_WS_Guvenlik Nesnesi (Zorunlu)</param>
        ///     ST_WS_Guvenlik Nesnesi:
        ///         CLIENT_CODE: Terminal ID (Zorunlu)
        ///         CLIENT_USERNAME: Kullanıcı Adı (Zorunlu)
        ///         CLIENT_PASSWORD: Şifre (Zorunlu)
        /// <param name="GUID">Üye İşyerine Ait Anahtar (Zorunlu)</param>
        /// <param name="KK_Sahibi">Kredi Kartı Sahibi (Zorunlu)</param>
        /// <param name="KK_No">Kredi Kartı Numarası (Zorunlu)</param>
        /// <param name="KK_SK_Ay">Son Kullanma Tarihi (Ay - Zorunlu)</param>
        /// <param name="KK_SK_Yil">Son Kullanma Tarihi (Yıl - Zorunlu)</param>
        /// <param name="KK_CVC">CVC Kodu (Zorunlu)</param>
        /// <param name="KK_Sahibi_GSM">Kredi Kartı Sahibi GSM No (Başında 0 Olmadan - Zorunlu)</param>
        /// <param name="Hata_URL">Ödeme İşlemi Başarısız Olursa Yönlenecek Sayfa Adresi (Zorunlu)</param>
        /// <param name="Basarili_URL">Ödeme İşlemi Başarılı Olursa Yönlenecek Sayfa Adresi (Zorunlu)</param>
        /// <param name="Siparis_ID">Siparişe Özel Tekil ID (Zorunlu)</param>
        /// <param name="Siparis_Aciklama">Siparişe Ait Açıklama</param>
        /// <param name="Taksit">Seçilen Taksit Sayısı (Tek çekim için 1 gönderiniz. - Zorunlu)</param>
        /// <param name="Islem_Tutar">Sipariş Tutarı (Virgüllü - Zorunlu)</param>
        /// <param name="Toplam_Tutar">Komisyon Dahil Sipariş Tutarı (Virgüllü - Zorunlu)</param>
        /// <param name="Islem_Hash">İşlem Hash Değeri (Zorunlu)</param>
        /// <param name="Islem_Guvenlik_Tip">Güvenlik Tipi (NS (NonSecure) veya 3D gönderilir. - Zorunlu)</param>
        /// <param name="Islem_ID">İşleme Ait Sipariş ID haricinde Tekil ID </param>
        /// <param name="IPAdr">IP Adresi</param>
        /// <param name="Ref_URL">Ödemenin Gerçekleştiği Sayfanın URL'i</param>
        /// <param name="Data1">Extra Alan 1</param>
        /// <param name="Data2">Extra Alan 2</param>
        /// <param name="Data3">Extra Alan 3</param>
        /// <param name="Data4">Extra Alan 4</param>
        /// <param name="Data5">Extra Alan 5</param>
        /// <returns>ST_WMD_UCD Nenesi</returns>
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
        ///         Bank_HostRefNum: Bankanın RRN Değeri
        ///         Ext_Data: Ekstra Veri
        public Task<ST_WMD_UCD> TPWMDUCDAsync(ST_WS_Guvenlik G, string GUID, string KK_Sahibi, string KK_No, string KK_SK_Ay, string KK_SK_Yil, string KK_CVC, string KK_Sahibi_GSM, string Hata_URL, string Basarili_URL, string Siparis_ID, string Siparis_Aciklama, int Taksit, string Islem_Tutar, string Toplam_Tutar, string Islem_Hash, string Islem_Guvenlik_Tip, string Islem_ID, string IPAdr, string Ref_URL, string Data1, string Data2, string Data3, string Data4, string Data5);
        public Task<ST_WMD_UCD> TPWMDUCDPuanAsync(ST_WS_Guvenlik G, string GUID, string KK_Sahibi, string KK_No, string KK_SK_Ay, string KK_SK_Yil, string KK_CVC, string KK_Sahibi_GSM, string Hata_URL, string Basarili_URL, string Siparis_ID, string Siparis_Aciklama, int Taksit, string Islem_Tutar, string Toplam_Tutar, string Islem_Hash, string Islem_Guvenlik_Tip, string Islem_ID, string IPAdr, string Ref_URL, string Data1, string Data2, string Data3, string Data4, string Data5, string Pos_ID, string Islem_Tip);
        public Task<ST_WMD_UCD> TPWMDUCDWPAsync(ST_WS_Guvenlik G, string GUID, string KK_Sahibi, string KK_No, string KK_SK_Ay, string KK_SK_Yil, string KK_CVC, string KK_Sahibi_GSM, string Hata_URL, string Basarili_URL, string Siparis_ID, string Siparis_Aciklama, int Taksit, string Islem_Tutar, string Toplam_Tutar, string Islem_Hash, string Islem_Guvenlik_Tip, string Islem_ID, string IPAdr, string Ref_URL, string Data1, string Data2, string Data3, string Data4, string Data5, string Puan, string Pos_ID, string Islem_Tip);
        public Task<ST_WMD_UCD_v2> TPWMDUCDv2Async(ST_WS_Guvenlik G, string GUID, string KK_Sahibi, string KK_No, string KK_SK_Ay, string KK_SK_Yil, string KK_CVC, string KK_Sahibi_GSM, string Hata_URL, string Basarili_URL, string Siparis_ID, string Siparis_Aciklama, int Taksit, string Islem_Tutar, string Toplam_Tutar, string Islem_Hash, string Islem_Guvenlik_Tip, string Islem_ID, string IPAdr, string Ref_URL, string Data1, string Data2, string Data3, string Data4, string Data5);
        public Task<ST_Vadeli_Islem_Izleme_Sonuc> VadeliIslemIzlemeAsync(ST_WS_Guvenlik G, string GUID, string Tarih_Bas, string Tarih_Bit, string Siparis_No);
    }
}