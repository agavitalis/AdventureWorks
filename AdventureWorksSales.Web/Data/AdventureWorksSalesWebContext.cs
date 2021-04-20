using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AdventureWorksSales.Web.Data
{
    public class AdventureWorksSalesWebContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public AdventureWorksSalesWebContext() : base("name=AdventureWorksSalesWebContext")
        {
        }

        public System.Data.Entity.DbSet<AdventureWorksSales.Web.Models.Product> Products { get; set; }

        public System.Data.Entity.DbSet<AdventureWorksSales.Web.Models.ProductCategory> ProductCategories { get; set; }

        public System.Data.Entity.DbSet<AdventureWorksSales.Web.Models.SalesOrder> SalesOrders { get; set; }
    }
}
