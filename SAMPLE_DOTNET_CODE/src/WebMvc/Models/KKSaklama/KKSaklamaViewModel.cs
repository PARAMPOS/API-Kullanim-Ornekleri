using TurkPosWSTEST;

namespace WebMvc.Models.KKSaklama
{
    public class KKSaklamaViewModel
    {
        public ST_WS_Guvenlik G { get; set; } = new() { CLIENT_CODE = "10738", CLIENT_USERNAME = "test", CLIENT_PASSWORD = "test" };
        public string GUID { get; set; } = "0c13d406-873b-403b-9c09-a5766840d98c";
        public string Kart_No { get; set; } = string.Empty;
        public string KK_Sahibi { get; set; } = "Nikola Tesla";
        public string KK_No { get; set; } = string.Empty;
        public string KK_SK_Ay { get; set; } = string.Empty;
        public string KK_SK_Yil { get; set; } = string.Empty;
        public string KK_CVV { get; set; } = string.Empty;
        public string Data1 { get; set; } = string.Empty;
        public string Data2 { get; set; } = string.Empty;
        public string Data3 { get; set; } = string.Empty;
    }
}