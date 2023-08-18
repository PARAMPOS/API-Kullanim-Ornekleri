using System.Xml.Serialization;

namespace WebMvc.DTOs.KS_Kart_Liste
{
    [XmlRoot(ElementName = "Temp")]
    public class KS_Kart_ListeDT_BilgiDTO
    {
        public string? ID { get; set; }
        public string? KK_GUID { get; set; }
        public string? Tarih { get; set; }
        public string? KK_No { get; set; }
        public string? KK_Tip { get; set; }
        public string? KK_Banka { get; set; }
        public string? KK_Marka { get; set; }
        public string? Kart_Adi { get; set; }
        public string? KK_Hash { get; set; }
        public string? KK_KD { get; set; }
        public string? KK_SK { get; set; }
        public string? Data2 { get; set; }
    }
}