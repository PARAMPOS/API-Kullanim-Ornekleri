using TurkPosWSTEST;

namespace WebMvc.DTOs.Pazaryeri_TP_AltUyeIsyeri_Liste
{
    public class Pazaryeri_TP_AltUyeIsyeri_ListeRequestDTO
    {
        public ST_WS_Guvenlik? G { get; set; }
        public string? ETS_GUID { get; set; }
        public string? Limit { get; set; }
        public string? Skip { get; set; }
    }
}