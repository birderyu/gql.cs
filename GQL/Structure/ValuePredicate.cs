using System;
namespace GQL.Structure
{
    abstract class ValuePredicate : Predicate, IValuePredicate
    {
        /// <summary>
        /// 匹配的顺序
        /// </summary>
        /// <value>The match order.</value>
        public static IValuePredicate[] MatchOrder 
        { 
            get
            {
                return new IValuePredicate[]
                {
                    EqualPredicate.Instance,
                    UnequalPredicate.Instance,
                };
            }
        }

        public abstract ValuePredicateType Type { get; }

        public abstract IValuePredicate Inverse { get; }
    }
}
