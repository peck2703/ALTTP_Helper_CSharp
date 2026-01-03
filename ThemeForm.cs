using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALTTP_Helper_CSharp
{
    public partial class ThemeForm : Form
    {
        public int ThemeID { get; private set; }

        public ThemeForm()
        {
            InitializeComponent();
        }

        private void ThemeForm_Load(object sender, EventArgs e)
        {
            //Load up the possible items for the list box

        }

        private void confirmThemeBtn_Click(object sender, EventArgs e)
        {
            ThemeID = themeListBox.SelectedIndex;

            if (ThemeID < 0)
            {
                //Invalid index
                MessageBox.Show($"No theme selected. Reverting to default theme.");
            }

            this.DialogResult = DialogResult.OK;
        }

        private void cancelThemeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
