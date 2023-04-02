using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9
{
    public class Hero
    {
        private int _health;
        private int _damage;

        protected int Health {
            get {
                if(Items.Count > 0)
                {
                    return _health + Items[0].HpBonus;
                }
                return _health;
            }

            set {
                _health = value;
            } 
        }
        protected int Damage 
        {
            get
            {
                if (Items.Count > 0)
                {
                    return _damage + Items[0].AtackBouns;
                }
                return _damage;
            } 
            set
            {
                _damage = value;
            }
        }

        public List<Item> Items { get; set; } = new List<Item>();

        public void Hit(Hero hero)
        {
            hero.Health -= Damage;
        }

        public void addItem(Item item)
        {
            if(Items.Count >= 1)
            {
                throw new Exception("Alredy have item");
            }
            else
            {
                Items.Add(item);
            }
            
        }

        public void removeItem(Item item)
        {
            if(Items.Count == 0) 
            {
                throw new Exception("No items");
            }else
            {
                Items.RemoveAt(0);
            }
        }

        public Hero(int health, int damage)
        {
            Health = health;
            Damage = damage;
        }
    }
}
