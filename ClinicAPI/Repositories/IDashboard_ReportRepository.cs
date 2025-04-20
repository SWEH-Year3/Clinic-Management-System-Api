using ClinicAPI.Models.Domain;
using ClinicAPI.Models.DTO;

namespace ClinicAPI.Repositories
{
    public interface IDashboard_ReportRepository
    {
        Task<Dashboard_ReportResponseDto?> GetDoctorNotGrouped(Guid id);
        Task<object?> GetDoctorGrouped(Guid id);


    }
}
