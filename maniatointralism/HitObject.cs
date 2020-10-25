namespace maniatointralism
{
    public class HitObject
    {
        public string Pos { get; }
        public string Timing { get; }
        
        public HitObject(string pos, string timing)
        {
            this.Pos = pos switch
            {
                "64" => "Left",
                "192" => "Up",
                "320" => "Down",
                "448" => "Right",
                _ => pos
            };
            this.Timing = timing;
        }
    }
}