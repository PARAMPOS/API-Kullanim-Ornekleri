using TurkPosWSTEST;

namespace WebMvc.DTOs.MoneyPay_Islem_Sorgulama
{
    public class MoneyPay_Islem_SorgulamaRequestDTO
    {
        public ST_WS_Guvenlik G { get; set; } = null!;
        public string GUID { get; set; } = string.Empty;
        public string Siparis_ID { get; set; } = string.Empty;
        public string Tarih_Bas { get; set; } = string.Empty;
        public string Tarih_Bit { get; set; } = string.Empty;
    }
}