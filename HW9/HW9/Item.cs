using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9
{
    public class Item
    {
        public int AtackBouns { get;private set; }
        public int HpBonus { get;private set; }

        public Item(int atackBouns, int hpBonus)
        {
            AtackBouns = atackBouns;
            HpBonus = hpBonus;
        }
    }
}
