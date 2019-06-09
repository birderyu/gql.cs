using System;
namespace GQL.Structure
{
    class LessThanPredicate : ValuePredicate
    {
        public static readonly IValuePredicate Instance = new LessThanPredicate();

        public override ValuePredicateType Type => ValuePredicateType.LT;

        public override IValuePredicate Inverse => GreaterEqualThanPredicate.Instance;

        public override string Name => "小于";

        public override string Symbol => "<";

        public override string Prefix => null;

        public override string Suffix => null;
    }
}
