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
        private readonly PdfService pdfService;

        private readonly IHttpContextAccessor httpContextAccessor;

        public PrescriptionController(IPrescriptionRespository prescriptionRespository, PdfService pdfService, IHttpContextAccessor httpContextAccessor)
        {
            this.prescriptionRespository = prescriptionRespository;
            this.pdfService = pdfService;
            this.httpContextAccessor = httpContextAccessor;
        }

        [HttpPost]
        [RoleAuthorize("Doctor")]
        public async Task<IActionResult> CreatePrescription([FromBody] AddPrescriptionRequestDto addPrescription)
        {
            var PrescriptionDomainModel = new Prescription
            {
                AppointmentId = addPrescription.AppointmentId,
                Description = addPrescription.Description,
                Modification_date = addPrescription.Modification_date

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
                Modification_date = EditPrescription.Modification_date

            };
            PrescriptionDomainModel = await prescriptionRespository.UpdateAsync(id, PrescriptionDomainModel);
            if (PrescriptionDomainModel != null)
            {
                return Ok();
            }
            return NotFound();

        }
        [HttpGet("{id:guid}")]

        public async Task<IActionResult> GetPrescription([FromRoute]Guid id)
        {
            var prescriptionDomainModel=await prescriptionRespository.GetAsync(id);
            if (prescriptionDomainModel != null) {

                var response = new GetPrescriptionResponseDto()
                {
                    Id = prescriptionDomainModel.Id,
                    Description = prescriptionDomainModel.Description,
                    Modification_date = prescriptionDomainModel.Modification_date,
                    AppointmentId = prescriptionDomainModel.AppointmentId
                };
                return Ok(response);
            }
            return NotFound();

        }

        [HttpGet("{id:guid}/pdf")]
        public async Task<IActionResult> GetPrescriptionPdf([FromRoute] Guid id)
        {
            var prescription = await prescriptionRespository.GetAsync(id);

            if (prescription == null)
                return NotFound();


            var pdfBytes = pdfService.GeneratePrescriptionPdf(prescription.Description??"Empty Prescription");

            var folderPath = Path.Combine(Directory.GetCurrentDirectory(), "Files");
            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);

            var fileName = $"Prescription_{id}.pdf";
            var filePath = Path.Combine(folderPath, fileName);

            await System.IO.File.WriteAllBytesAsync(filePath, pdfBytes);

            var response = new
            {
                prescription.Id,
                FilePath = $"{httpContextAccessor.HttpContext.Request.Scheme}://" +
                      $"{httpContextAccessor.HttpContext.Request.Host}" +
                      $"{httpContextAccessor.HttpContext.Request.PathBase}" + $"/Files/{fileName}",
                Message = "PDF saved successfully."
            };

            return Ok(response);
        }
    }
}
