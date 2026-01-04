using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALTTP_Helper_CSharp
{
    internal class Shops
    {
        public string shopLocation;
        public List<string> items = new List<string>();

        public Shops()
        {
            shopLocation = string.Empty;
            items = new List<string>();
        }

        public Shops(string shopLocation, List<string> items)
        {
            this.shopLocation = shopLocation;
            this.items = items;
        }
    }
}
