namespace DesignPatterns.Behavioral.Specification.Core.Implementation
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;

    internal sealed class NotSpecification<T> : SpecificationComposite<T>
    {
        private readonly SpecificationComposite<T> specificationComposite;

        public NotSpecification(SpecificationComposite<T> specificationComposite)
        {
            this.specificationComposite = specificationComposite;
        }

        public override Expression<Func<T, bool>> ToExpression()
        {
            var expression = specificationComposite.ToExpression();
            var notExpression = Expression.Not(expression.Body);

            return Expression.Lambda<Func<T, bool>>(notExpression, expression.Parameters.Single());
        }
    }
}
