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
        /// 将值本身作为右值，与左值作比较操作
        /// </summary>
        /// <param name="left"></param>
        /// <param name="predicate"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        bool CompareBy(object left, IValuePredicate predicate);

        /// <summary>
        /// 检查当前值是否能够和值谓词做匹配
        /// </summary>
        /// <param name="predicate">值谓词</param>
        /// <param name="message">若匹配失败，则返回错误信息</param>
        /// <returns>若匹配成功，则返回true，否则返回false</returns>
        bool CheckBy(IValuePredicate predicate, ref string message);
    }
}
