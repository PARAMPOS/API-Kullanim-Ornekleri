using TurkPosWSTEST;

namespace WebMvc.Models.TPIslemOdemeOnProvWMD
{
    public class TPIslemOdemeOnProvWMDViewModel
    {
        public ST_WS_Guvenlik G { get; set; } = new() { CLIENT_CODE = "10738", CLIENT_USERNAME = "test", CLIENT_PASSWORD = "test" };
        public string GUID { get; set; } = "0c13d406-873b-403b-9c09-a5766840d98c";
        public string KK_Sahibi { get; set; } = "Albert Einstein";
        public string KK_No { get; set; } = string.Empty;
        public string KK_SK_Ay { get; set; } = string.Empty;
        public string KK_SK_Yil { get; set; } = string.Empty;
        public string KK_CVC { get; set; } = string.Empty;
        public string KK_Sahibi_GSM { get; set; } = "5555555555";
        public string Hata_URL { get; set; } = "https://localhost:7113/sonuc/tpislemodemeonprovwmd";
        public string Basarili_URL { get; set; } = "https://localhost:7113/op/modelonayla";
        public string Siparis_ID { get; set; } = string.Empty;
        public string Siparis_Aciklama { get; set; } = string.Empty;
        public string Islem_Tutar { get; set; } = string.Empty;
        public string Toplam_Tutar { get; set; } = string.Empty;
        public string Islem_Hash { get; set; } = string.Empty;
        public string Islem_Guvenlik_Tip { get; set; } = string.Empty;
        public string Islem_ID { get; set; } = string.Empty;
        public string IPAdr { get; set; } = "127.0.0.1";
        public string Ref_URL { get; set; } = string.Empty;
        public string Data1 { get; set; } = string.Empty;
        public string Data2 { get; set; } = string.Empty;
        public string Data3 { get; set; } = string.Empty;
        public string Data4 { get; set; } = string.Empty;
        public string Data5 { get; set; } = string.Empty;
        public int Taksit { get; set; } = 1;
    }
}

