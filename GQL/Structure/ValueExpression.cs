using System;

namespace GQL.Structure
{
    abstract class ValueExpression : IValueExpression
    {
        private int _hashCode = -1;

        public ValueExpression(object value)
        {
            Value = value;
        }

        public object Value { get; }

        public abstract ValueType Type { get; }

        public abstract int PlaceholderCount { get; }

        public abstract bool CheckBy(IValuePredicate predicate, ref string message);

        public bool CompareBy(object left, IValuePredicate predicate)
        {
            if (Type == ValueType.Key)
            {
                throw new ArgumentException("当前值为键值，左值无法与之作比较");
            }
            else if (Type == ValueType.Placeholder)
            {
                throw new ArgumentException("当前值为占位符，左值无法与之作比较");
            }
            else if (PlaceholderCount != 0)
            {
                throw new ArgumentException("当前值中包含了占位符，左值无法与之作比较");
            }
            else if (left == null || left is INullExpression)
            {
                // 若左值为null或空值，那么仅当右值也为空且值谓词为相等判断时，才会返回true
                // 这意味着此时的表达式为：
                // null = null
                // 这个表达式是恒为true的
                // 除此之外的所有表达式：
                // null [any-predicate] [any-value]
                // 都是恒为false的
                return Type == ValueType.Null && predicate.Type == ValuePredicateType.EQ;
            }
            else
            {
                if (Type == ValueType.Null && predicate.Type == ValuePredicateType.NEQ)
                {
                    // 左值不为null或空值，但右值为空值，且值谓词为不等判断，这意味着此时的表达式为：
                    // [no-null] != null
                    // 这个表达式是恒为true的
                    return false;
                }
                else
                {
                    switch (predicate.Type)
                    {
                        case ValuePredicateType.EQ: return EqualsBy(left);
                        case ValuePredicateType.NEQ: return UnequalsBy(left);
                        case ValuePredicateType.LT: return LessBy(left);
                        case ValuePredicateType.LTE: return LessEqualsBy(left);
                        case ValuePredicateType.GT: return GreaterBy(left);
                        case ValuePredicateType.GTE: return GreaterEqualsBy(left);
                        case ValuePredicateType.LIKE: return LikeBy(left);
                        case ValuePredicateType.IN: return InBy(left);
                        case ValuePredicateType.NIN: return UninBy(left);
                        case ValuePredicateType.INTERSECT: return IntersectBy(left);
                        case ValuePredicateType.WITHIN: return WithinBy(left);
                        default: return false;
                    }
                }
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == this)
            {
                return true;
            }
            IValueExpression value = obj as IValueExpression;
            if (value == null)
            {
                return false;
            }
            if (Type != value.Type)
            {
                return false;
            }
            if (Value == null && value.Value == null)
            {
                return true;
            }
            if (Value == value.Value)
            {
                return true;
            }
            return Value.Equals(value.Value);
        }

        public override int GetHashCode()
        {
            if (_hashCode == -1)
            {
                _hashCode = Hashing();
            }
            return _hashCode;
        }

        public override string ToString()
        {
            return Value.ToString();
        }

        protected virtual bool EqualsBy(object left)
        {
            // TODO，完善Message
            throw new ArgumentException();
        }

        protected virtual bool UnequalsBy(object left)
        {
            return false;
        }

        protected virtual bool LessBy(object left)
        {
            return false;
        }

        protected virtual bool LessEqualsBy(object left)
        {
            return false;
        }

        protected virtual bool GreaterBy(object left)
        {
            return false;
        }

        protected virtual bool GreaterEqualsBy(object left)
        {
            return false;
        }

        protected virtual bool LikeBy(object left)
        {
            return false;
        }

        protected virtual bool InBy(object left)
        {
            return false;
        }

        protected virtual bool UninBy(object left)
        {
            return false;
        }

        protected virtual bool IntersectBy(object left)
        {
            return false;
        }

        protected virtual bool WithinBy(object left)
        {
            return false;
        }

        protected virtual int Hashing()
        {
            if (Value == null)
            {
                return 0;
            }
            return Value.GetHashCode();
        }
    }
}
