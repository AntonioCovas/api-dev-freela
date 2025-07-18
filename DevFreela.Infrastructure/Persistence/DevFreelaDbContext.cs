using DevFreela.Core.Entities;

namespace DevFreela.Infrastructure.Persistence
{
    public class DevFreelaDbContext
    {
        public DevFreelaDbContext()
        {
            Projects = new List<Project>()
            {
                new Project("Meu projeto ASP.NET Core 1", "Descrição 1", 1, 1, 10000m),
                new Project("Meu projeto ASP.NET Core 2", "Descrição 2", 1, 1, 20000m),
                new Project("Meu projeto ASP.NET Core 3", "Descrição 3", 1, 1, 30000m),
            };

            Users = new List<User>()
            {
                new User("Antônio Covas Jr", "antonio@gmail.com", new DateTime(1998, 11, 19)),
                new User("Antônio Covas", "antoniopai@gmail.com", new DateTime(1945, 10, 26)),
                new User("Silvana Lima", "silvana@gmail.com", new DateTime(1963, 12, 12)),
            };

            Skills = new List<Skill>()
            {
                new Skill(".NET Core"),
                new Skill("C#"),
                new Skill("SQL") 
            };

            ProjectComments = new List<ProjectComment>();
        }

        public List<Project> Projects { get; set; }
        public List<User> Users { get; set; }
        public List<Skill> Skills { get; set; }
        public List<ProjectComment> ProjectComments { get; set; }
    }
}
