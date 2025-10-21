namespace OverloadAnOptional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            double sonuc1 = alanHesapla(3, "Daire");
            double sonuc2 = alanHesapla(4, 6, "Üçgen");
         

            double sonuc3 = OpsiyonelAlanHesapla(4);
            double sonuc4 = OpsiyonelAlanHesapla(5, sekil: "Daire");
            double sonuc5 = OpsiyonelAlanHesapla(3, birim2: 4, sekil: "Üçgen");
        }
        /// <summary>
        /// Belirli geometrik şeklin (Daire ya da Kare) alanını hesaplar
        /// </summary>
        /// <param name="birim1">Dairenin yarıçap uzunluğu ya da karenin kenar uzunluğu</param>
        /// <param name="sekil">Daire veya Kare</param>
        /// <returns>double cinsinden alan değeri</returns>
        /// <exception cref="ArgumentException"></exception>
       public static double alanHesapla(double birim1, string sekil)
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
      public  static double alanHesapla( double birim1, double birim2, string sekil) 
        {
            switch (sekil)
            {
                case "Üçgen":
                    return (birim1 * birim2)/2;
                case "Dikdörtgen":
                    return birim1 * birim2;
                default:
                    throw new ArgumentException("Sadece Üçgen veya Dikdörtgen girebilirsiniz ");

            }
        }
        /// <summary>
        /// Calculates the area of a specified geometric shape based on the provided dimensions.
        /// </summary>
        /// <param name="birim1">The first dimension of the shape. For example, the side length for a square, the radius for a circle, or the
        /// base for a triangle.</param>
        /// <param name="birim2">The second dimension of the shape, if applicable. For example, the height for a triangle or the second side
        /// for a rectangle. Defaults to 1.</param>
        /// <param name="sekil">The type of the geometric shape. Supported values are "Kare" (square), "Daire" (circle), "Üçgen" (triangle),
        /// and "Dikdörtgen" (rectangle). Defaults to "Kare".</param>
        /// <returns>The calculated area of the specified shape. For unsupported shapes, an exception is thrown.</returns>
        /// <exception cref="ArgumentException">Thrown if <paramref name="sekil"/> is not one of the supported values: "Kare", "Daire", "Üçgen", or
        /// "Dikdörtgen".</exception>
        public static double OpsiyonelAlanHesapla(double birim1, double birim2=1,string sekil="Kare")
        {
            switch (sekil)
            {
                case "Kare":
                    return Math.Pow(birim1, 2);
                case "Daire":
                    return Math.PI * Math.Pow(birim1, 2);
                case "Üçgen":
                    return (birim1 * birim2) / 2;
                case "Dikdörtgen":
                    return birim1 * birim2;
                default:
                    throw new ArgumentException("Üçgen, Dikdörtgen, Kare veya Daire girebilirsiniz ");
            }
        }
    }


}
