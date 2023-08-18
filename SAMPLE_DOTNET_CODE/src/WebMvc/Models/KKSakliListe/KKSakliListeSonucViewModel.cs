using WebMvc.DTOs.KK_Sakli_Liste;

namespace WebMvc.Models.KKSakliListe
{
    public class KKSakliListeSonucViewModel
    {
        public List<KK_Sakli_ListeDT_BilgiDTO>? DT_Bilgi { get; set; }
        public string? Sonuc { get; set; }
        public string? Sonuc_Str { get; set; }
    }
}