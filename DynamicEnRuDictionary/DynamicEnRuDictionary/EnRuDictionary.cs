using System.Collections;

namespace DynamicEnRuDictionary
{
    /// <summary> En-Ru dictionary. </summary>
    internal class EnRuDictionary
    {
        public static IEnumerable Dictionary()
        {
            yield return new { Key = "one", Value = "один" };
            yield return new { Key = "two", Value = "два" };
            yield return new { Key = "thrre", Value = "три" };
            yield return new { Key = "four", Value = "четыри" };
            yield return new { Key = "five", Value = "пять" };
            yield return new { Key = "six", Value = "шесть" };
            yield return new { Key = "seven", Value = "семь" };
            yield return new { Key = "eight", Value = "восемь" };
            yield return new { Key = "nine", Value = "девять" };
            yield return new { Key = "ten", Value = "десять" };
        }
    }
}