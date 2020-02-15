namespace DesignPatterns.Behavioral.Tests.Observer
{
    using DesignPatterns.Behavioral.Observer.A_FromScratch;
    using DesignPatterns.Behavioral.Observer.A_FromScratch.CustomObserver;
    using DesignPatterns.Behavioral.Observer.A_FromScratch.CustomObserver.Interface;
    using DesignPatterns.Behavioral.Observer.A1_WeakReferences;
    using System;
    using Xunit;

    [Collection("Behavioral.Tests")]
    public class ObserverWeakRefTest
    {
        [Fact]
        public void Doesnt_Handle_Null_Objects_Correctly_WeakRef()
        {
            var subject = new SportsAggregator();
            var observer1 = new NewsPapper();
            var observer2 = new RadioStation();
            var wr1 = subject.RegisterObserver(observer1);
            var wr2 = subject.RegisterObserver(observer2);
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
            subject.UnregisterObserver(wr2);
            subject.UnregisterObserver(wr1);
            Assert.Empty(subject.Observers);
        }

        [Fact]
        public void Should_Notify_Observers_Of_Game_Result_WeakRef()
        {
            // arrange
            var subject = new SportsAggregator();
            ICustomObserver observer1 = new NewsPapper();
            ICustomObserver observer2 = new RadioStation();
            var wr1 = subject.RegisterObserver(observer1);
            var wr2 = subject.RegisterObserver(observer2);

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
            subject.UnregisterObserver(wr1);
            subject.UnregisterObserver(wr2);
            //assert
            Assert.Empty(subject.Observers);
        }
    }
}
