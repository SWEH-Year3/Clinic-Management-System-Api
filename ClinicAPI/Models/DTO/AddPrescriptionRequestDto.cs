using System.ComponentModel.DataAnnotations;

namespace ClinicAPI.Models.DTO
{
    public class AddPrescriptionRequestDto
    {
        [Required]
        public Guid AppointmentId { get; set; }
        [Required]

        public string Description { get; set; }
        [Required]
        public string Modifictaion_data { get; set; }
    }
}
