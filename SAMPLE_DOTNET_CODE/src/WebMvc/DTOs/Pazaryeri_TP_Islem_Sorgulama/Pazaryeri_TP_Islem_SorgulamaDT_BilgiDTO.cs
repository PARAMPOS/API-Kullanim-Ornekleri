using System.Xml.Serialization;

namespace WebMvc.DTOs.Pazaryeri_TP_Islem_Sorgulama
{
    [XmlRoot(ElementName = "Temp")]
    public class Pazaryeri_TP_Islem_SorgulamaDT_BilgiDTO
    {
        public string? PYSiparis_GUID { get; set; }
        public string? Durum { get; set; }
        public string? Durum_Str { get; set; }
        public string? Tutar_Urun { get; set; }
        public string? Tutar_Odenecek { get; set; }
        public string? GUID_AltUyeIsyeri { get; set; }
        public string? SanalPOS_Islem_ID { get; set; }
        public string? Tarih { get; set; }
    }
}