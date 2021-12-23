using MakerHubAPIV2.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MakerHubAPIV2.DAL.Configurations {
    public class AnnonceConfig : IEntityTypeConfiguration<Annonce> {
        public void Configure(EntityTypeBuilder<Annonce> builder) {
            builder.ToTable("Annonce");

            builder.HasKey(a => a.Id);

            builder.Property(a => a.Id).ValueGeneratedOnAdd();
            builder.Property(a => a.Titre).IsRequired().HasMaxLength(255);
            builder.Property(a => a.Description).HasMaxLength(1500).IsRequired();
        }
    }
}
