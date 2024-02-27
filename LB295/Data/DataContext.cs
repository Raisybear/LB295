using LB295.Models;
using Microsoft.EntityFrameworkCore;

namespace LB295.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {


        }

        public DbSet<Buch> Bücher { get; set; }

        public DbSet<Tag> Tags { get; set; }
        public object Buch { get; internal set; }
    }
}
