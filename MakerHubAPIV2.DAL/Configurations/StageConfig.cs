using MakerHubAPIV2.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MakerHubAPIV2.DAL.Configurations {
    public class StageConfig : IEntityTypeConfiguration<Stage> {
        public void Configure(EntityTypeBuilder<Stage> builder) {
            builder.ToTable("Stage");

            builder.HasKey(s => s.Id);

            builder.Property(s => s.Id).ValueGeneratedOnAdd();
            builder.Property(s => s.Description).HasMaxLength(1500).IsRequired();
            builder.Property(s => s.Titre).HasMaxLength(100).IsRequired();
            builder.Property(s => s.DateDebut).IsRequired();
            builder.Property(s => s.DateFin).IsRequired();
            builder.Property(s => s.HeureDebut).IsRequired().HasMaxLength(5);
            builder.Property(s => s.HeureFin).IsRequired().HasMaxLength(5);
            builder.Property(s => s.PrixAffilies).IsRequired();
            builder.Property(s => s.PrixExternes).IsRequired();
            builder.Property(s=>s.Entraineur).IsRequired().HasMaxLength(50);
            builder.Property(s => s.ClassementMaximum).IsRequired().HasMaxLength(2);
            builder.Property(s => s.ClassementMinimum).IsRequired().HasMaxLength(2);
        }
    }
}
