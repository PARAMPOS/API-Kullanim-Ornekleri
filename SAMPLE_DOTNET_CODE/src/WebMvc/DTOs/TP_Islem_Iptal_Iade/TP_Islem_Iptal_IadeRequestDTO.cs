using TurkPosWSTEST;

namespace WebMvc.DTOs.TP_Islem_Iptal_Iade
{
    public class TP_Islem_Iptal_IadeRequestDTO
    {
        public ST_WS_Guvenlik G { get; set; } = null!;
        public string GUID { get; set; } = string.Empty;
        public string Durum { get; set; } = string.Empty;
        public string Dekont_ID { get; set; } = string.Empty;
    }
}