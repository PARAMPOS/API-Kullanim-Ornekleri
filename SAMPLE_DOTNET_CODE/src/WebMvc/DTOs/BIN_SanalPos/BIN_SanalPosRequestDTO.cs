using TurkPosWSTEST;

namespace WebMvc.DTOs.BIN_SanalPos
{
    public class BIN_SanalPosRequestDTO
    {
        public ST_WS_Guvenlik G { get; set; } = null!;
        public string BIN { get; set; } = string.Empty;
    }
}