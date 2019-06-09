namespace GQL.Structure
{
    /// <summary>
    /// 不等于
    /// </summary>
    class UnequalPredicate : ValuePredicate
    {
        public static readonly IValuePredicate Instance = new UnequalPredicate();

        private UnequalPredicate()
        {

        }

        public override ValuePredicateType Type => ValuePredicateType.EQ;

        public override string Name => "不等于";

        public override IValuePredicate Inverse => EqualPredicate.Instance;

        public override string Symbol => "!=";

        public override string Prefix => null;

        public override string Suffix => null;
    }
}
