namespace DesignPatterns.Behavioral.Observer.C_Framework
{
    using System;
    using System.Collections.Generic;

    internal class UnSubscriber<BaggageInfo> : IDisposable
    {
        private readonly IObserver<BaggageInfo> _observer;
        private readonly List<IObserver<BaggageInfo>> _observers;

        internal UnSubscriber(List<IObserver<BaggageInfo>> observers, IObserver<BaggageInfo> observer)
        {
            this._observers = observers;
            this._observer = observer;
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            this.ReleaseUnmanagedResources();
        }

        private void ReleaseUnmanagedResources()
        {
            if (this._observers.Contains(this._observer))
            {
                this._observers.Remove(this._observer);
            }
        }
    }
}
