using TurkPosWSTEST;

namespace WebMvc.DTOs.Pos_Plugin_Bildirim
{
    public class Pos_Plugin_BildirimRequestDTO
    {
        public ST_WS_Guvenlik G { get; set; } = null!;
        public string ETS_GUID { get; set; } = string.Empty;
        public string Domain_Adres { get; set; } = string.Empty;
        public string Yazilim_Bilgisi { get; set; } = string.Empty;
        public string Yazilim_Surum_Bilgisi { get; set; } = string.Empty;
    }
}