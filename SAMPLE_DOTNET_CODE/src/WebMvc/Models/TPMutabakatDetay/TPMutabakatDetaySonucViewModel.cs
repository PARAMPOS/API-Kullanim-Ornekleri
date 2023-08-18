using WebMvc.DTOs.TP_Mutabakat_Detay;

namespace WebMvc.Models.TPMutabakatDetay
{
    public class TPMutabakatDetaySonucViewModel
    {
        public TP_Mutabakat_DetayDT_BilgiDTO? DT_Bilgi { get; set; }
        public string? Sonuc { get; set; }
        public string? Sonuc_Str { get; set; }
    }
}