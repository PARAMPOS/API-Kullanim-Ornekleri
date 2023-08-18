namespace WebMvc.DTOs.SHA2B64
{
    public class SHA2B64RequestDTO
    {
        public string ClientCode { get; set; } = string.Empty;
        public string GUID { get; set; } = string.Empty;
        public string Taksit { get; set; } = string.Empty;
        public string IslemTutar { get; set; } = string.Empty;
        public string ToplamTutar { get; set; } = string.Empty;
        public string SiparisId { get; set; } = string.Empty;
        public string HataURL { get; set; } = string.Empty;
        public string BasariliURL { get; set; } = string.Empty;
    }
}