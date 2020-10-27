using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Heroes
{
   public  class Hero
    {
        
        public string Name { get; set; }
        public int Level { get; set; }
        public Item Item { get; set; }

        public  Hero(string name, int level, Item item)
        {
            this.Name = name;
            this.Level = level;
            this.Item = item;

            
        }

        public override string ToString()
        {
            StringBuilder printHero = new StringBuilder();
            printHero.AppendLine($"Hero: {Name} – {Level}lvl");
            printHero.AppendLine(Item.ToString());

            return printHero.ToString().Trim();
                   
        }

    }
}
