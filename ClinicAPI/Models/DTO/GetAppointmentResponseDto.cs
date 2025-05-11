namespace ClinicAPI.Models.DTO
{
    public class GetAppointmentResponseDto
    {
        public Guid Id { get; set; }
        public string DoctorId { get; set; }
        public string PatientId { get; set; }
        public string PatientName { get; set; }
        public string DoctorName { get; set; }
        public string Specialty { set; get; }
        public string Date { get; set; }
        public string State { get; set; }
        public string Time { get; set; }
        public string Phone { set; get; }
        public Guid? PrecriptionID { set; get; }


    }
}
