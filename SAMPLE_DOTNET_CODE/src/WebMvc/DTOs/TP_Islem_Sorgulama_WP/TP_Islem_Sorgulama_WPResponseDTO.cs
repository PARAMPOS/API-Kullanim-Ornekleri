using TurkPosWSTEST;

namespace WebMvc.DTOs.TP_Islem_Sorgulama_WP
{
    public class TP_Islem_Sorgulama_WPResponseDTO
    {
        public string? Sonuc { get; set; }
        public string? Sonuc_Str { get; set; }
        public string? Siparis_ID { get; set; }
        public string? Islem_ID { get; set; }
        public string? Ref_No { get; set; }
        public string? Durum { get; set; }
        public List<CL_WP>? List { get; set; }
    }
}