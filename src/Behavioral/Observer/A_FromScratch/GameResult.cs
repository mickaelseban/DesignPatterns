namespace DesignPatterns.Behavioral.Observer.A_FromScratch
{
    using System;

    public class GameResult
    {
        public DateTime GameDate { get; set; }
        public int LosingScore { get; set; }
        public string LosingTeam { get; set; }
        public int WinningScore { get; set; }
        public string WinningTeam { get; set; }
    }
}
