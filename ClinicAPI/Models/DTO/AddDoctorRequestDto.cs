using System.ComponentModel.DataAnnotations;

namespace ClinicAPI.Models.DTO
{
    public class AddDoctorRequestDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Specialty { get; set; }
        
        public long? Price { get; set; }
    }
}
