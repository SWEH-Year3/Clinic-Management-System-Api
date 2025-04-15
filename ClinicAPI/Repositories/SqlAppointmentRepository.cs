using ClinicAPI.Data;
using ClinicAPI.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace ClinicAPI.Repositories
{
    public class SqlAppointmentRepository : IAppointmentRepository
    {
        private readonly ApplicationDbContext dbContext;

        public SqlAppointmentRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<Appointment> CreateAsync(Appointment appointment)
        {
            await dbContext.Appointments.AddAsync(appointment);
            await dbContext.SaveChangesAsync();
            return appointment;
        }

        public async Task<List<Appointment>> GetAllAsync()
        {
            return await dbContext.Appointments
                .Include(u => u.Doctor).ThenInclude(d => d.userApplication)
                .Include(u => u.Patient)
                .Where(a => a.Patient != null).Where(u=>u.State=="pending").ToListAsync();
        }

        public async Task<List<Appointment?>> GetAppointmentDoctorAsync(Guid id)
        {
            return await dbContext.Appointments
                .Include(u => u.Doctor).ThenInclude(d => d.userApplication)
                .Include(u => u.Patient)
                .Where(a => a.Patient != null).Where(u => u.DoctorId ==id)
                .Where(u =>  u.State == "closed" || u.State=="ongoing" ).ToListAsync();
        }
        public async Task<List<Appointment?>> GetAppointmentPatientAsync(Guid id)
        {
            return await dbContext.Appointments
                .Include(u => u.Doctor).ThenInclude(d => d.userApplication)
                .Include(u => u.Patient)
                .Where(a => a.Patient != null).Where(u => u.PatientId==id.ToString())
                .ToListAsync();
        }

        public async Task<Appointment?> UpdateAsync(Guid id, Appointment appointment)
        {
            var existingAppointment = await dbContext.Appointments
                .Include(u => u.Doctor)
                .Include(u => u.Patient)
                .FirstOrDefaultAsync(u => u.Id == id);

            if (existingAppointment == null)
            {
                return null;
            }

            if (!string.IsNullOrEmpty(appointment.Date))
            {
                existingAppointment.Date = appointment.Date;
            }

            if (!string.IsNullOrEmpty(appointment.Time))
            {
                existingAppointment.Time = appointment.Time;
            }

            if (appointment.DoctorId != Guid.Empty)
            {
                existingAppointment.DoctorId = appointment.DoctorId;
            }

            if (!string.IsNullOrEmpty(appointment.PatientId))
            {
                existingAppointment.PatientId = appointment.PatientId;
            }
            if (appointment.PatientId=="not found")
            {
                existingAppointment.PatientId = null;
            }


            if (!string.IsNullOrEmpty(appointment.State))
            {
                existingAppointment.State = appointment.State;
            }

            await dbContext.SaveChangesAsync();
            return existingAppointment;
        }


    }
}
