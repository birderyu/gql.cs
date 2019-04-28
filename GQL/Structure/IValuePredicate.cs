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
    }
}
