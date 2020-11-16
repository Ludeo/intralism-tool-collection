using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

        [Newtonsoft.Json.JsonIgnore]
        public List<BetterEvent> BetterEvents { get; set; } = new List<BetterEvent>();

        public static IntralismMap FromJson(string path)
        {
            return JsonConvert.DeserializeObject<IntralismMap>(File.ReadAllText((path + "\\config.txt")));
        }

        public void EventsToBetterEvents()
        {
            this.BetterEvents.Clear();

            foreach (Event ev in this.Events)
            {
                this.BetterEvents.Add(new BetterEvent(ev.Time, ev.Data));
            }
        }

        public void BetterEventsToEvents()
        {
            this.Events.Clear();

            foreach (BetterEvent ev in this.BetterEvents)
            {
                List<string> data = new List<string>
                {
                    ev.Type,
                    ev.EventInformation,
                };

                this.Events.Add(new Event(ev.Time, data));
            }
        }

        public void SortBetterEvents()
        {
            this.BetterEvents = this.BetterEvents.OrderBy(x => x.Type).ToList();
        }

        public void SortEvents()
        {
            this.Events = this.Events.OrderBy(x => x.Data[0]).ToList();
        }
    }

    public partial class Event
    {
        [JsonProperty("time")]
        public double Time { get; set; }

        [JsonProperty("data")]
        public List<string> Data { get; set; }

        public Event(double time, List<string> data)
        {
            this.Time = time;
            this.Data = data;
        }
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
        [JsonProperty("time")]
        public double Time { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("eventinformation")]
        public string EventInformation { get; set; }

        public BetterEvent(double time, IReadOnlyList<string> data)
        {
            this.Time = time;
            this.Type = Enum.Parse(typeof(EventType), data[0]).ToString();
            this.EventInformation = data[1];
        }
    }
}