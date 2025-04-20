using ClinicAPI.Models.Domain;

namespace ClinicAPI.Repositories
{
    public interface IImageRepository
    {
        Task<FileImage> CreateAsync(Guid id,FileImage file);

    }
}
