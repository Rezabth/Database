using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooApp.Models;

namespace ZooApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ZooContext ctx = new ZooContext();
            Console.WriteLine("Enter a keeper name");
            var KeeperName = Console.ReadLine();
            var akeeper = new Keeper();
            akeeper.Name = KeeperName;
            ctx.SaveChanges();
            Console.WriteLine("Enter an animal name");
            var name = Console.ReadLine();
            var anAnimal = new Animal();
            anAnimal.Name = name;
            anAnimal.Email = name + "@disney.com";
            anAnimal.Keeper = akeeper;
            ctx.Animals.Add(anAnimal);
            ctx.SaveChanges();
            // List all animals

            foreach(var theAnimal in ctx.Animals)
            {
                Console.WriteLine($"{theAnimal.Keeper.Name} is keeper for {theAnimal.Name}");
            }
        }
    }
}
