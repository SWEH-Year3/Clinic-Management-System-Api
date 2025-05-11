using ClinicAPI.Data;
using ClinicAPI.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace ClinicAPI.Repositories
{
    public class SqlDoctorRepository : IDoctorRepository
    {
        private readonly ApplicationDbContext dbContext;

        public SqlDoctorRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<Doctor> CreateAsync(Doctor doctor)
        {
            await dbContext.Doctors.AddAsync(doctor);
            await dbContext.SaveChangesAsync();
            return doctor;
        }

        public async Task<Doctor?> DeleteAsync(Guid id)
        {
            var doctorExisting = await dbContext.Doctors.Include(d => d.userApplication).FirstOrDefaultAsync(u => u.Id == id);
            if (doctorExisting == null)
            {
                return null;
            }
            if (doctorExisting.userApplication != null)
            {
                dbContext.Users.Remove(doctorExisting.userApplication);
            }
            dbContext.Doctors.Remove(doctorExisting);
            await dbContext.SaveChangesAsync();
            return doctorExisting;
        }

        public async Task<Doctor?> EditDoctorAsync(Guid id, Doctor doctor)
        {
            var doctorExisting = await dbContext.Doctors.Include(d => d.userApplication).FirstOrDefaultAsync(u => u.Id == id);
            if (doctorExisting == null)
            {
                return null;
            }
            doctorExisting.Specialty = doctor.Specialty;
            doctorExisting.Price = doctor.Price;
            doctorExisting.userApplication.Email = doctor.userApplication.Email;
            doctorExisting.userApplication.PhoneNumber = doctor.userApplication.PhoneNumber;
            doctorExisting.userApplication.UserName = doctor.userApplication.UserName;

            await dbContext.SaveChangesAsync();
            return doctorExisting;

        }

        public async Task<Doctor?> GetDoctorAsync(Guid id)
        {
            return await dbContext.Doctors.Include(d => d.userApplication).FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task<List<Doctor>> GetDoctorsAsync()
        {
            return await dbContext.Doctors.Include(d => d.userApplication).ToListAsync();
        }
        public async Task<List<Doctor>> GetDoctorsByNameAsync(string Name)
        {
            return await dbContext.Doctors.Include(d => d.userApplication).Where(u => u.userApplication.UserName.Contains(Name)).ToListAsync();
        }
    }
}
