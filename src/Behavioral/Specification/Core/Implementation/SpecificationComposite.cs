namespace DesignPatterns.Behavioral.Specification.Core.Implementation
{
    using System;
    using System.Linq.Expressions;

    public abstract class SpecificationComposite<T> : ISpecification<T>
    {
        private static readonly SpecificationComposite<T> All = new IdentitySpecification<T>();

        public SpecificationComposite<T> And(SpecificationComposite<T> specificationComposite)
        {
            if (this == All)
            {
                return specificationComposite;
            }

            if (specificationComposite == All)
            {
                return this;
            }

            return new AndSpecification<T>(this, specificationComposite);
        }

        public bool IsSatisfiedBy(T entity)
        {
            Func<T, bool> predicate = ToExpression().Compile();
            return predicate(entity);
        }

        public SpecificationComposite<T> Not()
        {
            return new NotSpecification<T>(this);
        }

        public SpecificationComposite<T> Or(SpecificationComposite<T> specificationComposite)
        {
            if (this == All || specificationComposite == All)
            {
                return All;
            }

            return new OrSpecification<T>(this, specificationComposite);
        }

        public abstract Expression<Func<T, bool>> ToExpression();
    }
}
