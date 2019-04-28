using System;
using System.Collections.Generic;
using System.Text;

namespace GQL.Structure
{
    /// <summary>
    /// 复合谓词表达式
    /// </summary>
    public interface IMultiExpression : IPredicateExpression
    {
        /// <summary>
        /// 左值
        /// </summary>
        IPredicateExpression Left { get; }

        /// <summary>
        /// 谓词
        /// </summary>
        LogicalPredicate Predicate { get; }

        /// <summary>
        /// 右值
        /// </summary>
        IPredicateExpression Right { get; }
    }
}
