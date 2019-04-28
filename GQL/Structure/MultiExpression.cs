using System;
using System.Collections.Generic;
using System.Text;

namespace GQL.Structure
{
    class MultiExpression : IMultiExpression
    {
        public MultiExpression(IPredicateExpression left, LogicalPredicate predicate, IPredicateExpression right)
        {
            Left = left;
            Predicate = predicate;
            Right = right;
        }

        public IPredicateExpression Left { get; protected set; }

        public LogicalPredicate Predicate { get; protected set; }

        public IPredicateExpression Right { get; protected set; }

        public bool AlwaysTrue
        {
            get
            {
                bool left = Left.AlwaysTrue;
                if (Predicate.ShortFor(left))
                {
                    // 对左侧的谓词结果短路
                    return left;
                }
                bool right = Right.AlwaysTrue;
                if (Predicate.IsAnd())
                {
                    return left && right;
                }
                else if (Predicate.IsOr())
                {
                    return left || right;
                }
                else if(Predicate.IsXor())
                {
                    return (left && right) || (Left.AlwaysFalse && Right.AlwaysFalse);
                }
                return false;
            }
        }

        public bool AlwaysFalse
        {
            get
            {
                bool left = Left.AlwaysFalse;
                if (Predicate.ShortFor(!left))
                {
                    // 对左侧的谓词结果短路
                    return left;
                }
                bool right = Right.AlwaysFalse;
                if (Predicate.IsAnd())
                {
                    return left || right;
                }
                else if (Predicate.IsOr())
                {
                    return left && right;
                }
                else if (Predicate.IsXor())
                {
                    return (left && right) || (Left.AlwaysTrue && Right.AlwaysTrue);
                }
                return false;
            }
        }

        public int PlaceholderCount
        {
            get
            {
                return Left.PlaceholderCount + Right.PlaceholderCount;
            }
        }

        public bool Match(Func<string, object> getter)
        {
            if (AlwaysTrue)
            {
                return true;
            }
            else if (AlwaysFalse)
            {
                return false;
            }

            bool left = Left.Match(getter);
            if (Predicate.ShortFor(left))
            {
                // 对左侧的谓词结果短路
                return left;
            }
            bool right = Right.Match(getter);
            if (Predicate.IsAnd())
            {
                return left && right;
            }
            else if (Predicate.IsOr())
            {
                return left || right;
            }
            else if (Predicate.IsXor())
            {
                return (left && right) || (!left && !right);
            }
            return false;
        }
    }
}
