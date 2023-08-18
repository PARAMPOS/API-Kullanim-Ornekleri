using TurkPosWSTEST;

namespace WebMvc.DTOs.Pazaryeri_TP_AltUyeIsyeri_Ekleme_v2
{
    public class Pazaryeri_TP_AltUyeIsyeri_Ekleme_v2RequestDTO
    {
        public ST_WS_Guvenlik G { get; set; } = null!;
        public string ETS_GUID { get; set; } = string.Empty;
        public int Tip { get; set; }
        public string Ad_Soyad { get; set; } = string.Empty;
        public string Unvan { get; set; } = string.Empty;
        public string TC_VN { get; set; } = string.Empty;
        public string Kisi_DogumTarihi { get; set; } = string.Empty;
        public string GSM_No { get; set; } = string.Empty;
        public string IBAN_No { get; set; } = string.Empty;
        public string IBAN_Unvan { get; set; } = string.Empty;
        public string Adres { get; set; } = string.Empty;
        public string Il { get; set; } = string.Empty;
        public string Ilce { get; set; } = string.Empty;
        public string EPosta { get; set; } = string.Empty;
        public string Website { get; set; } = string.Empty;
        public string MCC_Kod { get; set; } = string.Empty;
        public string Yetkili_Kisi_TC { get; set; } = string.Empty;
        public string Yetkili_Kisi_DogumTarihi { get; set; } = string.Empty;
        public string Vergi_Daire { get; set; } = string.Empty;
        public string Bagli_Olunan_Hesap { get; set; } = string.Empty;
        public string SAPId { get; set; } = string.Empty;
        public string MageontoId { get; set; } = string.Empty;
    }
}