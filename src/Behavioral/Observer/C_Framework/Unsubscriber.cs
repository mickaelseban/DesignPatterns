namespace DesignPatterns.Behavioral.Observer.C_Framework
{
    using System;
    using System.Collections.Generic;

    internal class Unsubscriber<BaggageInfo> : IDisposable
    {
        private IObserver<BaggageInfo> _observer;
        private List<IObserver<BaggageInfo>> _observers;

        internal Unsubscriber(List<IObserver<BaggageInfo>> observers, IObserver<BaggageInfo> observer)
        {
            this._observers = observers;
            this._observer = observer;
        }

        public void Dispose()
        {
            if (_observers.Contains(_observer))
                _observers.Remove(_observer);
        }
    }
}
