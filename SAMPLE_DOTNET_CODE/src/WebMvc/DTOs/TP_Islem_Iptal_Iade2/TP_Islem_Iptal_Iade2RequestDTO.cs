using TurkPosWSTEST;

namespace WebMvc.DTOs.TP_Islem_Iptal_Iade2
{
    public class TP_Islem_Iptal_Iade2RequestDTO
    {
        public ST_WS_Guvenlik G { get; set; } = null!;
        public string GUID { get; set; } = string.Empty;
        public string Durum { get; set; } = string.Empty;
        public string Siparis_ID { get; set; } = string.Empty;
    }
}