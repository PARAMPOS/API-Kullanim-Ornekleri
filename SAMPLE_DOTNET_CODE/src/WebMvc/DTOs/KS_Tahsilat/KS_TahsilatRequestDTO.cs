using TP_KS;

namespace WebMvc.DTOs.KS_Tahsilat
{
    public class KS_TahsilatRequestDTO
    {
        public ST_WS_Guvenlik G { get; set; } = null!;
        public string GUID { get; set; } = string.Empty;
        public string KS_GUID { get; set; } = string.Empty;
        public string CVV { get; set; } = string.Empty;
        public string KK_Sahibi_GSM { get; set; } = string.Empty;
        public string Hata_URL { get; set; } = string.Empty;
        public string Basarili_URL { get; set; } = string.Empty;
        public string Siparis_ID { get; set; } = string.Empty;
        public string Siparis_Aciklama { get; set; } = string.Empty;
        public int Taksit { get; set; }
        public string Islem_Tutar { get; set; } = string.Empty;
        public string Toplam_Tutar { get; set; } = string.Empty;
        public string Islem_Guvenlik_Tip { get; set; } = string.Empty;
        public string Islem_ID { get; set; } = string.Empty;
        public string IPAdr { get; set; } = string.Empty;
        public string Ref_URL { get; set; } = string.Empty;
        public string Data1 { get; set; } = string.Empty;
        public string Data2 { get; set; } = string.Empty;
        public string Data3 { get; set; } = string.Empty;
        public string Data4 { get; set; } = string.Empty;
        public string KK_Islem_ID { get; set; } = string.Empty;
    }
}