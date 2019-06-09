using System;
using System.Collections.Generic;
using System.Text;

namespace GQL.Structure
{
    /// <summary>
    /// 谓词
    /// </summary>
    public interface IPredicate
    {
        /// <summary>
        /// 谓词的中文名称
        /// </summary>
        string Name { get; }

        /// <summary>
        /// 获取当前谓词的符号
        /// </summary>
        /// <value>The symbol.</value>
        string Symbol { get; }

        /// <summary>
        /// 获取当前谓词的前缀
        /// </summary>
        /// <value>谓词的前缀，若无则返回null</value>
        string Prefix { get; }

        /// <summary>
        /// 获取当前谓词的后缀
        /// </summary>
        /// <value>谓词的后缀，若无则返回null</value>
        string Suffix { get; }
    }
}
