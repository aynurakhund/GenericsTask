﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Interfaces
{
    public interface IProduct
    {
        int Id { get; set; }
        string Name { get; set; }
        int Price { get ; set; }
    }
}
