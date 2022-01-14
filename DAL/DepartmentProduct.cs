﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DepartmentProduct
    {
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
        public int ProductId { get; set; }  
        public virtual Product Product { get; set; }
    }
}
