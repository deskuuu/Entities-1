namespace HospitalSystem.Data
{
    using System.Data.Entity;

    using HospitalSystem.Models;

    public class HospitalSystemDbContext : DbContext
    {
        public IDbSet<Doctor> Doctors { get; set; }

        public IDbSet<Patient> Patients { get; set; }

        public IDbSet<HospitalWard> HospitalWards { get; set; }
    }
}
