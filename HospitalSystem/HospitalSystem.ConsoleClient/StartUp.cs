namespace HospitalSystem.ConsoleClient
{
    using System;
    using System.Data.Entity;

    using HospitalSystem.Data;
    using HospitalSystem.Data.Migrations;
    using HospitalSystem.Models;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<HospitalSystemDbContext, Configuration>());

            // Importer.Create(Console.Out).Import();

            // DataSearcher.Search(new HospitalSystemService());

            try
            {
                var db = new HospitalSystemDbContext();

                var pat = new Patient() { FirstName = "anna", LastName = "eliii", Age = 5 };

                db.Patients.Add(pat);
                db.SaveChanges();

                Console.WriteLine(db.Patients.Count());
            }
            catch (Exception ex)
            {
                Console.WriteLine("here");
            }
        }
    }
}