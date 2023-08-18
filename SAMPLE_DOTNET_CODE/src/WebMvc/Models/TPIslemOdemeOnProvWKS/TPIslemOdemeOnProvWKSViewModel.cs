using TurkPosWSTEST;

namespace WebMvc.Models.TPIslemOdemeOnProvWKS
{
    public class TPIslemOdemeOnProvWKSViewModel
    {
        public ST_WS_Guvenlik G { get; set; } = new() { CLIENT_CODE = "10738", CLIENT_USERNAME = "test", CLIENT_PASSWORD = "test" };
        public string GUID { get; set; } = "0c13d406-873b-403b-9c09-a5766840d98c";
        public string KS_Kart_No { get; set; } = "0c13d406-873b-403b-9c09-a5766840d98c";
        public string KK_GUID { get; set; } = "29a768aa-c8ab-4868-ba34-de172fe5274a";
        public string KK_Sahibi_GSM { get; set; } = "5454845";
        public string Hata_URL { get; set; } = "https://localhost:7113/Sonuc/TPIslemOdemeOnProvWKS";
        public string Basarili_URL { get; set; } = "https://localhost:7113/Sonuc/TPIslemOdemeOnProvWKS";
        public string Siparis_ID { get; set; } = "147963";
        public string Siparis_Aciklama { get; set; } = "string";
        public string Islem_Tutar { get; set; } = "100.00";
        public string Toplam_Tutar { get; set; } = "100.00";
        public string Islem_Hash { get; set; } = "VIwkKAhPVr0r05Ze1zgCLGc0AV0=";
        public string Islem_Guvenlik_Tip { get; set; } = "3D";
        public string Islem_ID { get; set; } = "sipariş11";
        public string IPAdr { get; set; } = "127.0.0.1";
        public string Ref_URL { get; set; } = string.Empty;
        public string Data1 { get; set; } = string.Empty;
        public string Data2 { get; set; } = string.Empty;
        public string Data3 { get; set; } = string.Empty;
        public string Data4 { get; set; } = string.Empty;
        public string Data5 { get; set; } = string.Empty;
    }
}