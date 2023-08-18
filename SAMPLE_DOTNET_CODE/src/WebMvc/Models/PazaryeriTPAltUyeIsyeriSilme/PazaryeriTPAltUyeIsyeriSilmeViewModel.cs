using TurkPosWSTEST;

namespace WebMvc.Models.PazaryeriTPAltUyeIsyeriSilme
{
    public class PazaryeriTPAltUyeIsyeriSilmeViewModel
    {
        public ST_WS_Guvenlik G { get; set; } = new() { CLIENT_CODE = "10738", CLIENT_USERNAME = "test", CLIENT_PASSWORD = "test" };
        public string GUID_AltUyeIsyeri { get; set; } = "a5c158be-8aaa-4716-abdc-f6f99eadfc81";
    }
}