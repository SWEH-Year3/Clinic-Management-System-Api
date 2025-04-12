using ClinicAPI.Models.Domain;

namespace ClinicAPI.Repositories
{
    public interface IDoctorRepository
    {
        Task<Doctor> CreateAsync(Doctor doctor);
        Task<List<Doctor>> GetDoctorsAsync();
        Task<Doctor?> GetDoctorAsync(Guid id);
        Task<Doctor?> EditDoctorAsync(Guid id, Doctor doctor);
        Task<Doctor?> DeleteAsync(Guid id);
    }
}
