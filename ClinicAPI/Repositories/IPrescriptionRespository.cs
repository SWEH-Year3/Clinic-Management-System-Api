using ClinicAPI.Models.Domain;

namespace ClinicAPI.Repositories
{
    public interface IPrescriptionRespository
    {
        Task<Prescription> CreateAsync(Prescription prescription);
        Task<Prescription?> UpdateAsync(Guid id,Prescription prescription);
        Task<Prescription?> GetAsync(Guid id);
    }
}
