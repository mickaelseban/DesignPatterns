namespace DesignPatterns.Behavioral.ChainOfResponsibility.Handlers.Implementations
{
    public class DirectorHandler : AbstractHandler
    {
        protected override string _roleName => "Director";

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
            return mobileType == MobileType.Iphone;
        }
    }
}
