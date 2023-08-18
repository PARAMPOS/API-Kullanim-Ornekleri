using TurkPosWSTEST;

namespace WebMvc.DTOs.TP_Islem_Sorgulama_WP
{
    public class TP_Islem_Sorgulama_WPRequestDTO
    {
        public ST_WS_Guvenlik G { get; set; } = null!;
        public string GUID { get; set; } = string.Empty;
        public string Dekont_ID { get; set; } = string.Empty;
        public string Siparis_ID { get; set; } = string.Empty;
        public string Islem_ID { get; set; } = string.Empty;
        public string Ref_No { get; set; } = string.Empty;
    }
}