using TurkPosWSTEST;

namespace WebMvc.DTOs.MP_OrderDetailQuery
{
    public class MP_OrderDetailQuerytResponseDTO
    {
        public int? ResultCode { get; set; }
        public string? ResultDescription { get; set; }
        public List<CL_Res_MP_ODQ_Data>? Data { get; set; }
    }
}