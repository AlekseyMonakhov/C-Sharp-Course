// See https://aka.ms/new-console-template for more information
using HW9;
using System.ComponentModel;
using System.Globalization;

var bar = new Barbarian();
var mage = new Mage();


try
{
    bar.addItem(new Satanic());
    mage.addItem(new BladesOfAtack());
    mage.useItem(bar);


    Console.WriteLine(bar.Health);
}
catch (Exception ex) 
{
    Console.WriteLine(ex.Message);  
}


public class BladesOfAtack : Item
{
    public BladesOfAtack() : base(2, 5)
    {
    }
    public void CriticalStrike(Hero hero)
    {
        Random rnd = new Random();
        int randomVal = rnd.Next(10, 50);
        hero.Health = hero.Health > randomVal ? hero.Health - randomVal : 0;
    }
}

public class Satanic: Item
{
    public Satanic(): base(2, 8) { }
}



