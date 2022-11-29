using System;

namespace RMBer
{
    /// <summary>
    /// 格式化输出方式
    /// </summary>
    public class Formatter
    {
        private Yuan _yuan;
        private Zheng _zheng;

        /// <summary>
        /// 元 | 圆
        /// </summary>
        public Yuan Yuan
        {
            get => _yuan;
            set => _yuan = Enum.IsDefined(typeof(Yuan), value) ? value : throw new ArgumentOutOfRangeException();
        }

        /// <summary>
        /// 整 | 正
        /// </summary>
        public Zheng Zheng
        {
            get => _zheng;
            set => _zheng = Enum.IsDefined(typeof(Zheng), value) ? value : throw new ArgumentOutOfRangeException();
        }

        /// <summary>
        /// 角整，默认元整
        /// </summary>
        public bool JiaoZheng { get; set; }
    }
}