using WebMvc.DTOs.Il_Ilce_Liste;

namespace WebMvc.Models.IlIlceListe
{
    public class IlIlceListeSonucViewModel
    {
        public List<Il_Ilce_ListeDT_BilgiDTO>? DT_Bilgi { get; set; }
        public string? Sonuc { get; set; }
        public string? Sonuc_Str { get; set; }
    }
}