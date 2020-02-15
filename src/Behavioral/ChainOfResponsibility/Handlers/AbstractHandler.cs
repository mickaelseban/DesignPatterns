namespace DesignPatterns.Behavioral.ChainOfResponsibility.Handlers
{
    public abstract class AbstractHandler : IHandler
    {
        private IHandler _nextHandler;
        protected abstract string _roleName { get; }

        public virtual Response Handle(MobileType request)
        {
            if (this._nextHandler != null)
            {
                return this._nextHandler.Handle(request);
            }
            else
            {
                return null;
            }
        }

        public IHandler SetNext(IHandler handler)
        {
            this._nextHandler = handler;
            return handler;
        }

        protected abstract bool CanHandle(MobileType mobileType);
    }
}
