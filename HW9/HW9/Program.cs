﻿// See https://aka.ms/new-console-template for more information
using HW9;
using System.ComponentModel;
using System.Globalization;

var bar = new Barbarian();
var mage = new Mage();


try
{
    bar.addItem(new BladesOfAtack());
    mage.addItem(new BladesOfAtack());
    
    

    

    Console.WriteLine(mage.Damage);
    Console.WriteLine(mage.Health);
}
catch (Exception ex) 
{
    Console.WriteLine(ex.Message);  
}


public class BladesOfAtack : Item
{
    public BladesOfAtack() : base(112, 115)
    {
    }
}

public class Satanic: Item
{
    public Satanic(): base(2, 8) { }
}



