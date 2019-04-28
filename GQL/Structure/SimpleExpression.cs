using System;
using System.Collections.Generic;
using System.Text;

namespace GQL.Structure
{
    class SimpleExpression : ISimpleExpression
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

        public IValueExpression Left { get; protected set; }

        public IValuePredicate Predicate { get; protected set; }

        public IValueExpression Right { get; protected set; }

        public bool AlwaysTrue
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

        public bool AlwaysFalse
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

        public int PlaceholderCount
        {
            get { return Right.PlaceholderCount; }
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
