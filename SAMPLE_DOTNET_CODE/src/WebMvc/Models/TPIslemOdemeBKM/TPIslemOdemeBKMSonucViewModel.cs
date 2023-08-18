using TurkPosWSTEST;
using WebMvc.DTOs.TP_Islem_Odeme_BKM;

namespace WebMvc.Models.TPIslemOdemeBKM
{
    public class TPIslemOdemeBKMSonucViewModel
    {
        public ST_TP_Islem_Odeme_BKM? Sonuc { get; set; }
        public TP_Islem_Odeme_BKMPOSTDTO? SonucPOST { get; set; }
    }
}