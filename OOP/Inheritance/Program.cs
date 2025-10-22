// See https://aka.ms/new-console-template for more information
using Inheritance;

Console.WriteLine("Hello, World!");

Player player = new Player();


player.Weapon = new Knife();
player.Weapon = new AK47();
player.Weapon = new Glock18 {  BurstFireEnabled = true};

Console.WriteLine(player.Weapon.Damage);
player.Weapon.ChangePosition();
player.Weapon.Attack();