using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternMatching
{
    public static class ComparePerformance
    {
        public static string OldwayClassification(object obj)
        {
            if (obj == null) return "null değer";

            if(obj is string str)
            {
                if (str.Length > 10) return "uzun string";
                if (str.Length <3 ) return "kısa string";
                return "normal uzunlukta string";
            }

            if (obj is int i)
            {
                if (i > 100) return "Büyük sayı";
                if (i < 0) return "Negatif sayı";
                return "0 ile 100 arası pozitif sayı";
            }

            return "Bilinmeyen veri tipi";
        }

        public static string PatternMatchingClassification(object obj)
        {
            return obj switch
            {
                null => "null değer",
                string s when s.Length > 10 => "uzun string",
                string s when s.Length < 3 => "kısa string",
                string s => "normal uzunlukta string",
                int i when i>100 => "büyük string",
                int i when i<0 =>"negatif sayı",
                int => "0 ile 100 arasında pozitif sayı",
                _ => "Bilinmeyen veri tipi"

            }; 
        }
    }
}
