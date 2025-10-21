using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadAnOptional
{
    public static class Geometri
    {
        /// <summary>
        /// Belirli geometrik şeklin (Daire ya da Kare) alanını hesaplar
        /// </summary>
        /// <param name="birim1">Dairenin yarıçap uzunluğu ya da karenin kenar uzunluğu</param>
        /// <param name="sekil">Daire veya Kare</param>
        /// <returns>double cinsinden alan değeri</returns>
        /// <exception cref="ArgumentException"></exception>
      public  static double AlanHesapla(double birim1, string sekil)
        {
            switch (sekil)
            {
                case "Kare":
                    return Math.Pow(birim1, 2);
                case "Daire":
                    return Math.PI * Math.Pow(birim1, 2);
                default:
                    throw new ArgumentException("Sadece Kare veya Daire girebilirsiniz ");

            }

        }
        /// <summary>
        /// Belirli geometrik şeklin (Üçgen ya da Dikdörtgen) alanını hesaplar
        /// </summary>
        /// <param name="birim1">En veya taban uzunuğu</param>
        /// <param name="birim2">Boy ya da yükseklik</param>
        /// <param name="sekil">Üçgen ya da Dikdörtgen</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
       public static double AlanHesapla(double birim1, double birim2, string sekil)
        {
            switch (sekil)
            {
                case "Üçgen":
                    return (birim1 * birim2) / 2;
                case "Dikdörtgen":
                    return birim1 * birim2;
                default:
                    throw new ArgumentException("Sadece Üçgen veya Dikdörtgen girebilirsiniz ");

            }
        }
    }
}
