using System.Xml;

namespace WebMvc.DTOs.Pazaryeri_TP_Islem_Sorgulama
{
    public class Pazaryeri_TP_Islem_SorgulamaResponseDTO
    {
        public XmlDocument? DT_Bilgi { get; set; }
        public string? Sonuc { get; set; }
        public string? Sonuc_Str { get; set; }
    }
}