using System;
using System.Collections.Generic;
using System.Text;

namespace GQL.Structure
{
    public interface INegativeExpression : IPredicateExpression
    {
        IPredicateExpression Positive { get; }
    }
}
