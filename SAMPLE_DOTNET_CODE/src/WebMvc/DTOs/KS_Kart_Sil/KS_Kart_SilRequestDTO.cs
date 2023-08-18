using TP_KS;

namespace WebMvc.DTOs.KS_Kart_Sil
{
    public class KS_Kart_SilRequestDTO
    {
        public ST_WS_Guvenlik G { get; set; } = null!;
        public string KS_GUID { get; set; } = string.Empty;
        public string KK_Islem_ID { get; set; } = string.Empty;
    }
}