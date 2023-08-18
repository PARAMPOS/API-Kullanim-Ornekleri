using System.Xml;

namespace WebMvc.DTOs.KS_Kart_Liste_Pagination
{
    public class KS_Kart_Liste_PaginationResponseDTO
    {
        public string? Sonuc { get; set; }
        public string? Sonuc_Str { get; set; }
        public XmlDocument? DT_Bilgi { get; set; }
    }
}