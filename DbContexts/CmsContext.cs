using efCode.Models;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace efCode.DbContexts
{
    public class CmsContext : DbContext
    {
        public DbSet<Schedule> Schedules { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "server=192.168.7.27;port=3306;username=root;password=123456;database=cms;sslmode=none";
            optionsBuilder.UseMySQL(connectionString);
        }
    }
}