using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALTTP_Helper_CSharp
{
    public class DungeonItem
    {
        internal enum DungeonItemType
        {
            Small_Key,
            Big_Key,
            Compass,
            Map
        }

        //Create all the variables for the tree nodes within the BST class
        public string primaryItemLocation;
        public string secondaryItemLocation;
        public string itemName;
        public string dungeonName;

        //Default constructor with non-null values
        public DungeonItem()
        {
            primaryItemLocation = string.Empty;
            secondaryItemLocation = string.Empty;
            itemName = string.Empty;
            dungeonName = string.Empty;
        }

        //Constructor used for insertion of dungeon items
        public DungeonItem(string primary, string secondary, string name, string dungeon)
        {
            primaryItemLocation = primary;
            secondaryItemLocation = secondary;
            itemName = name;
            dungeonName = dungeon;
        }
    }
}