using System.Xml.Serialization;

namespace WebMvc.DTOs.TP_Mutabakat_Ozet
{
    [XmlRoot(ElementName = "DT_Mutabakat_Ozet")]
    public class TP_Mutabakat_OzetDT_BilgiDTO
    {
        public string? Basarili_Islem_Sayi { get; set; }
        public string? Basarili_Islem_Toplam_Tutar { get; set; }
        public string? Iptal_Islem_Sayi { get; set; }
        public string? Iptal_Islem_Toplam_Tutar { get; set; }
        public string? Iade_Islem_Sayi { get; set; }
        public string? Iade_Islem_Toplam_Tutar { get; set; }
    }
}