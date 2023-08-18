using TurkPosWSTEST;

namespace WebMvc.DTOs.TP_Islem_Iptal_Iade_Kismi_WP
{
    public class TP_Islem_Iptal_Iade_Kismi_WPResponseDTO
    {
        public string? Sonuc { get; set; }
        public string? Sonuc_Str { get; set; }
        public string? Siparis_ID { get; set; }
        public string? Ref_No { get; set; }
        public List<CL_WP_II>? List { get; set; }
    }
}