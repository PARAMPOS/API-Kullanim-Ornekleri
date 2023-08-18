using TurkPosWSTEST;

namespace WebMvc.Models.PazaryeriTPAltUyeIsyeriListe
{
    public class PazaryeriTPAltUyeIsyeriListeViewModel
    {
        public ST_WS_Guvenlik G { get; set; } = new() { CLIENT_CODE = "10738", CLIENT_USERNAME = "test", CLIENT_PASSWORD = "test" };
        public string ETS_GUID { get; set; } = "0c13d406-873b-403b-9c09-a5766840d98c";
        public string Limit { get; set; } = "2";
        public string Skip { get; set; } = "1";
    }
}