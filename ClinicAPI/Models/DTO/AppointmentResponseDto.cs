namespace ClinicAPI.Models.DTO
{
    public class AppointmentResponseDto
    {

        public Guid Id { get; set; }
        public string Time { get; set; }
        public string Date { get; set; }
        public string State { get; set; }

    }
}
