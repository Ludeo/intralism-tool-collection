using System;
using System.Collections.Generic;
using System.Linq;
using ManiaToIntralism.Enums;

namespace ManiaToIntralism
{
    public readonly struct HitObject
    {
        public string Position { get; }
        public double Timing   { get; }

        public HitObject(string maniaNote, double timing)
        {
            this.Position = ParseManiaNote(maniaNote);
            this.Timing = timing;
        }
        
        private static string ParseManiaNote(string s)
        {
            Console.WriteLine(s);
            
            string[] nums = s.Split("-");
            IEnumerable<Position> positions = nums.Select(e => (Position)Enum.Parse(typeof(Position), e));

            return string.Join('-', positions);
        }
    }
}