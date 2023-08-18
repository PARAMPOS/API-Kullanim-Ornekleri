namespace WebMvc.DTOs.Pazaryeri_TP_Limit_Kontrol
{
    public class Pazaryeri_TP_Limit_KontrolRequestDTO
    {
        public string ETS_GUID { get; set; } = string.Empty;
        public string GUID_AltUyeIsyeri { get; set; } = string.Empty;
        public string Tutar_Odenecek { get; set; } = string.Empty;
    }
}