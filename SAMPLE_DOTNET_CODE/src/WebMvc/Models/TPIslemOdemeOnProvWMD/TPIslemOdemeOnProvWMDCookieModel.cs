using TurkPosWSTEST;

namespace WebMvc.Models.TPIslemOdemeOnProvWMD
{
    public class TPIslemOdemeOnProvWMDCookieModel
    {
        public long IslemID { get; set; }
        public ST_WS_Guvenlik G { get; set; } = null!;
        public string GUID { get; set; } = string.Empty;
        public TPIslemOdemeOnProvWMDCookieModel(ST_WS_Guvenlik g, string guid, long islemID)
        {
            G = g;
            GUID = guid;
            IslemID = islemID;
        }
        public TPIslemOdemeOnProvWMDCookieModel() { }
    }
}