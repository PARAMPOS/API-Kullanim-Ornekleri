using TurkPosWSTEST;

namespace WebMvc.DTOs.TP_Islem_Iptal_OnProv
{
    public class TP_Islem_Iptal_OnProvRequestDTO
    {
        public ST_WS_Guvenlik G { get; set; } = null!;
        public string GUID { get; set; } = string.Empty;
        public string Prov_ID { get; set; } = string.Empty;
        public string Siparis_ID { get; set; } = string.Empty;
    }
}