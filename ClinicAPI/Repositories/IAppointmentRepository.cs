using ClinicAPI.Models.Domain;

namespace ClinicAPI.Repositories
{
    public interface IAppointmentRepository
    {
        Task<Appointment> CreateAsync(Appointment appointment);
        Task<Appointment?> UpdateAsync(Guid id, Appointment appointment);
        Task<List<Appointment>> GetAllAsync();
    }
}
