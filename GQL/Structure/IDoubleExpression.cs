using System;
using System.Collections.Generic;
using System.Text;

namespace GQL.Structure
{
    public interface IDoubleExpression : INumberExpression
    {
        /// <summary>
        /// 
        /// </summary>
        new double Value { get; }
    }
}
