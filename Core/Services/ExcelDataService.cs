using Core.Interfaces;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;       //Microsoft Excel 14 object in references-> COM tab

namespace Core.Services
{
    public class ExcelDataService : IExcelDataService
    {
       
        /// <summary>
        /// Upload Excel Document
        /// </summary>
        /// <param name="filePath"></param>
        public async Task<List<ProcurementPlanItem>> ParseExcelData(String filePath)
        {
            //Create COM Objects. Create a COM object for everything that is referenced
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(filePath);
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;

            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;
            //iterate over the rows and columns and print to the console as it appears in the file
            //excel is not zero based!!
            // i = 1 ......i = 5
            var headerColumns = new List<string>();
            var headerPosition = 1; 
            var listOfDictionary = new List<ProcurementPlanItem>();

            for (int i = 1; i <= rowCount; i++)
            {
                var mutablePropertyValue = new ProcurementPlanItem();

                for (int j = 1; j <= colCount; j++)
                {
                    //new line
                    if (j == 1) Console.Write("\r\n");
                    var positionalValue = xlRange.Cells[i, j];

                    //write the value to the console
                    if (positionalValue?.Value2 != null)
                    {
                        if (i == headerPosition) {
                            if (!headerColumns.Contains(positionalValue?.Value2))
                                headerColumns.Add(positionalValue?.Value2);
                        }
                        else
                        {
                            string nameOfProperty = SanitizePropertyName(headerColumns[j - 1]);
                            var propertyInfo = mutablePropertyValue?.GetType().GetProperty(nameOfProperty);
                            var value = positionalValue?.Value2;

                            //var finalValue = value

                            propertyInfo?.SetValue(mutablePropertyValue, value?.ToString(), null);
                        }                        
                    }
                }
                if (!string.IsNullOrEmpty(mutablePropertyValue?.UNSPSC) && !string.IsNullOrEmpty(mutablePropertyValue?.Class))
                {
                    listOfDictionary.Add(mutablePropertyValue);
                }
            }

            //cleanup
            GC.Collect();
            GC.WaitForPendingFinalizers();
            
            //release com objects to fully kill excel process from running in the background
            Marshal.ReleaseComObject(xlRange);
            Marshal.ReleaseComObject(xlWorksheet);

            //close and release
            xlWorkbook.Close();
            Marshal.ReleaseComObject(xlWorkbook);

            //quit and release
            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);

            await Task.Delay(10);
            return listOfDictionary;
        }

        private string SanitizePropertyName(string v)
        {
            v = v.Trim();   
            return v.Replace(" ", "_").Replace("(Y/N)", "");
        }
    }
}
