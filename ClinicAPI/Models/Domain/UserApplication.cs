using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace ClinicAPI.Models.Domain
{
    public class UserApplication:IdentityUser
    {
        [ValidateNever]

        public ICollection<Appointment> Appointments { get; set; }=new List<Appointment>();



    }
}
