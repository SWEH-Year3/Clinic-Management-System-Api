using Microsoft.AspNetCore.Identity;

namespace ClinicAPI.Models.Domain
{
    public class UserApplication:IdentityUser
    {

        public ICollection<Appointment> Appointments { get; set; }



    }
}
