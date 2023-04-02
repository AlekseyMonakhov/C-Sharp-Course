using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9
{
    public class Team
    {
        public Hero[] Heroes;

        public Team(Hero hero1, Hero hero2)
        {
            this.Heroes = new Hero[]
            {
                hero1, hero2
            };
        }
    }
}
