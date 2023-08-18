using TP_KS;

namespace WebMvc.DTOs.KS_Kart_Liste_Pagination
{
    public class KS_Kart_Liste_PaginationRequestDTO
    {
        public ST_WS_Guvenlik G { get; set; } = null!;
        public string GUID { get; set; } = string.Empty;
        public string KK_Kart_Adi { get; set; } = string.Empty;
        public string KK_Islem_ID { get; set; } = string.Empty;
        public string Sayfa_Sayi { get; set; } = string.Empty;
        public string Sayfa_Index { get; set; } = string.Empty;
    }
}