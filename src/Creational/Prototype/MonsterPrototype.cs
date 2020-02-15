namespace DesignPatterns.Creational.Prototype
{
    public class FlyingMonsterPrototype : MonsterPrototype
    {
        public FlyingMonsterPrototype(bool canFly = true, bool canSwim = false, bool hasMagic = false) :
            base(canFly, canSwim, hasMagic)
        { }

        public override MonsterPrototype Clone() => MemberwiseClone() as MonsterPrototype;
    }

    public class MagicMonsterPrototype : MonsterPrototype
    {
        public MagicMonsterPrototype(bool canFly = false, bool canSwim = false, bool hasMagic = true) :
            base(canFly, canSwim, hasMagic)
        { }

        public override MonsterPrototype Clone() => MemberwiseClone() as MonsterPrototype;
    }

    public abstract class MonsterPrototype
    {
        protected MonsterPrototype(bool canFly, bool canSwim, bool hasMagic)
        {
            CanFly = canFly;
            CanSwim = canSwim;
            HasMagic = hasMagic;
        }

        public bool CanFly { get; set; }
        public bool CanSwim { get; set; }
        public bool HasMagic { get; set; }

        public abstract MonsterPrototype Clone();
    }
}
