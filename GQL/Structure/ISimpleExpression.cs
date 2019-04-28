using System;
using System.Collections.Generic;
using System.Text;

namespace GQL.Structure
{
    /// <summary>
    /// 简单谓词表达式
    /// </summary>
    public interface ISimpleExpression : IPredicateExpression
    {
        /// <summary>
        /// 左值
        /// </summary>
        IValueExpression Left { get; }

        /// <summary>
        /// 谓词
        /// </summary>
        IValuePredicate Predicate { get; }

        /// <summary>
        /// 右值
        /// </summary>
        IValueExpression Right { get; }

    }
}
