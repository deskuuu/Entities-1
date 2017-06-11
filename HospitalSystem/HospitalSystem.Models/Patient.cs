namespace HospitalSystem.Models
{
    using System;
    using System.Collections.Generic;

    public class Patient
    {
        public Patient()
        {
            this.Id = Guid.NewGuid();
            this.Doctors = new HashSet<Doctor>();
        }

        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public virtual ICollection<Doctor> Doctors { get; set; }
    }
}
