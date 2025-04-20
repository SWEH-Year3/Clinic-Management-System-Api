using ClinicAPI.Models.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ClinicAPI.Data
{
    public class ApplicationDbContext : IdentityDbContext<UserApplication>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<FileImage> FileImages { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            var doctorRoleId = "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797";
            var patientRoleId = "72235979-4cb2-4bb1-9de9-9e931f98610e";
            var adminRoleId = "675b578c-8739-4b1b-a706-816fb14910bd";

            var roles = new List<IdentityRole>
            {
                new IdentityRole {Id=adminRoleId, Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole {Id=doctorRoleId, Name = "Doctor", NormalizedName = "DOCTOR" },
                new IdentityRole {Id=patientRoleId, Name = "Patient", NormalizedName = "PATIENT" }
            };

            builder.Entity<IdentityRole>().HasData(roles);
            builder.Entity<Doctor>()
                .HasOne(u => u.userApplication)
                .WithOne()
                .HasForeignKey<Doctor>(u => u.UserId);
            builder.Entity<Appointment>()
                .HasOne(u => u.Doctor)
                .WithMany(u => u.Appointments)
                .HasForeignKey(u => u.DoctorId);
            builder.Entity<Appointment>()
                .HasOne(u => u.Patient)
                .WithMany(u => u.Appointments)
                .HasForeignKey(u => u.PatientId);
            builder.Entity<Prescription>()
                .HasOne(u => u.Appointment)
                .WithOne(u => u.Prescription)
                .HasForeignKey<Prescription>(u => u.AppointmentId);
            builder.Entity<FileImage>().
                HasOne(u => u.Doctor)
                .WithOne(u => u.FileImage)
                .HasForeignKey<FileImage>(u => u.DoctorId).IsRequired(false);
            builder.Entity<FileImage>().
                HasOne(u => u.Prescription)
                .WithOne(u => u.FileImage)
                .HasForeignKey<FileImage>(u => u.PrescriptionId).IsRequired(false);
        }
    }
}
