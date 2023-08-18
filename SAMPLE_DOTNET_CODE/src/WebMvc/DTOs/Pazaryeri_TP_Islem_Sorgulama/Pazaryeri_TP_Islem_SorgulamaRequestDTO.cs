using TurkPosWSTEST;

namespace WebMvc.DTOs.Pazaryeri_TP_Islem_Sorgulama
{
    public class Pazaryeri_TP_Islem_SorgulamaRequestDTO
    {
        public ST_WS_Guvenlik G { get; set; } = null!;
        public string ETS_GUID { get; set; } = string.Empty;
        public string GUID_AltUyeIsyeri { get; set; } = string.Empty;
        public string PYSiparis_GUID { get; set; } = string.Empty;
        public long SanalPOS_Islem_ID { get; set; }
        public string Tarih_Bas { get; set; } = string.Empty;
        public string Tarih_Bit { get; set; } = string.Empty;
    }
}