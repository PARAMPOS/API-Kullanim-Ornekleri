using TurkPosWSTEST;

namespace WebMvc.DTOs.KK_Saklama
{
    public class KK_SaklamaRequestDTO
    {
        public ST_WS_Guvenlik G { get; set; } = null!;
        public string Kart_No { get; set; } = string.Empty;
        public string KK_Sahibi { get; set; } = string.Empty;
        public string KK_No { get; set; } = string.Empty;
        public string KK_SK_Ay { get; set; } = string.Empty;
        public string KK_SK_Yil { get; set; } = string.Empty;
        public string KK_CVV { get; set; } = string.Empty;
        public string Data1 { get; set; } = string.Empty;
        public string Data2 { get; set; } = string.Empty;
        public string Data3 { get; set; } = string.Empty;
    }
}