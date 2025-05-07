using ClinicAPI.CustomActionFilters;
using ClinicAPI.Models.Domain;
using ClinicAPI.Models.DTO;
using ClinicAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ClinicAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageFileController : ControllerBase
    {
        private readonly IImageRepository imageRepository;

        public ImageFileController(IImageRepository imageRepository)
        {
            this.imageRepository = imageRepository;
        }

        [HttpPost("{id:guid}/{pre_id:guid}")]
        [RoleAuthorize("Doctor")]
        public async Task<IActionResult> CreateFile(
            [FromRoute] Guid id,
            [FromRoute] Guid pre_id,
            [FromForm] AddImageRequestDto requestDto)
        {
            ValidateFile(requestDto);

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var imageDomainModel = new FileImage
            {
                File = requestDto.File,
                FileLength = requestDto.File.Length,
                FileName = requestDto.FileName
            };

            var savedFile = await imageRepository.CreateAsync(id, pre_id, imageDomainModel);
            return Ok();
        }

        private void ValidateFile(AddImageRequestDto requestDto)
        {
            if (requestDto.File == null)
            {
                ModelState.AddModelError("File", "File is required.");
                return;
            }

            if (requestDto.File.Length > 10 * 1024 * 1024)
            {
                ModelState.AddModelError("File", "File size exceeds 10 MB.");
            }

            var allowedExtensions = new[] { ".jpg", ".jpeg", ".png", ".pdf", ".docx" };
            var extension = Path.GetExtension(requestDto.File.FileName).ToLower();
            if (!allowedExtensions.Contains(extension))
            {
                ModelState.AddModelError("File", "Unsupported file type.");
            }
        }
    }
}
