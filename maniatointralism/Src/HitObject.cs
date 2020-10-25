namespace ManiaToIntralism
{
    public readonly struct HitObject
    {
        public Position Position { get; }
        public double    Timing   { get; }
    
        public HitObject(Position pos, double timing)
        {
            this.Position = pos;
            this.Timing = timing;
        }
    }
}