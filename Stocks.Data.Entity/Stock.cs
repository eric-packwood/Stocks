using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stocks.Data.Entity
{
    public class Stock
    {
        public int StockId { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public string Description { get; set; }

        public int MarketId { get; set; }
        public virtual Market Market { get; set; }
    }
}
