using System.ComponentModel.DataAnnotations;

namespace ClinicAPI.Models.DTO
{
    public class LoginRequestDto
    {
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]

        public string Email { get; set; }
    }
}
