using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace ClinicAPI.Models.Domain
{
    public class FileImage
    {
        public Guid Id { get; set; }
        [NotMapped]
        public IFormFile File { get; set; }
        public string FilePath { get; set; }
        public double FileLength { get; set; }
        public string FileName { get; set; }
        [ValidateNever]
        public Prescription Prescription { get; set; }
        public Guid? PrescriptionId { get; set; }
        [ValidateNever]

        public Doctor Doctor { get; set; }
        public Guid?  DoctorId { get; set; }
    }
}
