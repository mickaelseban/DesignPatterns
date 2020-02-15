namespace DesignPatterns.Behavioral.ChainOfResponsibility.Handlers.Implementations
{
    public class CeoHandler : AbstractHandler
    {
        protected override string _roleName => "Ceo";

        public override Response Handle(MobileType request)
        {
            if (this.CanHandle(request))
            {
                return new Response(this._roleName, request);
            }
            else
            {
                return Handle(request);
            }
        }

        protected override bool CanHandle(MobileType mobileType)
        {
            return mobileType == MobileType.Samsung;
        }
    }
}
