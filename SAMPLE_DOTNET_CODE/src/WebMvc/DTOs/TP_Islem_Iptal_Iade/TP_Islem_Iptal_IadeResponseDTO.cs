using TurkPosWSTEST;

namespace WebMvc.DTOs.TP_Islem_Iptal_Iade
{
    public class TP_Islem_Iptal_IadeResponseDTO
    {
        public ST_WS_Guvenlik? G { get; set; }
        public string? Sonuc { get; set; }
        public string? Sonuc_Str { get; set; }
        public string? Banka_Sonuc_Kod { get; set; }
    }
}