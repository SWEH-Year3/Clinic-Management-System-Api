using ClinicAPI.Models.Domain;

namespace ClinicAPI.Repositories
{
    public interface IImageRepository
    {
        Task<FileImage> CreateAsync(Guid id, Guid Pre_id, FileImage file);

    }
}
