namespace WebMvc.DTOs.TP_Islem_Odeme_OnProv_Kapa
{
    public class TP_Islem_Odeme_OnProv_KapaResponseDTO
    {
        public string? Sonuc { get; set; }
        public string? Sonuc_Str { get; set; }
        public string? Prov_ID { get; set; }
        public long? Dekont_ID { get; set; }
        public int? Banka_Sonuc_Kod { get; set; }
        public string? Siparis_ID { get; set; }
        public string? Bank_Trans_ID { get; set; }
        public string? Bank_AuthCode { get; set; }
        public string? Bank_HostMsg { get; set; }
        public string? Bank_Extra { get; set; }
        public string? Bank_HostRefNum { get; set; }
    }
}