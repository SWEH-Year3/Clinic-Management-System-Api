using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace ClinicAPI.Models.Domain
{
    public class Prescription
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public string Modification_date { get; set; }
        public Guid AppointmentId { get; set; }
        [ValidateNever]
        public Appointment Appointment { get; set; }
        [ValidateNever]
        public FileImage FileImage { get; set; }

    }
}
