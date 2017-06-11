namespace HospitalSystem.Models
{
    using System;
    using System.Collections.Generic;

    public class Doctor
    {
        public Doctor()
        {
            this.Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public HospitalWard HospitalWard { get; set; }

        public virtual ICollection<Patient> Patients { get; set; }
    }
}