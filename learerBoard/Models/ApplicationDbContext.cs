using Microsoft.EntityFrameworkCore; 


namespace  learerBoard.Models 
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<learerBoard> lowTimes {get; set;}
        // does this refernece a property in class learerBoard ? 

        public DbSet<Session> Sessions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // the code blow sets the path of the data base file 
            optionsBuilder.UseSqlite("Filename=./learerBoard.db"); 
        }
    }
}