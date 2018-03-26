﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularWebapiApp.Models
{
    public class ProductModel
    {
        public List<Product> findAll()
        {
            List<Product> result = new List<Product>();
            result.Add(new Product { Id = "P01", Name = "Product 1", Price = 100, Quantity = 2 });
            result.Add(new Product { Id = "P02", Name = "Product 2", Price = 200, Quantity = 3 });
            result.Add(new Product { Id = "P03", Name = "Product 3", Price = 300, Quantity = 4 });
            return result;
        }
        public Product find(string id)
        {
            return findAll().Single(p => p.Id.Equals(id));
        }
    }
}