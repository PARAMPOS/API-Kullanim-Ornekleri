using TurkPosWSTEST;

namespace WebMvc.DTOs.TP_Islem_Iptal_Iade_Kismi
{
    public class TP_Islem_Iptal_Iade_KismiRequestDTO
    {
        public ST_WS_Guvenlik G { get; set; } = null!;
        public string GUID { get; set; } = string.Empty;
        public string Durum { get; set; } = string.Empty;
        public string Dekont_ID { get; set; } = string.Empty;
        public double Tutar { get; set; }
    }
}