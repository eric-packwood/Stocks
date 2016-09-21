using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stocks.Data.Entity
{
    public class Market
    {
        public int MarketId { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }

        public IEnumerable<Stock> Stocks { get; set; }
    }
}
