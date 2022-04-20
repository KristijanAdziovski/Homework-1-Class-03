using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog(1, "Maks", "while");
            Dog dog2 = new Dog(2, "Alex", "dark");
            Dog dog3 = new Dog(3, "Miley", "yellow");
            Dog dog4 = new Dog(1, "P","green");


            Console.WriteLine(Dog.Validate(dog1));
            Console.WriteLine(Dog.Validate(dog2));
            Console.WriteLine(Dog.Validate(dog3)); 
            Console.WriteLine(Dog.Validate(dog4));


            DogShelter.Dogs.Add(dog1);
            DogShelter.Dogs.Add(dog2);
            DogShelter.Dogs.Add(dog3);
            

            DogShelter.PrintAll();

            dog4.Bark();
        }
    }
}
