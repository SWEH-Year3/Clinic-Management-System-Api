using System.ComponentModel.DataAnnotations;

namespace ClinicAPI.Models.DTO
{
    public class EditPrescriptionRequestDto
    {
        [Required]
        public Guid AppointmentId { get; set; }
        [Required]

        public string Description { get; set; }
        
        public string Modification_date { get; set; }
    }
}
