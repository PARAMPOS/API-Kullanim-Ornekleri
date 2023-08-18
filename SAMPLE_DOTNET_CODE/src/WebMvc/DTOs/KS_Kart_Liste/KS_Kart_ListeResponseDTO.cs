using System.Xml;

namespace WebMvc.DTOs.KS_Kart_Liste
{
    public class KS_Kart_ListeResponseDTO
    {
        public string? Sonuc { get; set; }
        public string? Sonuc_Str { get; set; }
        public XmlDocument? DT_Bilgi { get; set; }
    }
}