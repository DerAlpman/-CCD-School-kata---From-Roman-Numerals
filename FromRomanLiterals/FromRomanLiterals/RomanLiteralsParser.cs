using System;
using System.Collections.Generic;

namespace FromRomanLiterals
{
    public static class RomanLiteralsParser
    {
        private static Dictionary<string, string> Map = new Dictionary<string, string>()
        {
            {"CM", "900"},
            { "M", "1000"},
            { "XC", "90"},
            { "C", "100"},
            { "XL", "40"},
            { "L", "50"},
            { "IX", "9"},
            { "X", "10"},
            { "IV", "4"},
            { "V", "5"},
            { "I", "1"}
        };

        public static int ConvertRomanLiteralToInt(string romanLiteral)
        {
            int result = 0;

            foreach (var item in Map)
            {
                romanLiteral = romanLiteral.Replace(item.Key, item.Value + ";");
            }

            foreach (var numberString in romanLiteral.Split(';'))
            {
                if (!string.IsNullOrWhiteSpace(numberString))
                {
                    result += Convert.ToInt32(numberString);
                }
            }
            return result;
        }
    }
}
