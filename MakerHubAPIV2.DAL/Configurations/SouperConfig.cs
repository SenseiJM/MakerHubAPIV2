using MakerHubAPIV2.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MakerHubAPIV2.DAL.Configurations {
    public class SouperConfig : IEntityTypeConfiguration<Souper> {
        public void Configure(EntityTypeBuilder<Souper> builder) {
            builder.ToTable("Souper");

            builder.HasKey(s => s.Id);

            builder.Property(s => s.Id).ValueGeneratedOnAdd();
            builder.Property(s => s.Titre).IsRequired().HasMaxLength(50);
            builder.Property(s => s.Date).IsRequired();
            builder.Property(s => s.TypeSouper).IsRequired().HasConversion<string>();
            builder.Property(s => s.PrixAffilies).IsRequired();
            builder.Property(s => s.PrixExternes).IsRequired();
            builder.Property(s => s.Description).IsRequired().HasMaxLength(1500);
        }
    }
}
