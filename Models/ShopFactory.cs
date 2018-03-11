using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;

namespace Arnaud.Models
{
    public class ShopFactory : DbContext
    {
        //provide access to a Products list coming from the db table
        public DbSet<Product> Products { get; set; } //db set

        public ShopFactory()
        {
            Database.SetInitializer(new ShopInitializer()); //initializer
        }
    }
}