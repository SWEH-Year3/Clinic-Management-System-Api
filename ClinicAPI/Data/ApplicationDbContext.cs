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

            var roles = new List<IdentityRole>
            {
                new IdentityRole { Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Name = "Doctor", NormalizedName = "DOCTOR" },
                new IdentityRole { Name = "Patient", NormalizedName = "PATIENT" }
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
