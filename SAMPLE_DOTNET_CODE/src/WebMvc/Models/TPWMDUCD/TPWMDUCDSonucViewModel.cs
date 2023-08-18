using TurkPosWSTEST;
using WebMvc.DTOs.TP_WMD_UCD;

namespace WebMvc.Models.TPWMDUCD
{
    public class TPWMDUCDSonucViewModel
    {
        public ST_WMD_UCD? SonucNonSecure { get; set; }
        public TP_WMD_UCDPostDTO? Sonuc3DSecure { get; set; }
        public ST_WMD_Pay? Completed3DSecure { get; set; }
        public int? Onaylandı { get; set; }
        public long? IslemID { get; set; }
    }
}