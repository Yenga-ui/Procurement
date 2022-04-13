using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Procurement.Models
{
    public class CsvLine
    {

        public string code { get; set; }
        public string description { get; set; }
        public string amount { get; set; }
        public string budgetLine { get; set; }
        public string Status { get; set; }

        public override string ToString()
        {
            return $"Budget Line - {description}: code: {code}, amount: {amount}";
        }
    }
}
