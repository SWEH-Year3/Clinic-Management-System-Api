using ClinicAPI.Models.Domain;

namespace ClinicAPI.Repositories
{
    public interface IAppointmentRepository
    {
        Task<Appointment> CreateAsync(Appointment appointment);
        Task<Appointment?> UpdateAsync(Guid id, Appointment appointment);
        Task<List<Appointment>> GetAllAsync();
        Task<List<Appointment?>> GetAppointmentDoctorAsync(Guid id);
        Task<List<Appointment?>> GetAppointmentPatientAsync(Guid id);

        Task<List<Appointment?>> GetAppointmentDoctorBookingAsync(Guid id);
    }
}
