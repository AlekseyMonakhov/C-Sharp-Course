﻿using System;
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

        public int Health {
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
        public int Damage {
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

        private List<Item> Items { get; set; } = new List<Item>();

        public void Hit(Hero hero)
        {
            hero.Health -= Damage;
        }

        public void useItem(Hero enemy)
        {
            if(Items.Count > 0)
            {
                if (Items[0].GetType() == typeof(BladesOfAtack))
                {
                    BladesOfAtack firstItem = (BladesOfAtack)Items[0];
                    firstItem.CriticalStrike(enemy);
                }
                else
                {
                    throw new Exception("Item has no active abilities");
                }

            }
            else
            {
                throw new Exception("Hero have no items");
            }
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

        public void removeItem()
        {
            if(Items.Count == 0) 
            {
                throw new Exception("No items");
            }
            else
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
