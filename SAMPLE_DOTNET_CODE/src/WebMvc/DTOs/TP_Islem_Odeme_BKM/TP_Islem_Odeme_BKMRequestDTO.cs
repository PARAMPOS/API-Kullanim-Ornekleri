using TurkPosWSTEST;

namespace WebMvc.DTOs.TP_Islem_Odeme_BKM
{
    public class TP_Islem_Odeme_BKMRequestDTO
    {
        public ST_WS_Guvenlik G { get; set; } = null!;
        public string GUID { get; set; } = string.Empty;
        public string Customer_Info { get; set; } = string.Empty;
        public string Customer_GSM { get; set; } = string.Empty;
        public string Error_URL { get; set; } = string.Empty;
        public string Success_URL { get; set; } = string.Empty;
        public string Order_ID { get; set; } = string.Empty;
        public string Order_Description { get; set; } = string.Empty;
        public string Amount { get; set; } = string.Empty;
        public string Payment_Hash { get; set; } = string.Empty;
        public string Transaction_ID { get; set; } = string.Empty;
        public string IPAddress { get; set; } = string.Empty;
        public string Referrer_URL { get; set; } = string.Empty;
    }
}