using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9
{
    public class Battlefield
    {
        public Team team1;
        public Team team2;

        public Battlefield(Team team1, Team team2)
        {
            this.team1 = team1;
            this.team2 = team2;
        }

        public void StartFight()
        {
            team1.Heroes.First().Hit(team2.Heroes.First());
        }
    }
}
