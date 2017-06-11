namespace HospitalSystem.ConsoleClient
{
    using System;
    using System.Data.Entity;

    using HospitalSystem.Data;
    using HospitalSystem.Data.Migrations;

    public class StartUp
    {
        public static void Main()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<HospitalSystemDbContext, Configuration>());

            // Importer.Create(Console.Out).Import();

            // DataSearcher.Search(new HospitalSystemService());
        }
    }
}