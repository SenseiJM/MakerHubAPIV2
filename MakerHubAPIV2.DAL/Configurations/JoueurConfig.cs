using MakerHubAPIV2.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MakerHubAPIV2.DAL.Configurations {
    public class JoueurConfig : IEntityTypeConfiguration<Joueur> {

        public void Configure(EntityTypeBuilder<Joueur> builder) {
            builder.ToTable("Joueur");

            builder.HasKey(j => j.Id);

            builder.Property(j => j.Id).ValueGeneratedOnAdd();
            builder.Property(j => j.Nom).IsRequired();
            builder.Property(j => j.Prenom).IsRequired();
        }

    }
}
