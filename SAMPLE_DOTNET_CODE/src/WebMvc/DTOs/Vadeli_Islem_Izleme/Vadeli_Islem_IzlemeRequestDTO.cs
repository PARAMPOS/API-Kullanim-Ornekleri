using TurkPosWSTEST;

namespace WebMvc.DTOs.Vadeli_Islem_Izleme
{
    public class Vadeli_Islem_IzlemeRequestDTO
    {
        public ST_WS_Guvenlik G { get; set; } = null!;
        public string GUID { get; set; } = string.Empty;
        public string Tarih_Bas { get; set; } = string.Empty;
        public string Tarih_Bit { get; set; } = string.Empty;
        public string Siparis_No { get; set; } = string.Empty;
    }
}