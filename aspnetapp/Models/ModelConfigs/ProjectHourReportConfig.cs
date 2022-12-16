using aspnetapp.Models.EntityModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace aspnetapp.Models.ModelConfigs
{
    public class ProjectHourReportConfig : IEntityTypeConfiguration<ProjectHourReport>
    {
        public void Configure(EntityTypeBuilder<ProjectHourReport> builder)
        {
            builder.ToTable("T_ProjectHourReports");
            builder.HasKey(x => x.Id);
        }
    }
}
