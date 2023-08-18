using TurkPosWSTEST;

namespace WebMvc.DTOs.MP_OrderDetailAdd
{
    public class MP_OrderDetailAddResponseDTO
    {
        public int ResultCode { get; set; }
        public string? ResultDescription { get; set; }
        public CL_Res_MP_ODA_Data? Data { get; set; }
    }
}