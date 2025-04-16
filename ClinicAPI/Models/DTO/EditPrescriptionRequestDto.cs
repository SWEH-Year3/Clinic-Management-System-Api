using System.ComponentModel.DataAnnotations;

namespace ClinicAPI.Models.DTO
{
    public class EditPrescriptionRequestDto
    {
        [Required]
        public Guid AppointmentId { get; set; }
        [Required]

        public string Description { get; set; }
        [Required]
        public string Modifiaction_data { get; set; }
    }
}
