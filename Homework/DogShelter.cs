using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
   public static  class DogShelter
    {
        public static List<Dog> Dogs = new List<Dog>();

        public static void PrintAll()
        {
            Console.WriteLine("Show all dogs");

            for (int i = 0; i < Dogs.Count; i++)
            {
                Console.WriteLine($"Id:{Dogs[i].Id} Name:{Dogs[i].Name} Color:{Dogs[i].Color}");
            }
        }
    }
}
