namespace ClinicAPI.Models.Domain
{
    public class Appointment
    {
        public Guid Id { get; set; }
        public string Time { get; set; }
        public Guid DoctorId { get; set; }
        public Doctor Doctor { get; set; }
        public string? PatientId {  get; set; }

        public UserApplication Patient { get; set; }
        public string Date { get; set; }
        public string State { get; set; }
    }
}
