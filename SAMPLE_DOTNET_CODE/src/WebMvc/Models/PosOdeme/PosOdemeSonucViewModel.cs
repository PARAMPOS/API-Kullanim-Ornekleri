using TurkPosWSTEST;
using WebMvc.DTOs.Pos_Odeme;

namespace WebMvc.Models.PosOdeme
{
    public class PosOdemeSonucViewModel
    {
        public ST_TP_Islem_Odeme? SonucNonSecure { get; set; }
        public Pos_OdemePostDTO? Sonuc3DSecure { get; set; }
    }
}