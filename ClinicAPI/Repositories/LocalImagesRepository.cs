using ClinicAPI.Data;
using ClinicAPI.Models.Domain;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.FileProviders;
using System;
using System.IO;
using System.Threading.Tasks;

namespace ClinicAPI.Repositories
{
    public class LocalImagesRepository : IImageRepository
    {
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly ApplicationDbContext dbContext;

        public LocalImagesRepository(
            IHttpContextAccessor httpContextAccessor,
            IWebHostEnvironment webHostEnvironment,
            ApplicationDbContext dbContext)
        {
            this.httpContextAccessor = httpContextAccessor;
            this.webHostEnvironment = webHostEnvironment;
            this.dbContext = dbContext;
        }

        public async Task<FileImage> CreateAsync(Guid id, Guid pre_id, FileImage file)
        {
            var doctor = await dbContext.Doctors.FindAsync(id);
            var prescription = await dbContext.Prescriptions.FindAsync(pre_id);

            var extension = Path.GetExtension(file.File.FileName).ToLower();

            var folder = (extension == ".pdf" || extension == ".docx") ? "Files" : "Images";
            var folderPath = Path.Combine(webHostEnvironment.ContentRootPath, folder);

            Directory.CreateDirectory(folderPath);

           
            var baseFileName = Path.GetFileNameWithoutExtension(file.FileName);
            if (string.IsNullOrWhiteSpace(baseFileName))
            {
                baseFileName = Guid.NewGuid().ToString();
            }

            var fullFileName = baseFileName + extension;
            var localPath = Path.Combine(folderPath, fullFileName);

            await using (var stream = new FileStream(localPath, FileMode.Create))
            {
                await file.File.CopyToAsync(stream);
            }

            var url = $"{httpContextAccessor.HttpContext.Request.Scheme}://" +
                      $"{httpContextAccessor.HttpContext.Request.Host}" +
                      $"{httpContextAccessor.HttpContext.Request.PathBase}/{folder}/{fullFileName}";

            file.FilePath = url;
            file.DoctorId = doctor?.Id;
            file.PrescriptionId = prescription?.Id;

            await dbContext.FileImages.AddAsync(file);
            await dbContext.SaveChangesAsync();

            return file;
        }
    }
}
