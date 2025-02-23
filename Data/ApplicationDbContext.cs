using Microsoft.EntityFrameworkCore;
using st10251759_prog7311_ice_task_1.Models;

namespace st10251759_prog7311_ice_task_1.Data
{
    public class ApplicationDbContext : DbContext
    {
        //constructor that passes the DbContext options to the base class for configuration
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        //DbSet representing the collection of ToDoTask entities in the database
        public DbSet<ToDoTask> Tasks { get; set; }
    }
}
