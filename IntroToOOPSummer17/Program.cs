using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOPSummer17
{
    class Program
    {
        static void Main(string[] args)
        {
            //When we initialize a new object, it is called INSTANTIATING (creating a new instance)
            //An object needs to be instantiated before it can be used
            //All objects of a specific type are created from the same template - CLASS
            //All objects from a class will have the same number and type of states, BUT ...
            //each instance can have it's own unique values.

            //the format we use to instantiate an object looks like this:
            //ClassName objectName = new ClassName();
            //Cat firstCat = new Cat();

            //firstCat.Name = "Mittens";
            ////Console.WriteLine(firstCat.Age);

            //Cat secondCat = new Cat("Oz", 3, "Orange and white");
            //secondCat.Name = "Ozzy";
            //Console.WriteLine(secondCat.Name);
            //Console.WriteLine(secondCat.Age);
            //secondCat.Eat();

            //To create a new object, we use a special method called a CONSTRUCTOR

            //Thinking about objects in real life, create (either hand-write or type)
            //three examples of objects. Your objects should have five states (characteristics)
            //and five behaviors.

            Superhero firstHero = new Superhero();
            //firstHero.StrengthLevel = 100;
            //firstHero.HasCape = true;

            //firstHero.BattleNemesis();
            //Console.WriteLine(firstHero.HasCape);
            //Console.WriteLine(firstHero.StrengthLevel);

            //firstHero.BattleNemesis();
            //Console.WriteLine(firstHero.HasCape);
            //Console.WriteLine(firstHero.StrengthLevel);

            Superhero secondHero = new Superhero("Diamond Daniel");
            //Console.WriteLine(secondHero.StrengthLevel);

            //secondHero.AllyGained();
            //Console.WriteLine(secondHero.StrengthLevel);

            Superhero thirdHero = new Superhero("black Kevlar body armor", "The Best Ever", 1000, "Being the best", false);

            thirdHero.BattleNemesis();
            Console.WriteLine("Oh no! Now my costume is " + thirdHero.Costume);
            Console.WriteLine("And my strength has diminished to " + thirdHero.StrengthLevel);
            

        }
    }
}
