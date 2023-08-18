using TurkPosWSTEST;

namespace WebMvc.Models.PazaryeriTPIslemSorgulama
{
    public class PazaryeriTPIslemSorgulamaViewModel
    {
        public ST_WS_Guvenlik G { get; set; } = new() { CLIENT_CODE = "10738", CLIENT_USERNAME = "test", CLIENT_PASSWORD = "test" };
        public string ETS_GUID { get; set; } = "0c13d406-873b-403b-9c09-a5766840d98c";
        public string GUID_AltUyeIsyeri { get; set; } = "46653e47-6845-416e-a5da-240cd31994d7";
        public string PYSiparis_GUID { get; set; } = "ae050833-f87a-4597-b458-d95ce2a34a93";
        public long SanalPOS_Islem_ID { get; set; } = 500000012;
        public string Tarih_Bas { get; set; } = "30.12.2020 00:00:00";
        public string Tarih_Bit { get; set; } = "30.12.2020 00:00:00";
    }
}