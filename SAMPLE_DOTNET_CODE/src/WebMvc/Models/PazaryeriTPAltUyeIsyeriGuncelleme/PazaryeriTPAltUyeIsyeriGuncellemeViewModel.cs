using TurkPosWSTEST;

namespace WebMvc.Models.PazaryeriTPAltUyeIsyeriGuncelleme
{
    public class PazaryeriTPAltUyeIsyeriGuncellemeViewModel
    {
        public ST_WS_Guvenlik G { get; set; } = new() { CLIENT_CODE = "10738", CLIENT_USERNAME = "test", CLIENT_PASSWORD = "test" };
        public string GUID_AltUyeIsyeri { get; set; } = "a5c158be-8aaa-4716-abdc-f6f99eadfc81";
        public string Ad_Soyad { get; set; } = "Test Deneme";
        public string Unvan { get; set; } = "Test Deneme";
        public string GSM_No { get; set; } = "5312920320";
        public string IBAN_No { get; set; } = "TR123456789123456789123456";
        public string IBAN_Unvan { get; set; } = "Test Deneme";
        public string Adres { get; set; } = "Çankaya ANKARA";
        public string Il { get; set; } = "01";
        public string Ilce { get; set; } = "1219";
        public string EPosta { get; set; } = "test@hotmail.com";
        public string Website { get; set; } = "www.param.com.tr";
        public string MCC_Kod { get; set; } = "1000";
        public string Vergi_Daire { get; set; } = "100000000";
        public string Bagli_Olunan_Hesap { get; set; } = string.Empty;
    }
}