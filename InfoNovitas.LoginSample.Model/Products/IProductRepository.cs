﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoNovitas.LoginSample.Model.Products
{
    public interface IProductRepository:IRepository<Product,int>
    {
    }
}
