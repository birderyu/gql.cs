namespace GQL.Structure
{
    class Int32Expression : NumberExpression, IInt32Expression
    {
        public Int32Expression(int value) : base(value)
        {
            
        }

        public new int Value => (int)base.Value;

        public override ValueType Type => ValueType.Int32;

        protected override bool EqualsBy(object left)
        {
            if (left is IInt32Expression)
            {
                return ((IInt32Expression)left).Value == Value;
            }
            else if (left is IInt64Expression)
            {
                return ((IInt64Expression)left).Value == Value;
            }
            else if (left is IDoubleExpression)
            {
                return ((IDoubleExpression)left).Value == Value;
            }
            else if (left is int)
            {
                return (int)left == Value;
            }
            else if (left is long)
            {
                return (long)left == Value;
            }
            else if (left is double)
            {
                return (double)left == Value;
            }
            else if (left is string)
            {
                if (!int.TryParse((string)left, out int lv))
                {
                    return false;
                }
                return lv == Value;
            }
            else
            {
                return false;
            }
        }

        protected override bool UnequalsBy(object left)
        {
            if (left is IInt32Expression)
            {
                return ((IInt32Expression)left).Value != Value;
            }
            else if (left is IInt64Expression)
            {
                return ((IInt64Expression)left).Value != Value;
            }
            else if (left is IDoubleExpression)
            {
                return ((IDoubleExpression)left).Value != Value;
            }
            else if (left is int)
            {
                return (int)left != Value;
            }
            else if (left is long)
            {
                return (long)left != Value;
            }
            else if (left is double)
            {
                return (double)left != Value;
            }
            else if (left is string)
            {
                if (!int.TryParse((string)left, out int lv))
                {
                    return false;
                }
                return lv != Value;
            }
            else
            {
                return false;
            }
        }

        protected override bool LessBy(object left)
        {
            if (left is IInt32Expression)
            {
                return ((IInt32Expression)left).Value < Value;
            }
            else if (left is IInt64Expression)
            {
                return ((IInt64Expression)left).Value < Value;
            }
            else if (left is IDoubleExpression)
            {
                return ((IDoubleExpression)left).Value < Value;
            }
            else if (left is int)
            {
                return (int)left < Value;
            }
            else if (left is long)
            {
                return (long)left < Value;
            }
            else if (left is double)
            {
                return (double)left < Value;
            }
            else if (left is string)
            {
                if (!int.TryParse((string)left, out int lv))
                {
                    return false;
                }
                return lv < Value;
            }
            else
            {
                return false;
            }
        }

        protected override bool LessEqualsBy(object left)
        {
            if (left is IInt32Expression)
            {
                return ((IInt32Expression)left).Value <= Value;
            }
            else if (left is IInt64Expression)
            {
                return ((IInt64Expression)left).Value <= Value;
            }
            else if (left is IDoubleExpression)
            {
                return ((IDoubleExpression)left).Value <= Value;
            }
            else if (left is int)
            {
                return (int)left <= Value;
            }
            else if (left is long)
            {
                return (long)left <= Value;
            }
            else if (left is double)
            {
                return (double)left <= Value;
            }
            else if (left is string)
            {
                if (!int.TryParse((string)left, out int lv))
                {
                    return false;
                }
                return lv <= Value;
            }
            else
            {
                return false;
            }
        }

        protected override bool GreaterBy(object left)
        {
            if (left is IInt32Expression)
            {
                return ((IInt32Expression)left).Value > Value;
            }
            else if (left is IInt64Expression)
            {
                return ((IInt64Expression)left).Value > Value;
            }
            else if (left is IDoubleExpression)
            {
                return ((IDoubleExpression)left).Value > Value;
            }
            else if (left is int)
            {
                return (int)left > Value;
            }
            else if (left is long)
            {
                return (long)left > Value;
            }
            else if (left is double)
            {
                return (double)left > Value;
            }
            else if (left is string)
            {
                if (!int.TryParse((string)left, out int lv))
                {
                    return false;
                }
                return lv > Value;
            }
            else
            {
                return false;
            }
        }

        protected override bool GreaterEqualsBy(object left)
        {
            if (left is IInt32Expression)
            {
                return ((IInt32Expression)left).Value >= Value;
            }
            else if (left is IInt64Expression)
            {
                return ((IInt64Expression)left).Value >= Value;
            }
            else if (left is IDoubleExpression)
            {
                return ((IDoubleExpression)left).Value >= Value;
            }
            else if (left is int)
            {
                return (int)left >= Value;
            }
            else if (left is long)
            {
                return (long)left >= Value;
            }
            else if (left is double)
            {
                return (double)left >= Value;
            }
            else if (left is string)
            {
                if (!int.TryParse((string)left, out int lv))
                {
                    return false;
                }
                return lv >= Value;
            }
            else
            {
                return false;
            }
        }
    }
}
