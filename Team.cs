using System;

namespace Assignment 04
{
    public class Team
    {
        public int TeamID{ get; set; }
        public string TeamName { get; set; }
        public string TeamDescription { get; set; }

        public override string ToString()
        {
            return $"{TeamName} - {TeamDescription}";
        }
    }
}