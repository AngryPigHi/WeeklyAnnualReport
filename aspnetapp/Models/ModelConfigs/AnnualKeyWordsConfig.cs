using aspnetapp.Models.EntityModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace aspnetapp.Models.ModelConfigs
{
    public class AnnualKeyWordsConfig : IEntityTypeConfiguration<AnnualKeyWords>
    {
        public void Configure(EntityTypeBuilder<AnnualKeyWords> builder)
        {
            builder.ToTable("T_AnnualKeyWords");
            builder.HasKey(a => a.Id);
        }
    }
}
