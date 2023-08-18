using TurkPosWSTEST;

namespace WebMvc.Models.PazaryeriTPAltUyeIsyeriEkleme
{
    public class PazaryeriTPAltUyeIsyeriEklemeViewModel
    {
        public ST_WS_Guvenlik G { get; set; } = new() { CLIENT_CODE = "10738", CLIENT_USERNAME = "test", CLIENT_PASSWORD = "test" };
        public string ETS_GUID { get; set; } = "0c13d406-873b-403b-9c09-a5766840d98";
        public int Tip { get; set; } = 1;
        public string Ad_Soyad { get; set; } = "Test Deneme";
        public string Unvan { get; set; } = "Test Deneme";
        public string TC_VN { get; set; } = "5788924350";
        public string Kisi_DogumTarihi { get; set; } = "01.12.2022";
        public string GSM_No { get; set; } = "5312920320";
        public string IBAN_No { get; set; } = "123456";
        public string IBAN_Unvan { get; set; } = "Test Deneme";
        public string Adres { get; set; } = "AdanaMerkez";
        public string Il { get; set; } = "1";
        public string Ilce { get; set; } = "1218";
        public string EPosta { get; set; } = "test.deneme@hotmail.com";
        public string Website { get; set; } = "www.google.com";
        public string MCC_Kod { get; set; } = "1000";
        public string Yetkili_Kisi_TC { get; set; } = "61057998660";
        public string Yetkili_Kisi_DogumTarihi { get; set; } = "01.12.2022";
        public string Vergi_Daire { get; set; } = "1000587";
        public string Bagli_Olunan_Hesap { get; set; } = string.Empty;
    }
}