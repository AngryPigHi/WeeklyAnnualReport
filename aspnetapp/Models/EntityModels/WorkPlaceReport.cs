namespace aspnetapp.Models.EntityModels
{
    public class WorkPlaceReport
    {
        public Guid Id { get; set; }

        public Guid Domain { get; set; }

        public Guid UserId { get; set; }

        public int Year { get; set; }

        public string WorkPlace { get; set; }//工作地点

        public double WorkHours { get; set; }//工作地点对应工时

        public double HourRate { get; set; }//工时比例

        public int Sort { get; set; }//排序 不超过4

    }
}
