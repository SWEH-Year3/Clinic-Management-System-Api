using ClinicAPI.Data;
using ClinicAPI.Models.Domain;
using ClinicAPI.Models.DTO;
using Microsoft.EntityFrameworkCore;

namespace ClinicAPI.Repositories
{
    public class SqlDashboard_ReportRepository : IDashboard_ReportRepository
    {
        private readonly ApplicationDbContext dbContext;

        public SqlDashboard_ReportRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<object?> GetDoctorGrouped(Guid id)
        {
            var doctor = await dbContext.Doctors
                .Include(d => d.userApplication)
                .Include(d => d.Appointments)
                .FirstOrDefaultAsync(d => d.Id == id);

            if (doctor == null)
                return null;

            var grouped = doctor.Appointments
                .GroupBy(a => DateTime.Parse(a.Date).ToString("yyyy-MM"))
                .Select(g => new
                {
                    Month = g.Key,
                    Appointments = g.Select(a => new
                    {
                        a.Date,
                        a.Time,
                        a.State,
                        PatientName = a.Patient?.UserName
                    }).ToList()
                }).ToList();

            return new
            {
                DoctorId = doctor.Id,
                Name = doctor.userApplication.UserName,
                Specialty = doctor.Specialty,
                MonthlyAppointments = grouped
            };
        }



        public async Task<Dashboard_ReportResponseDto?> GetDoctorNotGrouped(Guid id)
        {
            var doctor = await dbContext.Doctors.Where(u => u.Id == id)
                .Include(u => u.userApplication)
                .Include(u => u.Appointments).Select(u => new Dashboard_ReportResponseDto
                {
                  Id=  u.Id,
                   Name= u.userApplication.UserName,
                    Specialty = u.Specialty,
                    NumberOfAppointment = u.Appointments.Count()
                })
                .FirstOrDefaultAsync();
            return doctor;

        }
    }
}
