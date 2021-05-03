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
    ///     <see cref="ThemedForm"/> that is opened when <see cref="MainForm.MapEditorButton"/> was pressed.
    /// </summary>
    public partial class MapEditorForm : ThemedForm
    {
        private readonly string editorDirectory;
        private string workingDirectory;

        private Point lastMouseDownLocation;
        private bool mouseIsDown;

        private EditorIntralismMap loadedMap;

        /// <summary>
        ///     Initializes a new instance of the <see cref="MapEditorForm"/> class.
        /// </summary>
        /// <param name="editorDirectory"> The directory of the intralism editor folder. </param>
        public MapEditorForm(string editorDirectory)
        {
            this.editorDirectory = editorDirectory;
            this.InitializeComponent();
            this.ReloadTheme();
        }

        private string ConfigPath => this.workingDirectory + @"\config.txt";

        private void OpenMapFolder(object sender, EventArgs e)
        {
            this.workingDirectory = this.OpenMap(Functions.OpenFolderAndGetName(this.editorDirectory));

            if (this.workingDirectory != string.Empty)
            {
                this.loadedMap = new EditorIntralismMap(new IntralismBeatMap(this.ConfigPath));
                this.UpdateTextBox();
            }
        }

        private void FormMouseDown(object sender, MouseEventArgs e)
        {
            this.lastMouseDownLocation = e.Location;
            this.mouseIsDown = true;
        }

        private void FormMouseUp(object sender, MouseEventArgs e) => this.mouseIsDown = false;

        private string OpenMap(string folderToCheck)
        {
            // If the user cancelled, return ""
            // If there's a config.txt, return the folder
            if (folderToCheck == string.Empty || File.Exists(folderToCheck + @"\config.txt"))
            {
                try
                {
                    IntralismBeatMap testMap = new(folderToCheck + @"\config.txt");

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
            int xDifference = this.lastMouseDownLocation.X - x;
            int yDifference = this.lastMouseDownLocation.Y - y;

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

        private void ArcSpawnTextBoxTextChanged(object sender, EventArgs e)
        {
            int lastCursorPosition = this.ArcSpawnTextBox.SelectionStart;
            
            try
            {
                this.loadedMap.ArcSpawns = JsonConvert.DeserializeObject<List<Event>>(this.ArcSpawnTextBox.Text!);
                this.loadedMap.BuildEvents();

                this.DefaultViewTextBox.Text = JsonSerializer.Serialize(
                    this.loadedMap,
                    new JsonSerializerOptions { WriteIndented = true });
            }
            catch (Exception e2)
            {
                Console.WriteLine(e2);
            }

            this.ArcSpawnTextBox.SelectionStart = lastCursorPosition;
        }

        private void ZoomEventTextBoxTextChanged(object sender, EventArgs e)
        {
            int lastCursorPosition = this.ZoomEventTextBox.SelectionStart;

            try
            {
                this.loadedMap.Zooms = JsonConvert.DeserializeObject<List<Event>>(this.ZoomEventTextBox.Text!);
                this.loadedMap.BuildEvents();

                this.DefaultViewTextBox.Text = JsonSerializer.Serialize(
                    this.loadedMap,
                    new JsonSerializerOptions { WriteIndented = true });
            }
            catch (Exception e2)
            {
                Console.WriteLine(e2);
            }

            this.ZoomEventTextBox.SelectionStart = lastCursorPosition;
        }

        private void SpeedEventTextBoxTextChanged(object sender, EventArgs e)
        {
            int lastCursorPosition = this.SpeedEventTextBox.SelectionStart;

            try
            {
                this.loadedMap.Speeds = JsonConvert.DeserializeObject<List<Event>>(this.SpeedEventTextBox.Text!);
                this.loadedMap.BuildEvents();

                this.DefaultViewTextBox.Text = JsonSerializer.Serialize(
                    this.loadedMap,
                    new JsonSerializerOptions { WriteIndented = true });
            }
            catch (Exception e2)
            {
                Console.WriteLine(e2);
            }

            this.SpeedEventTextBox.SelectionStart = lastCursorPosition;
        }

        private void StoryBoardEventTextBoxTextChanged(object sender, EventArgs e)
        {
            int lastCursorPosition = this.StoryBoardTextBox.SelectionStart;

            try
            {
                this.loadedMap.StoryBoard = JsonConvert.DeserializeObject<List<Event>>(this.StoryBoardTextBox.Text!);
                this.loadedMap.BuildEvents();

                this.DefaultViewTextBox.Text = JsonSerializer.Serialize(
                    this.loadedMap,
                    new JsonSerializerOptions { WriteIndented = true });
            }
            catch (Exception e2)
            {
                Console.WriteLine(e2);
            }

            this.StoryBoardTextBox.SelectionStart = lastCursorPosition;
        }

        private void DefaultViewTextBoxTextChanged(object sender, EventArgs e)
        {
            int lastCursorPosition = this.DefaultViewTextBox.SelectionStart;

            try
            {
                IntralismBeatMap intralismBeatMap =
                    JsonSerializer.Deserialize<IntralismBeatMap>(this.DefaultViewTextBox.Text!);

                this.loadedMap = new EditorIntralismMap(intralismBeatMap);
                this.UpdateTextBox();
            }
            catch (Exception e2)
            {
                Console.WriteLine(e2);
            }

            this.DefaultViewTextBox.SelectionStart = lastCursorPosition;
        }

        private void UpdateTextBox()
        {
            this.ArcSpawnTextBox.Text = JsonConvert.SerializeObject(this.loadedMap.ArcSpawns, Formatting.Indented);
            this.ZoomEventTextBox.Text = JsonConvert.SerializeObject(this.loadedMap.Zooms, Formatting.Indented);
            this.SpeedEventTextBox.Text = JsonConvert.SerializeObject(this.loadedMap.Speeds, Formatting.Indented);
            this.StoryBoardTextBox.Text = JsonConvert.SerializeObject(this.loadedMap.StoryBoard, Formatting.Indented);
            
            this.DefaultViewTextBox.Text = JsonSerializer.Serialize(
                this.loadedMap,
                new JsonSerializerOptions { WriteIndented = true });
        }
    }
}