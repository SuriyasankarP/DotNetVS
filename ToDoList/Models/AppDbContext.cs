using Microsoft.EntityFrameworkCore;

namespace ToDoList.Models
{
    public class AppDbContext : DbContext
    {


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<list> list { get; set; }

    }
}
