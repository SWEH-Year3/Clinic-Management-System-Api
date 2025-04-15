namespace ClinicAPI.Models.Domain
{
    public class Doctor
    {
        public Guid Id { get; set; }
        public string Specialty { get; set; }
        public double Price { get; set; }

        public string UserId { get; set; }

        public UserApplication userApplication { get; set; }

        public ICollection<Appointment> Appointments { get; set; }
    }
}
