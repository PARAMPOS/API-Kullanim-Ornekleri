using TurkPosWSTEST;

namespace WebMvc.Models.TPWMDUCD
{
    public class TPWMDUCDCookieModel
    {
        public long IslemID { get; set; }
        public ST_WS_Guvenlik G { get; set; } = null!;
        public string GUID { get; set; } = string.Empty;
        public TPWMDUCDCookieModel(ST_WS_Guvenlik g, string guid)
        {
            G = g;
            GUID = guid;
        }
        public TPWMDUCDCookieModel() { }
    }
}