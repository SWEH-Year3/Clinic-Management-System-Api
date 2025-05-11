using ClinicAPI.Data;
using ClinicAPI.Models.Domain;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
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
                .Where(a => a.Patient != null).Where(u=>u.State=="pending" || u.State =="ongoing").ToListAsync();
        }
        public async Task<List<Appointment>> GetAllByNameAsync(string Name)
        {
            return await dbContext.Appointments
                .Include(u => u.Doctor).ThenInclude(d => d.userApplication)
                .Include(u => u.Patient).Where(u => u.Doctor.userApplication.UserName.Contains(Name)).ToListAsync();
        }
        public async Task<List<Appointment?>> GetAppointmentDoctorAsync(Guid id)
        {
            return await dbContext.Appointments
                .Include(u => u.Doctor).ThenInclude(d => d.userApplication)
                .Include(u => u.Patient)
                .Where(u => u.DoctorId ==id)
                .Where(u =>  u.State == "closed" || u.State=="ongoing" ).ToListAsync();
        }
        public async Task<List<Appointment?>> GetAppointmentDoctorBookingAsync(Guid id)
        {
            return await dbContext.Appointments
                .Include(u => u.Doctor).ThenInclude(d => d.userApplication)
                .Include(u => u.Patient).Where(u => u.DoctorId == id).ToListAsync();
        }
        public async Task<List<Appointment?>> GetAppointmentPatientAsync(Guid id)
        {
            return await dbContext.Appointments
                .Include(u => u.Doctor).ThenInclude(d => d.userApplication)
                .Include(u => u.Patient)
                .Where(a => a.Patient != null).Where(u => u.PatientId==id.ToString())
                .ToListAsync();
        }
        public async Task<Appointment> DeleteAppointmentAsync(Guid id)
        {
            //return await dbContext.Appointments
            //    .Include(u => u.Doctor).ThenInclude(d => d.userApplication)
            //    .Include(u => u.Patient)
            //    .Where(a => a.Patient != null).Where(u => u.PatientId == id.ToString())
            //    .ToListAsync();
            var appo = dbContext.Appointments.FirstOrDefault(a => a.Id == id);
            if(appo != null)
            {
                dbContext.Appointments.Remove(appo);
                dbContext.SaveChanges();
            }

            return appo;

        }
        public async Task<Appointment?> CancelBookAsync(Guid id, Appointment appointment)
        {
            var existingAppointment = await dbContext.Appointments
                .Include(u => u.Doctor)
                .Include(u => u.Patient)
                .FirstOrDefaultAsync(u => u.Id == id);

            if(appointment.PatientId == existingAppointment.PatientId)
            {
                existingAppointment.State = appointment.State;
                dbContext.Appointments.Update(existingAppointment);
                dbContext.SaveChanges();
            }
            return existingAppointment;
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
