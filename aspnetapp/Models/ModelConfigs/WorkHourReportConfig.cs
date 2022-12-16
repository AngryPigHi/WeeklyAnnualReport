using aspnetapp.Models.EntityModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace aspnetapp.Models.ModelConfigs
{
    public class WorkHourReportConfig : IEntityTypeConfiguration<WorkHourReport>
    {
        public void Configure(EntityTypeBuilder<WorkHourReport> builder)
        {
            builder.ToTable("T_WorkHourReports");
            builder.HasKey(x => x.Id);
        }
    }
}
