using TurkPosWSTEST;

namespace WebMvc.DTOs.TP_Multiple_Payment_Status
{
    public class TP_Multiple_Payment_StatusRequestDTO
    {
        public CL_Payment_Status Payment_Info { get; set; } = null!;
    }
}