﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace E_Procurement.Models
{
    public partial class Gender
    {
        public int GenderId { get; set; }
        public string Code { get; set; }
        public string LongDescription { get; set; }
    }
}