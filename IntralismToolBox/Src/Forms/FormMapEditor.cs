using System;
using System.IO;
using System.Windows.Forms;

namespace ManiaToIntralism.Forms
{
    public partial class FormMapEditor : Form
    {
        private string workingDirectory;
        private string editorDirectory;
        
        private string ConfigPath => workingDirectory + @"\config.txt";
        
        public FormMapEditor(string editorDirectory)
        {
            this.editorDirectory = editorDirectory;
            InitializeComponent();
        }

        private void OpenMapFolder(object sender, EventArgs e)
        {
            workingDirectory = OpenMap(Functions.OpenFolderAndGetName(editorDirectory));

            if (workingDirectory != "")
            {
                // Load map
                // ...
            }
        }

        private string OpenMap(string folderToCheck)
        {
            // If the user cancelled, return ""
            // If there's a config.txt, return the folder
            // TODO: Check the config is compatible with Intralism
            if (folderToCheck == "" || File.Exists(folderToCheck + @"\config.txt")) return folderToCheck;
            
            // Otherwise retry the folder dialog
            Functions.DisplayErrorMessage("Please select a map folder with a config.txt!");
            return OpenMap(Functions.OpenFolderAndGetName(editorDirectory));

        }
    }
}