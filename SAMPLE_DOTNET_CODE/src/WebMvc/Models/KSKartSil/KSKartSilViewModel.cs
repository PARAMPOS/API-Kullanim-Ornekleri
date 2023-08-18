using TP_KS;

namespace WebMvc.Models.KSKartSil
{
    public class KSKartSilViewModel
    {
        public ST_WS_Guvenlik G { get; set; } = new() { CLIENT_CODE = 10738, CLIENT_USERNAME = "test", CLIENT_PASSWORD = "test" };
        public string KS_GUID { get; set; } = "7647f35d-7f37-4f83-bdc6-37c1e18fcd96";
        public string KK_Islem_ID { get; set; } = "1014";
    }
}