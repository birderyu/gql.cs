using System;
using System.Collections.Generic;
using System.Text;

namespace GQL.Structure
{
    abstract class InvariableExpression : PredicateExpression, IInvariableExpression
    {
        private readonly bool _always;

        public InvariableExpression(bool always)
        {
            _always = always;
        }

        public override bool AlwaysTrue => _always;

        public override bool AlwaysFalse => !_always;

        public override int PlaceholderCount => 0;

        public override bool Match(Func<string, object> getter)
        {
            return _always;
        }
    }
}
