using TurkPosWSTEST;

namespace WebMvc.DTOs.TP_Islem_Sorgulama5
{
    public class TP_Islem_Sorgulama5ResponseDTO
    {
        public List<CL>? DT_Bilgi { get; set; }
        public string? Sonuc { get; set; }
        public string? Sonuc_Str { get; set; }
    }
}