namespace HospitalSystem.Models
{
    using System;
    using System.Collections.Generic;

    public class HospitalWard
    {
        public HospitalWard()
        {
            this.Id = Guid.NewGuid();
            this.Patients = new HashSet<Patient>();
        }

        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Patient> Patients { get; set; }
    }
}
