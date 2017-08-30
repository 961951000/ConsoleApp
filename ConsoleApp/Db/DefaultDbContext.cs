using ConsoleApp.Models;
using System.Data.Entity;

namespace ConsoleApp.Db
{
    public class DefaultDbContext : DbContext
    {
        public DefaultDbContext() : base("name=DefaultConnection") { }

        public DbSet<Student> Student { get; set; }

        public DbSet<School> School { get; set; }
    }
}
