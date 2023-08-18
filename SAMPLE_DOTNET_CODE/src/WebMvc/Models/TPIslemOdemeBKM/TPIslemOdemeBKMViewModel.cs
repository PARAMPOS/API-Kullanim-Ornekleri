using TurkPosWSTEST;

namespace WebMvc.Models.TPIslemOdemeBKM
{
    public class TPIslemOdemeBKMViewModel
    {
        public ST_WS_Guvenlik G { get; set; } = new() { CLIENT_CODE = "10738", CLIENT_USERNAME = "test", CLIENT_PASSWORD = "test" };
        public string GUID { get; set; } = "0c13d406-873b-403b-9c09-a5766840d98c";
        public string Customer_Info { get; set; } = string.Empty;
        public string Customer_GSM { get; set; } = "5551231212";
        public string Error_URL { get; set; } = "https://localhost:7113/Sonuc/TPIslemOdemeBKM";
        public string Success_URL { get; set; } = "https://localhost:7113/Sonuc/TPIslemOdemeBKM";
        public string Order_ID { get; set; } = "sipariş1";
        public string Order_Description { get; set; } = string.Empty;
        public string Amount { get; set; } = "100.00";
        public string Payment_Hash { get; set; } = "4HaFjeEYpcVMQYgq94lxuYWHAV8=";
        public string Transaction_ID { get; set; } = string.Empty;
        public string IPAddress { get; set; } = "127.0.0.1";
        public string Referrer_URL { get; set; } = string.Empty;
    }
}