using System.Text.Json.Serialization;

namespace ManiaToIntralism
{
    public class Player
    {
        [JsonPropertyName("name")]
        public string Name { get; }

        [JsonPropertyName("link")]
        public string Link { get; }

        public Player(string name, string link)
        {
            this.Name = name;
            this.Link = link;
        }

        public override string ToString() => this.Name;
    }
}