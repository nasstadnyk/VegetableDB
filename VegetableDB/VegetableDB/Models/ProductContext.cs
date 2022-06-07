﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace VegetableDB.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("VegetableDB") 
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<CartItem> ShoppingCartItem { get; set; }
    }
}