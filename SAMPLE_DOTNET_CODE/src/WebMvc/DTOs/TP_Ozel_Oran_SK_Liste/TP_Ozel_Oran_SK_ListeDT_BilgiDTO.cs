using System.Xml.Serialization;

namespace WebMvc.DTOs.TP_Ozel_Oran_SK_Liste
{
    [XmlRoot(ElementName = "DT_Ozel_Oranlar_SK")]
    public class TP_Ozel_Oran_SK_ListeDT_BilgiDTO
    {
        public long? Ozel_Oran_SK_ID { get; set; }
        public string? GUID { get; set; }
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