using System.Xml.Serialization;

namespace WebMvc.DTOs.TP_Islem_Izleme
{
    [XmlRoot(ElementName = "Temp")]
    public class TP_Islem_IzlemeDT_BilgiDTO
    {
        public long? SanalPOS_Islem_ID { get; set; }
        public long? SanalPOS_Islem_ID_Orj { get; set; }
        public string? Sonuc_Str { get; set; }
        public string? Tip_Str { get; set; }
        public string? Tarih { get; set; }
        public string? Odeme_Yapan_Bilgisi { get; set; }
        public string? Odeme_Yapan_AdSoyad { get; set; }
        public string? Odeme_Yapan_GSM { get; set; }
        public string? Odeme_Yapan_TC { get; set; }
        public string? Odeme_Aciklama { get; set; }
        public int? Taksit { get; set; }
        public string? SanalPOS_Banka { get; set; }
        public string? Komisyon_Oran { get; set; }
        public string? Komisyon_Tutar { get; set; }
        public string? Net_Tutar { get; set; }
        public string? Tutar { get; set; }
        public string? Islem_Guvenlik { get; set; }
        public long? Dekont_ID { get; set; }
        public string? ORJ_ORDER_ID { get; set; }
        public int? Sonuc { get; set; }
        public string? Kaynak { get; set; }
        public string? Toplam_Iade_Tutar { get; set; }
        public string? ORJ_Tarih { get; set; }
        public string? PB { get; set; }
    }
}