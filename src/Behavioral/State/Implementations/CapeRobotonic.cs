namespace DesignPatterns.Behavioral.State.Implementations
{
    public class CapeRobotonic : IState
    {
        private static CapeRobotonic instance = new CapeRobotonic();

        private CapeRobotonic()
        {
        }

        public static CapeRobotonic GetInstance => instance;

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
            robotonic.GotCoins(300);
        }

        public void MetBadGuy(Robotonic robotonic)
        {
            robotonic.ChangeState(SmallRobotonic.GetInstance);
        }
    }
}
