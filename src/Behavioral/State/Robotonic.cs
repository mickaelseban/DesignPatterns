namespace DesignPatterns.Behavioral.State
{
    using DesignPatterns.Behavioral.State.Implementations;

    public class Robotonic
    {
        private int _coin;
        private int _life;
        private IState _state;

        public Robotonic()
        {
            this._life = 1;
            this._coin = 0;

            this._state = SmallRobotonic.GetInstance;
        }

        public void ChangeState(IState state)
        {
            this._state = state;
        }

        public void GameOver()
        {
            this._life = 0;
            this._coin = 0;
        }

        public int GetCoinCount() => this._coin;

        public int GetLifeCount() => this._life;

        public IState GetState() => this._state;

        public void GotCoins(int numberOfCoins)
        {
            this._coin += numberOfCoins;

            if (this._coin >= 5000)
            {
                this.GotLife();
                this._coin -= 5000;
            }
        }

        public void GotFireDisk()
        {
            _state.GotFireDisk(this);
        }

        public void GotLife()
        {
            this._life += 1;
        }

        public void GotMushroom()
        {
            _state.GotStar(this);
        }

        public void GotWings()
        {
            _state.GotWings(this);
        }

        public void LostLife()
        {
            this._life -= 1;

            if (this._life <= 0)
            {
                this.GameOver();
            }
        }

        public void MetMonster()
        {
            _state.MetBadGuy(this);
        }
    }
}
