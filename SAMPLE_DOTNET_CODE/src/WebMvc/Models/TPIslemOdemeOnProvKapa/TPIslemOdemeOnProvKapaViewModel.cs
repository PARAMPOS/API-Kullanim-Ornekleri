using TurkPosWSTEST;

namespace WebMvc.Models.TPIslemOdemeOnProvKapa
{
    public class TPIslemOdemeOnProvKapaViewModel
    {
        public ST_TP_Islem_Odeme Sonuc { get; set; } = null!;
        public ST_WS_Guvenlik G { get; set; } = new() { CLIENT_CODE = "10738", CLIENT_USERNAME = "test", CLIENT_PASSWORD = "test" };
        public string GUID { get; set; } = "0c13d406-873b-403b-9c09-a5766840d98c";
        public string Prov_ID { get; set; } = string.Empty;
        public string Prov_Tutar { get; set; } = string.Empty;
        public string Siparis_ID { get; set; } = string.Empty;
    }
}