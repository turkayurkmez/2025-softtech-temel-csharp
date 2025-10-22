using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LooselyCoupled
{
    public class Oyuncu
    {
        public void Giy(IKiyafet giyim) { }
    }


    public interface IKiyafet { }
    public abstract class UstGiyim : IKiyafet { }
    public class Kazak : UstGiyim
    {

    }
    public class KirmiziKazak : Kazak
    {

    }
}
