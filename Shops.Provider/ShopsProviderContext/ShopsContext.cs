using System;
using System.Data.Entity;
using Shops.Provider.ProviderModel;

namespace Shops.Provider.ShopsProviderContext
{
    public class ShopsContext : DbContext
    {
        public ShopsContext() : base("ShopsConnetions") { }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
