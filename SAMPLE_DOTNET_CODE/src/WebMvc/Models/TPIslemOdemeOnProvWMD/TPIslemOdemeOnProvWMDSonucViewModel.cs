using TurkPosWSTEST;
using WebMvc.DTOs.TP_Islem_Odeme_OnProv_WMD;

namespace WebMvc.Models.TPIslemOdemeOnProvWMD
{
    public class TPIslemOdemeOnProvWMDSonucViewModel
    {
        public ST_WMD_UCD? SonucNonSecure { get; set; }
        public TP_Islem_Odeme_OnProv_WMDPostDTO? Sonuc3DSecure { get; set; }
        public ST_WMD_Pay? Completed3DSecure { get; set; }
        public int? Onaylandı { get; set; }
        public long? IslemID { get; set; }
    }
}