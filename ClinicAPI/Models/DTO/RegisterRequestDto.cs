using System.ComponentModel.DataAnnotations;

namespace ClinicAPI.Models.DTO
{
    public class RegisterRequestDto
    {
        [Required]
        [DataType(DataType.Password)]

        public string Password { get; set; }
        [Required]
        [DataType(DataType.Text)]

        public string Name { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]

        public string Email { get; set; }
        [Required]

        [DataType(DataType.PhoneNumber)]

        public string Phone { get; set; }



    }
}
