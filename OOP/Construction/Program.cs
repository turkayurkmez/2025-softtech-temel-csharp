// See https://aka.ms/new-console-template for more information
using Construction;

Console.WriteLine("Hello, World!");

ReportGenerator generator = new ReportGenerator("file.smp", ReportFormatEnums.HTML);

Console.WriteLine(generator.ReportFormat);

ReportGenerator generator1 = new ReportGenerator("C:\\sample.xslx");

Console.WriteLine(generator1.ReportFormat);

