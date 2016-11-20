﻿using System;
using System.Collections.Generic;


namespace Shops.Provider.ProviderModel
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int ShopId { get; set; }
    }
}
