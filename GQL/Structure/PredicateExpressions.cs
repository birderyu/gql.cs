using System;
using System.Collections.Generic;

namespace GQL.Structure
{
    public static class PredicateExpressions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="expression"></param>
        /// <param name="map"></param>
        /// <returns></returns>
        public static bool Match(this IPredicateExpression expression, IDictionary<string, object> map)
        {
            return expression.Match(key => 
            {
                if (!map.TryGetValue(key, out object value))
                {
                    return null;
                }
                return value;
            });
        }

        public static Func<Func<string, object>, bool> ToFunction(this IPredicateExpression expression)
        {
            return getter => expression.Match(getter);
        }
    }
}
