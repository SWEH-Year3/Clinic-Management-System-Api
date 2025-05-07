using ClinicAPI.CustomActionFilters;
using ClinicAPI.Models.DTO;
using ClinicAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClinicAPI.Controllers
{
    [Route("api/")]
    [ApiController]
    public class Dashboard_ReportController : ControllerBase
    {
        private readonly IDashboard_ReportRepository dashboard_ReportRepository;

        public Dashboard_ReportController(IDashboard_ReportRepository dashboard_ReportRepository)
        {
            this.dashboard_ReportRepository = dashboard_ReportRepository;
        }
        [HttpGet("Dashboard/{id:guid}")]
        
        [RoleAuthorize("Admin")]
        public async Task<IActionResult> GetDoctorDashboard([FromRoute] Guid id)
        {
            var Doctor = await dashboard_ReportRepository.GetDoctorNotGrouped(id);
            if (Doctor == null)
            {

                return NotFound();
            }
            var response = new Dashboard_ReportResponseDto
            {
                Id= Doctor.Id,
                Name=Doctor.Name,
                MonthlyAppointments = Doctor.MonthlyAppointments,
                Specialty =Doctor.Specialty,
            };


                return Ok(response);
            
        }
        [HttpGet("Report")]
        [RoleAuthorize("Admin")]
        public async Task<IActionResult> Report()
        {
            var Doctor = await dashboard_ReportRepository.GetDoctorGrouped();
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
