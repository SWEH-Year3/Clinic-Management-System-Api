using ClinicAPI.CustomActionFilters;
using ClinicAPI.Models.Domain;
using ClinicAPI.Models.DTO;
using ClinicAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ClinicAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly UserManager<UserApplication> userManager;
        private readonly IDoctorRepository doctorRepository;
        public HomeController(UserManager<UserApplication> userManager, IDoctorRepository doctorRepository)
        {
            this.userManager = userManager;
            this.doctorRepository = doctorRepository;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var doctors = await doctorRepository.GetDoctorsAsync();
            var doctorDtos = new List<GetDoctorsDto>();

            if (doctors != null)
            {
                foreach (var doctor in doctors)
                {
                    var role = await userManager.GetRolesAsync(doctor.userApplication);
                    doctorDtos.Add(new GetDoctorsDto
                    {
                        UserId = doctor.UserId,
                        Name = doctor.userApplication.UserName,
                        Email = doctor.userApplication.Email,
                        phone = doctor.userApplication.PhoneNumber,
                        Role = role.FirstOrDefault(),
                        DoctorId = doctor.Id.ToString(),
                        Specialty = doctor.Specialty,
                        Price = doctor.Price
                    });
                }
            }

            return Ok(doctorDtos);
        }
        [HttpGet]
        [Route("DetailsDoctor/{id:guid}")]
        [RoleAuthorize("Admin", "Patient","Doctor")]

        public async Task<IActionResult> GetDoctor([FromRoute] Guid id)
        {
            var doctor = await doctorRepository.GetDoctorAsync(id);

            if (doctor != null)
            {
                var doctorDto = new GetDoctorDetailsDto
                {
                    DoctorId = doctor.Id.ToString(),
                    Name = doctor.userApplication.UserName,
                    Email = doctor.userApplication.Email,
                    Phone = doctor.userApplication.PhoneNumber,
                    Specialty = doctor.Specialty,
                    Price = doctor.Price,
                    Appointments = doctor.Appointments.Select(a => new AppointmentResponseDto
                    {
                        Id = a.Id,
                        Date = a.Date,
                        Time = a.Time,
                        State = a.State
                    }).ToList()
                };
                return Ok(doctorDto);
            }

            return BadRequest("Doctor not found");
        }


    }
}
