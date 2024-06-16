using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyAssembler
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        // called on the loading of the settings window
        private void Settings_Load(object sender, EventArgs e)
        {
            // sets the default values
            FormatList.SelectedIndex = 0;
            TypeList.SelectedIndex = 0;
        }

        // called on the user clicking the save button
        private void SaveButton_Click(object sender, EventArgs e)
        {
            // closes the form
            Close();
        }

        // called on the user clicking the cancel button
        private void CancelButton_Click(object sender, EventArgs e)
        {
            // closes the form
            Close();
        }

        private void FormatList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
