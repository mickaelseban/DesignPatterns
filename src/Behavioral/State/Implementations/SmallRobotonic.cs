namespace DesignPatterns.Behavioral.State.Implementations
{
    public class SmallRobotonic : IState
    {
        private static SmallRobotonic instance = new SmallRobotonic();

        private SmallRobotonic()
        {
        }

        public static SmallRobotonic GetInstance => instance;

        public void GotFireDisk(Robotonic robotonic)
        {
            robotonic.ChangeState(FireRobotonic.GetInstance);
            robotonic.GotCoins(200);
        }

        public void GotStar(Robotonic robotonic)
        {
            robotonic.ChangeState(SuperRobotonic.GetInstance);
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
            robotonic.LostLife();
        }
    }
}
