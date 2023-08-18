using TurkPosWSTEST;

namespace WebMvc.Models.BINSanalPos
{
    public class BINSanalPosViewModel
    {
        public ST_WS_Guvenlik G { get; set; } = new() { CLIENT_CODE = "10738", CLIENT_USERNAME = "test", CLIENT_PASSWORD = "test" };
        public string BIN { get; set; } = "454671";
    }
}