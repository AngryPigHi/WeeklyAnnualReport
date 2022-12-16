namespace aspnetapp.Models.EntityModels
{
    public class WorkHourReport
    {
        public Guid Id { get; set; }

        public Guid Domain { get; set; }

        public Guid UserId { get; set; }

        public int Year { get; set; }

        public int ReportCount { get; set; }//日报总条数

        public double ReportTotalTime { get; set; }//日报总工时

        public int DaysOver8Hours { get; set; }//工时超过8小时天数

        public double AverageHours { get; set; }//平均工时（有工时的天为总天数）

        public DateTime? SpecialDayDate { get; set; }//特殊的一天

        public double SpecialDayHours { get; set; }//特殊天的工时


    }
}
