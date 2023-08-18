namespace WebMvc.DTOs.Pazaryeri_TP_Limit_Kontrol
{
    public class Pazaryeri_TP_Limit_KontrolResponseDTO
    {
        public string? Sonuc { get; set; }
        public string? Sonuc_Str { get; set; }
        public string? AltUyeIsyeri { get; set; }
        public bool? Odeme_Alma_Durumu { get; set; }
        public int? Toplam_Tahsilat_Tutari { get; set; }
        public int? Pazaryeri_Limit { get; set; }
        public int? Yeni_Odenecek_Tutar { get; set; }
    }
}