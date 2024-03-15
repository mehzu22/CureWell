using CureWell.Models;
using Microsoft.EntityFrameworkCore;

namespace CureWell.Database
{
    public class CureWellContext : DbContext
    {
        public CureWellContext(DbContextOptions<CureWellContext> options): base(options)
        {

        }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<DoctorSpecialization> DoctorSpecializations { get; set; }
        public DbSet<Specialization> Specializations { get; set; }
        public DbSet<Surgery> Surgeries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DoctorSpecialization>()
                .HasKey(ds => new { ds.DoctorId, ds.SpecializationCode });
        }
    }
    
}