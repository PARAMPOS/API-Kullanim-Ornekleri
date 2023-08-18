using TurkPosWSTEST;

namespace WebMvc.DTOs.TP_KK_Verify
{
    public class TP_KK_VerifyRequestDTO
    {
        public ST_WS_Guvenlik G { get; set; } = null!;
        public string KK_No { get; set; } = string.Empty;
        public string KK_SK_Ay { get; set; } = string.Empty;
        public string KK_SK_Yil { get; set; } = string.Empty;
        public string KK_CVC { get; set; } = string.Empty;
        public string Return_URL { get; set; } = string.Empty;
        public string Data1 { get; set; } = string.Empty;
        public string Data2 { get; set; } = string.Empty;
        public string Data3 { get; set; } = string.Empty;
        public string Data4 { get; set; } = string.Empty;
        public string Data5 { get; set; } = string.Empty;
    }
}