using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Product
    {
        private decimal price;
        public Product()
        {
            Test = 8;
        }
        public void SetPrice(decimal price)
        {
            if (price<=0)
            {
                throw new ArgumentException("fiyat değeri negatif olamaz!");
            }

            this.price = price;
        }

        public decimal GetPrice() { 
            return this.price;
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Description { get; set; }

        private int stockCount = 0;
        public bool IsStock { get { return stockCount > 0; } }

        public int Test { get; private set; }

        public int Test2 { private get; set; }

        public void ChangeTest()
        {
            Test = 10;
            //private set: sadece nesne içinde set edilebilir:
            //init: sadece object initializer ({}) ile değer atanabilir.
            //set hiç yok: constructor dışında hiçbir yerden set edilemez
        }

    }
}
