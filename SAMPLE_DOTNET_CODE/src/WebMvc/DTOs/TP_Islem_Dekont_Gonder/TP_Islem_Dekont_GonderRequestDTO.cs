using TurkPosWSTEST;

namespace WebMvc.DTOs.TP_Islem_Dekont_Gonder
{
    public class TP_Islem_Dekont_GonderRequestDTO
    {
        public ST_WS_Guvenlik G { get; set; } = null!;
        public string GUID { get; set; } = string.Empty;
        public string Dekont_ID { get; set; } = string.Empty;
        public string E_Posta { get; set; } = string.Empty;
    }
}