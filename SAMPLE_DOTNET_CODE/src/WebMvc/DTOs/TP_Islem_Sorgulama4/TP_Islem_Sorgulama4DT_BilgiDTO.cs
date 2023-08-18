namespace WebMvc.DTOs.TP_Islem_Sorgulama4
{
    public class TP_Islem_Sorgulama4DT_BilgiDTO
    {
        public int? Odeme_Sonuc { get; set; }
        public string? Odeme_Sonuc_Aciklama { get; set; }
        public string? Dekont_ID { get; set; }
        public string? Siparis_ID { get; set; }
        public string? Islem_ID { get; set; }
        public string? Durum { get; set; }
        public string? Tarih { get; set; }
        public double? Toplam_Tutar { get; set; }
        public double? Komisyon_Oran { get; set; }
        public double? Komisyon_Tutar { get; set; }
        public string? Banka_Sonuc_Aciklama { get; set; }
        public int? Taksit { get; set; }
        public string? Ext_Data { get; set; }
        public double? Toplam_Iade_Tutar { get; set; }
        public string? KK_No { get; set; }
        public string? Bank_Extra { get; set; }
        public string? Islem_Tip { get; set; }
        public string? Bank_Trans_ID { get; set; }
        public string? Bank_AuthCode { get; set; }
        public string? Bank_HostRefNum { get; set; }
    }
}