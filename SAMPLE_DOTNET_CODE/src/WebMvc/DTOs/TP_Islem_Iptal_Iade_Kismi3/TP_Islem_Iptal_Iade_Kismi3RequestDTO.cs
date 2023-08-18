using TurkPosWSTEST;

namespace WebMvc.DTOs.TP_Islem_Iptal_Iade_Kismi3
{
    public class TP_Islem_Iptal_Iade_Kismi3RequestDTO
    {
        public ST_WS_Guvenlik G { get; set; } = null!;
        public string GUID { get; set; } = string.Empty;
        public string Durum { get; set; } = string.Empty;
        public string Siparis_ID { get; set; } = string.Empty;
        public double Tutar { get; set; }
        public string Ref_No { get; set; } = string.Empty;
    }
}