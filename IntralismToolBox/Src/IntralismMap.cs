using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using ManiaToIntralism.Enums;
using Newtonsoft.Json;

namespace ManiaToIntralism
{
    
    public class IntralismMap
    {
        [JsonProperty("configVersion")]
        public long ConfigVersion { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("info")]
        public string Info { get; set; }

        [JsonProperty("levelResources")]
        public List<LevelResource> LevelResources { get; set; }

        [JsonProperty("tags")]
        public List<string> Tags { get; set; }

        [JsonProperty("handCount")]
        public long HandCount { get; set; }

        [JsonProperty("moreInfoURL")]
        public string MoreInfoUrl { get; set; }

        [JsonProperty("speed")]
        public long Speed { get; set; }

        [JsonProperty("lives")]
        public long Lives { get; set; }

        [JsonProperty("maxLives")]
        public long MaxLives { get; set; }

        [JsonProperty("musicFile")]
        public string MusicFile { get; set; }

        [JsonProperty("musicTime")]
        public long MusicTime { get; set; }

        [JsonProperty("iconFile")]
        public string IconFile { get; set; }

        [JsonProperty("environmentType")]
        public long EnvironmentType { get; set; }

        [JsonProperty("unlockConditions")]
        public List<object> UnlockConditions { get; set; }

        [JsonProperty("hidden")]
        public bool Hidden { get; set; }

        [JsonProperty("checkpoints")]
        public List<object> Checkpoints { get; set; }

        [JsonProperty("events")]
        public List<Event> Events { get; set; }
        
        public List<BetterEvent> BetterEvents { get; set; } = new List<BetterEvent>();

        public static IntralismMap FromJson(string path)
        {
            return JsonConvert.DeserializeObject<IntralismMap>(File.ReadAllText((path + "\\config.txt")));
        }

        public void TurnToBetterInformation()
        {
            List<Event> oldEvents = this.Events;

            foreach (Event ev in oldEvents)
            {
                this.BetterEvents.Add(new BetterEvent(ev.Time, ev.Data));
            }
        }
    }

    public partial class Event
    {
        [JsonProperty("time")]
        public double Time { get; set; }

        [JsonProperty("data")]
        public List<string> Data { get; set; }
    }

    public partial class LevelResource
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }
    }
    
    public partial class BetterEvent
    {
        public double Time { get; set; }
        
        public EventType Type { get; set; }

        public string EventInformation { get; set; }

        public BetterEvent(double time, List<string> data)
        {
            this.Time = time;
            this.Type = (EventType)Enum.Parse(typeof(EventType), data[0]);
            this.EventInformation = data[1];
        }
    }
    
}

