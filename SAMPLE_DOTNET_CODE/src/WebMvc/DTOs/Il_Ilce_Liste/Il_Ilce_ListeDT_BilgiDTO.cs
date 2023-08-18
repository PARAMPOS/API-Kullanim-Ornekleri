using System.Xml.Serialization;

namespace WebMvc.DTOs.Il_Ilce_Liste
{
    [XmlRoot(ElementName = "Temp")]
    public class Il_Ilce_ListeDT_BilgiDTO
    {
        public string? Ilce_Kodu { get; set; }
        public string? Ilce { get; set; }
    }
}