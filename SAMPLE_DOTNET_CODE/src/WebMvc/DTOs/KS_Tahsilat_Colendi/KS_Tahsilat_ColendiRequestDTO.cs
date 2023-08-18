using TP_KS;

namespace WebMvc.DTOs.KS_Tahsilat_Colendi
{
    public class KS_Tahsilat_ColendiRequestDTO
    {
        public ST_WS_Guvenlik? G { get; set; }
        public string? MGUID { get; set; }
        public string? GUID { get; set; }
        public string? KS_GUID { get; set; }
        public string? CVV { get; set; }
        public string? KK_Sahibi_GSM { get; set; }
        public string? Hata_URL { get; set; }
        public string? Basarili_URL { get; set; }
        public string? Siparis_ID { get; set; }
        public string? Siparis_Aciklama { get; set; }
        public int Taksit { get; set; }
        public string? Islem_Tutar { get; set; }
        public string? Toplam_Tutar { get; set; }
        public string? Islem_Guvenlik_Tip { get; set; }
        public string? Islem_ID { get; set; }
        public string? IPAdr { get; set; }
        public string? Ref_URL { get; set; }
        public string? Data1 { get; set; }
        public string? Data2 { get; set; }
        public string? Data3 { get; set; }
        public string? Data4 { get; set; }
        public string? KK_Islem_ID { get; set; }
    }
}