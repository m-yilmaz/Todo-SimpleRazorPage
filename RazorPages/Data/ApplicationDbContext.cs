using Microsoft.EntityFrameworkCore;

namespace RazorPages.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<ToDoItem> ToDoItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ToDoItem>().HasData(

                new ToDoItem() { Id = 1, Title = "Eat", IsDone = true },
                new ToDoItem() { Id = 2, Title = "Pray", IsDone = false },
                new ToDoItem() { Id = 3, Title = "Love", IsDone = true },
                new ToDoItem() { Id = 4, Title = "Run", IsDone = false }
                );
        }
    }
}
