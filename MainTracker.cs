using ALTTP_Helper_CSharp.Classes;
using System.Diagnostics;

namespace ALTTP_Helper_CSharp
{
    public partial class MainTracker : Form
    {
        //Flip flop the track mode variables
        private bool manualTrackMode = false;
        private bool liveTrackMode = false;


        //Node systems
        BinarySearchTree itemSearchTree;

        //Generate a list of paths for player to choose
        List<Pathfinder> pathList;

        //Generate a list of shops for players to find
        List<Shops> shopsList;

        /*Store the value of which dungeon has which boss.
        * In this case, the dungeon is the key, and the boss the value
        * <dungeon, boss>
        */
        Dictionary<string, string> bossLocations;

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

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
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
            }

            /* Begin to parse the document into its counterparts. Here is a list to follow:
             * -Create a Map variable consisting of two other map variables 
             * (i.e. Map< Map<item, count>, Map<location, secondary location> > for each item to collect. 
             * Create Node struct objects for each item consisting of name, memory address, offset, location, 
             * secondary location, count, etc. 
             * Create a Binary Search Tree object and sort recursively for faster lookup times for objects. 
             * Functions including insert recursively, search recursively, no need to delete recursively. 
             * For dungeon items (compass, small/big keys, maps, etc) create one key node, and then 
             * add to a vector inside for location, using dungeon name as the name of the node. 
             * -Create entrance node objects (PathFinder class) like a doubly linked list that points to previous and 
             * next nodes for game modes that need to navigate complex pathways. Create function that takes in 
             * the last location and works backwards to either the main world (light or dark). */
        }

        private void resetTrackerToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
