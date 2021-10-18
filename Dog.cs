using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDogCsharp
{
    public class Dog : Observer
    {
        public Cat cat;
        public Dog (string name): base( name)
        {

        }

     
       public void Smell(Dog dog,Cat cat )
        {
            cat.RegisterObserver(cat, this);
            Console.WriteLine(dog.name + " Just smelled " + cat.name);
        }
    }
}
