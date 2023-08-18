using TurkPosWSTEST;

namespace WebMvc.DTOs.TP_WMD_Pay
{
    public class TP_WMD_PayRequestDTO
    {
        public ST_WS_Guvenlik G { get; set; } = null!;
        public string GUID { get; set; } = string.Empty;
        public string UCD_MD { get; set; } = string.Empty;
        public string Islem_GUID { get; set; } = string.Empty;
        public string Siparis_ID { get; set; } = string.Empty;
    }
}