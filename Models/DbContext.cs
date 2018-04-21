using Microsoft.EntityFrameworkCore;

namespace efCode.Models
{
    public class EfContext : DbContext
    {
        public DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "server=192.168.7.27;port=3306;username=root;password=123456;database=asp.net;sslmode=none";
            optionsBuilder.UseMySQL(connectionString);
        }
    }
}