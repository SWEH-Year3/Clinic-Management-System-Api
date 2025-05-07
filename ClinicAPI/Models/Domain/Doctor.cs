using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace ClinicAPI.Models.Domain
{
    public class Doctor
    {
        public Guid Id { get; set; }
        public string Specialty { get; set; }
        public double Price { get; set; }

        public string UserId { get; set; }
        [ValidateNever]

        public UserApplication userApplication { get; set; }
        [ValidateNever]

        public ICollection<Appointment> Appointments { get; set; }
        [ValidateNever]
        public List <FileImage> FileImages { get; set; } = new List<FileImage>();
    }
}
