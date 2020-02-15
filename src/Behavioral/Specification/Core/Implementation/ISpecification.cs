namespace DesignPatterns.Behavioral.Specification.Core.Implementation
{
    using System;
    using System.Linq.Expressions;

    internal interface ISpecification<T>
    {
        SpecificationComposite<T> And(SpecificationComposite<T> specificationComposite);

        bool IsSatisfiedBy(T entity);

        SpecificationComposite<T> Not();

        SpecificationComposite<T> Or(SpecificationComposite<T> specificationComposite);

        Expression<Func<T, bool>> ToExpression();
    }
}
