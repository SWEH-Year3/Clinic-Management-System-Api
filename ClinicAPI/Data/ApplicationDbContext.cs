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

            //Data Seeding
            var passwordHasher = new PasswordHasher<UserApplication>();
            var users = new List<UserApplication>();
            var doctors = new List<Doctor>();
            var appointments = new List<Appointment>();
            var prescriptions = new List<Prescription>();
            var userRoles = new List<IdentityUserRole<string>>();

            // Seed 20 Patients
            for (int i = 1; i <= 20; i++)
            {
                var userId = Guid.NewGuid().ToString();
                var user = new UserApplication
                {
                    Id = userId,
                    UserName = $"patient{i}@clinic.com",
                    NormalizedUserName = $"PATIENT{i}@CLINIC.COM",
                    Email = $"patient{i}@clinic.com",
                    NormalizedEmail = $"PATIENT{i}@CLINIC.COM",
                    PhoneNumber = $"010000000{i:D2}",
                    EmailConfirmed = true,
                    PhoneNumberConfirmed = true,
                    SecurityStamp = Guid.NewGuid().ToString()
                };
                user.PasswordHash = passwordHasher.HashPassword(user, "patient@123");
                users.Add(user);
                userRoles.Add(new IdentityUserRole<string> { UserId = userId, RoleId = patientRoleId });
            }

            // Seed 20 Doctors
            for (int i = 1; i <= 20; i++)
            {
                var doctorId = Guid.NewGuid().ToString();
                var doctorUser = new UserApplication
                {
                    Id = doctorId,
                    UserName = $"doctor{i}@clinic.com",
                    NormalizedUserName = $"DOCTOR{i}@CLINIC.COM",
                    Email = $"doctor{i}@clinic.com",
                    NormalizedEmail = $"DOCTOR{i}@CLINIC.COM",
                    PhoneNumber = $"011000000{i:D2}",
                    EmailConfirmed = true,
                    PhoneNumberConfirmed = true,
                    SecurityStamp = Guid.NewGuid().ToString()
                };
                doctorUser.PasswordHash = passwordHasher.HashPassword(doctorUser, "doctor@123");
                users.Add(doctorUser);
                userRoles.Add(new IdentityUserRole<string> { UserId = doctorId, RoleId = doctorRoleId });

                doctors.Add(new Doctor
                {
                    Id = Guid.NewGuid(),
                    Specialty = $"Specialty {i}",
                    Price = 100 + i,
                    UserId = doctorId
                });
            }

            // Seed 20 Appointments and Prescriptions
            var random = new Random();
            for (int i = 0; i < 20; i++)
            {
                var doctor = doctors[i % 20];
                var patient = users[i % 20];

                var appointmentId = Guid.NewGuid();
                appointments.Add(new Appointment
                {
                    Id = appointmentId,
                    DoctorId = doctor.Id,
                    PatientId = patient.Id,
                    Time = $"{9 + i % 12}:00 AM",
                    Date = $"2025-05-{(i % 30) + 1:D2}",
                    State = "Scheduled"
                });

                prescriptions.Add(new Prescription
                {
                    Id = Guid.NewGuid(),
                    AppointmentId = appointmentId,
                    Description = $"Prescription for appointment {i + 1}",
                    Modification_date = DateTime.UtcNow.ToString("yyyy-MM-dd")
                });
            }

            // Apply seeding
            builder.Entity<UserApplication>().HasData(users);
            builder.Entity<IdentityUserRole<string>>().HasData(userRoles);
            builder.Entity<Doctor>().HasData(doctors);
            builder.Entity<Appointment>().HasData(appointments);
            builder.Entity<Prescription>().HasData(prescriptions);


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
