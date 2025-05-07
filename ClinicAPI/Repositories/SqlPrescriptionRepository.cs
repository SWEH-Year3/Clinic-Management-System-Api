using ClinicAPI.Data;
using ClinicAPI.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace ClinicAPI.Repositories
{
    public class SqlPrescriptionRepository : IPrescriptionRespository
    {
        private readonly ApplicationDbContext dbContext;

        public SqlPrescriptionRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<Prescription> CreateAsync(Prescription prescription)
        {
            await dbContext.Prescriptions.AddAsync(prescription);
            await dbContext.SaveChangesAsync();
            return prescription;
        }

        public async Task<Prescription?> GetAsync(Guid id)
        {
            var existing= await dbContext.Prescriptions.Include(a=> a.Appointment).FirstOrDefaultAsync(x => x.Id == id || x.Appointment.Id == id);
            if (existing != null) { 
                return existing;
            }
            return null;
        }

        public async Task<Prescription?> UpdateAsync(Guid id, Prescription prescription)
        {
            var existing = await dbContext.Prescriptions.FirstOrDefaultAsync(x => x.Id == id);
            if (existing == null)
            {
                return null;
            }
            existing.AppointmentId = prescription.AppointmentId;
            existing.Modification_date=prescription.Modification_date;
            existing.Description=prescription.Description;
            await dbContext.SaveChangesAsync();
            return prescription;
        }
    }
}
