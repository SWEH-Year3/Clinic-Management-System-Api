namespace ClinicAPI.Models.DTO
{
    public class GetDoctorsDto
    {
        public string UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string phone  { get; set; }
        public string Role { get; set; }
        public string DoctorId { get; set; }
        public string Specialty { get; set; }
        public double Price { get; set; }

    }
}
