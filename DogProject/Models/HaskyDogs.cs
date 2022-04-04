using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogProject.Models
{
    public class HaskyDogs
    {
        public class HaskyDog : Dogs, IBark, IEat
        {
            public void Bark()
            {
                Console.WriteLine($"Dog age: {Age}");
                Console.WriteLine($"{Name} is barking!!! woof!!!");
            }

            public void Eat()
            {
                Console.WriteLine($"{Name} dog is EATING!!! NIAM NIAM!!!");
            }
        }

    }
}
