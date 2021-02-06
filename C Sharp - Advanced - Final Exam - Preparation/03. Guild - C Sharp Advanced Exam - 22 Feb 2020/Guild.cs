using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guild
{
    public class Guild
    {
        private HashSet<Player> roster;

        public Guild(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.roster = new HashSet<Player>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count
        {
            get
            {
                return this.roster.Count;
            }
        }

        public void AddPlayer(Player player)
        {
            if (this.Count < this.Capacity)
            {

                this.roster.Add(player);

            }
        }

        public bool RemovePlayer(string name)
        {
            foreach (var player in this.roster)
            {

                if (player.Name == name)
                {
                    this.roster.Remove(player);
                    return true;
                }

            }

            return false;
        }

        public void PromotePlayer(string name)
        {

            foreach (var player in this.roster)
            {
                if (player.Name == name)
                {
                    if (player.Rank == "Trial")
                    {
                        player.Rank = "Member";
                    }
                }
            }
        }

        public void DemotePlayer(string name)
        {
            foreach (var player in this.roster)
            {
                if (player.Name == name)
                {
                    if (player.Rank == "Member")
                    {
                        player.Rank = "Trial";
                    }
                }
            }
        }

        public Player[] KickPlayersByClass(string playerClass)
        {
            List<Player> playersRemovedByClass = new List<Player>();

            //for (int i = 0; i < this.roster.Count; i++)
            //{
            //    if (this.roster[i].Class == playerClass)
            //    {
            //        playersRemovedByClass.Add(this.roster[i]);
            //        this.roster.Remove(this.roster[i]);
            //        i--;
            //    }
            //}

            playersRemovedByClass = this.roster.Where(x => x.Class == playerClass).ToList();
            this.roster = this.roster.Where(x => x.Class != playerClass).ToHashSet();

            return playersRemovedByClass.ToArray();
        }

        public string Report()
        {

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Players in the guild: {this.Name}");

            foreach (var player in this.roster)
            {
                sb.AppendLine(player.ToString());
            }

            return sb.ToString().TrimEnd();

        }
    }
}
