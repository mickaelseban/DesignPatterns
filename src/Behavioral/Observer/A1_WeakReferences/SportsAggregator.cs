namespace DesignPatterns.Behavioral.Observer.A1_WeakReferences
{
    using DesignPatterns.Behavioral.Observer.A_FromScratch;
    using DesignPatterns.Behavioral.Observer.A_FromScratch.CustomObserver.Interface;
    using System;
    using System.Collections.Generic;

    public class SportsAggregator : ISubject
    {
        private readonly List<WeakReference<ICustomObserver>> _observers = new List<WeakReference<ICustomObserver>>();
        public IReadOnlyList<WeakReference<ICustomObserver>> Observers => this._observers.AsReadOnly();

        public void AddGameResult(GameResult result)
        {
            NotifyObservers(result);
        }

        public void NotifyObservers(GameResult result)
        {
            foreach (var item in _observers.ToArray())
            {
                item.TryGetTarget(out ICustomObserver obs);
                if (obs == null)
                    UnregisterObserver(item);
                else
                    obs.Update(result);
            }
        }

        public WeakReference<ICustomObserver> RegisterObserver(ICustomObserver customObserver)
        {
            var weakCustomObserver = new WeakReference<ICustomObserver>(customObserver);
            _observers.Add(weakCustomObserver);
            return weakCustomObserver;
        }

        public void UnregisterObserver(WeakReference<ICustomObserver> observer)
        {
            _observers.Remove(observer);
        }
    }
}
