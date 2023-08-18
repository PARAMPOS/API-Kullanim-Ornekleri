using TurkPosWSTEST;

namespace WebMvc.DTOs.TP_Ozel_Oran_SK_Guncelle
{
    public class TP_Ozel_Oran_SK_GuncelleRequestDTO
    {
        public ST_WS_Guvenlik G { get; set; } = null!;
        public string GUID { get; set; } = string.Empty;
        public string Ozel_Oran_SK_ID { get; set; } = string.Empty;
        public string MO_1 { get; set; } = string.Empty;
        public string MO_2 { get; set; } = string.Empty;
        public string MO_3 { get; set; } = string.Empty;
        public string MO_4 { get; set; } = string.Empty;
        public string MO_5 { get; set; } = string.Empty;
        public string MO_6 { get; set; } = string.Empty;
        public string MO_7 { get; set; } = string.Empty;
        public string MO_8 { get; set; } = string.Empty;
        public string MO_9 { get; set; } = string.Empty;
        public string MO_10 { get; set; } = string.Empty;
        public string MO_11 { get; set; } = string.Empty;
        public string MO_12 { get; set; } = string.Empty;
    }
}