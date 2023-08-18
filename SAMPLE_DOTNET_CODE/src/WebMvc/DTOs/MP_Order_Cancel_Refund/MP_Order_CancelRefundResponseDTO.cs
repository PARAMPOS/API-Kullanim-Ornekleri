using TurkPosWSTEST;

namespace WebMvc.DTOs.MP_OrderCancelRefund
{
    public class MP_Order_CancelRefundResponseDTO
    {
        public int? ResultCode { get; set; }
        public string? ResultDescription { get; set; }
        public List<CL_L_Res_MP_OCR>? List { get; set; }
    }
}