namespace DesignPatterns.Behavioral.ChainOfResponsibility.Handlers.Implementations
{
    public class TeamLeaderHandler : AbstractHandler
    {
        protected override string _roleName => "TeamLeader";

        public override Response Handle(MobileType request)
        {
            if (this.CanHandle(request))
            {
                return new Response(this._roleName, request);
            }
            else
            {
                return base.Handle(request);
            }
        }

        protected override bool CanHandle(MobileType mobileType)
        {
            return false;
        }
    }
}
