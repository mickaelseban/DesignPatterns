namespace DesignPatterns.Behavioral.State.Implementations
{
    public class FireRobotonic : IState
    {
        private static FireRobotonic instance = new FireRobotonic();

        private FireRobotonic()
        {
        }

        public static FireRobotonic GetInstance => instance;

        public void GotFireDisk(Robotonic robotonic)
        {
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
