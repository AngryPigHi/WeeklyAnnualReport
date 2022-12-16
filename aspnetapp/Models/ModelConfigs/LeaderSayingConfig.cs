using aspnetapp.Models.EntityModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace aspnetapp.Models.ModelConfigs
{
    public class LeaderSayingConfig : IEntityTypeConfiguration<LeaderSaying>
    {
        public void Configure(EntityTypeBuilder<LeaderSaying> builder)
        {
            builder.ToTable("T_LeaderSayings");
            builder.HasKey(l=>l.Id);
        }
    }
}
