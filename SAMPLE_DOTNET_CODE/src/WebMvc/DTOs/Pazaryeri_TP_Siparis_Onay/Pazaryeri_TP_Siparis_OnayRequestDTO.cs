using TurkPosWSTEST;

namespace WebMvc.DTOs.Pazaryeri_TP_Siparis_Onay
{
    public class Pazaryeri_TP_Siparis_OnayRequestDTO
    {
        public ST_WS_Guvenlik G { get; set; } = null!;
        public string PYSiparisGUID { get; set; } = string.Empty;
        public string Durum { get; set; } = string.Empty;
    }
}