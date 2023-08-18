using TP_KS;

namespace WebMvc.DTOs.KS_Kart_Liste
{
    public class KS_Kart_ListeRequestDTO
    {
        public ST_WS_Guvenlik G { get; set; } = null!;
        public string GUID { get; set; } = string.Empty;
        public string KK_Kart_Adi { get; set; } = string.Empty;
        public string KK_Islem_ID { get; set; } = string.Empty;
    }
}