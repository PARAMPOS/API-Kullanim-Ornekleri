using System.Xml;

namespace WebMvc.DTOs.TP_Ozel_Oran_Liste
{
    public class TP_Ozel_Oran_ListeResponseDTO
    {
        public XmlDocument? DT_Bilgi { get; set; }
        public string? Sonuc { get; set; }
        public string? Sonuc_Str { get; set; }
    }
}