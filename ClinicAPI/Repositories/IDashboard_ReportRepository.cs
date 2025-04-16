using ClinicAPI.Models.Domain;

namespace ClinicAPI.Repositories
{
    public interface IDashboard_ReportRepository
    {
        Task<object?> GetDoctorNotGrouped(Guid id);
        Task<object?> GetDoctorGrouped(Guid id);


    }
}
