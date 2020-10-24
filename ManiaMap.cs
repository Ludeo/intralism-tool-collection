using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using NAudio.Wave;

namespace maniatointralism
{
    public class ManiaMap
    {
        public string Audio { get; }
        public string Mode { get; }
        public string Title { get; }
        public string Artist { get; }
        public string Creator { get; }
        public string Version { get; }
        public string Beatmapid { get; }
        public string Beatmapsetid { get; }
        public string Background { get; }
        private readonly List<HitObject> _rawnotes = new List<HitObject>();
        public List<HitObject> Arcs { get; }
        public string Speed { get; set; }
        public string Lives { get; }
        public string Length { get; }
        public string Folder { get; }


        public ManiaMap(string path)
        {
            Arcs = new List<HitObject>();
            Speed = "25";
            Lives = "50";
            using var sr = new StreamReader(path);
            string line;
                
            while ((line = sr.ReadLine()) != null)
            {
                    
                if (line.StartsWith("AudioFilename:"))
                {
                    this.Audio = line.Substring(line.IndexOf(":", StringComparison.Ordinal) + 2);
                } 
                else if (line.StartsWith("Mode:"))
                {
                    string mode = line.Substring(line.IndexOf(":", StringComparison.Ordinal) + 2);
                    if (mode == "0") this.Mode = "Standard";
                    else if (mode == "1") this.Mode = "Taiko";
                    else if (mode == "2") this.Mode = "Catch";
                    else if (mode == "3") this.Mode = "Mania";
                }
                else if (line.StartsWith("Title:"))
                {
                    this.Title = line.Substring(line.IndexOf(":", StringComparison.Ordinal) + 1);
                }
                else if (line.StartsWith("Artist:"))
                {
                    this.Artist = line.Substring(line.IndexOf(":", StringComparison.Ordinal) + 1);
                }
                else if (line.StartsWith("Creator"))
                {
                    this.Creator = line.Substring(line.IndexOf(":", StringComparison.Ordinal) + 1);
                }
                else if (line.StartsWith("Version"))
                {
                    this.Version = line.Substring(line.IndexOf(":", StringComparison.Ordinal) + 1);
                }
                else if (line.StartsWith("BeatmapID:"))
                {
                    this.Beatmapid = line.Substring(line.IndexOf(":", StringComparison.Ordinal) + 1);
                }
                else if (line.StartsWith("BeatmapSetID:"))
                {
                    this.Beatmapsetid = line.Substring(line.IndexOf(":", StringComparison.Ordinal) + 1);
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
                        _rawnotes.Add(new HitObject(cur[0], cur[2]));
                    }
                        
                }
                    
            }
            ConvertTimings();
                
            Folder = path.Substring(0, path.LastIndexOf("\\", StringComparison.Ordinal));
            Mp3FileReader reader = new Mp3FileReader(Folder + "\\" + Audio);
            Length = (int) reader.TotalTime.TotalMilliseconds + "";
        }
        
        private void ConvertTimings()
        {
                
            HitObject lastnote = new HitObject("Down", "-100");
            List<HitObject> lastnotes = new List<HitObject> {lastnote};

            foreach (HitObject x in _rawnotes)
            {
                    
                if (x.Pos != "Left" && x.Pos != "Up" && x.Pos != "Down" && x.Pos != "Right") continue;
                if (lastnote.Timing == x.Timing) lastnotes.Add(x);
                else
                {
                    string pos = "";
                    foreach (HitObject y in lastnotes)
                    {
                        pos += $"{y.Pos}-";
                    }

                    if (lastnote.Timing != "-100")
                    {
                        Arcs.Add(new HitObject(pos.Substring(0, pos.Length-1), lastnote.Timing));
                    } 
                        
                    lastnotes.Clear();
                    lastnotes.Add(x);
                    lastnote = x;
                }
            }
                
            if (Arcs.Last().Timing != lastnote.Timing)
            {
                string pos = "";
                foreach (HitObject y in lastnotes)
                {
                    pos += $"{y.Pos}-";
                }
                    
                Arcs.Add(new HitObject(pos.Substring(0, pos.Length - 1), lastnote.Timing));
            }
        }
    }
}