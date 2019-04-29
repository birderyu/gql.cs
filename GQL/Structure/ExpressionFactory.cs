namespace GQL.Structure
{
    public class ExpressionFactory
    {
        public INullExpression BuildNull()
        {
            return NullExpression.Instance;
        }
    }
}
