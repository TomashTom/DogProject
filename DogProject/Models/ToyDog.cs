using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DogProject.Models
{
    public  class ToyDog : Dogs, IBark
    {
        public void Bark()
        {
            Console.WriteLine($"Toy Dog age: {Age}");
            Console.WriteLine($"{Name} is barking!!! woof!!!");

        }

        
    }
}
