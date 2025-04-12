using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace ClinicAPI.Models.DTO
{
    public class GetDoctorResponseDto
    {
        public string DoctorId { get; set; }
        public string Name { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.PhoneNumber)]

        public string Phone { get; set; }
        public string Specialty { get; set; }
        [DataType(DataType.Currency)]

        public double Price { get; set; }

    }
}
