namespace WebMvc.DTOs.TP_WMD_Pay
{
    public class TP_WMD_PayPostDTO
    {
        public string md { get; set; } = string.Empty;
        public string mdStatus { get; set; } = string.Empty;
        public string orderId { get; set; } = string.Empty;
        public string transactionAmount { get; set; } = string.Empty;
        public string islemGUID { get; set; } = string.Empty;
        public string islemHash { get; set; } = string.Empty;
        public string bankResult { get; set; } = string.Empty;
        public string dc { get; set; } = string.Empty;
        public string dcUrl { get; set; } = string.Empty;
    }
}