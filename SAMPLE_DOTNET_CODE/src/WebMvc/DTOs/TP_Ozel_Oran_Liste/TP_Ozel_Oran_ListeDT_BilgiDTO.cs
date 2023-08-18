using System.Xml.Serialization;
using System.Xml.XPath;

namespace WebMvc.DTOs.TP_Ozel_Oran_Liste
{
    [Serializable]
    [XmlRoot(ElementName = "DT_Ozel_Oranlar")]
    public class TP_Ozel_Oran_ListeDT_BilgiDTO
    {
        public long? Ozel_Oran_ID { get; set; }
        public string? GUID { get; set; }
        public string? Tarih_Bas { get; set; }
        public string? Tarih_Bit { get; set; }
        public int? SanalPOS_ID { get; set; }
        public string? Kredi_Karti_Banka { get; set; }
        public string? Kredi_Karti_Banka_Gorsel { get; set; }
        public string? MO_01 { get; set; }
        public string? MO_02 { get; set; }
        public string? MO_03 { get; set; }
        public string? MO_04 { get; set; }
        public string? MO_05 { get; set; }
        public string? MO_06 { get; set; }
        public string? MO_07 { get; set; }
        public string? MO_08 { get; set; }
        public string? MO_09 { get; set; }
        public string? MO_10 { get; set; }
        public string? MO_11 { get; set; }
        public string? MO_12 { get; set; }
    }
}