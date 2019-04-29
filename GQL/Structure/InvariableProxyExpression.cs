using System;
using System.Collections.Generic;
using System.Text;

namespace GQL.Structure
{
    class InvariableProxyExpression : InvariableExpression
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly IExpression _expression;

        public InvariableProxyExpression(IExpression expression, bool always) : base(always)
        {
            _expression = expression;
        }

        public override int PlaceholderCount => _expression.PlaceholderCount;

        public override string ToString()
        {
            return _expression.ToString();
        }
    }
}
