using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;

namespace Arnaud.Models
{
    public class ShopInitializer : DropCreateDatabaseIfModelChanges<ShopFactory>
    {
        protected override void Seed(ShopFactory context)
        {
            context.Products.Add(new Product() { Name = "Yoghurt", Description = "This creamy one will melt you", Price = 5.4M });
            context.Products.Add(new Product() { Name = "Cleaning lotion", Description = "Nothing cets in its way", Price = 64M });
            context.Products.Add(new Product() { Name = "Banana", Description = "Hungry ? That's going to get you satisfied", Price = 3M });
        }
    }
}