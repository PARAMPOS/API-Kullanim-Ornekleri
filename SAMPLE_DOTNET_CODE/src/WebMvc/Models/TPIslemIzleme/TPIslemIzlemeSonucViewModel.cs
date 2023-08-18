using WebMvc.DTOs.TP_Islem_Izleme;

namespace WebMvc.Models.TPIslemIzleme
{
    public class TPIslemIzlemeSonucViewModel
    {
        public List<TP_Islem_IzlemeDT_BilgiDTO>? DT_Bilgi { get; set; }
        public string? Sonuc { get; set; }
        public string? Sonuc_Str { get; set; }
    }
}