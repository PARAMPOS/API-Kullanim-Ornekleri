using TurkPosWSTEST;

namespace WebMvc.DTOs.TP_Ozel_Oran_SK_Liste
{
    public class TP_Ozel_Oran_SK_ListeRequestDTO
    {
        public ST_WS_Guvenlik? G { get; set; } = null!;
        public string GUID { get; set; } = string.Empty;
    }
}