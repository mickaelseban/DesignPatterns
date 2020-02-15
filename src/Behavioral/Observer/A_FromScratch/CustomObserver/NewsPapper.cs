namespace DesignPatterns.Behavioral.Observer.A_FromScratch.CustomObserver
{
    using DesignPatterns.Behavioral.Observer.A_FromScratch.CustomObserver.Interface;
    using System.Collections.Generic;

    public class NewsPapper : ICustomObserver
    {
        public List<GameResult> Results { get; set; } = new List<GameResult>();

        public void Update(GameResult result)
        {
            Results.Add(result);
        }
    }
}
