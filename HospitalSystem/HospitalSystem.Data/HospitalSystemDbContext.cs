namespace HospitalSystem.Data
{
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;

    using HospitalSystem.Models;

    public class HospitalSystemDbContext : DbContext
    {
        public HospitalSystemDbContext()
            : base("HospitalSystem")
        {
        }

        public IDbSet<Doctor> Doctors { get; set; }

        public IDbSet<Patient> Patients { get; set; }

        public IDbSet<HospitalWard> HospitalWards { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            base.OnModelCreating(modelBuilder);
        }
    }
}
