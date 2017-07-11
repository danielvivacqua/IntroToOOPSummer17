using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOPSummer17
{
    class Cat
    {
        //Inside of our class, we create the blueprint for our object.
        //Classes are templates in OOP that we use to create objects.
        //They should always be named in Pascal case.

        //In OOP, there are two types of States:
        //Fields - variables that belong to a class
        private string name;
        private int age;
        private string furColor;
        private bool isHungry = true;

        //Properties - A sort of mix between a field and a method that allow controlled access
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        //We also have Behaviors.
        //Methods - repeatable/reusable sections of code - Actions
        //Constructors - specialized methods that are used when instantiating an object
        //     - Allow us to control the state of an object upon creation.
        //     - Allow us to perform any actions the object might need upon creation.
        //     - Always share the name of the class

        public Cat()
        {
            //This is an example of a default constructor. A default constructor takes
            //no arguments/parameters.
        }

        public Cat(string name, int age, string furColor)
        {
            this.name = name;
            this.age = age;
            this.furColor = furColor;
        }

        public void Eat()
        {
            if (isHungry)
            {
                isHungry = false;
            }
            Console.WriteLine("Is the cat hungry? " + isHungry);
        }
    }
}


