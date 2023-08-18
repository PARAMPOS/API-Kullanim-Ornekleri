using TurkPosWSTEST;

namespace WebMvc.DTOs.TP_Islem_Sorgulama4
{
    public class TP_Islem_Sorgulama4ResponseDTO
    {
        public DT_Bilgi? DT_Bilgi { get; set; }
        public string? Sonuc { get; set; }
        public string? Sonuc_Str { get; set; }
    }
}