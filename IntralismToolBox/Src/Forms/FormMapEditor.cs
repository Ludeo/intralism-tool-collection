using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ManiaToIntralism.Forms
{
    public partial class FormMapEditor : Form
    {
        private string workingDirectory;
        private string editorDirectory;

        private Point lastMouseDownLocation;
        private bool mouseIsDown = false;
        
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

        private void FormMouseDown(object sender, MouseEventArgs e)
        {
            lastMouseDownLocation = e.Location;
            mouseIsDown = true;
        }

        private void FormMouseUp(object sender, MouseEventArgs e)
            => mouseIsDown = false;

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

        /// <summary>
        /// Controls resizing the left and right panels via the section in between them.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void ResizeWestAndEast(object sender, MouseEventArgs e)
        {
            if (!mouseIsDown) return;
            ResizePanels(e.X, lastMouseDownLocation.Y);
        }

        private void ResizeNorthAndSouth(object sender, MouseEventArgs e)
        {
            if (!mouseIsDown) return;
            ResizePanels(lastMouseDownLocation.X, e.Y);
        }

        private void ResizePanels(int x, int y)
        {
            int mouseDownXLocation = x;
            int mouseDownYLocation = y;

            int xDifference = lastMouseDownLocation.X - mouseDownXLocation;
            int yDifference = lastMouseDownLocation.Y - mouseDownYLocation;

            // Get current size
            Size splitSize = splitConfigs.Size;
            Size defaultSize = defaultConfig.Size;
            Size eventConfigSize = eventConfig.Size;    
            
            // Change widths
            splitSize.Width -= xDifference;
            defaultSize.Width += xDifference;
            
            // Change heights
            splitSize.Height -= yDifference;
            defaultSize.Height -= yDifference;
            eventConfigSize.Height += yDifference;

            // Move the resize and default config panels
            resizeWE.Location = new Point(resizeWE.Location.X - xDifference, resizeWE.Location.Y);
            resizeNS.Location = new Point(resizeNS.Location.X, resizeNS.Location.Y - yDifference);
            defaultConfig.Location = new Point(defaultConfig.Location.X - xDifference, defaultConfig.Location.Y);
            eventConfig.Location = new Point(eventConfig.Location.X, eventConfig.Location.Y - yDifference);
                
            // Apply the resize
            splitConfigs.Size = splitSize;
            defaultConfig.Size = defaultSize;
            eventConfig.Size = eventConfigSize;
        }
    }
}