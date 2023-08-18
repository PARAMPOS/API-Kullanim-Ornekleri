namespace WebMvc.DTOs.TP_Islem_Odeme_WKS
{
    public class TP_Islem_Odeme_WKSResponseDTO
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