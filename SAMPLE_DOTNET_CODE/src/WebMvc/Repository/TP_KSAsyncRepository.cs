using TP_KS;
using WebMvc.Repository.Interface;

namespace WebMvc.Repository
{
    /// <inheritdoc />
    public class TP_KSAsyncRepository : ITP_KSAsyncRepository
    {
        private readonly TP_KSSoapClient client;
        public TP_KSAsyncRepository(TP_KSSoapClient client)
        {
            this.client = client;
        }
        public async Task<ST_KS_Kart_Ekle> KSKartEkleAsync(ST_WS_Guvenlik G, string GUID, string KK_Sahibi, string KK_No, string KK_SK_Ay, string KK_SK_Yil, string KK_Kart_Adi, string KK_Islem_ID)
        {
            return await client.KS_Kart_EkleAsync(G, GUID, KK_Sahibi, KK_No, KK_SK_Ay, KK_SK_Yil, KK_Kart_Adi, KK_Islem_ID);
        }
        public async Task<ST_KS_Kart_Liste> KSKartListeAsync(ST_WS_Guvenlik G, string GUID, string KK_Kart_Adi, string KK_Islem_ID)
        {
            return await client.KS_Kart_ListeAsync(G, GUID, KK_Kart_Adi, KK_Islem_ID);
        }
        public async Task<ST_KS_Kart_Liste> KSKartListePaginationAsync(ST_WS_Guvenlik G, string GUID, string KK_Kart_Adi, string KK_Islem_ID, string sayfa_Sayi, string sayfa_index)
        {
            return await client.KS_Kart_Liste_PaginationAsync(G, GUID, KK_Kart_Adi, KK_Islem_ID, sayfa_Sayi, sayfa_index);
        }
        public async Task<ST_Sonuc> KSKartSilAsync(ST_WS_Guvenlik G, string KS_GUID, string KK_Islem_ID)
        {
            return await client.KS_Kart_SilAsync(G, KS_GUID, KK_Islem_ID);
        }
        public async Task<ST_TP_Islem_Odeme> KSTahsilatAsync(ST_WS_Guvenlik G, string GUID, string KS_GUID, string CVV, string KK_Sahibi_GSM, string Hata_URL, string Basarili_URL, string Siparis_ID, string Siparis_Aciklama, int Taksit, string Islem_Tutar, string Toplam_Tutar, string Islem_Guvenlik_Tip, string Islem_ID, string IPAdr, string Ref_URL, string Data1, string Data2, string Data3, string Data4, string KK_Islem_ID)
        {
            return await client.KS_TahsilatAsync(G, GUID, KS_GUID, CVV, KK_Sahibi_GSM, Hata_URL, Basarili_URL, Siparis_ID, Siparis_Aciklama, Taksit, Islem_Tutar, Toplam_Tutar, Islem_Guvenlik_Tip, Islem_ID, IPAdr, Ref_URL, Data1, Data2, Data3, Data4, KK_Islem_ID);
        }
        public async Task<ST_TP_Islem_Odeme> KSTahsilatColendiAsync(ST_WS_Guvenlik G, string MGUID, string GUID, string KS_GUID, string CVV, string KK_Sahibi_GSM, string Hata_URL, string Basarili_URL, string Siparis_ID, string Siparis_Aciklama, int Taksit, string Islem_Tutar, string Toplam_Tutar, string Islem_Guvenlik_Tip, string Islem_ID, string IPAdr, string Ref_URL, string Data1, string Data2, string Data3, string Data4, string KK_Islem_ID)
        {
            return await client.KS_Tahsilat_ColendiAsync(G, MGUID, GUID, KS_GUID, CVV, KK_Sahibi_GSM, Hata_URL, Basarili_URL, Siparis_ID, Siparis_Aciklama, Taksit, Islem_Tutar, Toplam_Tutar, Islem_Guvenlik_Tip, Islem_ID, IPAdr, Ref_URL, Data1, Data2, Data3, Data4, KK_Islem_ID);
        }
    }
}