using TurkPosWSTEST;

namespace WebMvc.Models.IlListe
{
    public class IlListeViewModel
    {
        public ST_WS_Guvenlik G { get; set; } = new() { CLIENT_CODE = "10738", CLIENT_USERNAME = "test", CLIENT_PASSWORD = "test" };
    }
}