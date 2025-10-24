using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{

    public enum CharType
    {
        LowerCase,
        UpperCase,
        Digit,
        Symbol

    }
    public static class CustomExtensions
    {
        public static int GetSquare(this int value)
        {
            return (int)Math.Pow(value, 2);
        }

        public static string ToTitleCase(this string value)
        {
            //value: türkay ürkmez -> Türkay Ürkmez
            var words = value.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].Substring(0, 1).ToUpper() + words[i].Substring(1).ToLower();
            }
            return string.Join(" ", words);
        }

        public static string NextChar(this Random random, CharType charType)
        {
            var asciiValue = 0;

            var (min, max) = charType switch
            {
                CharType.UpperCase => (65, 91),
                CharType.Digit => (48, 58),
                CharType.Symbol => (33, 48),
                _ => (97, 123)
            };
           
            asciiValue = random.Next(min, max);
            return ((char)asciiValue).ToString();
        }

        public static string NextPassword(this Random random, int length=6)
        {
            var generatedPassword = new StringBuilder(length);
            for (int i = 0; i < length; i++)
            {
                var charType = (CharType)random.Next(0, 4);
                generatedPassword.Append(random.NextChar(charType));
            }

            return generatedPassword.ToString();
        }

        public static string ToTurkish(this DayOfWeek dayOfWeek)
        {
            return dayOfWeek switch
            {
                DayOfWeek.Friday => "Cuma",
                DayOfWeek.Monday => "Pazartesi",
                DayOfWeek.Tuesday => "Salı",
                DayOfWeek.Wednesday => "Çarşamba",
                DayOfWeek.Thursday => "Perşembe",
                DayOfWeek.Saturday => "Cumartesi",
                DayOfWeek.Sunday => "Pazar"
            };
        }
    }
}
