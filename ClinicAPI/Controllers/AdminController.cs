using ClinicAPI.CustomActionFilters;
using ClinicAPI.Models.Domain;
using ClinicAPI.Models.DTO;
using ClinicAPI.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace ClinicAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [RoleAuthorize("Admin")]
    public class AdminController : ControllerBase
    {
        private readonly UserManager<UserApplication> userManager;
        private readonly IDoctorRepository doctorRepository;

        public AdminController(UserManager<UserApplication> userManager, IDoctorRepository doctorRepository)
        {
            this.userManager = userManager;
            this.doctorRepository = doctorRepository;
        }
        [RoleAuthorize("Admin")]
        [HttpPost("CreateDoctor")]
        public async Task<IActionResult> CreateDoctor([FromBody] AddDoctorRequestDto addDoctorRequestDto)
        {
            var userIdentity = new UserApplication
            {
                Email = addDoctorRequestDto.Name,
                UserName = addDoctorRequestDto.Name,
                PhoneNumber = addDoctorRequestDto.Phone,
            };
            var resultIdentity = await userManager.CreateAsync(userIdentity, addDoctorRequestDto.Name + '@' + addDoctorRequestDto.Phone);
            Console.WriteLine(resultIdentity.ToString());
            if (resultIdentity.Succeeded)
            {
                resultIdentity = await userManager.AddToRoleAsync(userIdentity, "Doctor");
                if (resultIdentity.Succeeded)
                {
                    var doctorDomainModel = new Doctor()
                    {
                        UserId = userIdentity.Id,
                        Price = addDoctorRequestDto.Price ?? 0,
                        Specialty = addDoctorRequestDto.Specialty

                    };
                    await doctorRepository.CreateAsync(doctorDomainModel);
                    var response = new AddDoctorResponseDto
                    {
                        Email = userIdentity.Email,
                        Password = addDoctorRequestDto.Name + '@' + addDoctorRequestDto.Phone
                    };
                    return Ok(response);

                }


            }
            return BadRequest("something wrong");
        }
        [HttpGet("GetAll")]
        [RoleAuthorize("Admin", "Patient")]
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

            // Always return a list, even if empty
            return Ok(doctorDtos);
        }

        [HttpGet]
        [Route("GetDoctor/{id:guid}")]
        [RoleAuthorize("Admin", "Patient")]

        public async Task<IActionResult> GetDoctor([FromRoute] Guid id)
        {
            var doctor = await doctorRepository.GetDoctorAsync(id);

            if (doctor != null)
            {
                var doctorDto = new GetDoctorResponseDto
                {
                    DoctorId = doctor.Id.ToString(),
                    Name = doctor.userApplication.UserName,
                    Email = doctor.userApplication.Email,
                    Phone = doctor.userApplication.PhoneNumber,
                    Specialty = doctor.Specialty,
                    Price = doctor.Price
                };
                return Ok(doctorDto);
            }
            return BadRequest("not found doctor");

        }
        [HttpPut]
        [Route("UpdateDoctor/{id:guid}")]
        [RoleAuthorize("Admin")]

        public async Task<IActionResult> EditDoctor([FromRoute] Guid id, EditDoctorDto editDoctor)
        {
            var doctorDomainModel = new Doctor
            {
                Price = editDoctor.Price,
                Specialty = editDoctor.Specialty,
                userApplication = new UserApplication
                {
                    Email = editDoctor.Email,
                    PhoneNumber = editDoctor.Phone,
                    UserName = editDoctor.Name
                }
            };

            var updateDoctor = await doctorRepository.EditDoctorAsync(id, doctorDomainModel);
            if (updateDoctor == null)
            {
                return NotFound();
            }
            return Ok();
        }
        [HttpDelete]
        [Route("DeleteDoctor/{id:guid}")]
        [RoleAuthorize("Admin")]

        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var deleteDoctor = await doctorRepository.DeleteAsync(id);
            if (deleteDoctor == null)
            {
                return NotFound();
            }
            return Ok("doctor is deleted");
        }
    }
}
