namespace aspnetapp.Models.EntityModels
{
    public class WorkTypeReport
    {
        //工作类型 非周报系统中的项目

        public Guid Id { get; set; }

        public Guid Domain { get; set; }

        public Guid UserId { get; set; }

        public int Year { get; set; }

        public string PMOWorkType { get; set; }//对应PMOWorkTask字段

        public double WorkHours { get; set; }//工作地点对应工时

        public double HourRate { get; set; }//工时比例

        public int Sort { get; set; }//排序 不超过4

    }
}
