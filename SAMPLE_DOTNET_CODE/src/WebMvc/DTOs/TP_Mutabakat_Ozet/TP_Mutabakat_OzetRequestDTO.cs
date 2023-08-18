using TurkPosWSTEST;

namespace WebMvc.DTOs.TP_Mutabakat_Ozet
{
    public class TP_Mutabakat_OzetRequestDTO
    {
        public ST_WS_Guvenlik G { get; set; } = null!;
        public string GUID { get; set; } = string.Empty;
        public string Tarih_Bas { get; set; } = string.Empty;
        public string Tarih_Bit { get; set; } = string.Empty;
    }
}