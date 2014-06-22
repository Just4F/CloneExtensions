﻿using System;
using System.Linq.Expressions;

namespace CloneExtensions.ExpressionFactories
{
    class PrimitiveTypeExpressionFactory<T> : ExpressionFactoryBase<T>
    {
        public PrimitiveTypeExpressionFactory(ParameterExpression source, Expression target, ParameterExpression flags, ParameterExpression initializers)
            : base(source, target, flags, initializers)
        {
        }

        public override bool IsDeepCloneDifferentThanShallow
        {
            get
            {
                return false;
            }
        }

        public override bool AddNullCheck
        {
            get
            {
                return false;
            }
        }

        public override Expression GetDeepCloneExpression()
        {
            return Expression.Assign(Target, Source);
        }

        public override Expression GetShallowCloneExpression()
        {
            throw new InvalidOperationException();
        }
    }
}
