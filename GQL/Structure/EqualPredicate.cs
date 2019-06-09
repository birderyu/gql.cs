namespace GQL.Structure
{
    /// <summary>
    /// 等于
    /// </summary>
    class EqualPredicate : ValuePredicate
    {
        public static readonly IValuePredicate Instance = new EqualPredicate();

        private EqualPredicate()
        {

        }

        public override ValuePredicateType Type => ValuePredicateType.EQ;

        public override string Name => "等于";

        public override IValuePredicate Inverse => UnequalPredicate.Instance;

        public override string Symbol => "=";

        public override string Prefix => null;

        public override string Suffix => null;
    }
}
