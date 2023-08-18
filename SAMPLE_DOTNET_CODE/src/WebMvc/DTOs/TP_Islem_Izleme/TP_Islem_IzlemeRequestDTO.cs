using TurkPosWSTEST;

namespace WebMvc.DTOs.TP_Islem_Izleme
{
    public class TP_Islem_IzlemeRequestDTO
    {
        public ST_WS_Guvenlik G { get; set; } = null!;
        public string GUID { get; set; } = string.Empty;
        public string Tarih_Bas { get; set; } = string.Empty;
        public string Tarih_Bit { get; set; } = string.Empty;
        public string Islem_Tip { get; set; } = string.Empty;
        public string Islem_Durum { get; set; } = string.Empty;
    }
}