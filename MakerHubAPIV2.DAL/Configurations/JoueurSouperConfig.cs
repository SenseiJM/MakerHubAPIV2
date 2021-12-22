using MakerHubAPIV2.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MakerHubAPIV2.DAL.Configurations {
    public class JoueurSouperConfig : IEntityTypeConfiguration<JoueurSouper> {
        public void Configure(EntityTypeBuilder<JoueurSouper> builder) {
            builder.ToTable("JoueurSouper");

            builder.HasKey(js => js.Id);

            builder.Property(js => js.Id).ValueGeneratedOnAdd();

            builder.HasOne(js => js.Souper).WithMany(s => s.JoueurSoupers).HasForeignKey(js => js.IdSouper);
            builder.HasOne(js => js.Joueur).WithMany(j => j.JoueurSoupers).HasForeignKey(js => js.IdJoueur);

            builder.Property(js => js.NbReservations).IsRequired();
        }
    }
}
