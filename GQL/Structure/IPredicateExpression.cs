using System;
using System.Collections.Generic;
using System.Text;

namespace GQL.Structure
{
    /// <summary>
    /// 谓词表达式
    /// </summary>
    public interface IPredicateExpression : IExpression
    {
        /// <summary>
        /// 
        /// </summary>
        bool AlwaysTrue { get; }

        /// <summary>
        /// 
        /// </summary>
        bool AlwaysFalse { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="getter"></param>
        /// <returns></returns>
        bool Match(Func<string, object> getter);
    }
}
