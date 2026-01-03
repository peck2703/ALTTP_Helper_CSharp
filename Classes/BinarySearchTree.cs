using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALTTP_Helper_CSharp.Classes
{
    internal class BinarySearchTree
    {
        public BinarySearchTree() { }

        //Use this class for all non-dungeon items
        private class ItemTreeNode
        {
            //Create all the variables for the tree nodes within the BST class
            public string primaryItemLocation;
            public string secondaryItemLocation;
            public string itemName;
            public int itemCount;

            //Default constructor with empty non-null values
            public ItemTreeNode()
            {
                primaryItemLocation = string.Empty;
                secondaryItemLocation = string.Empty;
                itemName = string.Empty;
            }

            //Constructor used for insertion of correct objects
            public ItemTreeNode(string primary, string secondary, string name, int count)
            {
                primaryItemLocation = primary;
                secondaryItemLocation = secondary;
                itemName = name;
                itemCount = count;         //Most likely this will evaluate to '0'
            }
        }

        //Use this for dungeon items only (map, compass, big/small key)
        private class DungeonItemTreeNode
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
            public DungeonItemTreeNode()
            {
                primaryItemLocation = string.Empty;
                secondaryItemLocation = string.Empty;
                itemName = string.Empty;
                dungeonName = string.Empty;
            }

            //Constructor used for insertion of dungeon items
            public DungeonItemTreeNode(string primary, string secondary, string name, string dungeon)
            {
                primaryItemLocation = primary;
                secondaryItemLocation = secondary;
                itemName = name;
                dungeonName = dungeon;
            }
        }

        //Add Search, Insert recursive functions here.
    }
}
