using System;

namespace GQL.Structure
{
    /// <summary>
    /// 表达式接口
    /// </summary>
    public interface IExpression
    {
        /// <summary>
        /// 表达式中占位符的数量
        /// </summary>
        int PlaceholderCount { get; }
    }
}
