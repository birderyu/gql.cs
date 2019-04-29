using System;
using System.Collections.Generic;
using System.Text;

namespace GQL.Structure
{
    class InvariableStringExpression : InvariableExpression
    {
        /// <summary>
        /// 
        /// </summary>
        public static readonly IInvariableExpression ALWAYS_TRUE = new InvariableStringExpression("true", true);

        /// <summary>
        /// 
        /// </summary>
        public static readonly IInvariableExpression ALWAYS_FALSE = new InvariableStringExpression("false", false);

        /// <summary>
        /// 
        /// </summary>
        private readonly string _expression;

        public InvariableStringExpression(string expression, bool always) : base(always)
        {
            _expression = expression;
        }

        public override string ToString()
        {
            return _expression;
        }
    }
}
