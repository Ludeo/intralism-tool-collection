namespace maniatointralism
{
    public class HitObject
    {
        public string Pos { get; }
        public string Timing { get; }
        
        public HitObject(string pos, string timing)
        {
            if (pos == "64") this.Pos = "Left";
            else if (pos == "192") this.Pos = "Up";
            else if (pos == "320") this.Pos = "Down";
            else if (pos == "448") this.Pos = "Right";
            else this.Pos = pos;
            this.Timing = timing;
        }
    }
}