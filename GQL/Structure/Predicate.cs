using System;
namespace GQL.Structure
{
    abstract class Predicate : IPredicate
    {
        public abstract string Name { get; }
        public abstract string Symbol { get; }
        public abstract string Prefix { get; }
        public abstract string Suffix { get; }

        public override string ToString()
        {
            return Symbol;
        }
    }
}
