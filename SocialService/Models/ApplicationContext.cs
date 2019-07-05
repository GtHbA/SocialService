using System.Data.Entity;

namespace SocialService.Models
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext() : base("DefaultConnection")
        {
        }

        public DbSet<Friend> Friends { get; set; }
    }
}