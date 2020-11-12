using System.Configuration;

namespace ManiaToIntralism
{
    public class Player
    {
        public string name { get; }
        public string link { get; }

        public Player(string name, string link)
        {
            this.name = name;
            this.link = link;
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}