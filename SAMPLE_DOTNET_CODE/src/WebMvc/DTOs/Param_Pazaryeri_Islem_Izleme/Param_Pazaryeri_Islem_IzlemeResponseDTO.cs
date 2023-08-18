using System.Xml;

namespace WebMvc.DTOs.Param_Pazaryeri_Islem_Izleme
{
    public class Param_Pazaryeri_Islem_IzlemeResponseDTO
    {
        public string? Sonuc { get; set; }
        public string? Sonuc_Str { get; set; }
        public XmlDocument? DT_Bilgi { get; set; }
        public string? Durum_Onay { get; set; }
        public string? SanalPOS_Banka { get; set; }
        public string? SanalPOS_Islem_ID { get; set; }
        public string? Odeme_Yapan_Bilgisi { get; set; }
        public string? ODEME_TUTAR { get; set; }
        public string? Komisyon_Odeyen_Aciklama { get; set; }
        public string? islem_durumu { get; set; }
        public string? tutar_urun { get; set; }
        public string? AltUye_Isyeri_Ad_Soyad { get; set; }
        public string? uye_isyeri_odeme_tutarı { get; set; }
        public string? param_komisyon_orani { get; set; }
        public string? param_komisyon_ucreti { get; set; }
        public string? alt_uye_is_yeri_odeme_tutarı { get; set; }
        public string? Valor { get; set; }
    }
}