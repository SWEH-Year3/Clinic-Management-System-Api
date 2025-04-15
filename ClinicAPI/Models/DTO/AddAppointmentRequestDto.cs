using System.ComponentModel.DataAnnotations;

namespace ClinicAPI.Models.DTO
{
    public class AddAppointmentRequestDto
    {
        [Required]
        public string Time { get; set; }
        public Guid DoctorId { get; set; }
        public string Date { get; set; }

    }
}
