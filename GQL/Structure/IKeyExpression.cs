using System;
using System.Collections.Generic;
using System.Text;

namespace GQL.Structure
{
    public interface IKeyExpression : IValueExpression
    {
        new string Value { get; }
    }
}
