using System;
using System.Collections.Generic;
using System.Text;

namespace GQL.Structure
{
    static class LogicalPredicates
    {
        /// <summary>
        /// 判断是否对左侧的谓词结果短路
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="left"></param>
        /// <returns></returns>
        public static bool ShortFor(this LogicalPredicate predicate, bool left)
        {
            return false;
        }

        public static bool IsAnd(this LogicalPredicate predicate)
        {
            return false;
        }

        public static bool IsOr(this LogicalPredicate predicate)
        {
            return false;
        }

        public static bool IsXor(this LogicalPredicate predicate)
        {
            return false;
        }
    }
}
