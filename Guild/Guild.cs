using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guild
{
    public class Guild
    {

        private List<Player> players;

        public string Name{ get; set; }
        public int Capacity { get; set; }


        public Guild(string name, int capacity)
        {
            this.players = new List<Player>();
            this.Name = name;
            this.Capacity = capacity;
        }

        public int Count
        {
            get
            {
                return this.players.Count;
            }

        }

        public void AddPlayer(Player player) 
        {
            if (this.Capacity>this.Count)
            {
                this.players.Add(player);
            }
        }

        public bool RemovePlayer(string name) 
        {
            if (this.Count>0)
            {
                foreach (var player in this.players)
                {
                    if (player.Name == name)
                    {
                        this.players.Remove(player);

                        return true;

                    }
                }
            }
            

            return false;
        }

        

        public Player DemotePlayer(string name) 
        {

            var getPlayer = this.players.Where(n => n.Name == name).First();

            if (getPlayer.Rank!="Trial")
            {
                getPlayer.Rank = "Trial";

            
            }

            return getPlayer;
        }

        public Player PromotePlayer(string name) 
        {

            var getPlayer = this.players.Where(n => n.Name == name).FirstOrDefault();

            if (getPlayer.Rank!="Member")
            {
                getPlayer.Rank = "Member";

                
            }

            return getPlayer;
        }

        public Player[] KickPlayersByClass(string className) 
        {
            var array = players.Where(p => p.ClassName == className).ToArray();
            this.players.RemoveAll(p => p.ClassName == className);
            return array;
        
        }

        public string Report() 
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Players in the guild: {this.Name}");

            foreach (var player in this.players)
            {
                sb.AppendLine(player.ToString());
            }

            return sb.ToString().Trim();

        }










    }
}
