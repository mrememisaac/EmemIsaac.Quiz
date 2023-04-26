using EmemIsaac.QuizManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmemIsaac.QuizManager.Persistence.Configurations
{
    public class QuizConfiguration : IEntityTypeConfiguration<Quiz>
    {
        public void Configure(EntityTypeBuilder<Quiz> builder)
        {
            builder
                .Property(prop => prop.Topic)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(prop => prop.Description)
                .IsRequired()
                .HasMaxLength(250);

            builder
                .Property(prop => prop.ImageUri)
                .HasMaxLength(250);
        }
    }
}
