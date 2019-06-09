using System;
namespace GQL.Structure
{
    class GreaterEqualThanPredicate : ValuePredicate
    {
        public static readonly IValuePredicate Instance = new GreaterEqualThanPredicate();

        public override ValuePredicateType Type => ValuePredicateType.GTE;

        public override IValuePredicate Inverse => LessThanPredicate.Instance;

        public override string Name => "大于等于";

        public override string Symbol => ">=";

        public override string Prefix => null;

        public override string Suffix => null;
    }
}
