// See https://aka.ms/new-console-template for more information
using AbstractANDInterface;

Console.WriteLine("Hello, World!");
PDFDocument pdf = new PDFDocument();
ExcelDocument excel = new ExcelDocument();
WordDocument word = new WordDocument();

DocumentPrinter printer = new DocumentPrinter();
//printer.Print(pdf);
printer.Print(excel);
printer.Print(word);
