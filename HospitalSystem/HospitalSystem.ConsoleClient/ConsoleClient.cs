namespace HospitalSystem.ConsoleClient
{
    using System.Linq;

    using HospitalSystem.Data;
    using HospitalSystem.Models;

    public class ConsoleClient
    {
        public static void Main()
        {
            var data = new HospitalSystemDbContext();

            var hospitalWard = new HospitalWard
            {
                Name="",
                Description=""
            };

            data.HospitalWards.Add(hospitalWard);
            data.SaveChanges();

            var count = data.HospitalWards.Count();

            System.Console.WriteLine(count);
        }
    }
}