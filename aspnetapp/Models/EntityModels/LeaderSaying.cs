namespace aspnetapp.Models.EntityModels
{
    public class LeaderSaying
    {
        public Guid Id { get; set; }

        public Guid Domain { get; set; }//事业部经理通过Domain去匹配

        public int Year { get; set; }

        public Guid LeaderId { get; set; }

        public string LeaderName { get; set; }

        public string LeaderRole { get; set; }//事业部和部门角色

        public Guid LeaderOrganizationId { get; set; }//部门经理通过OrganizationId去匹配

        public string LeaderOrganizationName { get; set; }

        public string Saying { get; set; }//寄语
    }
}
