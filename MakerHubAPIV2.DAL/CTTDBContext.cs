using MakerHubAPIV2.DAL.Configurations;
using MakerHubAPIV2.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace MakerHubAPIV2.DAL {
    public class CTTDBContext : DbContext {

        public DbSet<Souper> Soupers { get; set; }
        public DbSet<Joueur> Joueurs { get; set; }
        public DbSet<JoueurSouper> JoueurSoupers { get; set; }
        public DbSet<Stage> Stages { get; set; }
        public DbSet<Annonce> Annonces { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer("server=SENSEI-LAPTOP\\SQLEXPRESS;database=CTTPhilippeville;integrated security=true;MultipleActiveResultSets=True;");
            //optionsBuilder.UseSqlServer("server=SENSEI-ALICE-V1\\TB2019;database=CTTPhilippeville;integrated security=true;MultipleActiveResultSets=True;");
        }

        protected override void OnModelCreating(ModelBuilder mb) {
            mb.ApplyConfiguration(new SouperConfig());
            mb.ApplyConfiguration(new JoueurConfig());
            mb.ApplyConfiguration(new JoueurSouperConfig());
            mb.ApplyConfiguration(new StageConfig());
            mb.ApplyConfiguration(new AnnonceConfig());
        }

    }
}
