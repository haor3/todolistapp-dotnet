using Microsoft.EntityFrameworkCore;

namespace ToDoListAppApi.Models
{
    public class ToDoListDBContext:DbContext
    {
        public ToDoListDBContext(DbContextOptions<ToDoListDBContext> options): base(options)
        {

        }

        public DbSet<Job> Jobs { get; set; }
    }
}
