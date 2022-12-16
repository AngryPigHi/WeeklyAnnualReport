using aspnetapp.Models.EntityModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace aspnetapp.Models.ModelConfigs
{
    public class WorkPlaceReportConfig : IEntityTypeConfiguration<WorkPlaceReport>
    {
        public void Configure(EntityTypeBuilder<WorkPlaceReport> builder)
        {
            builder.ToTable("T_WorkPlaceReports");
            builder.HasKey(x => x.Id);
        }
    }
}
