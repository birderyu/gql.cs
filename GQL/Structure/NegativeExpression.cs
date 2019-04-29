using System;
using System.Collections.Generic;
using System.Text;

namespace GQL.Structure
{
    class NegativeExpression : PredicateExpression, INegativeExpression
    {
        public NegativeExpression(IPredicateExpression positive)
        {
            Positive = positive;
        }

        public IPredicateExpression Positive { get; }

        public override bool AlwaysTrue => Positive.AlwaysFalse;

        public override bool AlwaysFalse => Positive.AlwaysTrue;

        public override int PlaceholderCount => Positive.PlaceholderCount;

        public override bool Match(Func<string, object> getter)
        {
            return !Positive.Match(getter);
        }

        public override string ToString()
        {
            return $"!({Positive})";
        }
    }
}
