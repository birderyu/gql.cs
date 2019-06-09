using System;
namespace GQL.Structure
{
    public static class ValueTypes
    {
        public static string GetName(this ValueType type)
        {
            switch (type)
            {
                case ValueType.Null: return "空类型";
                case ValueType.Boolean: return "布尔型";
                case ValueType.Int32: return "32位整型";
                case ValueType.Int64: return "64位整型";
                case ValueType.Double: return "浮点型";
                case ValueType.String: return "字符串型";
                case ValueType.Bytes: return "字节数组型";
                case ValueType.Date: return "日期类型";
                case ValueType.Timestamp: return "时间戳类型";
                case ValueType.Geometry: return "几何区域类型";
                case ValueType.List: return "列表类型";
                case ValueType.Key: return "键类型";
                case ValueType.Placeholder: return "占位符类型";
            }
            return "未知类型";
        }
    }
}
