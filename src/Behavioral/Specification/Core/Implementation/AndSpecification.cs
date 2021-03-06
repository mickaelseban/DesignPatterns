﻿namespace DesignPatterns.Behavioral.Specification.Core.Implementation
{
    using System;
    using System.Linq.Expressions;

    internal sealed class AndSpecification<T> : SpecificationComposite<T>
    {
        private readonly SpecificationComposite<T> _left;
        private readonly SpecificationComposite<T> _right;

        public AndSpecification(SpecificationComposite<T> left, SpecificationComposite<T> right)
        {
            this._right = right;
            this._left = left;
        }

        public override Expression<Func<T, bool>> ToExpression()
        {
            var leftExpression = this._left.ToExpression();
            var rightExpression = this._right.ToExpression();

            var invokedExpression = Expression.Invoke(rightExpression, leftExpression.Parameters);
            var lambdaExpression = Expression.Lambda(Expression.AndAlso(leftExpression.Body, invokedExpression),
                leftExpression.Parameters);

            return (Expression<Func<T, bool>>)lambdaExpression;
        }
    }
}
