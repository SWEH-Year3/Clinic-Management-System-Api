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

        public async Task<Dashboard_ReportResponseDto?> GetDoctorNotGrouped(Guid id)
        {
            var doctor = await dbContext.Doctors
                .Include(d => d.userApplication)
                .Include(d => d.Appointments)
                .FirstOrDefaultAsync(d => d.Id == id);

            if (doctor == null)
                return null;

            var grouped = doctor.Appointments
                .GroupBy(a => DateTime.Parse(a.Date).ToString("yyyy-MM"))
                .Select(g => new MonthlyAppointmentsDto
                {
                    Month = g.Key,
                    Appointments = g.Select(a => new AggAppointmentDto
                    {
                        Date = a.Date,
                        Time = a.Time,
                        State = a.State
                    }).ToList(),
                    AppointmentCount = g.Select(a => new
                    {
                        a.Date,
                        a.Time,
                        a.State
                    }).ToList().Count()
                }).ToList();

            Dashboard_ReportResponseDto dashboard_ReportResponseDto = new Dashboard_ReportResponseDto
            {
                Id = doctor.Id,
                Name = doctor.userApplication.UserName,
                Specialty = doctor.Specialty,
                MonthlyAppointments = grouped
            };
            return dashboard_ReportResponseDto;
        }

        public async Task<IEnumerable<object?>> GetDoctorGrouped()
        {
            var doctors = await dbContext.Doctors
                .Include(d => d.userApplication)
                .Include(d => d.Appointments)
                    .ThenInclude(a => a.Patient)
                .ToListAsync();

            var result = doctors.Select(doctor => new
            {
                DoctorId = doctor.Id,
                Name = doctor.userApplication.UserName,
                Specialty = doctor.Specialty,
                MonthlyAppointments = doctor.Appointments
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
                        }).ToList(),
                        AppointmentCount = g.Select(a => new
                        {
                            a.Date,
                            a.Time,
                            a.State,
                            PatientName = a.Patient?.UserName
                        }).ToList().Count()

                    })
                    .ToList()
            });

            return result;
        }




        //public async Task<Dashboard_ReportResponseDto?> GetDoctorNotGrouped(Guid id)
        //{
        //    var doctor = await dbContext.Doctors.Where(u => u.Id == id)
        //        .Include(u => u.userApplication)
        //        .Include(u => u.Appointments).Select(u => new Dashboard_ReportResponseDto
        //        {
        //          Id=  u.Id,
        //           Name= u.userApplication.UserName,
        //            Specialty = u.Specialty,
        //            NumberOfAppointment = u.Appointments.Count()
        //        })
        //        .FirstOrDefaultAsync();
        //    return doctor;

        //}
    }
}
