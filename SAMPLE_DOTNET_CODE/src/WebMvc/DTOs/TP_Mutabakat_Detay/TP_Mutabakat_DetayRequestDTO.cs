using TurkPosWSTEST;

namespace WebMvc.DTOs.TP_Mutabakat_Detay
{
    public class TP_Mutabakat_DetayRequestDTO
    {
        public ST_WS_Guvenlik G { get; set; } = null!;
        public string GUID { get; set; } = string.Empty;
        public string Tarih { get; set; } = string.Empty;
    }
}