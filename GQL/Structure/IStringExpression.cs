using System;
using System.Collections.Generic;
using System.Text;

namespace GQL.Structure
{
    public interface IStringExpression : IValueExpression
    {
        new string Value { get; }
    }
}
