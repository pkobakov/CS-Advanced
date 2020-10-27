using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes
{
    public class Item
    {
        public int Strenght { get; set; }
        public int Ability { get; set; }
        public int Intelligence { get; set; }

        public Item(int strenght, int ability, int intelligence)
        {
            this.Strenght = strenght;
            this.Ability = ability;
            this.Intelligence = intelligence;
        }

        public override string ToString()
        {

            StringBuilder printItem = new StringBuilder();
            printItem.AppendLine("Item:");
            printItem.AppendLine($"  * Strenght: {Strenght}");
            printItem.AppendLine($"  * Ability: {Ability}");
            printItem.AppendLine($"  * Inteligence: {Intelligence}");

            return printItem.ToString().Trim();
        }

    }
}
