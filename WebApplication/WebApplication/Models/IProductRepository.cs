﻿using System.Linq;

namespace WebApplication.Models
{
   public  interface IProductRepository
    {
        IQueryable<Product> Products { get;  }
       
        void SaveProduct(Product product);
        Product DeleteProduct(int productId);
    }
}
