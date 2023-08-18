using TurkPosWSTEST;

namespace WebMvc.DTOs.Pazaryeri_TP_Iptal_Iade
{
    public class Pazaryeri_TP_Iptal_IadeRequestDTO
    {
        public ST_WS_Guvenlik G { get; set; } = null!;
        public string PYSiparis_GUID { get; set; } = string.Empty;
        public string GUID { get; set; } = string.Empty;
        public string Durum { get; set; } = string.Empty;
        public string Siparis_ID { get; set; } = string.Empty;
        public double SiparisTutar { get; set; }
        public double OdenecekTutar { get; set; }
    }
}