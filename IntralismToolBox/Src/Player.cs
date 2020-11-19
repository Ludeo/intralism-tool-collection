using System.Text.Json.Serialization;

namespace IntralismToolBox
{
    public class Player
    {
        public Player(string name, string link)
        {
            this.Name = name;
            this.Link = link;
        }

        [JsonPropertyName("name")]
        public string Name { get; }

        [JsonPropertyName("link")]
        public string Link { get; }

        public override string ToString() => this.Name;
    }
}