using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usingRecordTypes
{
 


    public class ProductWithRecord
    {
        public string Name { get; set; }
        public MoneyRecord Price { get; set; }
    }
    public record MoneyRecord
    {
        public decimal Amount { get; set; }
        public string Currency { get; set; }
    }


    public class Product
    {
        public string Name { get; set; }
        public Money Price { get; set; }
    }
    public class Money
    {
        public decimal Amount { get; set; }
        public string Currency { get; set; }

        // override object.Equals
        public override bool Equals(object obj)
        {
            //       
            // See the full list of guidelines at
            //   http://go.microsoft.com/fwlink/?LinkID=85237  
            // and also the guidance for operator== at
            //   http://go.microsoft.com/fwlink/?LinkId=85238
            //

            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            var that = (Money) obj;
            // TODO: write your implementation of Equals() here
            if (this.Currency == that.Currency && this.Amount == that.Amount)
            {
                return true;
            }
            return false;
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            // TODO: write your implementation of GetHashCode() here
            return (int)Amount;
        }

        public static bool operator ==(Money lhs, Money rhs) { 
            return lhs.Equals(rhs);
        }
        public static bool operator !=(Money lhs, Money rhs)
        {
            return !lhs.Equals(rhs);
        }
    }

}
