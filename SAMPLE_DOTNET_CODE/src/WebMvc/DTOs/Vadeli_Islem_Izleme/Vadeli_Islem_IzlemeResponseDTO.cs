using TurkPosWSTEST;

namespace WebMvc.DTOs.Vadeli_Islem_Izleme
{
    public class Vadeli_Islem_IzlemeResponseDTO
    {
        public string? Sonuc { get; set; }
        public string? Sonuc_Str { get; set; }
        public List<CL_Res_Vadeli_Islem_Izleme_Sonuc>? Info { get; set; }
    }
}