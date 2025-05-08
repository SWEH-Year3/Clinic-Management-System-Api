
using ClinicAPI.Data;
using ClinicAPI.Models.Domain;
using ClinicAPI.Models.DTO;
using Microsoft.EntityFrameworkCore;

namespace ClinicAPI.Repositories
{
    public class SqlProfileRepository : IProfileRepository
    {
        private readonly ApplicationDbContext dbContext;

        public SqlProfileRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<GetProfileResponseDto?> GetProfileAsync(Guid id)
        {
            var profile = await dbContext.Users
                .Where(u => u.Id == id.ToString())
                .Select(u => new GetProfileResponseDto
                {
                   Id= u.Id,
                   UserName= u.UserName,
                   Email= u.Email,
                   PhoneNumber= u.PhoneNumber,
                })
                .FirstOrDefaultAsync();

            if (profile != null)
                return profile;
            return null;


        }
        public async Task<DoctorProfileDto?> GetProfileDoctorAsync(Guid id)
        {
            var doctorProfile = await dbContext.Doctors
                .Include(d => d.userApplication)
                .Where(d => d.Id == id)
                .Select(d => new DoctorProfileDto
                {
                    Id = d.Id,
                    UserName = d.userApplication.UserName,
                    Email = d.userApplication.Email,
                    PhoneNumber = d.userApplication.PhoneNumber,
                    Specialty = d.Specialty,
                    Price = d.Price
                })
                .FirstOrDefaultAsync();

            return doctorProfile;
        }

    }
}
