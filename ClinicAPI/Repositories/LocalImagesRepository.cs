using ClinicAPI.Data;
using ClinicAPI.Models.Domain;
using static System.Net.Mime.MediaTypeNames;

namespace ClinicAPI.Repositories
{
    public class LocalImagesRepository : IImageRepository
    {
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly ApplicationDbContext dbContext;

        public LocalImagesRepository(IHttpContextAccessor httpContextAccessor, IWebHostEnvironment webHostEnvironment, ApplicationDbContext dbContext)
        {
            this.httpContextAccessor = httpContextAccessor;
            this.webHostEnvironment = webHostEnvironment;
            this.dbContext = dbContext;
        }
        public async Task<FileImage> CreateAsync(Guid id, FileImage file)
        {
            var doctor = await dbContext.Doctors.FindAsync(id);
            var prescription = await dbContext.Prescriptions.FindAsync(id);
            var Extension = Path.GetExtension(file.File.FileName).ToLower();
            string folder = (Extension == ".pdf" || Extension == ".docx") ? "Files" : "Images";
            string localPath = Path.Combine(webHostEnvironment.ContentRootPath, folder, file.FileName);

            await using (var stream = new FileStream(localPath, FileMode.Create))
            {
                await file.File.CopyToAsync(stream);
            }


            var url = $"{httpContextAccessor.HttpContext.Request.Scheme}://{httpContextAccessor.HttpContext.Request.Host}" +
                $"{httpContextAccessor.HttpContext.Request.PathBase}/{folder}/{file.FileName}";

            file.FilePath = url;
            file.DoctorId = doctor?.Id;
            file.PrescriptionId = prescription?.Id;
            await dbContext.FileImages.AddAsync(file);
            await dbContext.SaveChangesAsync();

            return file;



        }
    }
}
