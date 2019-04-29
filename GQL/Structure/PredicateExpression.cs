using System;
using System.Collections.Generic;
using System.Text;

namespace GQL.Structure
{
    abstract class PredicateExpression : IPredicateExpression
    {
        public abstract bool AlwaysTrue { get; }

        public abstract bool AlwaysFalse { get; }

        public abstract int PlaceholderCount { get; }

        public abstract bool Match(Func<string, object> getter);

        public Func<Func<string, object>, bool> Function => getter => Match(getter);


        
    }
}
