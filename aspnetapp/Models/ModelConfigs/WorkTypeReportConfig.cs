using aspnetapp.Models.EntityModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace aspnetapp.Models.ModelConfigs
{
    public class WorkTypeReportConfig : IEntityTypeConfiguration<WorkTypeReport>
    {
        public void Configure(EntityTypeBuilder<WorkTypeReport> builder)
        {
            builder.ToTable("T_WorkTypeReports");
            builder.HasKey(x => x.Id);
        }
    }
}
