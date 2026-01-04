using System.Diagnostics;
using System.IO;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace ALTTP_Helper_CSharp
{
    public partial class MainTracker : Form
    {
        //Flip flop the track mode variables
        private bool manualTrackMode = false;
        private bool liveTrackMode = false;

        //Node systems
        BinarySearchTree? itemSearchTree = null!;

        //Generate a list of paths for player to choose
        [JsonPropertyName("paths")]
        List<Pathfinder> pathList = null!;

        //Generate a list of shops for players to find
        [JsonPropertyName("Shops")]
        List<Shops> shopsList = null!;

        //List of full entrances
        [JsonPropertyName("Entrances")]
        public List<Entrance> entrances { get; set; } = null!;

        //List all items and other data here
        [JsonExtensionData]
        public Dictionary<string, JsonElement> OtherData { get; set; }

        //For testing purposes
        internal int itemCount = 0;
        internal int dungeonCount = 0;


        /*Store the value of which dungeon has which boss.
        * In this case, the dungeon is the key, and the boss the value
        * <dungeon, boss>
        */
        [JsonPropertyName("Bosses")]
        Dictionary<string, string> bossLocations = null!;

        public void setManualTrackMode()
        {
            manualTrackMode = true;
            liveTrackMode = false;
        }
        public void setLiveTrackMode()
        {
            manualTrackMode = false;
            liveTrackMode = true;
        }
        public bool getManualTrackMode()
        {
            return manualTrackMode;
        }
        public bool getLiveTrackMode()
        {
            return liveTrackMode;
        }

        public MainTracker()
        {
            InitializeComponent();
        }

        private void MainTracker_Load(object sender, EventArgs e)
        {
            liveUpdatingToolStripMenuItem.Checked = false;
            manualUpdatingToolStripMenuItem.Checked = true;
        }

        private void howItWorksToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void spoilerLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using var openSpoilerDialog = new OpenFileDialog();

            //validating the files exist
            openSpoilerDialog.CheckFileExists = true;
            openSpoilerDialog.CheckPathExists = true;

            openSpoilerDialog.InitialDirectory = @"C:\Documents";
            openSpoilerDialog.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";
            openSpoilerDialog.Title = "Select a file.";

            if (openSpoilerDialog.ShowDialog() == DialogResult.OK)
            {
                string spoilerLogPath = openSpoilerDialog.FileName;
                liveUpdatingToolStripMenuItem.Checked = true;

                //Set to Live Tracking
                setLiveTrackMode();

                //Use File Stream to read all lines
                using FileStream fs = File.OpenRead(spoilerLogPath);

                var root = JsonNode.Parse(fs);

                if (root is JsonObject alldata)
                {
                    //Process Entrances
                    //Using AsArray to pass the section on entrances to get processed
                    if (alldata?["Entrances"] is JsonArray entranceData)
                    {
                        //Pass that data as array
                        this.entrances = ProcessEntrances(entranceData);

                        // Optional: Update your UI now that the list is full
                        MessageBox.Show($"Successfully loaded {this.entrances.Count} entrances!");
                    }
                    else
                    {
                        MessageBox.Show("File Parsing Error. Please verify the file is a spoiler log."
                            , "Error with File.");
                    }

                    //Process Shops
                    //Using AsArray to pass the section on shops to get processed
                    if (alldata?["Shops"] is JsonArray shopdata)
                    {
                        //Pass that data as array
                        this.shopsList = ProcessShops(shopdata);

                        // Optional: Update your UI now that the list is full
                        MessageBox.Show($"Successfully loaded {this.shopsList.Count} shops!");
                    }
                    else
                    {
                        MessageBox.Show("File Parsing Error. Please verify the file is a spoiler log."
                            , "Error with File.");
                    }

                    //Process Paths (Different from Entrances
                    //Using AsArray to pass the section on paths to get processed
                    if (alldata?["paths"] is JsonObject pathLists)
                    {
                        //Pass that data as array
                        this.pathList = ProcessPathList(pathLists);

                        // Optional: Update your UI now that the list is full
                        MessageBox.Show($"Successfully loaded {this.pathList.Count} pathways!");

                        /*TODO: Please be sure to finish the Pathfinder class to process each section individually */
                    }
                    else
                    {
                        MessageBox.Show("File Parsing Error. Please verify the file is a spoiler log."
                            , "Error with File.");
                    }

                    //AUTO-DETECT the rest of the world sections
                    foreach (var section in alldata)
                    {
                        //Skip the ones handled above
                        string key = section.Key;
                        if (key == "Entrances" || key == "Shops" || key == "paths" ||
                            key == "Special" || key == "playthrough") continue;

                        if(section.Value is JsonObject worldData)
                        {
                            //This will process all others than above listed
                            ProcessLocations(worldData);

                            
                        }
                    }

                    // Optional: Update your UI now that the list is full
                    MessageBox.Show($"Successfully loaded {itemCount} items!");

                    // Optional: Update your UI now that the list is full
                    MessageBox.Show($"Successfully loaded {dungeonCount} dungeon items!");

                }
            }

            /* Begin to parse the document into its counterparts. Here is a list to follow:
             * TODO Create a Map variable consisting of two other map variables 
             * (i.e. Map< Map<item, count>, Map<location, secondary location> > for each item to collect. 
             * TODO Create Node struct objects for each item consisting of name, memory address, offset, location, 
             * secondary location, count, etc. 
             * TODO Create a Binary Search Tree object and sort recursively for faster lookup times for objects. 
             * TODO Functions including insert recursively, search recursively, no need to delete recursively. 
             * TODO For dungeon items (compass, small/big keys, maps, etc) create one key node, and then 
             * add to a vector inside for location, using dungeon name as the name of the node. 
             * TODO Create entrance node objects (PathFinder class) like a doubly linked list that points to previous and 
             * next nodes for game modes that need to navigate complex pathways. Create function that takes in 
             * the last location and works backwards to either the main world (light or dark). */


        }

        List<Entrance> ProcessEntrances(JsonArray entranceList)
        {
            //Initialize the list
            entrances = new List<Entrance>();

            if (entranceList == null) return entrances;

            foreach (var node in entranceList)
            {
                if(node == null) continue;

                //Extract the strings from each object
                string entrance = node["entrance"]?.ToString() ?? "";
                string exit = node["exit"]?.ToString() ?? "";
                string direction = node["direction"]?.ToString() ?? "";

                //Create new entrance object
                Entrance newEntrance = new Entrance(entrance, exit, direction);


                //Add it to the processed list
                entrances.Add(newEntrance);
            }

            return entrances;
        }


        //Shops List
        List<Shops> ProcessShops(JsonArray shopData)
        {
            //Initialize the list
            shopsList = new List<Shops>();

            if(shopData == null) return shopsList;

            foreach(var node in shopData)
            {
                if(node == null) continue;

                //Extract all strings from each item in shop
                string shopName = node["location"]?.ToString() ?? "";

                string item0 = node["item_0"]?.ToString() ?? "";
                string item1 = node["item_1"]?.ToString() ?? "";
                string item2 = node["item_2"]?.ToString() ?? "";

                Shops newShop = new Shops(shopName, new List<string> { item0, item1, item2 });

                shopsList.Add(newShop);
            }
            return shopsList;
        }

        //Paths List (Different from Entrances)
        List<Pathfinder> ProcessPathList(JsonObject pathData)
        {
            //Initialize the list
            pathList = new List<Pathfinder>();

            foreach(var kvp in pathData)
            {
                //Get the name
                string pathName = kvp.Key;

                //Get the path steps
                JsonArray path = kvp.Value?.AsArray() ?? new JsonArray();

                Pathfinder newPathfinder = new Pathfinder(pathName);
                
                //Pass along the JsonArray to process later
                newPathfinder.ProcessJSONPaths(path);

                pathList.Add(newPathfinder);
            }

            return pathList;
        }
        private void ProcessLocations(JsonObject worldData)
        {
            //TODO: Allow user to opt out of these items w/checkbox
            //Items to filter out
            string[] filterItems = { "Rupees", "Bombs", "Arrows", "Heart", "Compass", "Map", "Pendant", "Crystal" };


            if (itemSearchTree == null)
            {
                //If tree does not exist, create one
                itemSearchTree = new BinarySearchTree();
            }
            foreach (var kvp in worldData)
            {
                string location = kvp.Key;
                string item = kvp.Value?.ToString() ?? "";

                bool isJunk = filterItems.Any(junk => item.Contains(junk, StringComparison.OrdinalIgnoreCase));

                if (!isJunk && !string.IsNullOrEmpty(item))
                {
                    //Filtered item. Add to the Search Tree. Now check for dungeon vs non-dungeon
                    if (item.Contains("key", StringComparison.OrdinalIgnoreCase))
                    {
                        //Create a dungeon item
                        DungeonItem newDungeonItem = new DungeonItem();

                        //Increment count
                        dungeonCount++;
                    }
                    else
                    {
                        Item newItem = new Item();

                        //Increment the count
                        itemCount++;
                    }
                }
            }
        }

        private void snes9xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO: Learn to get the process ID for Snes9x program
        }

        private void retroArchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO: Learn to get the process ID for RetroArch program
        }

        private void openEmuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO: Learn to get the process ID for OpenEmu program
        }

        private void ZNESZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO: Learn to get the process ID for ZSNES program
        }

        private void resetTrackerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Clear out tree.
            //TODO: Research better way to clear out tree, maybe recursively
            itemSearchTree = null;
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void liveUpdatingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (liveUpdatingToolStripMenuItem.Checked)
            {
                liveUpdatingToolStripMenuItem.Checked = false;
                manualUpdatingToolStripMenuItem.Checked = true;
            }
            else
            {
                manualUpdatingToolStripMenuItem.Checked = false;
                liveUpdatingToolStripMenuItem.Checked = true;
            }
        }

        private void manualUpdatingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (manualUpdatingToolStripMenuItem.Checked)
            {
                manualUpdatingToolStripMenuItem.Checked = false;
                liveUpdatingToolStripMenuItem.Checked = true;
            }
            else
            {
                liveUpdatingToolStripMenuItem.Checked = false;
                manualUpdatingToolStripMenuItem.Checked = true;
            }
        }

        private void themeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var newThemeForm = new ThemeForm())
            {
                if (newThemeForm.ShowDialog() == DialogResult.OK)
                {
                    int themeChoice = newThemeForm.ThemeID;

                    //Then process the new theme here.
                    switch (themeChoice)
                    {
                        default:
                            MessageBox.Show($"No theme selected.");
                            break;
                    }
                }
            }

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void gitHubPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string gitHubURL = "https://github.com/peck2703/ALTTP_Helper_CSharp";

            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = gitHubURL,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Could not open web link. {ex.Message}");
            }
        }

        private void liveTrackRadio_CheckedChanged(object sender, EventArgs e)
        {
            worldGroupLabel.Visible = false;
            worldSelectionGroupbox.Visible = false;
        }

        private void manualTrackRadio_CheckedChanged(object sender, EventArgs e)
        {
            worldGroupLabel.Visible = false;
            worldSelectionGroupbox.Visible = false;
        }

        private void mapTrackRadio_CheckedChanged(object sender, EventArgs e)
        {
            worldGroupLabel.Visible = true;
            worldSelectionGroupbox.Visible = true;
        }

    }
}
