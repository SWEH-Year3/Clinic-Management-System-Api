using System.IdentityModel.Tokens.Jwt;
using ClinicAPI.CustomActionFilters;
using ClinicAPI.Models.Domain;
using ClinicAPI.Models.DTO;
using ClinicAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClinicAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private readonly IAppointmentRepository appointmentRepository;

        public AppointmentController(IAppointmentRepository appointmentRepository)
        {
            this.appointmentRepository = appointmentRepository;
        }

        [HttpPost]
        [RoleAuthorize("Admin")]
        public async Task<IActionResult> AddNewAppointment([FromBody] AddAppointmentRequestDto addAppointmentRequestDto)
        {
            var appointmentDomainModel = new Appointment
            {
                Time = addAppointmentRequestDto.Time,
                DoctorId = addAppointmentRequestDto.DoctorId,
                Date = addAppointmentRequestDto.Date,
                State = "open"
            };
            await appointmentRepository.CreateAsync(appointmentDomainModel);
            return Ok();
        }

        [HttpPut("{id:guid}")]
        [RoleAuthorize("Admin")]
        public async Task<IActionResult> EditAppointment([FromRoute] Guid id, [FromBody] EditAppointmentRequestDto edit)
        {
            var exist = new Appointment
            {
                Date = edit.Date,
                Time = edit.Time,
            };
            exist = await appointmentRepository.UpdateAsync(id, exist);
            if (exist != null)
            {
                return Ok();
            }
            return NotFound();
        }

        [HttpPut("{id:guid}/book")]
        [RoleAuthorize("Patient")]
        public async Task<IActionResult> BookAppointment([FromRoute] Guid id, [FromBody] BookAppointmentRequestDto book)
        {
            var existing = new Appointment
            {
                PatientId = book.PatientId.ToString(),
                State = "pending"
            };
            existing = await appointmentRepository.UpdateAsync(id, existing);

            if (existing != null)
            {
                return Ok();
            }
            return NotFound();
        }
        [HttpPut("reschedule")]
        [RoleAuthorize("Patient")]
        public async Task<IActionResult> RescheduleAppointent([FromBody] ReschedulaAppointentRequestDto reschedula)
        {
            var setOldAppointment = new Appointment
            {
                PatientId = "not found",
                State = "open"
            };
            setOldAppointment = await appointmentRepository.UpdateAsync(reschedula.OldAppointmentId, setOldAppointment);
            if (setOldAppointment == null)
            {
                return NotFound();
            }
            var updateNewAppointment = new Appointment
            {
                PatientId = reschedula.PatientId.ToString(),
                DoctorId = reschedula.DoctorId,

            };
            updateNewAppointment = await appointmentRepository.UpdateAsync(reschedula.NewAppointmentId, updateNewAppointment);
            if (updateNewAppointment == null)
            {
                return NotFound();
            }
            return Ok();
        }
        [HttpPut("{id:guid}/treat")]
        [RoleAuthorize("Doctor")]
        public async Task<IActionResult> TreatAppointment([FromRoute] Guid id, TreatAppointmentRequestDto treat)
        {
            var update = new Appointment
            {
                State = treat.State
            };
            update = await appointmentRepository.UpdateAsync(id, update);
            if (update == null) { return NotFound(); }
            return Ok();
        }
        [HttpPut("{id:guid}/Admin")]
        [RoleAuthorize("Admin")]
        public async Task<IActionResult> ApprovedAppointment([FromRoute] Guid id, TreatAppointmentRequestDto treat)
        {
            var update = new Appointment
            {
                State = treat.State
            };
            update = await appointmentRepository.UpdateAsync(id, update);
            if (update == null) { return NotFound(); }
            return Ok();
        }
        [HttpGet]
        [RoleAuthorize("Doctor", "Admin", "Patient")]
        public async Task<IActionResult> GetAppointment()
        {
            var appointments = await appointmentRepository.GetAllAsync();

            var response = new List<GetAppointmentResponseDto>();

            foreach (var appointment in appointments)
            {
                var dto = new GetAppointmentResponseDto
                {
                    Date = appointment.Date,
                    Time = appointment.Time,
                    Id = appointment.Id,
                    DoctorId = appointment.DoctorId.ToString(),
                    PatientId = appointment.PatientId ?? null,
                    State = appointment.State,
                    PatientName = appointment.Patient?.UserName ?? "not found",
                    DoctorName = appointment.Doctor?.userApplication?.UserName ?? "not found"
                };

                response.Add(dto);
            }

            return Ok(response);
        }


    }
}
