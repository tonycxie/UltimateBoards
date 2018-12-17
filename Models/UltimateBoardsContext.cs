using Microsoft.EntityFrameworkCore;
 
namespace UltimateBoards.Models
{
    public class UltimateBoardsContext : DbContext
    {
        public DbSet<User> Users {get;set;}
        public UltimateBoardsContext(DbContextOptions<UltimateBoardsContext> options) : base(options) { }
    }
}