using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;

namespace Data.EntityConfiguration
{
    public class PollOptionConfiguration : IEntityTypeConfiguration<PollOption>
    {
        public void Configure(EntityTypeBuilder<PollOption> builder)
        {
            builder.HasKey(k => k.Id);
            builder.Property(p => p.PollId);
            builder.Property(p => p.Description);
            builder.Property(p => p.Votes);
        }
    }
}
