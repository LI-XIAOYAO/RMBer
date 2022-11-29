using System;
using System.Text.RegularExpressions;

namespace RMBer
{
    /// <summary>
    /// RMB
    /// </summary>
    public static class RMBer
    {
        private const string STRING = "#L#E#D#C#K#E#D#C#J#E#D#C#I#E#D#C#H#E#D#C#G#E#D#C#F#E#D#C#.0B0A";

        /// <summary>
        /// 全局默认输出方式
        /// </summary>
        public static Formatter Formatter { get; private set; } = new Formatter();

        /// <summary>
        /// 默认配置
        /// </summary>
        /// <param name="formatterOptions"></param>
        public static void Config(Action<Formatter> formatterOptions)
        {
            formatterOptions?.Invoke(Formatter);
        }

        /// <summary>
        /// 转换成大写人民币金额
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static string ToCapitalRMB(this decimal number)
        {
            return number.ToCapitalRMB(null);
        }

        /// <summary>
        /// 转换成大写人民币金额
        /// </summary>
        /// <param name="number"></param>
        /// <param name="formatter"></param>
        /// <returns></returns>
        public static string ToCapitalRMB(this decimal number, Formatter formatter)
        {
            return number.ToString(STRING).GenerateCapitalRMB(formatter);
        }

        /// <summary>
        /// 转换成大写人民币金额
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static string ToCapitalRMB(this double number)
        {
            return number.ToCapitalRMB(null);
        }

        /// <summary>
        /// 转换成大写人民币金额
        /// </summary>
        /// <param name="number"></param>
        /// <param name="formatter"></param>
        /// <returns></returns>
        public static string ToCapitalRMB(this double number, Formatter formatter)
        {
            return number.ToString(STRING).GenerateCapitalRMB(formatter);
        }

        /// <summary>
        /// 转换成大写人民币金额
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static string ToCapitalRMB(this int number)
        {
            return number.ToCapitalRMB(null);
        }

        /// <summary>
        /// 转换成大写人民币金额
        /// </summary>
        /// <param name="number"></param>
        /// <param name="formatter"></param>
        /// <returns></returns>
        public static string ToCapitalRMB(this int number, Formatter formatter)
        {
            return number.ToString(STRING).GenerateCapitalRMB(formatter);
        }

        /// <summary>
        /// 转换成大写人民币金额
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static string ToCapitalRMB(this long number)
        {
            return number.ToCapitalRMB(null);
        }

        /// <summary>
        /// 转换成大写人民币金额
        /// </summary>
        /// <param name="number"></param>
        /// <param name="formatter"></param>
        /// <returns></returns>
        public static string ToCapitalRMB(this long number, Formatter formatter)
        {
            return number.ToString(STRING).GenerateCapitalRMB(formatter);
        }

        /// <summary>
        /// 转换成大写人民币金额
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static string ToCapitalRMB(this string number)
        {
            return number.ToCapitalRMB(null);
        }

        /// <summary>
        /// 转换成大写人民币金额
        /// </summary>
        /// <param name="number"></param>
        /// <param name="formatter"></param>
        /// <returns></returns>
        public static string ToCapitalRMB(this string number, Formatter formatter)
        {
            return decimal.TryParse(number, out decimal val) ? val.ToString(STRING).GenerateCapitalRMB(formatter) : "转换失败，输入有误！";
        }

        /// <summary>
        /// GenerateCapitalRMB
        /// </summary>
        /// <param name="str"></param>
        /// <param name="formatter"></param>
        /// <returns></returns>
        private static string GenerateCapitalRMB(this string str, Formatter formatter = null)
        {
            var s = Regex.Replace(str, @"(((?<=-)|(?!-)^)[^1-9]*)|((?'z'0)[0A-E]*((?=[1-9])|(?'-z'(?=[F-L\.]|$))))|((?'b'[F-L])(?'z'0)[0A-L]*((?=[1-9])|(?'-z'(?=[\.]|$))))", "${b}${z}");
            var result = Regex.Replace(s, ".", c => "负元空零壹贰叁肆伍陆柒捌玖空空空空空空空分角拾佰仟万亿兆京垓秭穰"[c.Value[0] - '-'].ToString());

            if (string.IsNullOrEmpty(s))
            {
                result = "零元";
            }

            // Format
            formatter = formatter ?? Formatter;

            result = Regex.Replace(result, "元$", $"元{formatter.Zheng}");

            if (formatter.JiaoZheng)
            {
                result = Regex.Replace(result, "角$", $"角{formatter.Zheng}");
            }

            if (Yuan.元 != formatter.Yuan)
            {
                result = Regex.Replace(result, "元", $"{formatter.Yuan}");
            }

            return result;
        }
    }
}