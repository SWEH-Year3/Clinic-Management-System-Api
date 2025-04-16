using ClinicAPI.CustomActionFilters;
using ClinicAPI.Models.Domain;
using ClinicAPI.Models.DTO;
using ClinicAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace ClinicAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrescriptionController : ControllerBase
    {
        private readonly IPrescriptionRespository prescriptionRespository;

        public PrescriptionController(IPrescriptionRespository prescriptionRespository)
        {
            this.prescriptionRespository = prescriptionRespository;
        }

        [HttpPost]
        [RoleAuthorize("Doctor")]
        public async Task<IActionResult> CreatePrescription([FromBody] AddPrescriptionRequestDto addPrescription)
        {
            var PrescriptionDomainModel = new Prescription
            {
                AppointmentId = addPrescription.AppointmentId,
                Description = addPrescription.Description,
                Modification_date = addPrescription.Modifictaion_data

            };
            await prescriptionRespository.CreateAsync(PrescriptionDomainModel);

            return Ok();
        }
        [HttpPut("{id:guid}")]
        [RoleAuthorize("Doctor")]
        public async Task<IActionResult> UpdatePrescription([FromRoute]Guid id, [FromBody] EditPrescriptionRequestDto EditPrescription)
        {
            var PrescriptionDomainModel = new Prescription
            {
                AppointmentId = EditPrescription.AppointmentId,
                Description = EditPrescription.Description,
                Modification_date = EditPrescription.Modifiaction_data

            };
            PrescriptionDomainModel = await prescriptionRespository.UpdateAsync(id, PrescriptionDomainModel);
            if (PrescriptionDomainModel != null)
            {
                return Ok();
            }
            return NotFound();

        }
        [HttpGet("{id:guid}")]
        [RoleAuthorize("Doctor")]

        public async Task<IActionResult> GetPrescription([FromRoute]Guid id)
        {
            var prescriptionDomainModel=await prescriptionRespository.GetAsync(id);
            if (prescriptionDomainModel != null) {

                var response = new GetPrescriptionResponseDto()
                {
                    Id = prescriptionDomainModel.Id,
                    Description = prescriptionDomainModel.Description,
                    Modifiaction_data = prescriptionDomainModel.Modification_date,
                    AppointmentId = prescriptionDomainModel.AppointmentId
                };
                return Ok(response);
            }
            return NotFound();

        }
    }
}
