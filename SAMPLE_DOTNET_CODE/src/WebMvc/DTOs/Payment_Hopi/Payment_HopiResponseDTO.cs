using TurkPosWSTEST;

namespace WebMvc.DTOs.Payment_Hopi
{
    public class Payment_HopiResponseDTO
    {
        public int? ResultCode { get; set; }
        public string? ResultDescription { get; set; }
        public CL_Res_Hopi_Data? Data { get; set; }
    }
}