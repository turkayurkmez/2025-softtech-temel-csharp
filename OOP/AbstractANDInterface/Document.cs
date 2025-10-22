using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractANDInterface
{
    public interface IPrintable
    {
        void Print();
    }
    public abstract class Document
    {
        public void Copy(string from, string to)
        {
            Console.WriteLine("Kopyalandı....");
        }

        public void ChangeTitle(string title)
        {
            Console.WriteLine(title);
        }
        //Her dokümanın kayıt işlemi farklı olacak!
        public abstract void Save(string filename);        
        public abstract void Load(string filename);
       

    }

    public class WordDocument : Document, IPrintable
    {
        public override void Load(string filename)
        {
            Console.WriteLine("Word yükleniyor");
        }

        public void Print()
        {
            Console.WriteLine("Word çıktısı.....");
        }

        public override void Save(string filename)
        {
            Console.WriteLine("Word kaydediliyor");

        }
    }

    public class ExcelDocument: Document, IPrintable
    {
        public override void Load(string filename)
        {
            Console.WriteLine("Excel yükleniyor");
        }

        public void Print()
        {
            Console.WriteLine("Excel çıktısı.....");

        }

        public override void Save(string filename)
        {
            Console.WriteLine("Excel kaydediliyor");

        }
    }

    public class PDFDocument : Document
    {
        public override void Load(string filename)
        {
            Console.WriteLine("PDF yükleniyor");
        }

       

        public override void Save(string filename)
        {
            Console.WriteLine("PDF kaydediliyor");

        }
    }

    public class DocumentPrinter
    {
        public void Print(IPrintable document)
        {
            document.Print();
        }
    }

}
