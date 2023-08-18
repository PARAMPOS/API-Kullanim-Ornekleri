using TP_KS;

namespace WebMvc.DTOs.KS_Kart_Ekle
{
    public class KS_Kart_EkleRequestDTO
    {
        public ST_WS_Guvenlik G { get; set; } = null!;
        public string GUID { get; set; } = string.Empty;
        public string KK_Sahibi { get; set; } = string.Empty;
        public string KK_No { get; set; } = string.Empty;
        public string KK_SK_Ay { get; set; } = string.Empty;
        public string KK_SK_Yil { get; set; } = string.Empty;
        public string KK_Kart_Adi { get; set; } = string.Empty;
        public string KK_Islem_ID { get; set; } = string.Empty;
    }
}