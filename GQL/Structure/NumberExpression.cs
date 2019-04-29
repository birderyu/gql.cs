using System;
using System.Collections.Generic;
using System.Text;

namespace GQL.Structure
{
    internal abstract class NumberExpression : ValueExpression, INumberExpression
    {
        public NumberExpression(object value) : base(value)
        {

        }

        public override int PlaceholderCount => 0;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public override bool CheckBy(IValuePredicate predicate, ref string message)
        {
            if (predicate.Type == ValuePredicateType.EQ 
                || predicate.Type == ValuePredicateType.NEQ
                || predicate.Type == ValuePredicateType.GT
                || predicate.Type == ValuePredicateType.GTE
                || predicate.Type == ValuePredicateType.LT
                || predicate.Type == ValuePredicateType.LTE)
            {
                return true;
            }
            message = "数字值只能和等于、不等于、大于、大于等于、小于、小于等于相匹配";
            return false;
        }
    }
}
