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
        private readonly IEmailService email;

        public AppointmentController(IAppointmentRepository appointmentRepository, IEmailService email)
        {
            this.appointmentRepository = appointmentRepository;
            this.email = email;
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
        [HttpPut("{id:guid}/book/cancel")]
        [RoleAuthorize("Patient")]
        public async Task<IActionResult> CancelAppointment([FromRoute] Guid id, [FromBody] BookAppointmentRequestDto book)
        {
            var existing = new Appointment
            {
                PatientId = book.PatientId.ToString(),
                State = "open"
            };
            existing = await appointmentRepository.CancelBookAsync(id, existing);

            if (existing != null && existing.State == "open")
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
                State = "pending"

            };
            updateNewAppointment = await appointmentRepository.UpdateAsync(reschedula.NewAppointmentId, updateNewAppointment);
            if (updateNewAppointment == null)
            {
                return NotFound();
            }
            await email.SendEmailAsync(updateNewAppointment.Patient.Email, "ChangeSchedula", "change successfully");
            return Ok();
        }
        [HttpPut("{id:guid}/treat")]
        [RoleAuthorize("Doctor")]
        public async Task<IActionResult> TreatAppointment([FromRoute] Guid id, TreatAppointmentRequestDto treat)
        {
            var update = new Appointment
            {
                State = treat.State,
                PatientId = treat.PatientId
            };
            update = await appointmentRepository.UpdateAsync(id, update);
            if (update == null) { return NotFound(); }
            return Ok();
        }
        [HttpPut("{id:guid}/Admin")]
        public async Task<IActionResult> ApprovedAppointment([FromRoute] Guid id, TreatAppointmentRequestDto treat)
        {
            var update = new Appointment
            {
                State = treat.State,
                PatientId = treat.PatientId
            };
            update = await appointmentRepository.UpdateAsync(id, update);
            if (update == null ) { return NotFound(); }
            if(update.Patient != null && update.Patient.Email != null)
            {
                await email.SendEmailAsync(update.Patient.Email, "AdminApproved", "you are accepted");
            }
            return Ok();
        }
        [HttpGet]
        [RoleAuthorize("Admin")]
        public async Task<IActionResult> GetAppointments()
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
                    DoctorName = appointment.Doctor?.userApplication?.UserName ?? "not found",
                    Phone = appointment?.Patient?.PhoneNumber,
                    PrecriptionID = appointment?.Prescription?.Id,
                    Specialty = appointment.Doctor.Specialty
                };

                response.Add(dto);
            }

            return Ok(response);
        }

        [HttpGet("doctor/search")]
        public async Task<IActionResult> GetAppointmentsByDocName([FromQuery(Name = "Name")] string Name)
        {
            var appointments = await appointmentRepository.GetAllByNameAsync(Name);

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
                    DoctorName = appointment.Doctor?.userApplication?.UserName ?? "not found",
                    Phone = appointment?.Patient?.PhoneNumber,
                    PrecriptionID = appointment?.Prescription?.Id,
                    Specialty = appointment.Doctor.Specialty
                };

                response.Add(dto);
            }

            return Ok(response);
        }

        [HttpGet("{id:guid}/doctor")]
        [RoleAuthorize("Doctor")]
        public async Task<IActionResult> GetDoctorAppointment([FromRoute] Guid id)
        {
            var appointments = await appointmentRepository.GetAppointmentDoctorAsync(id);

            if (appointments == null) { return NotFound(); }
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
                    DoctorName = appointment.Doctor?.userApplication?.UserName ?? "not found",
                    PrecriptionID = appointment?.Prescription?.Id,
                    Phone = appointment.Patient.PhoneNumber,
                    Specialty = appointment.Doctor.Specialty
                };
                response.Add(dto);
            }

            return Ok(response);


        }

        [HttpGet("Booking/{id:guid}")]
        public async Task<IActionResult> GetBookingAppointment([FromRoute] Guid id)
        {
            var appointments = await appointmentRepository.GetAppointmentDoctorBookingAsync(id);

            if (appointments == null) { return NotFound(); }
            var response = new List<GetAppointmentResponseDto>();

            foreach (var appointment in appointments)
            {
                var dto = new GetAppointmentResponseDto
                {
                    Date = appointment.Date,
                    Time = appointment.Time,
                    Id = appointment.Id,
                    DoctorId = appointment.DoctorId.ToString(),
                    State = appointment.State,
                    DoctorName = appointment.Doctor?.userApplication?.UserName ?? "not found",
                    PrecriptionID = appointment?.Prescription?.Id ?? null,
                    PatientId = appointment?.PatientId,
                    PatientName = appointment?.Patient?.UserName ?? "not found",
                    Phone = appointment?.Patient?.PhoneNumber,
                    Specialty = appointment?.Doctor?.Specialty
                };
                if (dto != null)
                {

                    response.Add(dto);
                }
            }

            return Ok(response);


        }
        [HttpGet("{id:guid}/patient")]
        [RoleAuthorize("Patient")]
        public async Task<IActionResult> GetPatientAppointment([FromRoute] Guid id)
        {
            var appointments = await appointmentRepository.GetAppointmentPatientAsync(id);

            if (appointments == null) { return NotFound(); }
            var response = new List<GetAppointmentResponseDto>();

            foreach (var appointment in appointments)
            {
                var dto = new GetAppointmentResponseDto
                {
                    Date = appointment?.Date,
                    Time = appointment?.Time,
                    Id = appointment.Id,
                    DoctorId = appointment.DoctorId.ToString(),
                    PatientId = appointment.PatientId ?? null,
                    Specialty = appointment.Doctor.Specialty,
                    State = appointment.State,
                    PatientName = appointment.Patient?.UserName ?? "not found",
                    DoctorName = appointment.Doctor?.userApplication?.UserName ?? "not found",
                    PrecriptionID = appointment?.Prescription?.Id,
                    Phone = appointment.Patient.PhoneNumber
                };

                response.Add(dto);
            }

            return Ok(response);


        }

        [HttpDelete("{id:guid}")]
        [RoleAuthorize("Admin")]
        public async Task<IActionResult> deleteAppointment([FromRoute] Guid id)
        {
            var appo = await appointmentRepository.DeleteAppointmentAsync(id);
            if(appo == null)
            {
                return BadRequest();
            }
            return Ok();
        }
    }
}
