namespace aspnetapp.Models.EntityModels
{
    public class AnnualKeyWords
    {
        public Guid Id { get; set; }

        public Guid Domain { get; set; }

        public Guid UserId { get; set; }

        public int Year { get; set; }

        public string KeyWord { get; set; }//关键词

        public int KeyWeight { get; set; }//权重

        public int Active { get; set; } //控制是否显示 人为限制
    }
}
