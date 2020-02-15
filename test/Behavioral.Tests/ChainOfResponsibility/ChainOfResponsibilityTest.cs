namespace DesignPatterns.Behavioral.Tests.ChainOfResponsibility
{
    using DesignPatterns.Behavioral.ChainOfResponsibility;
    using DesignPatterns.Behavioral.ChainOfResponsibility.Handlers;
    using DesignPatterns.Behavioral.ChainOfResponsibility.Handlers.Implementations;
    using Xunit;

    [Collection("Behavioral.Tests")]
    public class ChainOfResponsibilityTest
    {
        private IHandler _chain;

        public ChainOfResponsibilityTest()
        {
            this.SetupChainOfResponsibility();
        }

        [Theory]
        [ClassData(typeof(ChainOfResponsibilityTestData))]
        public void Handle_WithMobileType_ShouldReturnsRoleNameAndAssignedMobile(Response expected, MobileType parameter)
        {
            // Act
            var actual = this._chain.Handle(parameter);

            // Assert
            Assert.NotNull(actual);
            Assert.Equal(expected.RoleName, actual.RoleName);
            Assert.Equal(expected.AssignedMobile, actual.AssignedMobile);
        }

        private void SetupChainOfResponsibility()
        {
            var teamLeader = new TeamLeaderHandler();
            var manager = new ManagerHandler();
            var director = new DirectorHandler();
            var ceo = new CeoHandler();

            teamLeader
                .SetNext(manager)
                .SetNext(director)
                .SetNext(ceo);

            this._chain = teamLeader;
        }

        private class ChainOfResponsibilityTestData : TheoryDataInput<Response, MobileType>
        {
            public ChainOfResponsibilityTestData()
            {
                base.Add(new Response("Director", MobileType.Iphone), MobileType.Iphone);
                base.Add(new Response("Ceo", MobileType.Samsung), MobileType.Samsung);
                base.Add(new Response("Manager", MobileType.Xiaomi), MobileType.Xiaomi);
            }
        }
    }
}
