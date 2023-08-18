using TurkPosWSTEST;

namespace WebMvc.DTOs.TP_Islem_Sorgulama6
{
    public class TP_Islem_Sorgulama6RequestDTO
    {
        public ST_WS_Guvenlik G { get; set; } = null!;
        public string GUID { get; set; } = string.Empty;
        public string Siparis_ID { get; set; } = string.Empty;
    }
}