using System.ComponentModel.DataAnnotations;

namespace ClinicAPI.Models.DTO
{
    public class RegisterRequestDto
    {
    
        public string Password { get; set; }
 

        public string Name { get; set; }

        public string Email { get; set; }


        public string Phone { get; set; }



    }
}
