using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andre_Inventory
{
    internal class Item
    {

            public int Quantity { get; set; }
            public decimal Price { get; set; }
            public string Name { get; internal set; }
    }
}
