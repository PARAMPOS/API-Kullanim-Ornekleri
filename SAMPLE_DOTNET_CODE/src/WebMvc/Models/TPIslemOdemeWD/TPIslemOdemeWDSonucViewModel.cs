using TurkPosWSTEST;
using WebMvc.DTOs.Pos_Odeme;

namespace WebMvc.Models.TPIslemOdemeWD
{
    public class TPIslemOdemeWDSonucViewModel
    {
        public ST_TP_Islem_Odeme? SonucNonSecure { get; set; }
        public TPIslemOdemeWDPostDTO? Sonuc3DSecure { get; set; }
    }
}