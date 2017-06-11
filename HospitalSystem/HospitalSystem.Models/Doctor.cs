namespace HospitalSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Doctor
    {
        private ICollection<Patient> patients;

        public Doctor()
        {
            this.Id = Guid.NewGuid();
            this.patients = new HashSet<Patient>();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        public virtual HospitalWard HospitalWard { get; set; }

        public virtual ICollection<Patient> Patients
        {
            get { return this.patients; }

            set { this.patients = value; }
        }
    }
}