namespace aspnetapp.Models.EntityModels
{
    public class NewYearLuckyTips
    {
        //新年幸运签

        public Guid Id { get; set; }

        public Guid Domain { get; set; }

        public Guid UserId { get; set; }

        public int Year { get; set; }

        public int NewYear { get; set; }

        public string LuckyTitle { get; set; }

        public string LuckyContent { get; set; }
    }
}
