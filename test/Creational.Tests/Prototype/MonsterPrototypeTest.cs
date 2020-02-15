namespace DesignPatterns.Creational.Tests.Prototype
{
    using DesignPatterns.Creational.Prototype;
    using Xunit;

    [Collection("Creational.Tests")]
    public class MonsterPrototypeTest
    {
        [Fact]
        public void ShouldCreateAnotherFlyingMonster()
        {
            FlyingMonsterPrototype instance = new FlyingMonsterPrototype();
            var copyInstance = instance.Clone();
            Assert.Equal(instance.CanFly, copyInstance.CanFly);
            Assert.Equal(instance.CanSwim, copyInstance.CanSwim);
            Assert.Equal(instance.HasMagic, copyInstance.HasMagic);
        }

        [Fact]
        public void ShouldCreateAnotherMagicMonsterWhichAreNotTheSame()
        {
            MagicMonsterPrototype instance = new MagicMonsterPrototype();
            var copyInstance = instance.Clone();
            Assert.IsType(instance.GetType(), copyInstance);
            Assert.NotSame(instance, copyInstance);
        }
    }
}
