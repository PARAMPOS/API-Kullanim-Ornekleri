using TurkPosWSTEST;

namespace WebMvc.DTOs.Param_Pazaryeri_Islem_Izleme
{
    public class Param_Pazaryeri_Islem_IzlemeRequestDTO
    {
        public ST_WS_Guvenlik G { get; set; } = null!;
        public IslemIzlemeReq IslemIzlemeReq { get; set; } = null!;
    }
}