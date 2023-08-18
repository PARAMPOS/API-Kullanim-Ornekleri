namespace WebMvc.DTOs.TP_WMD_Pay
{
    public class TP_WMD_PayResponseDTO
    {
        public int? Sonuc { get; set; }
        public string? Sonuc_Ack { get; set; }
        public string? Dekont_ID { get; set; }
        public string? Siparis_ID { get; set; }
        public string? UCD_MD { get; set; }
        public string? Bank_Trans_ID { get; set; }
        public string? Bank_AuthCode { get; set; }
        public string? Bank_HostMsg { get; set; }
        public string? Bank_Extra { get; set; }
        public int? Bank_Sonuc_Kod { get; set; }
        public string? Bank_HostRefNum { get; set; }
        public double? Komisyon_Oran { get; set; }
    }
}