using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;
using IntralismManiaConverter.Enums;
using IntralismManiaConverter.Intralism;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace IntralismToolBox.Forms
{
    /// <summary>
    ///     Form that is opened when <see cref="MainForm.MapEditorButton"/> was pressed.
    /// </summary>
    public partial class MapEditorForm : Form
    {
        private readonly string editorDirectory;
        private string workingDirectory;

        private Point lastMouseDownLocation;
        private bool mouseIsDown;

        private IntralismBeatMap loadedMap;

        /// <summary>
        ///     Initializes a new instance of the <see cref="MapEditorForm"/> class.
        /// </summary>
        /// <param name="editorDirectory"> The directory of the intralism editor folder. </param>
        public MapEditorForm(string editorDirectory)
        {
            this.editorDirectory = editorDirectory;
            this.InitializeComponent();
        }

        private string ConfigPath => this.workingDirectory + @"\config.txt";

        private void OpenMapFolder(object sender, EventArgs e)
        {
            this.workingDirectory = this.OpenMap(Functions.OpenFolderAndGetName(this.editorDirectory));

            if (this.workingDirectory != string.Empty)
            {
                // TODO Load map
                this.loadedMap = new IntralismBeatMap(this.ConfigPath);
                List<Event> arcSpawnList = this.loadedMap.Events!.Where(x => x.IsEventOfType(EventType.SpawnObj)).ToList();
                List<Event> zoomList = this.loadedMap.Events!.Where(x => x.IsEventOfType(EventType.SetPlayerDistance)).ToList();
                List<Event> speedList = this.loadedMap.Events!.Where(x => x.IsEventOfType(EventType.SetSpeed)).ToList();
                List<Event> storyBoardList = this.loadedMap.Events!.Where(x => !x.IsEventOfType(EventType.SpawnObj)
                                                                               && !x.IsEventOfType(EventType.SetSpeed)
                                                                               && !x.IsEventOfType(EventType.SetPlayerDistance)).ToList();

                this.richTextBox2.Text = JsonConvert.SerializeObject(arcSpawnList, Formatting.Indented);
                this.richTextBox1.Text = JsonConvert.SerializeObject(zoomList, Formatting.Indented);
                this.richTextBox6.Text = JsonConvert.SerializeObject(speedList, Formatting.Indented);
                this.richTextBox3.Text = JsonConvert.SerializeObject(storyBoardList, Formatting.Indented);
                this.richTextBox4.Text = JsonSerializer.Serialize(this.loadedMap, new JsonSerializerOptions { WriteIndented = true });
            }
        }

        private void FormMouseDown(object sender, MouseEventArgs e)
        {
            this.lastMouseDownLocation = e.Location;
            this.mouseIsDown = true;
        }

        private void FormMouseUp(object sender, MouseEventArgs e)
            => this.mouseIsDown = false;

        private string OpenMap(string folderToCheck)
        {
            // If the user cancelled, return ""
            // If there's a config.txt, return the folder
            // TODO: Check the config is compatible with Intralism
            if (folderToCheck == string.Empty || File.Exists(folderToCheck + @"\config.txt"))
            {
                try
                {
                    Console.WriteLine(folderToCheck + @"\config.txt");
                    IntralismBeatMap testMap = new (folderToCheck + @"\config.txt");

                    if (testMap.ConfigVersion == 3)
                    {
                        if (testMap.Events!.Any(x => x.IsEventOfType(EventType.SpawnObj)))
                        {
                            return folderToCheck;
                        }

                        if (MessageBox.Show(
                            @"This map might be encoded, you still want to continue?",
                            @"Config v3",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            return folderToCheck;
                        }

                        Functions.DisplayErrorMessage("Please select a map folder with a config.txt!");
                        return this.OpenMap(Functions.OpenFolderAndGetName(this.editorDirectory));
                    }
                }
                catch
                {
                    Functions.DisplayErrorMessage("Please select a map folder with a config.txt!");
                    return this.OpenMap(Functions.OpenFolderAndGetName(this.editorDirectory));
                }

                return folderToCheck;
            }

            // Otherwise retry the folder dialog
            Functions.DisplayErrorMessage("Please select a map folder with a config.txt!");
            return this.OpenMap(Functions.OpenFolderAndGetName(this.editorDirectory));
        }

        private void ResizeWestAndEast(object sender, MouseEventArgs e)
        {
            if (!this.mouseIsDown)
            {
                return;
            }

            this.ResizePanels(e.X, this.lastMouseDownLocation.Y);
        }

        private void ResizeNorthAndSouth(object sender, MouseEventArgs e)
        {
            if (!this.mouseIsDown)
            {
                return;
            }

            this.ResizePanels(this.lastMouseDownLocation.X, e.Y);
        }

        private void ResizePanels(int x, int y)
        {
            int mouseDownXLocation = x;
            int mouseDownYLocation = y;

            int xDifference = this.lastMouseDownLocation.X - mouseDownXLocation;
            int yDifference = this.lastMouseDownLocation.Y - mouseDownYLocation;

            // Get current size
            Size splitSize = this.splitConfigs.Size;
            Size defaultSize = this.defaultConfig.Size;
            Size eventConfigSize = this.eventConfig.Size;

            // Change widths
            splitSize.Width -= xDifference;
            defaultSize.Width += xDifference;

            // Change heights
            splitSize.Height -= yDifference;
            defaultSize.Height -= yDifference;
            eventConfigSize.Height += yDifference;

            // Move the resize and default config panels
            this.resizeWE.Location = new Point(this.resizeWE.Location.X - xDifference, this.resizeWE.Location.Y);
            this.resizeNS.Location = new Point(this.resizeNS.Location.X, this.resizeNS.Location.Y - yDifference);
            this.defaultConfig.Location = new Point(this.defaultConfig.Location.X - xDifference, this.defaultConfig.Location.Y);
            this.eventConfig.Location = new Point(this.eventConfig.Location.X, this.eventConfig.Location.Y - yDifference);

            // Apply the resize
            this.splitConfigs.Size = splitSize;
            this.defaultConfig.Size = defaultSize;
            this.eventConfig.Size = eventConfigSize;
        }
    }
}