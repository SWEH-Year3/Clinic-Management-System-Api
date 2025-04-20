namespace ClinicAPI.Models.DTO
{
    public class Dashboard_ReportResponseDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Specialty { get; set; }
        public int NumberOfAppointment { get; set; }
    }
}
