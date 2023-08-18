using TurkPosWSTEST;

namespace WebMvc.DTOs.Pazaryeri_TP_AltUyeIsyeri_Silme
{
    public class Pazaryeri_TP_AltUyeIsyeri_SilmeRequestDTO
    {
        public ST_WS_Guvenlik G { get; set; } = null!;
        public string GUID_AltUyeIsyeri { get; set; } = string.Empty;
    }
}