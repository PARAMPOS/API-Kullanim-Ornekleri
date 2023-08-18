using System.Xml.Serialization;

namespace WebMvc.DTOs.Pazaryeri_TP_AltUyeIsyeri_Liste
{
    [XmlRoot(ElementName = "Temp1")]
    public class Pazaryeri_TP_AltUyeIsyeri_ListeDT_BilgiDTO
    {
        public string? ID { get; set; }
        public string? ETS_GUID { get; set; }
        public string? Durum { get; set; }
        public string? Tip { get; set; }
        public string? Ad_Soyad { get; set; }
        public string? Unvan { get; set; }
        public string? TC_VN { get; set; }
        public string? Yetkili_Kisi_TC { get; set; }
        public string? GSM_No { get; set; }
        public string? IBAN_No { get; set; }
        public string? Adres { get; set; }
        public string? Il { get; set; }
        public string? Ilce { get; set; }
        public string? Website { get; set; }
        public string? MCC_Kod { get; set; }
        public string? GUID { get; set; }
        public string? Tarih { get; set; }
        public string? Vergi_Daire { get; set; }
    }
}