using ClinicAPI.CustomActionFilters;
using ClinicAPI.Models.DTO;
using ClinicAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClinicAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        private readonly IProfileRepository profileRepository;

        public ProfileController(IProfileRepository profileRepository)
        {
            this.profileRepository = profileRepository;
        }
        [HttpGet]
        [Route("{id:guid}")]
        [RoleAuthorize("Patient","Admin")]

        public async Task<IActionResult> GetProfilePatient(Guid id)
        {
            // Assuming you have a service to get the profile
            var profile = await profileRepository.GetProfileAsync(id);
            if (profile == null)
            {
                return NotFound();
            }           
            return Ok(profile);
        }
        [HttpGet]
        [Route("doctor/{id:guid}")]
        [RoleAuthorize("Doctor")]
        public async Task<IActionResult> GetProfileDoctor(Guid id)
        {
            var profile = await profileRepository.GetProfileDoctorAsync(id);
            if (profile == null)
            {
                return NotFound();
            }
            return Ok(profile);
        }

    }
}
