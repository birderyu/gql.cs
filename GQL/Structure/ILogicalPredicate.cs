namespace GQL.Structure
{
    /// <summary>
    /// 逻辑谓词
    /// </summary>
    public interface ILogicalPredicate : IPredicate
    {
        /// <summary>
        /// 逻辑谓词类型
        /// </summary>
        /// <value>The type.</value>
        LogicalPredicateType Type { get; }

        /// <summary>
        /// 判断是否对左侧的逻辑运算结果短路
        /// </summary>
        /// <returns><c>true</c>, if for was shorted, <c>false</c> otherwise.</returns>
        /// <param name="left">逻辑谓词左侧的逻辑运算结果</param>
        bool ShortFor(bool left);
    }
}
