using aspnetapp.Models.EntityModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace aspnetapp.Models.ModelConfigs
{
    public class NewYearLuckyTipsConfig : IEntityTypeConfiguration<NewYearLuckyTips>
    {
        public void Configure(EntityTypeBuilder<NewYearLuckyTips> builder)
        {
            builder.ToTable("T_NewYearLuckyTips");
            builder.HasKey(x => x.Id);
        }
    }
}
