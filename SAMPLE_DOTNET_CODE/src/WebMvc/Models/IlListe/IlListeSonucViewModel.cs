using WebMvc.DTOs.Il_Liste;

namespace WebMvc.Models.IlListe
{
    public class IlListeSonucViewModel
    {
        public int Sonuc { get; set; }
        public string? Sonuc_Str { get; set; }
        public List<Il_ListeDTDTO>? DT { get; set; }
    }
}