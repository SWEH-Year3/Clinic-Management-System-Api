using ClinicAPI.CustomActionFilters;
using ClinicAPI.Data;
using ClinicAPI.Models.Domain;
using ClinicAPI.Models.DTO;
using ClinicAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Validations;

namespace ClinicAPI.Controllers
{
    //TODO: To be Removed
    //[Route("api/[controller]")]
    //[ApiController]
    public class ImageFileController : ControllerBase
    {
        private readonly IImageRepository imageRepository;

        public ImageFileController(IImageRepository imageRepository)
        {
            this.imageRepository = imageRepository;
        }
        //[HttpPost("{id:guid}")]
        //[RoleAuthorize("Doctor")]
        public async Task<IActionResult> CreateFile([FromRoute] Guid id, [FromForm] AddImageRequestDto requestDto)
        {
            ValidationFile(requestDto);
            if (ModelState.IsValid)
            {

            var ImageDomainModel=new FileImage
            {
                File=requestDto.File,
                FileLength=requestDto.File.Length,
                FileName=requestDto.FileName
            };

               
                await imageRepository.CreateAsync(id,ImageDomainModel);
                return Ok();
            }
            return BadRequest(ModelState);
        }

        private void ValidationFile(AddImageRequestDto requestDto)
        {
            if (requestDto.File == null)
            {
                ModelState.AddModelError("File", "File is required.");
                return;
            }
            if (requestDto.File.Length > 10485760)
            {
                ModelState.AddModelError("File", "this is out of length");

            }
        }

    }
}
