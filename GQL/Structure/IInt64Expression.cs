using System;
using System.Collections.Generic;
using System.Text;

namespace GQL.Structure
{
    /// <summary>
    /// 
    /// </summary>
    public interface IInt64Expression : INumberExpression
    {
        /// <summary>
        /// 
        /// </summary>
        new long Value { get; }
    }
}
