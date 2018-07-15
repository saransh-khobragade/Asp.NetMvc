using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            var ctx = new TrainingContext();
            Batch batch = new Batch()
            {
                BatchID = 1,
                BatchName = "Jan15-CS",
                BatchOwner = "Sharan"
            };
            Trainee trainee = new Trainee()
            {
                TraineeID = 101,
                TraineeName = "John",
                EmailID = "john@infy.com",
                DateOfJoining = Convert.ToDateTime("01/01/2015"),
                Batch = batch
            };
            ctx.Trainees.Add(trainee);
            ctx.SaveChanges();
            Console.WriteLine("Done");
            Console.ReadLine();
        }
        public class Trainee
        {
            public Trainee()
            {
            }
            public int TraineeID { get; set; }
            public string TraineeName { get; set; }
            public string EmailID { get; set; }
            public DateTime DateOfJoining { get; set; }
            public Batch Batch { get; set; }
        }
        public class Batch
        {
            public Batch()
            {
            }
            public int BatchID { get; set; }
            public string BatchName { get; set; }
            public string BatchOwner { get; set; }
            public ICollection<Trainee> Trainees { get; set; }
        }
        public class TrainingContext : DbContext
        {
            public TrainingContext()
                : base("name=CodeFirstConString")
            {
            }
            public DbSet<Trainee> Trainees { get; set; }
            public DbSet<Batch> Batches { get; set; }
        }
    }
}
