using ClinicAPI.Models.DTO;

public class GetDoctorDetailsDto
{
    public string DoctorId { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Specialty { get; set; }
    public double Price { get; set; }

    public List<AppointmentResponseDto> Appointments { get; set; } = new List<AppointmentResponseDto>();
}