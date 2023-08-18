using TurkPosWSTEST;

namespace WebMvc.DTOs.Pazaryeri_TP_Siparis_Detay_Ekle
{
    public class Pazaryeri_TP_Siparis_Detay_EkleRequestDTO
    {
        public ST_WS_Guvenlik G { get; set; } = null!;
        public string ETS_GUID { get; set; } = string.Empty;
        public string Tutar_Urun { get; set; }= string.Empty;
        public string Tutar_Odenecek { get; set; }= string.Empty;
        public string SanalPOS_Islem_ID { get; set; }= string.Empty;
        public string GUID_AltUyeIsyeri { get; set; }= string.Empty;
    }
}