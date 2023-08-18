using TurkPosWSTEST;

namespace WebMvc.Models.PazaryeriTPIptalIade
{
    public class PazaryeriTPIptalIadeViewModel
    {
        public ST_WS_Guvenlik G { get; set; } = new() { CLIENT_CODE = "10738", CLIENT_USERNAME = "test", CLIENT_PASSWORD = "test" };
        public string PYSiparis_GUID { get; set; } = "D8523FA4-F5E9-4142-BD34-962088026796";
        public string GUID { get; set; } = "0c13d406-873b-403b-9c09-a5766840d98c";
        public string Durum { get; set; } = "IPTAL";
        public string Siparis_ID { get; set; } = "siparis54";
        public double SiparisTutar { get; set; } = 5.00;
        public double OdenecekTutar { get; set; } = 5.00;
    }
}