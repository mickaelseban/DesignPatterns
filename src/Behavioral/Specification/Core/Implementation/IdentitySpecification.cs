namespace DesignPatterns.Behavioral.Specification.Core.Implementation
{
    using System;
    using System.Linq.Expressions;

    internal sealed class IdentitySpecification<T> : SpecificationComposite<T>
    {
        public override Expression<Func<T, bool>> ToExpression()
        {
            return x => true;
        }
    }
}
