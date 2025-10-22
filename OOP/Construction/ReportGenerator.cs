using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction
{

    public class ReportFormatTypes
    {
        public const string PDF = "PDF";
        public const string HTML = "HTML";
    }

    public enum ReportFormatEnums
    {
        PDF,
        HTML
    }
    public class ReportGenerator
    {
        //Amaç: Bir excel dosyası içindeki verileri okuyarak, rapor oluşturan nesne.


        public ReportFormatEnums ReportFormat { get; set; }
        public string ExcelFilePath { get; set; }

        //public ReportGenerator() 
        //{
        //    ReportFormat = "PDF";
        //}

        public ReportGenerator(string excelFilePath):this(excelFilePath, ReportFormatEnums.PDF ) 
        {
            //ExcelFilePath = excelFilePath;
            //ReportFormat = "PDF";
            //bilmemne(excelFilePath, "PDF");
        }

        public ReportGenerator(string excelFilePath, ReportFormatEnums reportFormat)
        {
            ExcelFilePath = excelFilePath;
            ReportFormat = reportFormat;
        }



    }
}
