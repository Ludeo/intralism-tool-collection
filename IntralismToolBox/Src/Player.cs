using System.Text.Json.Serialization;

namespace IntralismToolBox
{
    /// <summary>
    ///     Class that represents a intralism player.
    /// </summary>
    public class Player
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Player"/> class.
        /// </summary>
        /// <param name="name"> Name of the intralism player. </param>
        /// <param name="link"> Link to the profile of the intralism player. </param>
        public Player(string name, string link)
        {
            this.Name = name;
            this.Link = link;
        }

        /// <summary>
        ///     Gets the name of the intralism player.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        ///     Gets the link of the intralism player.
        /// </summary>
        [JsonPropertyName("link")]
        public string Link { get; }

        /// <summary>
        ///     Turns the player object to a string.
        /// </summary>
        /// <returns> The name of the player. </returns>
        public override string ToString() => this.Name;
    }
}