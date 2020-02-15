namespace DesignPatterns.Behavioral.State
{
    public interface IState
    {
        void GotFireDisk(Robotonic robotonic);

        void GotStar(Robotonic robotonic);

        void GotWings(Robotonic robotonic);

        void MetBadGuy(Robotonic robotonic);
    };
}
