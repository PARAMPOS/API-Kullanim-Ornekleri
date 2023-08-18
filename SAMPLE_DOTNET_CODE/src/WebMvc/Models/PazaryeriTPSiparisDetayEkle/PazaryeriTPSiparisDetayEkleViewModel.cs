using TurkPosWSTEST;

namespace WebMvc.Models.PazaryeriTPSiparisDetayEkle
{
    public class PazaryeriTPSiparisDetayEkleViewModel
    {
        public ST_WS_Guvenlik G { get; set; } = new() { CLIENT_CODE = "10738", CLIENT_USERNAME = "test", CLIENT_PASSWORD = "test" };
        public string ETS_GUID { get; set; } = "0C13D406-873B-403B-9C09-A5766840D98C";
        public string Tutar_Urun { get; set; } = "1,75";
        public string Tutar_Odenecek { get; set; } = "1,75";
        public string SanalPOS_Islem_ID { get; set; } = "1247910825";
        public string GUID_AltUyeIsyeri { get; set; } = "84715A8E-14D3-47B5-80F0-B833D8DE1057";
    }
}