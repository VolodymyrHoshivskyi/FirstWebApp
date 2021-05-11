﻿using FirstWebApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebApp.Data.Interfaces
{
    public interface ICarsCategory { 

        IEnumerable<Category> AllCategories { get; } // повертає список з типом данних Category
    
    }
}
