using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace ManiaToIntralism
{
    
    public partial class IntralismMap
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

        public static IntralismMap FromJson(string path)
        {
            return JsonConvert.DeserializeObject<IntralismMap>(File.ReadAllText((path + "\\config.txt")));
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
    
}

