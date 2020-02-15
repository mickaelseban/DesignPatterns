namespace DesignPatterns.Behavioral.Tests.State
{
    using DesignPatterns.Behavioral.State;
    using DesignPatterns.Behavioral.State.Implementations;
    using Xunit;

    [Collection("Behavioral.Tests")]
    public class CharacterStateTest
    {
        private readonly Robotonic _sut;

        public CharacterStateTest()
        {
            this._sut = new Robotonic();
        }

        [Fact]
        public void State_FromSmallRobotonicToSuperRobotonicToSmallRobotonic_CorrectState()
        {
            // Act
            this._sut.GotMushroom();
            this._sut.GotFireDisk();
            this._sut.GotWings();
            this._sut.GotCoins(4800);
            this._sut.MetMonster();

            //Assert
            Assert.NotNull(this._sut);
            Assert.Equal(SmallRobotonic.GetInstance, this._sut.GetState());
            Assert.Equal(2, this._sut.GetLifeCount());
            Assert.Equal(400, this._sut.GetCoinCount());
        }

        [Fact]
        public void State_InitialState_CorrectState()
        {
            // Assert
            Assert.NotNull(this._sut);
            Assert.Equal(SmallRobotonic.GetInstance, this._sut.GetState());
            Assert.Equal(1, this._sut.GetLifeCount());
            Assert.Equal(0, this._sut.GetCoinCount());
        }
    }
}
