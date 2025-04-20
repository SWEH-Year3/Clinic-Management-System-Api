namespace ClinicAPI.Models.DTO
{
    public class AddImageRequestDto
    {
        public IFormFile File { get; set; }
        public string FileName { get; set; }
        
    }
}
