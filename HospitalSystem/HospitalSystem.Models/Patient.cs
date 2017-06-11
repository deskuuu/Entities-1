namespace HospitalSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Patient
    {
        private HospitalWard hospitalWard;
        private ICollection<Doctor> doctors;

        public Patient()
        {
            this.Id = Guid.NewGuid();
            this.hospitalWard = new HospitalWard();
            this.doctors = new HashSet<Doctor>();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(50)]
        public string LastName { get; set; }

        public int Age { get; set; }

        public virtual HospitalWard HospitalWard
        {
            get { return this.hospitalWard; }

            set { this.hospitalWard = value; }
        }

        public virtual ICollection<Doctor> Doctors
        {
            get { return this.doctors; }

            set { this.doctors = value; }
        }
    }
}