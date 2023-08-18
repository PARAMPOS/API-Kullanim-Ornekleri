using TurkPosWSTEST;

namespace WebMvc.Models.PazaryeriTPSiparisOnay
{
    public class PazaryeriTPSiparisOnayViewModel
    {
        public ST_WS_Guvenlik G { get; set; } = new() { CLIENT_CODE = "10738", CLIENT_USERNAME = "test", CLIENT_PASSWORD = "test" };
        public string PYSiparis_GUID { get; set; } = "02540E9E6-4733-4C45-99C6-C1B0F896136F";
        public string Durum { get; set; } = "1";
    }
}