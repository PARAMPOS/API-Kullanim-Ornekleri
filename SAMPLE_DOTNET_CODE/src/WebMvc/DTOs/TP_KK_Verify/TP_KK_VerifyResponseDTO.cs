namespace WebMvc.DTOs.TP_KK_Verify
{
    public class TP_KK_VerifyResponseDTO
    {
        public long? Islem_ID { get; set; }
        public string? UCD_URL { get; set; }
        public string? Sonuc { get; set; }
        public string? Sonuc_Str { get; set; }
        public int? Banka_Sonuc_Kod { get; set; }
        public string? Siparis_ID { get; set; }
        public double? Komisyon_Oran { get; set; }
    }
}