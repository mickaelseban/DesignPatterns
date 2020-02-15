namespace DesignPatterns.Behavioral.State.Implementations
{
    public class SuperRobotonic : IState
    {
        private static SuperRobotonic instance = new SuperRobotonic();

        private SuperRobotonic()
        {
        }

        public static SuperRobotonic GetInstance => instance;

        public void GotFireDisk(Robotonic robotonic)
        {
            robotonic.ChangeState(FireRobotonic.GetInstance);
            robotonic.GotCoins(200);
        }

        public void GotStar(Robotonic robotonic)
        {
            robotonic.GotCoins(100);
        }

        public void GotWings(Robotonic robotonic)
        {
            robotonic.ChangeState(CapeRobotonic.GetInstance);
            robotonic.GotCoins(300);
        }

        public void MetBadGuy(Robotonic robotonic)
        {
            robotonic.ChangeState(SmallRobotonic.GetInstance);
        }
    }
}
