namespace DesignPatterns.Behavioral.Tests.Observer
{
    using DesignPatterns.Behavioral.Observer.A_FromScratch;
    using DesignPatterns.Behavioral.Observer.A_FromScratch.CustomObserver;
    using DesignPatterns.Behavioral.Observer.A_FromScratch.CustomObserver.Interface;
    using DesignPatterns.Behavioral.Observer.A_FromScratch.Subject;
    using System;
    using Xunit;

    public class ObserverTest
    {
        [Fact]
        public void Doesnt_Handle_Null_Objects_Correctly()
        {
            var subject = new SportsAggregator();
            var observer1 = new NewsPapper();
            var observer2 = new RadioStation();
            subject.RegisterObserver(observer1);
            subject.RegisterObserver(observer2);
            observer1 = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();
            var gameResult = new GameResult
            {
                GameDate = DateTime.Now,
                LosingScore = 1,
                LosingTeam = "Chicago Cubs",
                WinningScore = 5,
                WinningTeam = "Cincinnati Reds"
            };
            subject.AddGameResult(gameResult);
            subject.UnregisterObserver(observer2);
            //subject.UnregisterObserver(observer1);
            Assert.Single(subject.Observers);
        }

        [Fact]
        public void Should_Notify_Observers_Of_Game_Result()
        {
            // arrange
            var subject = new SportsAggregator();

            ICustomObserver observer1 = new NewsPapper();
            ICustomObserver observer2 = new RadioStation();

            subject.RegisterObserver(observer1);
            subject.RegisterObserver(observer2);

            var gameResult = new GameResult
            {
                GameDate = DateTime.Now,
                LosingScore = 1,
                LosingTeam = "Chicago",
                WinningScore = 5,
                WinningTeam = "Reds"
            };
            //act
            subject.AddGameResult(gameResult);

            //assert
            Assert.Single(observer1.Results);
            Assert.Single(observer2.Results);
            Assert.Same(gameResult, observer1.Results[0]);
            Assert.Same(gameResult, observer2.Results[0]);

            //act
            subject.UnregisterObserver(observer1);
            subject.UnregisterObserver(observer2);

            //assert
            Assert.Empty(subject.Observers);
        }
    }
}
