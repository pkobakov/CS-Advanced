using System;
using System.Collections.Generic;
using System.Text;

namespace Guild
{
    public class Player
    {
        public string Name { get; set; }
        public string ClassName { get; set; }
        public string Rank{ get; set; }
        public string Description { get; set; }

        public Player(string name, string className)
        {
            Name = name;
            ClassName = className;
            Rank = "Trial";
            Description = "n/a";
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Player {Name}: {ClassName}");
            sb.AppendLine($"Rank: {Rank}");
            sb.AppendLine($"Description: {Description}");

            return sb.ToString().Trim();
        }
    }
}
