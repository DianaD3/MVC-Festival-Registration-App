using Festivals.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
namespace Festivals.DAL
{
    public class FestivalContext : DbContext
    {
        public FestivalContext()
            : base("FestivalContext")
        {
        }
        public DbSet<Artist> Artist { get; set; }
        public DbSet<Desfasurator> Desfasurator { get; set; }
        public DbSet<Festival> Festival { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

        }
    }
}