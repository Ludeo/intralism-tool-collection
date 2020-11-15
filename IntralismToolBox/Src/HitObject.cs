﻿using System;
using System.Collections.Generic;
using System.Linq;
using ManiaToIntralism.Enums;

namespace ManiaToIntralism
{
    /// <summary>
    /// object of an intralism arc
    /// </summary>
    public readonly struct HitObject
    {
        public string Position { get; }
        public double Timing   { get; }

        public HitObject(string maniaNote, double timing)
        {
            this.Position = ParseManiaNote(maniaNote);
            this.Timing = timing;
        }
        
        /// <summary>
        /// validates that it is a correct arc 
        /// </summary>
        public static string ParseManiaNote(string s)
        {
            string[] nums = s.Split("-");
            IEnumerable<Position> positions = nums.Select(e => (Position)Enum.Parse(typeof(Position), e));

            return string.Join('-', positions);
        }
    }
}