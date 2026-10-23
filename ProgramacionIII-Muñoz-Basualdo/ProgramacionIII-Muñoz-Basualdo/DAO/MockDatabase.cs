using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;  
namespace DAO
{
    public static class MockDatabase
    {

        public static List<Player> Players { get; set; } = new List<Player>
        {
            new Player { Id = 1, Name = "Juan Jose", Age = 20, Dni = "215646", Numero = 8, TeamId = 1 },
            new Player { Id = 2, Name = "Jose Juan", Age = 40, Dni = "147916", Numero = 1, TeamId = 1 }
        };

        public static List<Trainer> Trainers { get; set; } = new List<Trainer>
        {
            new Trainer { Id = 1, Name = "Pepe", Age = 32, Dni = "19861256" }
        };

        public static List<Team> Teams { get; set; } = new List<Team>
        {
            new Team { Id = 1, Name = "Los teletubies", Category = "La mejor" }
        };

    
        public static List<Student> Students { get; set; } = new List<Student>
        {
            new Student { Id = 1, Name = "Jana", Age = 19, Dni = "1687464", File = "007" }
        };

        public static List<Course> Courses { get; set; } = new List<Course>
        {
            new Course { Id = 1, Name = "Desarrollo de software" }
        };

        public static List<Activity> Activities { get; set; } = new List<Activity>
        {
            new Activity {
                Id = 1,
                Title = "Entrega final",
                Description = "trabajo final integraados",
                Date = DateTime.Now,
                Type = TypeActivity.PracticalWork
            }
        };








    }
}
