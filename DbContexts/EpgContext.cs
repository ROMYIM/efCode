using efCode.Models;
using Microsoft.EntityFrameworkCore;

namespace efCode.DbContexts
{
    public class EpgContext : DbContext
    {
        public DbSet<Epg> Epg { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "server=192.168.7.27;port=3306;username=root;password=123456;database=epg;sslmode=none";
            optionsBuilder.UseMySQL(connectionString);
        }
    }
}