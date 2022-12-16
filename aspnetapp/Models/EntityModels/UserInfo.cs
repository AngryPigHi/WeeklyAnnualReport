namespace aspnetapp.Models.EntityModels
{
    public class UserInfo
    {
        //用户信息

        public int Id { get; set; }

        public Guid Domain { get; set; }

        public Guid Organization { get; set; }

        public string Account { get; set; }

        public string Password { get; set; }

        public string UserName { get; set; }

        //填写第一条日报的日期
        public DateTime? FirstReportDate { get; set; }

    }
}
