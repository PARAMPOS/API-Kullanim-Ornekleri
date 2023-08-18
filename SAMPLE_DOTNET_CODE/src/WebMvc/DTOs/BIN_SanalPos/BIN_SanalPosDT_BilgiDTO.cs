using System.Xml.Serialization;

namespace WebMvc.DTOs.BIN_SanalPos
{
    [XmlRoot(ElementName = "Temp")]
    public class BIN_SanalPosDT_BilgiDTO
    {
        public string? BIN { get; set; }
        public string? SanalPOS_ID { get; set; }
        public string? Kart_Banka { get; set; }
        public string? DKK { get; set; }
        public string? Kart_Tip { get; set; }
        public string? Kart_Org { get; set; }
        public string? Banka_Kodu { get; set; }
        public string? Kart_Ticari { get; set; }
        public string? Kart_Marka { get; set; }
    }
}