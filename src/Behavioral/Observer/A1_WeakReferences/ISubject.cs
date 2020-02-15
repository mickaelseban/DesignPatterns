namespace DesignPatterns.Behavioral.Observer.A1_WeakReferences
{
    using DesignPatterns.Behavioral.Observer.A_FromScratch;
    using DesignPatterns.Behavioral.Observer.A_FromScratch.CustomObserver.Interface;
    using System;

    public interface ISubject
    {
        void NotifyObservers(GameResult result);

        WeakReference<ICustomObserver> RegisterObserver(ICustomObserver customObserver);

        void UnregisterObserver(WeakReference<ICustomObserver> observer);
    }
}
