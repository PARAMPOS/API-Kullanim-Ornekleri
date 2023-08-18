using TurkPosWSTEST;

namespace WebMvc.DTOs.TP_Multiple_Payment
{
    public class TP_Multiple_PaymentRequestDTO
    {
        public CL_Payment Payment_Info { get; set; } = null!;
    }
}