using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarnivalConsoleGame
{
    public class CarnivalGames
    {
       public CarnivalGames(){}

        public CarnivalGames(string splash, List<string> exits, string name, int time, int tickets, int funPoints)
        {
            Splash = splash;
            Exits = exits;
            Name = name;
            Time = time;
            Tickets = tickets;
            FunPoints = funPoints;
        }
        public string Splash { get; }
        public List<string> Exits { get; }
        public string Name { get; }
        public int Time { get; }
        public int Tickets { get; }
        public int FunPoints { get; }

        
    }

}
    

