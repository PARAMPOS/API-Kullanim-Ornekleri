using TurkPosWSTEST;

namespace WebMvc.Models.TPMutabakatDetay
{
    public class TPMutabakatDetayViewModel
    {
        public ST_WS_Guvenlik G { get; set; } = new() { CLIENT_CODE = "10738", CLIENT_USERNAME = "test", CLIENT_PASSWORD = "test" };
        public string GUID { get; set; } = "0c13d406-873b-403b-9c09-a5766840d98c";
        public string Tarih { get; set; } = "14.04.2021 00:00:16<";
    }
}