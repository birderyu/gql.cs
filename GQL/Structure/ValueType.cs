using System;
using System.Collections.Generic;
using System.Text;

namespace GQL.Structure
{
    public enum ValueType
    {
        /// <summary>
        /// 空类型
        /// </summary>
        Null,

        /// <summary>
        /// 布尔型
        /// </summary>
        Boolean,

        /// <summary>
        /// 32位整型
        /// </summary>
        Int32,

        /// <summary>
        /// 64位整型
        /// </summary>
        Int64,

        /// <summary>
        /// 浮点型
        /// </summary>
        Double,

        /// <summary>
        /// 字符串型
        /// </summary>
        String,

        /// <summary>
        /// 字节数组型
        /// </summary>
        Bytes,

        /// <summary>
        /// 日期类型
        /// </summary>
        Date,

        /// <summary>
        /// 时间戳类型
        /// </summary>
        Timestamp,

        /// <summary>
        /// 几何区域类型
        /// </summary>
        Geometry,

        /// <summary>
        /// 列表类型
        /// </summary>
        List,

        /// <summary>
        /// 键类型
        /// </summary>
        Key,

        /// <summary>
        /// 占位符类型
        /// </summary>
        Placeholder,
    }
}
