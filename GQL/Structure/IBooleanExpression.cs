namespace GQL.Structure
{
    public interface IBooleanExpression : IValueExpression
    {
        new bool Value { get; }

        /// <summary>
        /// 转化为一个恒定的谓词表达式
        /// </summary>
        /// <returns></returns>
        IPredicateExpression Predicate { get; }
    }
}
