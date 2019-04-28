using System;
using System.Collections.Generic;
using System.Text;

namespace GQL.Structure
{
    /// <summary>
    /// 值表达式
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IValueExpression : IExpression
    {
        /// <summary>
        /// 
        /// </summary>
        object Value { get; }

        /// <summary>
        /// 值的类型
        /// </summary>
        ValueType Type { get; }

        /// <summary>
        /// 将值本身作为右值，与左值进行比较操作
        /// </summary>
        /// <param name="left"></param>
        /// <param name="predicate"></param>
        /// <returns></returns>
        bool CompareBy(object left, IValuePredicate predicate);
    }
}
