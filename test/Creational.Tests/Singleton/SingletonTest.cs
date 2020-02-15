namespace DesignPatterns.Creational.Tests.Singleton
{
    using DesignPatterns.Creational.Singleton;
    using Xunit;

    [Collection("Creational.Tests")]
    public class SingletonTest
    {
        [Fact]
        public void ShouldReturnSameInstance()
        {
            var instance1 = SingletonClass.Instance;
            var instance2 = SingletonClass.Instance;
            Assert.Same(instance1, instance2);
        }

        [Fact]
        public void ShouldReturnSameInstanceSealed()
        {
            var instance1 = SingletonSealedClass.Instance;
            var instance2 = SingletonSealedClass.Instance;
            Assert.Same(instance1, instance2);
        }

        [Fact]
        public void ShouldReturnsSameValueAfterChangingValues()
        {
            var instance1 = SingletonClass.Instance;
            var instance2 = SingletonClass.Instance;
            instance1.SomeValue++;
            Assert.Equal(instance1.SomeValue, instance2.SomeValue);
        }

        [Fact]
        public void ShouldReturnsSameValueAfterChangingValuesSealed()
        {
            var instance1 = SingletonSealedClass.Instance;
            var instance2 = SingletonSealedClass.Instance;
            instance1.SomeValue++;
            Assert.Equal(instance1, instance2);
        }
    }
}
