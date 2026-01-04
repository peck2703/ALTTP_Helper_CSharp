using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALTTP_Helper_CSharp
{
    public  class Item
    {
        //Create all the variables for the tree nodes within the BST class
        public string primaryItemLocation;
        public string secondaryItemLocation;
        public string itemName;
        public int itemCount;

        //Default constructor with empty non-null values
        public Item()
        {
            primaryItemLocation = string.Empty;
            secondaryItemLocation = string.Empty;
            itemName = string.Empty;
        }

        //Constructor used for insertion of correct objects
        public Item(string primary, string secondary, string name, int count)
        {
            primaryItemLocation = primary;
            secondaryItemLocation = secondary;
            itemName = name;
            itemCount = count;         //Most likely this will evaluate to '0'
        }
    }
}