using TP_KS;

namespace WebMvc.Models.KSTahsilat
{
    public class KSTahsilatViewModel
    {
        public ST_WS_Guvenlik G { get; set; } = new() { CLIENT_CODE = 10738, CLIENT_USERNAME = "test", CLIENT_PASSWORD = "test" };
        public string GUID { get; set; } = "0c13d406-873b-403b-9c09-a5766840d98c";
        public string KS_GUID { get; set; } = "0af56e91-5737-4268-bd86-57965b88d140";
        public string CVV { get; set; } = "000";
        public string KK_Sahibi_GSM { get; set; } = "5551231212";
        public string Hata_URL { get; set; } = "https://localhost:7113/Sonuc/KSTahsilat";
        public string Basarili_URL { get; set; } = "https://localhost:7113/Sonuc/KSTahsilat";
        public string Siparis_ID { get; set; } = "sipariş1";
        public string Siparis_Aciklama { get; set; } = string.Empty;
        public int Taksit { get; set; } = 1;
        public string Islem_Tutar { get; set; } = "100.00";
        public string Toplam_Tutar { get; set; } = "100.00";
        public string Islem_Guvenlik_Tip { get; set; } = string.Empty;
        public string Islem_ID { get; set; } = string.Empty;
        public string IPAdr { get; set; } = "127.0.0.1";
        public string Ref_URL { get; set; } = string.Empty;
        public string Data1 { get; set; } = string.Empty;
        public string Data2 { get; set; } = string.Empty;
        public string Data3 { get; set; } = string.Empty;
        public string Data4 { get; set; } = string.Empty;
        public string KK_Islem_ID { get; set; } = string.Empty;
    }
}