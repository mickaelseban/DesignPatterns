namespace DesignPatterns.Behavioral.Observer.A_FromScratch.CustomObserver.Interface
{
    using System.Collections.Generic;

    public interface ICustomObserver
    {
        List<GameResult> Results { get; set; }

        void Update(GameResult result);
    }
}
