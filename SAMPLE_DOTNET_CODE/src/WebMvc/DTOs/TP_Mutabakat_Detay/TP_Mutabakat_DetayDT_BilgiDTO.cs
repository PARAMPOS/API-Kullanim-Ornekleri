using System.Xml.Serialization;

namespace WebMvc.DTOs.TP_Mutabakat_Detay
{
    [XmlRoot(ElementName = "Temp")]
    public class TP_Mutabakat_DetayDT_BilgiDTO
    {
        public string? GUNSONU_TARIHI { get; set; }
        public string? ISLEM_TARIHI { get; set; }
        public string? VALOR_TARIHI { get; set; }
        public string? KART_NO { get; set; }
        public string? TRANSACTION_TIPI { get; set; }
        public string? PROVIZYON_NO { get; set; }
        public int? TAKSIT_SIRA { get; set; }
        public int? TAKSIT_SAYISI { get; set; }
        public string? PROVIZYON_TUTARI { get; set; }
        public string? KOMISYON_TUTARI { get; set; }
        public string? KOMISYON_ORANI { get; set; }
        public string? NET_TUTAR { get; set; }
        public string? SIPARIS_NO { get; set; }
        public string? ANA_KART_TIPI { get; set; }
        public string? ALT_KART_TIPI { get; set; }
    }
}