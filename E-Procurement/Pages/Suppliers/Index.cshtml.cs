﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using E_Procurement.Models;

namespace E_Procurement.Pages.Suppliers
{
    public class IndexModel : PageModel
    {
        private readonly E_Procurement.Models.MyPayrollContext _context;

        public IndexModel(E_Procurement.Models.MyPayrollContext context)
        {
            _context = context;
        }

        public IList<SupplierRegistation> SupplierRegistation { get;set; }

        public async Task OnGetAsync()
        {
            SupplierRegistation = await _context.SupplierRegistation.ToListAsync();
        }
    }
}
