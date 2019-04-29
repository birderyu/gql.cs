using System;
using System.Collections.Generic;
using System.Text;

namespace GQL.Structure
{
    class SimpleExpression : PredicateExpression, ISimpleExpression
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="predicate"></param>
        /// <param name="right"></param>
        public SimpleExpression(IValueExpression left, IValuePredicate predicate, IValueExpression right)
        {
            Left = left;
            Predicate = predicate;
            Right = right;
        }

        public IValueExpression Left { get; }

        public IValuePredicate Predicate { get; }

        public IValueExpression Right { get; }

        public override bool AlwaysTrue
        {
            get
            {
                if (Left.Type != ValueType.Key && Right.PlaceholderCount != 0)
                {
                    object left = Left.Value;
                    return Right.CompareBy(left, Predicate);
                }
                return false;
            }
        }

        public override bool AlwaysFalse
        {
            get
            {
                if (Left.Type != ValueType.Key && Right.PlaceholderCount != 0)
                {
                    object left = Left.Value;
                    return !Right.CompareBy(left, Predicate);
                }
                return false;
            }
        }

        public override int PlaceholderCount
        {
            get { return Right.PlaceholderCount; }
        }

        public override bool Match(Func<string, object> getter)
        {
            if (AlwaysTrue)
            {
                return true;
            }
            else if (AlwaysFalse)
            {
                return false;
            }

            IKeyExpression key = Left as IKeyExpression;
            if (key == null)
            {
                return false;
            }

            object left = getter(key.Value);
            return !Right.CompareBy(left, Predicate);
        }

        public override string ToString()
        {
            return $"{Left} {Predicate} {Right}";
        }
    }
}
