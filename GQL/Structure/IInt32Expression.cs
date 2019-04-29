using System;
using System.Collections.Generic;
using System.Text;

namespace GQL.Structure
{
    /// <summary>
    /// 
    /// </summary>
    public interface IInt32Expression : INumberExpression
    {
        /// <summary>
        /// 
        /// </summary>
        new int Value { get; }
    }
}
