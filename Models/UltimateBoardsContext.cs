using Microsoft.EntityFrameworkCore;
 
namespace UltimateBoards.Models
{
    public class UltimateBoardsContext : DbContext
    {
        public DbSet<User> Users {get;set;}
        public DbSet<Thread> Threads {get;set;}
        public DbSet<Category> Categories {get;set;}
        public DbSet<ThreadComment> ThreadComments {get;set;}
        public UltimateBoardsContext(DbContextOptions<UltimateBoardsContext> options) : base(options) { }
    }
}