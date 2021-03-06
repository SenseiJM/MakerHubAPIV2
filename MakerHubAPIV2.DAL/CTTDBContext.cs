using MakerHubAPIV2.DAL.Configurations;
using MakerHubAPIV2.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace MakerHubAPIV2.DAL {
    public class CTTDBContext : DbContext {

        public DbSet<Souper> Soupers { get; set; }
        public DbSet<Joueur> Joueurs { get; set; }
        public DbSet<JoueurSouper> JoueurSoupers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer("server=SENSEI-LAPTOP\\SQLEXPRESS;database=CTTPhilippeville;integrated security=true;");
        }

        protected override void OnModelCreating(ModelBuilder mb) {
            mb.ApplyConfiguration(new SouperConfig());
            mb.ApplyConfiguration(new JoueurConfig());
            mb.ApplyConfiguration(new JoueurSouperConfig());
        }

    }
}
