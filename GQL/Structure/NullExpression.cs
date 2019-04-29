using System;
using System.Collections.Generic;
using System.Text;

namespace GQL.Structure
{
    class NullExpression : ValueExpression, INullExpression
    {
        public static readonly INullExpression Instance = new NullExpression();

        private NullExpression() : base(null)
        {

        }

        public override ValueType Type => ValueType.Null;

        public override int PlaceholderCount => 0;

        public override bool CheckBy(IValuePredicate predicate, ref string message)
        {
            if (predicate.Type == ValuePredicateType.EQ
                || predicate.Type == ValuePredicateType.NEQ)
            {
                return true;
            }
            message = "空值只能和等于、不等于相匹配";
            return false;
        }

        public override string ToString()
        {
            return "null";
        }

        protected override int Hashing()
        {
            return 0;
        }

        protected override bool EqualsBy(object left)
        {
            if (left == null || left is INullExpression)
            {
                // null = null
                return true;
            }
            return false;
        }

        protected override bool UnequalsBy(object left)
        {
            if (left != null && !(left is INullExpression))
            {
                // [no-null] != null
                return true;
            }
            return false;
        }
    }
}
