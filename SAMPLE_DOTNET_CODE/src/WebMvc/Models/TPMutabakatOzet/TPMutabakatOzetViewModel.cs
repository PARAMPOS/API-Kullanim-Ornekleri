using TurkPosWSTEST;

namespace WebMvc.Models.TPMutabakatOzet
{
    public class TPMutabakatOzetViewModel
    {
        public ST_WS_Guvenlik G { get; set; } = new() { CLIENT_CODE = "10738", CLIENT_USERNAME = "test", CLIENT_PASSWORD = "test" };
        public string GUID { get; set; } = "0c13d406-873b-403b-9c09-a5766840d98c";
        public string Tarih_Bas { get; set; } = "20.11.2015 00:00:00";
        public string Tarih_Bit { get; set; } = "20.11.2015 15:15:00";
    }
}