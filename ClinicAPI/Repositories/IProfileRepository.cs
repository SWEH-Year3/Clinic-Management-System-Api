using ClinicAPI.Models.DTO;

namespace ClinicAPI.Repositories
{
    public interface IProfileRepository
    {
        Task<GetProfileResponseDto?> GetProfileAsync(Guid id);
        Task<DoctorProfileDto?> GetProfileDoctorAsync(Guid id);

        Task<object?> UpdateProfileAsync(Guid id, GetProfileResponseDto data);
        Task<object?> UpdateProfileDoctorAsync(Guid id, DoctorProfileDto data);


    }
}