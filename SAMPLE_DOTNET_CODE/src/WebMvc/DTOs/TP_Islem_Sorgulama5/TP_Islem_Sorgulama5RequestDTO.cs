using TurkPosWSTEST;

namespace WebMvc.DTOs.TP_Islem_Sorgulama5
{
    public class TP_Islem_Sorgulama5RequestDTO
    {
        public ST_WS_Guvenlik G { get; set; } = null!;
        public string GUID { get; set; } = string.Empty;
        public string Dekont_ID { get; set; } = string.Empty;
        public string Siparis_ID { get; set; } = string.Empty;
        public string Islem_ID { get; set; } = string.Empty;
    }
}