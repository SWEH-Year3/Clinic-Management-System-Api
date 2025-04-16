using System.ComponentModel.DataAnnotations;

namespace ClinicAPI.Models.DTO
{
    public class GetPrescriptionResponseDto
    {
        
        public Guid AppointmentId { get; set; }
        
        public Guid Id { get; set; }
        public string Description { get; set; }
       
        public string Modifiaction_data { get; set; }
    }
}
