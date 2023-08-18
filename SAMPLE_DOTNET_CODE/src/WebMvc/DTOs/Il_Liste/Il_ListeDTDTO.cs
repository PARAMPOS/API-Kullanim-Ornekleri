using System.Xml.Serialization;

namespace WebMvc.DTOs.Il_Liste
{
    [XmlRoot(ElementName = "Temp")]
    public class Il_ListeDTDTO
    {
        public string? Plaka { get; set; }
        public string? IL { get; set; }
    }
}