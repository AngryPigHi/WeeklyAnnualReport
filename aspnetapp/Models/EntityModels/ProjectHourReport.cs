namespace aspnetapp.Models.EntityModels
{
    public class ProjectHourReport
    {
        public Guid Id { get; set; }

        public Guid Domain { get; set; }

        public Guid UserId { get; set; }

        public int Year { get; set; }

        public string ProjectNameWithManager { get; set; }//项目名称包含项目经理

        public double WorkHours { get; set; }//本项目工时

        public double HourRate { get; set; }//项目工时占比

        public int Sort { get; set; }//工时排序，倒序，不超过三个


    }
}
