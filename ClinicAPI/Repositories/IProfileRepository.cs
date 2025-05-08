using ClinicAPI.Models.DTO;

namespace ClinicAPI.Repositories
{
    public interface IProfileRepository
    {
        Task<GetProfileResponseDto?> GetProfileAsync(Guid id);
        Task<DoctorProfileDto?> GetProfileDoctorAsync(Guid id);
    }
}
