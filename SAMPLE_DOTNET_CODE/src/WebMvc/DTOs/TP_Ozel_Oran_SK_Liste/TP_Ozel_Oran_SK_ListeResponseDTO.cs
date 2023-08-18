using System.Xml;

namespace WebMvc.DTOs.TP_Ozel_Oran_SK_Liste
{
    public class TP_Ozel_Oran_SK_ListeResponseDTO
    {
        public XmlDocument? DT_Bilgi { get; set; }
        public string? Sonuc { get; set; }
        public string? Sonuc_Str { get; set; }
    }
}