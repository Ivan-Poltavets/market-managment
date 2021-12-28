﻿using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCases.DataStore
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
    }
}