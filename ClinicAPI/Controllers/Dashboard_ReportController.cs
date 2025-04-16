using ClinicAPI.CustomActionFilters;
using ClinicAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClinicAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Dashboard_ReportController : ControllerBase
    {
        private readonly IDashboard_ReportRepository dashboard_ReportRepository;

        public Dashboard_ReportController(IDashboard_ReportRepository dashboard_ReportRepository)
        {
            this.dashboard_ReportRepository = dashboard_ReportRepository;
        }
        [HttpGet("{id:guid}")]
        [RoleAuthorize("Doctor")]
        public async Task<IActionResult> GetDoctorDashboard([FromRoute] Guid id)
        {
            var Doctor = await dashboard_ReportRepository.GetDoctorNotGrouped(id);
            if (Doctor == null)
            {

                return NotFound();
            }
            else
            {
                return Ok(Doctor);
            }
        }
        [HttpGet("{id:guid}/Report")]
        [RoleAuthorize("Doctor")]
        public async Task<IActionResult> Report([FromRoute] Guid id)
        {
            var Doctor = await dashboard_ReportRepository.GetDoctorGrouped(id);
            if (Doctor == null)
            {

                return NotFound();
            }
            else
            {
                return Ok(Doctor);
            }

        }

    }
}
