using TurkPosWSTEST;

namespace WebMvc.DTOs.KK_Sakli_Liste
{
    public class KK_Sakli_ListeRequestDTO
    {
        public ST_WS_Guvenlik G { get; set; } = null!;
        public string Kart_No { get; set; } = string.Empty;
        public string KS_KK_Kisi_ID { get; set; } = string.Empty;
    }
}