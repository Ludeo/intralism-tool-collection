using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using IntralismManiaConverter.Enums;
using IntralismManiaConverter.Intralism;

namespace IntralismToolBox
{
    /// <summary>
    ///     Class of <see crf="IntralismManiaConverter.Intralism.IntralismBeatMap"/> that includes separated lists
    ///     for each event.
    /// </summary>
    public class EditorIntralismMap : IntralismBeatMap
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="EditorIntralismMap"/> class.
        /// </summary>
        /// <param name="beatMap"> An IntralismBeatMap that should be turned into a EditorIntralismMap. </param>
        public EditorIntralismMap(IntralismBeatMap beatMap)
        {
            this.Events = beatMap.Events;
            this.Info = beatMap.Info;
            this.Lives = beatMap.Lives;
            this.Name = beatMap.Name;
            this.Path = beatMap.Path;
            this.Speed = beatMap.Speed;
            this.ConfigVersion = beatMap.ConfigVersion;
            this.EnvironmentType = beatMap.EnvironmentType;
            this.HandCount = beatMap.HandCount;
            this.IconFile = beatMap.IconFile;
            this.LevelResources = beatMap.LevelResources;
            this.MaxLives = beatMap.MaxLives;
            this.MusicFile = beatMap.MusicFile;
            this.MusicTime = beatMap.MusicTime;

            this.UncategorizedEvents = this.Events!.ToList();

            foreach (Event entry in this.Events)
            {
                if (entry.IsEventOfType(EventType.SpawnObj))
                {
                    this.ArcSpawns.Add(entry);
                }
                else if (entry.IsEventOfType(EventType.SetPlayerDistance))
                {
                    this.Zooms.Add(entry);
                }
                else if (entry.IsEventOfType(EventType.SetSpeed))
                {
                    this.Speeds.Add(entry);
                }
                else if (!entry.IsEventOfType(EventType.SpawnObj)
                         && !entry.IsEventOfType(EventType.SetSpeed)
                         && !entry.IsEventOfType(EventType.SetPlayerDistance))
                {
                    this.StoryBoard.Add(entry);
                }
                else
                {
                    continue;
                }

                this.UncategorizedEvents.Remove(entry);
            }

            this.BuildEvents();
        }

        /// <summary>
        ///     Gets or sets the List of ArcSpawn Events.
        /// </summary>
        [JsonIgnore] public List<Event> ArcSpawns { get; set; } = new ();

        /// <summary>
        ///     Gets or sets the List of Zoom Events.
        /// </summary>
        [JsonIgnore] public List<Event> Zooms { get; set; } = new ();

        /// <summary>
        ///     Gets or sets the List of Speed Events.
        /// </summary>
        [JsonIgnore] public List<Event> Speeds { get; set; } = new ();

        /// <summary>
        ///     Gets or sets the List of StoryBoard Events.
        /// </summary>
        [JsonIgnore] public  List<Event> StoryBoard { get; set; } = new ();

        [JsonIgnore] private List<Event> UncategorizedEvents { get; }

        /// <summary>
        ///     Function that fills up UncategorizedEvents with all the other Lists.
        /// </summary>
        public void BuildEvents() => this.Events = this.UncategorizedEvents!
                                                   .Concat(this.ArcSpawns!)
                                                   .Concat(this.Zooms!)
                                                   .Concat(this.Speeds!)
                                                   .Concat(this.StoryBoard!)
                                                   .ToList();
    }
}