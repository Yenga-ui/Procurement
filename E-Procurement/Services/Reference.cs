using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Procurement.Services
{
    public class Reference
    {
        public Reference()
        {

        }

        private readonly string prefix = "SUPP-";

        public string generateReferenceNumber(string organization)
        {
            string reference = "";
           DateTime d= DateTime.Now;
            reference = reference + prefix + d.Year + d.Month + "-" + organization;

            return reference;
        }
    }
}
