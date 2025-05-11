namespace ClinicAPI.Models.DTO
{
    public class GetProfileResponseDto
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public List<AppointmentResponseDto> Appointments { get; set; } = new List<AppointmentResponseDto>();

    }
}
