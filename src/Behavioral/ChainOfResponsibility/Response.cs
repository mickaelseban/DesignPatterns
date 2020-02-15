namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    public class Response
    {
        public Response(string roleName, MobileType assignedMobile)
        {
            this.RoleName = roleName;
            this.AssignedMobile = assignedMobile;
        }

        public MobileType AssignedMobile { get; private set; }
        public string RoleName { get; private set; }
    }
}
