using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;

namespace EasyAssembler
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // shows the settings window to the user
            new Settings().Show();
            // read from a settings file in order to fill data
            // rewrite settings when user hits save
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        // opens a project file on the disk
        private void OpenProject(string ProjectPath)
        {
            // loads up the project settings
            XElement ProjectSettings = XElement.Load(ProjectPath);
            // gets the source files attribute
            XElement SourceFiles = ProjectSettings.Element("sourceFiles");
            // iterates through the source files
            foreach (XElement Source in SourceFiles.Elements())
            {
                // creates a new tab for each source file
                // gets the path of the source file
                string SourceFile = Path.Combine(Path.GetDirectoryName(ProjectPath), SourceFiles.Element("filePath").Value);
                // writes the contense of the source file to the editor
                AssemblyEditor.Text = File.ReadAllText(SourceFile);
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            OpenProject("D:\\Projects\\Assembly\\Project\\Project.easm");
        }
    }
}
