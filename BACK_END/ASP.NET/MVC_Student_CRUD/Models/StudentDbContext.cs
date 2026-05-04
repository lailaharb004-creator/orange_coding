using Microsoft.EntityFrameworkCore;
namespace MVC_Student_CRUD.Models
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext (DbContextOptions<StudentDbContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
    }
}
