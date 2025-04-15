namespace ClinicAPI.Models.DTO
{
    public class ReschedulaAppointentRequestDto
    {
        public Guid OldAppointmentId { get; set; }
        public Guid NewAppointmentId { get; set; }
        public Guid PatientId { get; set; }
        public Guid DoctorId { get; set; }
    }
}
