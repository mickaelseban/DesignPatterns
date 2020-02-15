namespace DesignPatterns.Behavioral.Observer.A_FromScratch.Subject
{
    using DesignPatterns.Behavioral.Observer.A_FromScratch.CustomObserver.Interface;
    using DesignPatterns.Behavioral.Observer.A_FromScratch.Subject.Interface;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class SportsAggregator : ISubject
    {
        private readonly List<ICustomObserver> _observers = new List<ICustomObserver>();
        public IReadOnlyCollection<ICustomObserver> Observers => _observers.AsReadOnly();

        public void AddGameResult(GameResult result)
        {
            NotifyObservers(result);
        }

        public void NotifyObservers(GameResult result)
        {
            Parallel.ForEach(_observers, x => x.Update(result));
        }

        public void RegisterObserver(ICustomObserver customObserver)
        {
            _observers.Add(customObserver);
        }

        public void UnregisterObserver(ICustomObserver customObserver)
        {
            _observers.Remove(customObserver);
        }
    }
}
