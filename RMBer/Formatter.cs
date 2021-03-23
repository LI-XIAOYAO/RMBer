using RMBer.Enum;
using System;

namespace RMBer
{
    /// <summary>
    /// Formatter
    /// </summary>
    public class Formatter
    {
        /// <summary>
        /// Yuan
        /// </summary>
        public Yuan Yuan { get; set; }

        /// <summary>
        /// Zheng
        /// </summary>
        public Zheng Zheng { get; set; }

        /// <summary>
        /// 角整，默认元整
        /// </summary>
        public bool JiaoZheng { get; set; }
    }
}