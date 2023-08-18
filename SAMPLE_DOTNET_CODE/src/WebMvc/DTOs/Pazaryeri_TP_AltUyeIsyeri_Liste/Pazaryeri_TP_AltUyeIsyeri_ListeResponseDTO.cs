using System.Xml;

namespace WebMvc.DTOs.Pazaryeri_TP_AltUyeIsyeri_Liste
{
    public class Pazaryeri_TP_AltUyeIsyeri_ListeResponseDTO
    {
        public int? Toplam_Kayit { get; set; }
        public XmlDocument? DT_Bilgi { get; set; }
        public int? Sonuc { get; set; }
        public string? Sonuc_Str { get; set; }
        public string? GUID_AltUyeIsyeri { get; set; }
    }
}