using System;
using System.Collections.Generic;
using System.Text;

namespace GQL.Structure
{
    /// <summary>
    /// 值谓词的类型
    /// </summary>
    public enum ValuePredicateType
    {
        EQ,

        NEQ,

        LT,

        LTE,

        GT,

        GTE,

        LIKE,

        IN,

        NIN,

        /// <summary>
        /// 几何相交
        /// </summary>
        INTERSECT,

        /// <summary>
        /// 几何包含
        /// </summary>
        WITHIN,
    }
}
