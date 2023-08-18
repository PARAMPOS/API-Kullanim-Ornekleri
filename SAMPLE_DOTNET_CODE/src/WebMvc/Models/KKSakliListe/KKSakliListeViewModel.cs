using TurkPosWSTEST;

namespace WebMvc.Models.KKSakliListe
{
    public class KKSakliListeViewModel
    {
        public ST_WS_Guvenlik G { get; set; } = new() { CLIENT_CODE = "10738", CLIENT_USERNAME = "test", CLIENT_PASSWORD = "test" };
        public string Kart_No { get; set; } = string.Empty;
        public string KS_KK_Kisi_ID { get; set; } = string.Empty;
    }
}