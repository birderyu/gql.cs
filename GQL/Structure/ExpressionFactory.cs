namespace GQL.Structure
{
    public static class ExpressionFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public static readonly IValuePredicate EqualPredicate = Structure.EqualPredicate.Instance;

        /// <summary>
        /// 
        /// </summary>
        public static readonly IValuePredicate UnEqualPredicate = Structure.UnequalPredicate.Instance;

        public static INullExpression BuildNull()
        {
            return NullExpression.Instance;
        }
    }
}
