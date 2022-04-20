using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    public class Dog
    {
        

        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public void Bark()
        {
            Console.WriteLine("Bark Bark");
        }

        public static bool Validate (Dog validate)
        {
            return validate.Id > 0 && validate.Name.Length > 1 && validate.Color != string.Empty; 
        }

        public Dog(int id, string name, string color)
        {
            Id = id;
            Name = name;
            Color = color;
        }

    }
}
