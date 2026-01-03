using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALTTP_Helper_CSharp.Classes
{
    /* This class is created for each of the "entrances" or "destinations 
     * for the player to find. each of the PathNodes are the nodes in which 
     * the player must traverse to get to the ultimate destination which is 
     * the name of the pathfinder's destination variable.
     * 
     * The entrances are created first in the text file, and the pathways 
     * are created near the end. To search for shops
     
      */

    internal class Pathfinder
    {
        //List of path nodes to create a pathway
        private List<PathNode> path = new();

        //Pass by value of where player wants to go
        private string destination;

        //Adding this so the Main tracker form can see this value
        public string DestinationName => destination;

        public class PathNode
        {
            //Each node on the path to the destination is stored like a linked list
            public string start { get; set; } = string.Empty;
            public string end { get; set; } = string.Empty;

            //Constructor with values
            //When parsing the text file, create as many path nodes for each entrance
            public PathNode(string begin, string dest)
            {
                this.start = begin!;
                this.end = dest!;
            }
        }

        //Default constructor -- do not use
        public Pathfinder() 
        {
            this.destination = string.Empty;
        }

        //Constructor with values
        /*This value will be generated when the parsing of the txt the 
         * destination from a list. One list, many path nodes, but at 
         * least one must exist*/
        public Pathfinder(string dest)
        {
            this.destination = dest;
        }

        //Begin to add objects to a list
        public void AddToPathList(PathNode newPath)
        {
            //Add to dynamic path
            path.Add(newPath);
        }

        /*Return entire list of path nodes. Call this function 
         * when the player selects a location from a list. 
         * Returns EVERY node in that path, to get displayed
         * from the form itself. Create a custom form for 
         * displaying the results */
        public List<PathNode> GetPath() { return path; }
    }
}
