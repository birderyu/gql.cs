using System;
using System.Collections.Generic;
using System.Text;

namespace GQL.Structure
{
    class BooleanExpression : ValueExpression, IBooleanExpression
    {
        /// <summary>
        /// 
        /// </summary>
        public static readonly IBooleanExpression True = new BooleanExpression(true);

        /// <summary>
        /// 
        /// </summary>
        public static readonly IBooleanExpression False = new BooleanExpression(false);

        private BooleanExpression(bool value) : base(value)
        {

        }

        public new bool Value => (bool)base.Value;

        public override ValueType Type => ValueType.Boolean;

        public override int PlaceholderCount => 0;

        public IPredicateExpression Predicate
        {
            get
            {
                if (Value)
                {
                    return InvariableStringExpression.ALWAYS_TRUE;
                }
                else
                {
                    return InvariableStringExpression.ALWAYS_FALSE;
                }
            }
        }

        public override bool CheckBy(IValuePredicate predicate, ref string message)
        {
            if (predicate.Type == ValuePredicateType.EQ
                || predicate.Type == ValuePredicateType.NEQ)
            {
                return true;
            }
            message = "布尔值只能和等于、不等于相匹配";
            return false;
        }

        public override string ToString()
        {
            return Value ? "true" : "false";
        }

        protected override int Hashing()
        {
            return Value ? 1 : 2;
        }

        protected override bool EqualsBy(object left)
        {
            if (left is IBooleanExpression)
            {
                return ((IBooleanExpression)left).Value == Value;
            }
            else if (left is bool)
            {
                return (bool)left == Value;
            }
            else if (left is string)
            {
                string sv = (string)left;
                if ("true".Equals(sv))
                {
                    return Value;
                }
                else if ("false".Equals(sv))
                {
                    return !Value;
                }
            }
            return false;
        }

        protected override bool UnequalsBy(object left)
        {
            if (left is IBooleanExpression)
            {
                return ((IBooleanExpression)left).Value != Value;
            }
            else if (left is bool)
            {
                return (bool)left != Value;
            }
            else if (left is string)
            {
                string sv = (string)left;
                if ("true".Equals(sv))
                {
                    return !Value;
                }
                else if ("false".Equals(sv))
                {
                    return Value;
                }
            }
            return false;
        }
    }
}
