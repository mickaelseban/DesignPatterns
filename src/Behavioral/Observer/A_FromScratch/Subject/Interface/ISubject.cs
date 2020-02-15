namespace DesignPatterns.Behavioral.Observer.A_FromScratch.Subject.Interface
{
    using DesignPatterns.Behavioral.Observer.A_FromScratch.CustomObserver.Interface;

    /*
        Defines a 1:MANY dependency between objects so that when one object changes state
        all of the dependents are notified and updated automatically
   */

    public interface ISubject
    {
        void NotifyObservers(GameResult result);

        void RegisterObserver(ICustomObserver customObserver);

        void UnregisterObserver(ICustomObserver customObserver);
    }
}
