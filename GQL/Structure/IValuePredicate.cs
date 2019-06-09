using System;
using System.Collections.Generic;
using System.Text;

namespace GQL.Structure
{
    /// <summary>
    /// 值谓词
    /// </summary>
    public interface IValuePredicate : IPredicate
    {
        /// <summary>
        /// 类型
        /// </summary>
        ValuePredicateType Type { get; }

        /// <summary>
        /// 获取当前值谓词的逆运算谓词，若无则返回null
        /// </summary>
        /// <value>The inverse.</value>
        IValuePredicate Inverse { get; }
    }
}
