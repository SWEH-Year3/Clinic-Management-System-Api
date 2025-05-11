
using ClinicAPI.Data;
using ClinicAPI.Models.Domain;
using ClinicAPI.Models.DTO;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace ClinicAPI.Repositories
{
    public class SqlProfileRepository : IProfileRepository
    {
        private readonly ApplicationDbContext dbContext;
        UserManager<UserApplication> userManager;
        public SqlProfileRepository(ApplicationDbContext dbContext ,UserManager<UserApplication> userManager)
        {
            this.dbContext = dbContext;
            this.userManager = userManager;
        }
        public async Task<GetProfileResponseDto?> GetProfileAsync(Guid id)
        {
            var profile = await dbContext.Users
                .Where(u => u.Id == id.ToString())
                .Select(u => new GetProfileResponseDto
                {
                    UserName = u.UserName,
                    Email = u.Email,
                    PhoneNumber = u.PhoneNumber,
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
                    UserName = d.userApplication.UserName,
                    Email = d.userApplication.Email,
                    PhoneNumber = d.userApplication.PhoneNumber,
                    Specialty = d.Specialty,
                    Price = d.Price
                })
                .FirstOrDefaultAsync();

            return doctorProfile;
        }

        public async Task<object?> UpdateProfileAsync(Guid id, GetProfileResponseDto data)
        {
            
            var user = await dbContext.Users.FirstOrDefaultAsync(u => u.Id == id.ToString());

            if (user == null) return new BadHttpRequestException("User Not Fount");

            user.Email = data.Email ?? user.Email ;
            user.UserName = data.UserName ?? user.UserName;
            user.PhoneNumber = data.PhoneNumber ?? user.PhoneNumber;


            await userManager.UpdateAsync(user);
            dbContext.SaveChanges();

            return 200;
        }

        public async Task<object?> UpdateProfileDoctorAsync(Guid id, DoctorProfileDto data)
        {
            var user = await dbContext.Doctors.Include(d=>d.userApplication).FirstOrDefaultAsync(u => u.Id == id 
                                                                                              || u.UserId == id.ToString() );

            if (user == null) return new BadHttpRequestException("User Not Fount");


            user.userApplication.Email = data.Email ?? user.userApplication.Email;
            user.userApplication.UserName = data.UserName ?? user.userApplication.UserName;
            user.userApplication.PhoneNumber = data.PhoneNumber ?? user.userApplication.PhoneNumber;
            user.Specialty = data.Specialty;
            user.Price = data.Price;

            await userManager.UpdateAsync(user.userApplication);
            dbContext.Doctors.Update(user);
            dbContext.SaveChanges();

            return 200;
        }
    }
}