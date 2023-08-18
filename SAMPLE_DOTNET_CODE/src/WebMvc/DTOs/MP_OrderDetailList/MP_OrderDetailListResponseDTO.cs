using TurkPosWSTEST;

namespace WebMvc.DTOs.MP_OrderDetailList
{
    public class MP_OrderDetailListResponseDTO
    {
        public int? ResultCode { get; set; }
        public string? ResultDescription { get; set; }
        public List<CL_Res_MP_ODL_Data>? Data { get; set; }
    }
}