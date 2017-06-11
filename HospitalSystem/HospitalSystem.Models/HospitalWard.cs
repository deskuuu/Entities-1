namespace HospitalSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class HospitalWard
    {
        private ICollection<Doctor> doctors;
        private ICollection<Patient> patients;

        public HospitalWard()
        {
            this.Id = Guid.NewGuid();
            this.doctors = new HashSet<Doctor>();
            this.patients = new HashSet<Patient>();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Doctor> Doctors
        {
            get { return this.doctors; }

            set { this.doctors = value; }
        }

        public virtual ICollection<Patient> Patients
        {
            get { return this.patients; }

            set { this.patients = value; }
        }
    }
}
