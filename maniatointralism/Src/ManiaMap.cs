using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ManiaToIntralism.Forms;
using NAudio.Wave;

namespace ManiaToIntralism
{
    public class ManiaMap
    {
        public string Audio { get; }

        public Mode Mode { get; }

        public string Title { get; }

        public string Artist { get; }

        public string Creator { get; }

        public string Version { get; }

        public string BeatmapId { get; }

        public string BeatmapsetId { get; }

        public string Background { get; }

        public List<HitObject> Arcs { get; } = new List<HitObject>();

        public int Speed { get; set; }

        public int Lives { get; }

        public int Length { get; }

        public string Folder { get; }

        private readonly List<HitObject> _rawNotes = new List<HitObject>();

        public ManiaMap(string path)
        {
            this.Speed = 25;
            this.Lives = 50;
            StringReader sr = new StringReader(path);
            string line;

            while ((line = sr.ReadLine()) != null)
            {
                string lineValue = line.Substring(line.IndexOf(":", StringComparison.Ordinal) + 1).Trim();

                if (line.StartsWith("AudioFilename:"))
                {
                    this.Audio = lineValue;
                }
                else if (line.StartsWith("Mode:"))
                {
                    this.Mode = (Mode)int.Parse(lineValue);
                }
                else if (line.StartsWith("Title:"))
                {
                    this.Title = lineValue;
                }
                else if (line.StartsWith("Artist:"))
                {
                    this.Artist = lineValue;
                }
                else if (line.StartsWith("Creator"))
                {
                    this.Creator = lineValue;
                }
                else if (line.StartsWith("Version"))
                {
                    this.Version = lineValue;
                }
                else if (line.StartsWith("BeatmapID:"))
                {
                    this.BeatmapId = lineValue;
                }
                else if (line.StartsWith("BeatmapSetID:"))
                {
                    this.BeatmapsetId = lineValue;
                }
                else if (line.StartsWith("//Background and Video events"))
                {
                    line = sr.ReadLine();
                    line = line?.Split(",\"")[1];
                    this.Background = line?.Substring(0, line.LastIndexOf("\"", StringComparison.Ordinal));
                }
                else if (line.StartsWith("[HitObjects]"))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] cur = line.Split(",");
                        this._rawNotes.Add(new HitObject((Position)int.Parse(cur[0]), double.Parse(cur[2])));
                    }
                }
            }

            this.ConvertTimings();
            
            this.Folder = path.Substring(0, path.LastIndexOf("\\", StringComparison.Ordinal));
            Mp3FileReader reader = new Mp3FileReader(Path.Combine(this.Folder, this.Audio));
            this.Length = (int)reader.TotalTime.TotalMilliseconds;
        }

        private void ConvertTimings()
        {
            HitObject lastNote = new HitObject(Position.Down, -100);
            List<HitObject> lastNotes = new List<HitObject> { lastNote };

            foreach (HitObject x in this._rawNotes.Where(x => !Enum.IsDefined(typeof(Position), x.Position)))
            {
                if (lastNote.Timing == x.Timing)
                {
                    lastNotes.Add(x);
                }
                else
                {
                    string pos = lastNotes.Aggregate("", (current, y) => current + $"{y.Position}-");

                    if (lastNote.Timing != -100)
                    {
                        this.Arcs.Add(new HitObject((Position)int.Parse(pos.Substring(0, pos.Length - 1)), lastNote.Timing));
                    }

                    lastNotes.Clear();
                    lastNotes.Add(x);
                    lastNote = x;
                }
            }

            if (this.Arcs.Last().Timing != lastNote.Timing)
            {
                string pos = lastNotes.Aggregate("", (current, y) => current + $"{y.Position}-");

                this.Arcs.Add(new HitObject((Position)int.Parse(pos.Substring(0, pos.Length - 1)), lastNote.Timing));
            }
        }
    }
}